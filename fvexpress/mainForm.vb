﻿Imports fvexpress.register.fvexpress
Imports fvexpress.settings.fvexpress
Imports fvexpress.update.fvexpress
Imports fvexpress.optionsForm
Imports fvexpress.core.fvexpress
Imports System.IO
Imports System.Windows.Forms
Imports System.Text

Public Class mainForm
    Public Shared ErrorMsg As String

    Private Sub mainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("您確定要離開？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            'Check the status of registeration
            If My.Computer.FileSystem.DirectoryExists(Directory.GetCurrentDirectory + "\Config") = False Then My.Computer.FileSystem.CreateDirectory(Directory.GetCurrentDirectory + "\Config")
            CheckRegisterStatus(Directory.GetCurrentDirectory + "\Config\Reg.key")
            If RegStatus = True Then
                mnuitemRegisterNow.Visible = False
                Me.Text = My.Application.Info.ProductName
                Dim tempload As StreamReader = New StreamReader(Directory.GetCurrentDirectory + "\Config\Reg.key")
                fvexpress.aboutForm.lblRegName.Text = Mid(tempload.ReadLine(), 9)
                fvexpress.aboutForm.lblRegOrg.Text = Mid(tempload.ReadLine(), 8)
                fvexpress.aboutForm.lblRegEmail.Text = Mid(tempload.ReadLine(), 10)
                tempload.Close()
            Else
                mnuitemRegisterNow.Visible = True
                Me.Text = My.Application.Info.ProductName + "(未註冊版本)"
                fvexpress.aboutForm.lblRegName.Text = "未註冊版本"
                fvexpress.aboutForm.lblRegOrg.Text = Nothing
                fvexpress.aboutForm.lblRegEmail.Text = Nothing
            End If

            'Load all the settings
            If My.Computer.FileSystem.DirectoryExists(Directory.GetCurrentDirectory + "\Config") = False Then My.Computer.FileSystem.CreateDirectory(Directory.GetCurrentDirectory + "\Config")
            If My.Computer.FileSystem.FileExists(Directory.GetCurrentDirectory + "\Config\Config.cfg") = False Then My.Computer.FileSystem.WriteAllText(Directory.GetCurrentDirectory + "\Config\Config.cfg", "AutoUpdate=False", True)
            LoadSettings(Directory.GetCurrentDirectory + "\Config\Config.cfg")
            If Mid(AutoUpdate, 11) = "True" Then
                optionsForm.chkAutoUpdate.Checked = True
            ElseIf Mid(AutoUpdate, 11) = "False" Then
                optionsForm.chkAutoUpdate.Checked = False
            End If

            'Check the status of update
            If My.Computer.FileSystem.DirectoryExists(Directory.GetCurrentDirectory + "\Config") = False Then My.Computer.FileSystem.CreateDirectory(Directory.GetCurrentDirectory + "\Config")
            If My.Computer.FileSystem.FileExists(Directory.GetCurrentDirectory + "\Config\Current.version") = False Then My.Computer.FileSystem.WriteAllText(Directory.GetCurrentDirectory + "\Config\Current.version", My.Application.Info.Version.ToString, True)
            CurrentVersion = My.Computer.FileSystem.ReadAllText(Directory.GetCurrentDirectory + "\Config\Current.version")
            Dim temp As Boolean
            If CurrentVersion = My.Computer.FileSystem.ReadAllText(Directory.GetCurrentDirectory + "\Config\Current.version") Then
                temp = True
            Else
                temp = False
            End If
            If temp = True Then
                CheckUpdate(CurrentVersion, LatestVersion)
            Else
                My.Computer.FileSystem.WriteAllText(Directory.GetCurrentDirectory + "\Config\Current.version", My.Application.Info.Version.ToString, False)
                CheckUpdate(CurrentVersion, LatestVersion)
            End If
            If UpdateStatus = True And Not LatestVersion = Nothing Then
                If MessageBox.Show("有新的軟體版本可供更新。您要立即更新嗎？", "有新版本", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then updateForm.ActiveForm.ShowDialog()
            End If

            'load some information
            statusVersion.Text = "版本 " + My.Application.Info.Version.ToString
            statusMainStatus.Text = "就緒"
        Catch ex As Exception
            ErrorMsg = "Date: " + Convert.ToString(Date.Now) & vbNewLine & "Details:" & vbNewLine & ex.ToString
            My.Computer.FileSystem.WriteAllText(Directory.GetCurrentDirectory + "\error-" + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") + ".log", ErrorMsg, False)
            MessageBox.Show("在開啟本軟體的過程中發生了錯誤。" + vbNewLine + "相關錯誤內容已輸出成錯誤記錄檔並放到本軟體的根目錄下。" + vbNewLine + vbNewLine + "本軟體將立即結束。", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End
        End Try
    End Sub

    Private Sub mnuitemAbout_MouseHover(sender As Object, e As EventArgs) Handles mnuitemAbout.MouseHover
        statusMainStatus.Text = "顯示 「關於 File Viewer Express™」對話方塊。"
    End Sub

    Private Sub mnuitemAbout_MouseLeave(sender As Object, e As EventArgs) Handles mnuitemAbout.MouseLeave
        statusMainStatus.Text = "就緒"
    End Sub

    Private Sub mnuitemHelpAndContent_MouseHover(sender As Object, e As EventArgs) Handles mnuitemHelpAndContent.MouseHover
        statusMainStatus.Text = "顯示本軟體的說明。"
    End Sub

    Private Sub mnuitemHelpAndContent_MouseLeave(sender As Object, e As EventArgs) Handles mnuitemHelpAndContent.MouseLeave
        statusMainStatus.Text = "就緒"
    End Sub

    Private Sub mnuitemOptions_Click(sender As Object, e As EventArgs) Handles mnuitemOptions.Click
        optionsForm.ShowDialog()
    End Sub

    Private Sub mnuitemOptions_MouseHover(sender As Object, e As EventArgs) Handles mnuitemOptions.MouseHover
        statusMainStatus.Text = "顯示「選項」對話方塊。"
    End Sub

    Private Sub mnuitemOptions_MouseLeave(sender As Object, e As EventArgs) Handles mnuitemOptions.MouseLeave
        statusMainStatus.Text = "就緒"
    End Sub

    Private Sub mnuitemQuit_Click(sender As Object, e As EventArgs) Handles mnuitemQuit.Click
        My.Forms.mainForm.Close()
    End Sub

    Private Sub mnuitemQuit_MouseHover(sender As Object, e As EventArgs) Handles mnuitemQuit.MouseHover
        statusMainStatus.Text = "結束本軟體。"
    End Sub

    Private Sub mnuitemQuit_MouseLeave(sender As Object, e As EventArgs) Handles mnuitemQuit.MouseLeave
        statusMainStatus.Text = "就緒"
    End Sub

    Private Sub mnuitemRegisterNow_MouseHover(sender As Object, e As EventArgs) Handles mnuitemRegisterNow.MouseHover
        statusMainStatus.Text = "顯示「立即註冊」對話方塊。"
    End Sub

    Private Sub mnuitemRegisterNow_MouseLeave(sender As Object, e As EventArgs) Handles mnuitemRegisterNow.MouseLeave
        statusMainStatus.Text = "就緒"
    End Sub

    Private Sub mnuitemUpdate_MouseHover(sender As Object, e As EventArgs) Handles mnuitemUpdate.MouseHover
        statusMainStatus.Text = "檢查本軟體是否有更新。"
    End Sub

    Private Sub mnuitemUpdate_MouseLeave(sender As Object, e As EventArgs) Handles mnuitemUpdate.MouseLeave
        statusMainStatus.Text = "就緒"
    End Sub

    Private Sub mnuitemViewFile_MouseHover(sender As Object, e As EventArgs) Handles mnuitemViewFile.MouseHover
        statusMainStatus.Text = "顯示檢視檔案操作介面。"
    End Sub

    Private Sub mnuitemViewFile_MouseLeave(sender As Object, e As EventArgs) Handles mnuitemViewFile.MouseLeave
        statusMainStatus.Text = "就緒"
    End Sub

    Private Sub mnuitemUpdate_Click(sender As Object, e As EventArgs) Handles mnuitemUpdate.Click
        updateForm.ShowDialog()
    End Sub

    Private Sub mnuitemHelpAndContent_Click(sender As Object, e As EventArgs) Handles mnuitemHelpAndContent.Click
        Try
            System.Diagnostics.Process.Start("fvexpress.chm")
        Catch ex As Exception
            ErrorMsg = "Date: " + Convert.ToString(Date.Now) & vbNewLine & "Details:" & vbNewLine & ex.ToString
            My.Computer.FileSystem.WriteAllText(Directory.GetCurrentDirectory + "\error-" + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") + ".log", ErrorMsg, False)
            MessageBox.Show("在處理的過程中發生了錯誤。" + vbNewLine + "相關錯誤內容已輸出成錯誤記錄檔並放到本軟體的根目錄下。" + vbNewLine + vbNewLine + "本軟體將立即結束。", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End
        End Try
    End Sub

    Private Sub mnuitemRegisterNow_Click(sender As Object, e As EventArgs) Handles mnuitemRegisterNow.Click
        registerForm.ShowDialog()
    End Sub

    Private Sub mnuitemViewFile_Click(sender As Object, e As EventArgs) Handles mnuitemViewFile.Click
        panelViewFile.Visible = True
    End Sub

    Private Sub mnuitemAbout_Click(sender As Object, e As EventArgs) Handles mnuitemAbout.Click
        aboutForm.ShowDialog()
    End Sub

    Private Sub txtCloseView_Click(sender As Object, e As EventArgs) Handles txtCloseView.Click
        panelViewFile.Visible = False
    End Sub

    Private Sub txtCloseView_MouseHover(sender As Object, e As EventArgs) Handles txtCloseView.MouseHover
        statusMainStatus.Text = "關閉檢視檔案操作介面。"
    End Sub

    Private Sub txtCloseView_MouseLeave(sender As Object, e As EventArgs) Handles txtCloseView.MouseLeave
        statusMainStatus.Text = "就緒"
    End Sub

    Private Sub btnBrowseFile_Click(sender As Object, e As EventArgs) Handles btnBrowseFile.Click
        Dim OpenFileBrowser As OpenFileDialog = New OpenFileDialog()
        Dim SelectedFile As String
        With OpenFileBrowser
            .Title = "選擇要開啟的檔案"
            .Filter = "所有文字檔案 (*.txt;*.ini;*.log)|*.txt;*.ini;*.log|CSV (*.csv)|*.csv|所有HTML網頁檔案 (*.htm;*.html)|*.htm;*.html|所有檔案 (*.*)|*.*"
        End With

        Try
            If Not OpenFileBrowser.ShowDialog() = DialogResult.Cancel Then
                SelectedFile = Path.GetFullPath(OpenFileBrowser.FileName)

                txtFilePath.Text = SelectedFile

                rtbViewFile.LoadFile(SelectedFile, RichTextBoxStreamType.PlainText)

                Encoding.UTF8.GetBytes(rtbViewFile.Text)
            End If
        Catch ex As Exception
            ErrorMsg = "Date: " + Convert.ToString(Date.Now) & vbNewLine & "Details:" & vbNewLine & ex.ToString
            My.Computer.FileSystem.WriteAllText(Directory.GetCurrentDirectory + "\error-" + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") + ".log", ErrorMsg, False)
            MessageBox.Show("在處理的過程中發生了錯誤。" + vbNewLine + "相關錯誤內容已輸出成錯誤記錄檔並放到本軟體的根目錄下。" + vbNewLine + vbNewLine + "本軟體將立即結束。", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End
        End Try

    End Sub

    Private Sub btnBrowseFile_MouseHover(sender As Object, e As EventArgs) Handles btnBrowseFile.MouseHover
        statusMainStatus.Text = "選擇您欲檢視的檔案路徑"
    End Sub

    Private Sub btnBrowseFile_MouseLeave(sender As Object, e As EventArgs) Handles btnBrowseFile.MouseLeave
        statusMainStatus.Text = "就緒"
    End Sub
End Class
