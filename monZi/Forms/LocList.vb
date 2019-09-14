Public Class LocList
#Region "Aero 그림자 효과 (Vista이상)"
    Dim loc As Point
    Dim HighlightBrush As Brush = New SolidBrush(Color.FromArgb(85, 85, 85))

    Dim ItemData(255) As String
    Dim count As Integer = 0

    Dim isSetLocClicked As Boolean = False


    Protected Overrides Sub OnHandleCreated(e As EventArgs)
        CreateDropShadow(Me)
        MyBase.OnHandleCreated(e)
    End Sub

#End Region

#Region "페이드 효과" 'Load시 Opacity=0 꼭하기

    Private Sub FadeInEffect(sender As Object, e As EventArgs) Handles MyBase.Shown
        Me.Refresh()
        FadeIn(Me, 1)

        ListBox1.Focus()
    End Sub

    Private Sub FadeOutEffect(sender As Object, e As EventArgs) Handles MyBase.Closing
        FadeOut(Me)
        If Not isSetLocClicked Then TrayForm.MainGUI_Open()
        'FadeIn(MainGUI, 1)
    End Sub
#End Region

    Private Sub FormDrag_MouseDown(sender As Object, e As MouseEventArgs) Handles TopPanel.MouseDown, TitleLabel.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            loc = e.Location
        End If
    End Sub

    Private Sub FormDrag_MouseMove(sender As Object, e As MouseEventArgs) Handles TopPanel.MouseMove, TitleLabel.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Location += e.Location - loc
        End If
    End Sub

    Private Sub LocList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Opacity = 0
        If My.Settings.UseNativeFont Then ChangeToNativeFont(Me)

        LoadData()
    End Sub

    Private Sub CloseBT_MouseEnter(sender As Object, e As EventArgs) Handles CloseBT.MouseEnter
        CloseBT.BackColor = ControlPaint.Light(TopPanel.BackColor, 0.2)
    End Sub

    Private Sub CloseBT_MouseLeave(sender As Object, e As EventArgs) Handles CloseBT.MouseLeave
        CloseBT.BackColor = Color.Transparent
    End Sub

    Private Sub ListBox1_DrawItem(sender As Object, e As System.Windows.Forms.DrawItemEventArgs) Handles ListBox1.DrawItem
        If ListBox1.Items.Count > 0 Then

            e.DrawBackground()

            If (e.Index Mod 2) = 1 Then
                e.Graphics.FillRectangle(New SolidBrush(Color.FromArgb(255, 255, 255)), e.Bounds)
            Else
                e.Graphics.FillRectangle(New SolidBrush(Color.FromArgb(245, 245, 245)), e.Bounds)
            End If

            If (e.State And DrawItemState.Selected) = DrawItemState.Selected Then
                e.Graphics.FillRectangle(HighlightBrush, e.Bounds)
            End If


            Using b As New SolidBrush(e.ForeColor)
                e.Graphics.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAlias
                e.Graphics.DrawString(ListBox1.GetItemText(ListBox1.Items(e.Index)), e.Font,
                                      b, e.Bounds.Left + dpicalc(Me, 20), ((e.Bounds.Height - ListBox1.Font.Height) \ 2) + e.Bounds.Top)
            End Using
            e.DrawFocusRectangle()

        End If
    End Sub

    Private Sub ListBox1_MeasureItem(ByVal sender As Object, ByVal e As System.Windows.Forms.MeasureItemEventArgs) Handles ListBox1.MeasureItem
        e.ItemHeight = dpicalc(Me, 40)
    End Sub

    Private Sub CloseBT_Click(sender As Object, e As EventArgs) Handles CloseBT.Click
        Me.Close()
    End Sub

    Private Sub ListBox1_DoubleClick(sender As Object, e As EventArgs) Handles ListBox1.DoubleClick
        ApplySet()
    End Sub

    Sub ApplySet()
        Dim ApplyData = ItemData(ListBox1.SelectedIndex)

        Dim newData As String = "<locinfo>" + ApplyData + "</locinfo>"

        For i = 0 To count - 1
            If Not i = ListBox1.SelectedIndex Then newData += vbCr + "<locinfo>" + ItemData(i) + "</locinfo>"
        Next

        My.Settings.LocHistory = newData


        If getData(ApplyData, "type") = "location" Then
            My.Settings.StationName = Nothing
            My.Settings.LocationName = getData(ApplyData, "string")
            My.Settings.LocationPoint_X = getData(ApplyData, "X")
            My.Settings.LocationPoint_Y = getData(ApplyData, "Y")
        Else
            My.Settings.LocationName = getData(ApplyData, "string") & " (측정소)"
            My.Settings.StationName = getData(ApplyData, "string")
        End If

        APIForm.AirAPICheck.CancelAsync()
        APIForm.Close()
        APIForm.combnum = 0
        APIForm.PrevChk = "-1" '무조건 업데이트하도록
        APIForm.prevCombnum = -1
        MainGUI.DrawState()
        APIForm.Activate()
        TrayForm.MainGUI_Open()

        Me.Close()
    End Sub

    Sub LoadData()
        ListBox1.Items.Clear()
        Dim tmpdata = My.Settings.LocHistory

        count = 0

ret:
        If tmpdata.Contains("<locinfo>") Then

            Dim FirstStart As Long = tmpdata.IndexOf("<locinfo>") + 10

            ItemData(count) = Trim(Mid$(tmpdata, FirstStart, tmpdata.Substring(FirstStart).IndexOf("</locinfo>") + 1))
            tmpdata = Mid(tmpdata, FirstStart, tmpdata.Length)

            If getData(ItemData(count), "type") = "station" Then
                ListBox1.Items.Add(getData(ItemData(count), "string") + " (측정소)")
            Else
                ListBox1.Items.Add(getData(ItemData(count), "string"))
            End If

            count += 1
            GoTo ret

        End If

        If ListBox1.Items.Count > 0 Then
            ListBox1.SetSelected(0, True)
            EmptyMsgPanel.Hide()
            ClearButton.Show()
        Else
            EmptyMsg_Upper.Height = EmptyMsgPanel.Height / 2
            EmptyMsgPanel.Show()
            ClearButton.Hide()
        End If

    End Sub

    Private Sub ClearButton_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ClearButton.LinkClicked
        If MsgBox("정말로 비우시겠습니까?", vbQuestion + MsgBoxStyle.YesNo) = vbYes Then
            My.Settings.LocHistory = Nothing
            My.Settings.Save()
            My.Settings.Reload()
            Me.Close()
        End If
    End Sub

    Private Sub ListBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles ListBox1.KeyDown
        If e.KeyValue = Keys.Enter Then
            ApplySet()
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles EmptyMsg_DownLink.LinkClicked
        isSetLocClicked = True

        Dim mouseloc As New Point(Cursor.Position.X, Cursor.Position.Y)
        Dim marign As Integer = dpicalc(Me, 10)

        Dim showx = Screen.GetWorkingArea(mouseloc).Width - LocationSet.Width - marign
        Dim showy = Screen.GetWorkingArea(mouseloc).Height - LocationSet.Height - marign
        LocationSet.SetDesktopLocation(showx, showy)

        LocationSet.Show()
        Me.Close()
    End Sub
End Class