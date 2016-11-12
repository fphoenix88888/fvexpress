Imports fvexpress.register.fvexpress
Imports fvexpress.settings.fvexpress
Imports fvexpress.update.fvexpress
Imports System.IO
Imports System.Net
Public Class updateForm
    Public Shared ErrorMsg As String
    Private Sub updateForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try


        Catch ex As Exception
            ErrorMsg = "Date: " + Convert.ToString(Date.Now) & vbNewLine & "Details:" & vbNewLine & ex.ToString
            My.Computer.FileSystem.WriteAllText(Directory.GetCurrentDirectory + "\error-" + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") + ".log", ErrorMsg, False)
            MessageBox.Show("在處理的過程中發生了錯誤。" + vbNewLine + "相關錯誤內容已輸出成錯誤記錄檔並放到本軟體的根目錄下。" + vbNewLine + vbNewLine + "本軟體將立即結束。", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

    End Sub
End Class