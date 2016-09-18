Imports fvexpress.register.fvexpress
Imports fvexpress.settings.fvexpress
Imports fvexpress.update.fvexpress
Imports System.IO
Imports fvexpress.mainForm
Public Class optionsForm
    Public Shared AutoUpdateParameter As String
    Private Shared Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Try
            If My.Forms.optionsForm.chkAutoUpdate.Checked = True Then
                AutoUpdateParameter = "AutoUpdate=True"
            Else
                AutoUpdateParameter = "AutoUpdate=False"
            End If
            SaveSettings(Directory.GetCurrentDirectory + "\Config\Config.cfg", AutoUpdateParameter)

            My.Forms.optionsForm.Close()
        Catch ex As Exception
            ErrorMsg = "Date: " + Convert.ToString(Date.Now) & vbNewLine & "Details:" & vbNewLine & ex.ToString
            My.Computer.FileSystem.WriteAllText(Directory.GetCurrentDirectory + "\error-" + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") + ".log", ErrorMsg, False)
            MessageBox.Show("在處理的過程中發生了錯誤。" + vbNewLine + "相關錯誤內容已輸出成錯誤記錄檔並放到本軟體的根目錄下。" + vbNewLine + vbNewLine + "本軟體將立即結束。", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End
        End Try
    End Sub

    Private Sub optionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Buffer = "產品版本：" + My.Application.Info.Version.ToString
        txtInfo.Text = Buffer
    End Sub
End Class