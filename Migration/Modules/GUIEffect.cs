using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Text;

static class GUIEffect
{
    struct MARGINS
    {
        public int Left, Right, Top, Bottom;
    }

    [DllImport("dwmapi.dll", PreserveSig = true)]
    private static int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize)
    {
    }

    [DllImport("dwmapi.dll")]
    private static int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset)
    {
    }

    public static bool CreateDropShadow(Form form)
    {
        if (My.Settings.AeroEnabled)
        {
            try
            {
                int val = 2;
                int ret1 = DwmSetWindowAttribute(form.Handle, 2, ref val, 4);

                if (ret1 == 0)
                {
                    MARGINS m = new MARGINS()
                    {
                        Left = 0,
                        Right = 0,
                        Top = 1,
                        Bottom = 0
                    };

                    int ret2 = DwmExtendFrameIntoClientArea(form.Handle, ref m);
                    return ret2 == 0;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                // dwmapi.dll 없음
                return false;
            }
        }
        else
            return false;
    }


    [DllImport("user32.dll")]
    private static int SendMessage(IntPtr hWnd, int Msg, bool wParam, IntPtr lParam)
    {
    }

    private const static int WM_SETREDRAW = 11;

    public static void ResumeDrawing(this Control Target, bool Redraw)
    {
        SendMessage(Target.Handle, WM_SETREDRAW, true, 0);
        if (Redraw)
            Target.Refresh();
    }

    public static void SuspendDrawing(this Control Target)
    {
        SendMessage(Target.Handle, WM_SETREDRAW, false, 0);
    }

    public static void ResumeDrawing(this Control Target)
    {
        ResumeDrawing(Target, true);
    }

    public static void dpicalc(Form targetform, int size)
    {
        Graphics g = targetform.CreateGraphics;
        var dpi = g.DpiX.ToString();

        var current = dpi / (double)96;
        var expand = current * size;

        return expand;
    }

    public static void FadeIn(Form Form, double goalopacity)
    {
        Form.Opacity = 0;

        if (My.Settings.FadeEnabled)
        {
            while (Form.Opacity < goalopacity - 0.1)
            {
                Form.Opacity += 0.1;
                System.Threading.Thread.Sleep(10);
            }
        }

        Form.Opacity = goalopacity;
    }

    public static void FadeOut(Form Form)
    {
        if (My.Settings.FadeEnabled)
        {
            while (!Form.Opacity == 0)
            {
                Form.Opacity = Form.Opacity - 0.1;
                System.Threading.Thread.Sleep(10);
            }
        }
    }

    public static void ChangeToNativeFont(Form targetForm)
    {
        ChangeFontName(targetForm, new Font("맑은 고딕", 10));
    }

    public static void ChangeFontName(Form aForm, Font aFont)
    {
        foreach (Form frm in My.Application.OpenForms)
        {
            if (frm.HasChildren == true)
            {
                foreach (Control ctrl in frm.Controls)
                    ChangeFontName(ctrl, aFont);
            }
        }

        if (aForm.IsMdiContainer == true)
        {
            foreach (Form frm in aForm.MdiChildren)
            {
                if (frm.HasChildren == true)
                {
                    foreach (Control ctrl in frm.Controls)
                        ChangeFontName(ctrl, aFont);
                }
            }
        }
    }

    public static void ChangeFontName(Control aControl, Font aFont)
    {
        if (aControl.HasChildren == true)
        {
            foreach (Control ctrl in aControl.Controls)
            {
                ctrl.Font = new Font(aFont.Name, ctrl.Font.Size, ctrl.Font.Style, ctrl.Font.Unit, ctrl.Font.GdiCharSet, ctrl.Font.GdiVerticalFont);
                ChangeFontName(ctrl, aFont);
            }
        }
    }

    public static SizeF GetStringSize(Control aControl)
    {
        return aControl.CreateGraphics.MeasureString(aControl.Text, aControl.Font);
    }

    private const static int mSnapOffset = 35;
    private const static int WM_WINDOWPOSCHANGING = 0x46;

    [StructLayout(LayoutKind.Sequential)]
    public struct WINDOWPOS
    {
        public IntPtr hwnd;
        public IntPtr hwndInsertAfter;
        public int x;
        public int y;
        public int cx;
        public int cy;
        public int flags;
    }

    public static void SnapToDesktopBorder(Form clientForm, IntPtr LParam, int widthAdjustment)
    {
        if (clientForm == null)
            // Satisfies rule: Validate parameters
            throw new ArgumentNullException("clientForm");

        // Snap client to the top, left, bottom or right desktop border
        // as the form is moved near that border.

        try
        {
            // Marshal the LPARAM value which is a WINDOWPOS struct
            WINDOWPOS NewPosition = new WINDOWPOS();
            NewPosition = (WINDOWPOS)System.Runtime.InteropServices.Marshal.PtrToStructure(LParam, typeof(WINDOWPOS));

            if (NewPosition.y == 0 || NewPosition.x == 0)
                return;// Nothing to do!

            // Adjust the client size for borders and caption bar
            Rectangle ClientRect = clientForm.RectangleToScreen(clientForm.ClientRectangle);
            ClientRect.Width += SystemInformation.FrameBorderSize.Width - widthAdjustment - dpicalc(clientForm, 8);
            ClientRect.Height += (SystemInformation.FrameBorderSize.Height + SystemInformation.CaptionHeight - dpicalc(clientForm, 31));
            // 임의로 포인트 변경

            // Now get the screen working area (without taskbar)
            Rectangle WorkingRect = Screen.GetWorkingArea(clientForm.ClientRectangle);

            // Left border
            if (NewPosition.x >= WorkingRect.X - mSnapOffset && NewPosition.x <= WorkingRect.X + mSnapOffset)
                NewPosition.x = WorkingRect.X;

            // Get screen bounds and taskbar height
            // (when taskbar is horizontal)
            Rectangle ScreenRect = Screen.GetBounds(Screen.PrimaryScreen.Bounds);
            int TaskbarHeight = ScreenRect.Height - WorkingRect.Height;

            // Top border (check if taskbar is on top
            // or bottom via WorkingRect.Y)
            if (NewPosition.y >= -mSnapOffset && (WorkingRect.Y > 0 && NewPosition.y <= (TaskbarHeight + mSnapOffset)) || (WorkingRect.Y <= 0 && NewPosition.y <= (mSnapOffset)))
            {
                if (TaskbarHeight > 0)
                    NewPosition.y = WorkingRect.Y; // Horizontal Taskbar
                else
                    NewPosition.y = 0;// Vertical Taskbar
            }

            // Right border
            if (NewPosition.x + ClientRect.Width <= WorkingRect.Right + mSnapOffset && NewPosition.x + ClientRect.Width >= WorkingRect.Right - mSnapOffset)
                NewPosition.x = WorkingRect.Right - (ClientRect.Width + SystemInformation.FrameBorderSize.Width);

            // Bottom border
            if (NewPosition.y + ClientRect.Height <= WorkingRect.Bottom + mSnapOffset && NewPosition.y + ClientRect.Height >= WorkingRect.Bottom - mSnapOffset)
                NewPosition.y = WorkingRect.Bottom - (ClientRect.Height + SystemInformation.FrameBorderSize.Height);

            // Marshal it back
            System.Runtime.InteropServices.Marshal.StructureToPtr(NewPosition, LParam, true);
        }
        catch (ArgumentException ex)
        {
        }
    }


    public static bool IsOnScreen(Form form)
    {
        Screen[] screens = Screen.AllScreens;

        foreach (Screen scrn in screens)
        {
            Rectangle formRectangle = new Rectangle(form.Left, form.Top, form.Width, form.Height);

            if (scrn.WorkingArea.Contains(formRectangle))
                return true;
        }

        return false;
    }
}
