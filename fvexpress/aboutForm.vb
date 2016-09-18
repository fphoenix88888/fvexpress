Imports fvexpress.register.fvexpress
Imports fvexpress.settings.fvexpress
Imports fvexpress.update.fvexpress
Imports System.IO
Public Class aboutForm
    Public Shared ErrorMsg As String
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub aboutForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Get version info and copyright
        lblVersion.Text = "版本 " + My.Application.Info.Version.ToString
        lblCopy.Text = My.Application.Info.Copyright

        'Read iroduct version
        Buffer = "產品版本：" + My.Application.Info.Version.ToString
        txtInfo.Text = Buffer

        'Read licenses

        'Read GNU GPL
    End Sub
End Class