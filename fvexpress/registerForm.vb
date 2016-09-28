Imports fvexpress.register.fvexpress
Imports fvexpress.settings.fvexpress
Imports fvexpress.update.fvexpress
Imports fvexpress.core.fvexpress
Imports System.IO
Public Class registerForm
    Public Shared ErrorMsg As String
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        txtRegName.Enabled = False : txtRegEmail.Enabled = False : txtRegOrg.Enabled = False
        RegName = txtRegName.Text : RegEmail = txtRegEmail.Text : RegOrg = txtRegOrg.Text
        GetRegData(RegName, RegOrg, RegEmail)
        GenerateRegSerial(RegGUID)
        GenerateRegKey(RegGUID)
        GenerateActKey(RegGUID)
        If ActKey <> "" Then My.Computer.Clipboard.SetText(ActKey)
        txtActCode.Enabled = True
        btnConfirm.Enabled = False
    End Sub

    Private Sub txtRegOrg_TextChanged(sender As Object, e As EventArgs) Handles txtRegOrg.TextChanged
        If Not txtRegName.Text = Nothing And Not txtRegEmail.Text = Nothing And Not txtRegOrg.Text = Nothing Then
            btnConfirm.Enabled = True
        Else
            btnConfirm.Enabled = False
        End If
    End Sub

    Private Sub txtActCode_TextChanged(sender As Object, e As EventArgs) Handles txtActCode.TextChanged
        If Not txtActCode.Text = Nothing Then
            btnRegister.Enabled = True
        Else
            btnRegister.Enabled = False
        End If
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Try
            GenerateRegKeyFile()
            MessageBox.Show("註冊成功！" + vbNewLine + "請重新啟動本軟體以啟用您的授權。", "註冊", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Catch ex As Exception
            ErrorMsg = "Date: " + Convert.ToString(Date.Now) & vbNewLine & "Details:" & vbNewLine & ex.ToString
            My.Computer.FileSystem.WriteAllText(Directory.GetCurrentDirectory + "\error-" + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") + ".log", ErrorMsg, False)
            MessageBox.Show("在註冊的過程中發生了錯誤。" + vbNewLine + "相關錯誤內容已輸出成錯誤記錄檔並放到本軟體的根目錄下。" + vbNewLine + vbNewLine + "本軟體將立即結束。", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End
        End Try

    End Sub
End Class