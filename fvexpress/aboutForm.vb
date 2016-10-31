Imports fvexpress.register.fvexpress
Imports fvexpress.settings.fvexpress
Imports fvexpress.update.fvexpress
Imports System.IO
Imports System.Net
Public Class aboutForm
    Public Shared ErrorMsg As String
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub aboutForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim client As WebClient = New WebClient()
            Dim gpladdress As String = "https://www.gnu.org/licenses/gpl-3.0.txt"
            Dim gplloader As StreamReader = New StreamReader(client.OpenRead(gpladdress))
            Dim licenseaddress As String = "http://dpw-tw.lionfree.net/about/licenses.txt"
            Dim licenseloader As StreamReader = New StreamReader(client.OpenRead(licenseaddress))

            'Get version info and copyright
            lblVersion.Text = "版本 " + My.Application.Info.Version.ToString
            lblCopy.Text = My.Application.Info.Copyright

            'Read iroduct version
            Buffer = "產品版本：" + My.Application.Info.Version.ToString
            txtInfo.Text = Buffer

            'Read licenses
            txtShowLicense.Text = licenseloader.ReadToEnd()

            'Read GNU GPL
            txtShowGPL.Text = gplloader.ReadToEnd()

            licenseloader.Close()
            gplloader.Close()
        Catch ex As Exception
            ErrorMsg = "Date: " + Convert.ToString(Date.Now) & vbNewLine & "Details:" & vbNewLine & ex.ToString
            My.Computer.FileSystem.WriteAllText(Directory.GetCurrentDirectory + "\error-" + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") + ".log", ErrorMsg, False)
            MessageBox.Show("在處理的過程中發生了錯誤。" + vbNewLine + "相關錯誤內容已輸出成錯誤記錄檔並放到本軟體的根目錄下。" + vbNewLine + vbNewLine + "本軟體將立即結束。", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End
        End Try
    End Sub

    Private Sub lnkDPWWebsite_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkDPWWebsite.LinkClicked
        System.Diagnostics.Process.Start("http://dpw-tw.lionfree.net")
    End Sub
End Class