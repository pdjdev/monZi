Public Class UpdateForm
    Private currentVersion As String = My.Application.Info.Version.ToString
    Private latestVersion As String = Nothing
    Private releaseNotes As String = Nothing
    Private updateLink As String = Nothing
    Private isUpdateCheckSuccessful As Boolean = True

#Region "Aero 그림자 효과 (Vista이상)"
    Private dragStartLocation As Point

    Protected Overrides Sub OnHandleCreated(e As EventArgs)
        CreateDropShadow(Me)
        MyBase.OnHandleCreated(e)
    End Sub

#End Region

#Region "페이드 효과" 'Load시 Opacity=0 꼭하기

    Private Sub FadeInEffect(sender As Object, e As EventArgs) Handles MyBase.Shown
        Me.Refresh()
        FadeIn(Me, 1)
    End Sub

    Private Sub FadeOutEffect(sender As Object, e As EventArgs) Handles MyBase.Closing
        FadeOut(Me)
        MainGUI.Show()
        FadeIn(MainGUI, 1)
    End Sub
#End Region

    Private Sub FormDrag_MouseDown(sender As Object, e As MouseEventArgs) Handles TopPanel.MouseDown, TitleLabel.MouseDown, VerLabel.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            dragStartLocation = e.Location
        End If
    End Sub

    Private Sub FormDrag_MouseMove(sender As Object, e As MouseEventArgs) Handles TopPanel.MouseMove, TitleLabel.MouseMove, VerLabel.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Location += e.Location - dragStartLocation
        End If
    End Sub

    Private Sub CloseBT_MouseEnter(sender As Object, e As EventArgs) Handles CloseBT.MouseEnter
        CloseBT.BackColor = ControlPaint.Light(TopPanel.BackColor, 0.2)
    End Sub

    Private Sub CloseBT_MouseLeave(sender As Object, e As EventArgs) Handles CloseBT.MouseLeave
        CloseBT.BackColor = Color.Transparent
    End Sub

    Private Sub CloseBT_Click(sender As Object, e As EventArgs) Handles CloseBT.Click
        Me.Close()
    End Sub

    Private Sub UpdateMgr_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Opacity = 0
        VerLabel.Text = My.Application.Info.Version.ToString

        VerLabel.Text = "현재 버전: " + currentVersion
        UpdateChk.RunWorkerAsync()
        If My.Settings.UseNativeFont Then ChangeToNativeFont(Me)
    End Sub

    Private Sub UpdateChk_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles UpdateChk.DoWork
        Try
            Dim info = webget($"https://raw.githubusercontent.com/pdjdev/monZi/master/latest.txt?t={DateTimeOffset.UtcNow.ToUnixTimeSeconds()}")
            latestVersion = getData(info, "version")
            releaseNotes = getData(info, "note")
            updateLink = getData(info, "link")
        Catch ex As Exception
            isUpdateCheckSuccessful = False
        End Try
    End Sub

    Private Sub UpdateChk_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles UpdateChk.RunWorkerCompleted
        RichTextBox1.Text = releaseNotes
        NewVerLabel.Text = "최신 버전: " + latestVersion


        If isUpdateCheckSuccessful Then
            If UpdateAvailable() Then
                UpdButton.Enabled = True
                NewVerLabel.Text += " (업데이트 가능)"
            Else
                NewVerLabel.Text += " (최신 버전)"
            End If
            ForceUpdButton.Enabled = True
        Else
            NewVerLabel.Text = "(업데이트 확인 실패)"
        End If

    End Sub

    Private Function UpdateAvailable() As Boolean
        If Convert.ToInt32(Replace(currentVersion, ".", Nothing)) < Convert.ToInt32(Replace(latestVersion, ".", Nothing)) Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Sub UpdButton_Click(sender As Object, e As EventArgs) Handles UpdButton.Click, ForceUpdButton.Click
        MsgBox("실행되는 페이지의 설치 파일을 받아 실행해 주시기 바랍니다" + vbCr + "(기존 버전을 삭제하시는것을 권장드립니다)", vbInformation)
        Process.Start(updateLink)
    End Sub
End Class
