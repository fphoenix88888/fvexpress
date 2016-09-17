<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainForm
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.menuMain = New System.Windows.Forms.MenuStrip()
        Me.mnuitemFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuitemViewFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnusepFile = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuitemQuit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuitemOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuitemHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuitemHelpAndContent = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuitemSep2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuitemUpdate = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuitemSep3 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuitemAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuitemRegisterNow = New System.Windows.Forms.ToolStripMenuItem()
        Me.statusMain = New System.Windows.Forms.StatusStrip()
        Me.statusMainStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.statusVersion = New System.Windows.Forms.ToolStripStatusLabel()
        Me.menuMain.SuspendLayout()
        Me.statusMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'menuMain
        '
        Me.menuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuitemFile, Me.mnuitemOptions, Me.mnuitemHelp, Me.mnuitemRegisterNow})
        Me.menuMain.Location = New System.Drawing.Point(0, 0)
        Me.menuMain.Name = "menuMain"
        Me.menuMain.Size = New System.Drawing.Size(584, 24)
        Me.menuMain.TabIndex = 0
        Me.menuMain.Text = "MenuStrip1"
        '
        'mnuitemFile
        '
        Me.mnuitemFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuitemViewFile, Me.mnusepFile, Me.mnuitemQuit})
        Me.mnuitemFile.Name = "mnuitemFile"
        Me.mnuitemFile.Size = New System.Drawing.Size(57, 20)
        Me.mnuitemFile.Text = "檔案(&F)"
        '
        'mnuitemViewFile
        '
        Me.mnuitemViewFile.Name = "mnuitemViewFile"
        Me.mnuitemViewFile.Size = New System.Drawing.Size(160, 22)
        Me.mnuitemViewFile.Text = "檢視檔案(&V)"
        '
        'mnusepFile
        '
        Me.mnusepFile.Name = "mnusepFile"
        Me.mnusepFile.Size = New System.Drawing.Size(157, 6)
        '
        'mnuitemQuit
        '
        Me.mnuitemQuit.Name = "mnuitemQuit"
        Me.mnuitemQuit.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.mnuitemQuit.Size = New System.Drawing.Size(160, 22)
        Me.mnuitemQuit.Text = "結束(&Q)"
        '
        'mnuitemOptions
        '
        Me.mnuitemOptions.Name = "mnuitemOptions"
        Me.mnuitemOptions.Size = New System.Drawing.Size(61, 20)
        Me.mnuitemOptions.Text = "選項(&O)"
        '
        'mnuitemHelp
        '
        Me.mnuitemHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuitemHelpAndContent, Me.mnuitemSep2, Me.mnuitemUpdate, Me.mnuitemSep3, Me.mnuitemAbout})
        Me.mnuitemHelp.Name = "mnuitemHelp"
        Me.mnuitemHelp.Size = New System.Drawing.Size(60, 20)
        Me.mnuitemHelp.Text = "說明(&H)"
        '
        'mnuitemHelpAndContent
        '
        Me.mnuitemHelpAndContent.Name = "mnuitemHelpAndContent"
        Me.mnuitemHelpAndContent.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.mnuitemHelpAndContent.Size = New System.Drawing.Size(241, 22)
        Me.mnuitemHelpAndContent.Text = "說明與主題(&H)"
        '
        'mnuitemSep2
        '
        Me.mnuitemSep2.Name = "mnuitemSep2"
        Me.mnuitemSep2.Size = New System.Drawing.Size(238, 6)
        '
        'mnuitemUpdate
        '
        Me.mnuitemUpdate.Name = "mnuitemUpdate"
        Me.mnuitemUpdate.Size = New System.Drawing.Size(241, 22)
        Me.mnuitemUpdate.Text = "線上更新(&U)"
        '
        'mnuitemSep3
        '
        Me.mnuitemSep3.Name = "mnuitemSep3"
        Me.mnuitemSep3.Size = New System.Drawing.Size(238, 6)
        '
        'mnuitemAbout
        '
        Me.mnuitemAbout.Name = "mnuitemAbout"
        Me.mnuitemAbout.Size = New System.Drawing.Size(241, 22)
        Me.mnuitemAbout.Text = "關於 File Viewer Express™(&A)..."
        '
        'mnuitemRegisterNow
        '
        Me.mnuitemRegisterNow.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.mnuitemRegisterNow.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.mnuitemRegisterNow.ForeColor = System.Drawing.Color.Red
        Me.mnuitemRegisterNow.Name = "mnuitemRegisterNow"
        Me.mnuitemRegisterNow.Size = New System.Drawing.Size(89, 20)
        Me.mnuitemRegisterNow.Text = "立即註冊(&R)!"
        '
        'statusMain
        '
        Me.statusMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.statusMainStatus, Me.statusVersion})
        Me.statusMain.Location = New System.Drawing.Point(0, 389)
        Me.statusMain.Name = "statusMain"
        Me.statusMain.Size = New System.Drawing.Size(584, 22)
        Me.statusMain.TabIndex = 1
        Me.statusMain.Text = "StatusStrip1"
        '
        'statusMainStatus
        '
        Me.statusMainStatus.Name = "statusMainStatus"
        Me.statusMainStatus.Size = New System.Drawing.Size(478, 17)
        Me.statusMainStatus.Spring = True
        Me.statusMainStatus.Text = "[StatusText]"
        Me.statusMainStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'statusVersion
        '
        Me.statusVersion.Name = "statusVersion"
        Me.statusVersion.Size = New System.Drawing.Size(91, 17)
        Me.statusVersion.Text = "[StatusVersion]"
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.fvexpress.My.Resources.Resources.bg
        Me.ClientSize = New System.Drawing.Size(584, 411)
        Me.Controls.Add(Me.statusMain)
        Me.Controls.Add(Me.menuMain)
        Me.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.menuMain
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "mainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "File Viewer Express™"
        Me.menuMain.ResumeLayout(False)
        Me.menuMain.PerformLayout()
        Me.statusMain.ResumeLayout(False)
        Me.statusMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents menuMain As MenuStrip
    Friend WithEvents mnuitemFile As ToolStripMenuItem
    Friend WithEvents mnuitemViewFile As ToolStripMenuItem
    Friend WithEvents mnusepFile As ToolStripSeparator
    Friend WithEvents mnuitemQuit As ToolStripMenuItem
    Friend WithEvents mnuitemOptions As ToolStripMenuItem
    Friend WithEvents mnuitemHelp As ToolStripMenuItem
    Friend WithEvents mnuitemRegisterNow As ToolStripMenuItem
    Friend WithEvents statusMain As StatusStrip
    Friend WithEvents statusMainStatus As ToolStripStatusLabel
    Friend WithEvents statusVersion As ToolStripStatusLabel
    Friend WithEvents mnuitemHelpAndContent As ToolStripMenuItem
    Friend WithEvents mnuitemSep2 As ToolStripSeparator
    Friend WithEvents mnuitemUpdate As ToolStripMenuItem
    Friend WithEvents mnuitemSep3 As ToolStripSeparator
    Friend WithEvents mnuitemAbout As ToolStripMenuItem
End Class
