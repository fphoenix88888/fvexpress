<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class aboutForm
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
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.tabAbout = New System.Windows.Forms.TabControl()
        Me.tabpageAbout = New System.Windows.Forms.TabPage()
        Me.lblRegEmail = New System.Windows.Forms.Label()
        Me.lblRegOrg = New System.Windows.Forms.Label()
        Me.lblRegName = New System.Windows.Forms.Label()
        Me.lblRegInfo = New System.Windows.Forms.Label()
        Me.lblStatement = New System.Windows.Forms.Label()
        Me.lblCopy = New System.Windows.Forms.Label()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.tabpageProductVersion = New System.Windows.Forms.TabPage()
        Me.txtInfo = New System.Windows.Forms.TextBox()
        Me.tabpageLicense = New System.Windows.Forms.TabPage()
        Me.txtShowLicense = New System.Windows.Forms.TextBox()
        Me.tabpageGPL = New System.Windows.Forms.TabPage()
        Me.txtShowGPL = New System.Windows.Forms.TextBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lnkDPWWebsite = New System.Windows.Forms.LinkLabel()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabAbout.SuspendLayout()
        Me.tabpageAbout.SuspendLayout()
        Me.tabpageProductVersion.SuspendLayout()
        Me.tabpageLicense.SuspendLayout()
        Me.tabpageGPL.SuspendLayout()
        Me.SuspendLayout()
        '
        'picLogo
        '
        Me.picLogo.BackColor = System.Drawing.Color.Transparent
        Me.picLogo.Image = Global.fvexpress.My.Resources.Resources.about_logo
        Me.picLogo.Location = New System.Drawing.Point(12, 12)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(293, 63)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picLogo.TabIndex = 0
        Me.picLogo.TabStop = False
        '
        'tabAbout
        '
        Me.tabAbout.Controls.Add(Me.tabpageAbout)
        Me.tabAbout.Controls.Add(Me.tabpageProductVersion)
        Me.tabAbout.Controls.Add(Me.tabpageLicense)
        Me.tabAbout.Controls.Add(Me.tabpageGPL)
        Me.tabAbout.Location = New System.Drawing.Point(12, 81)
        Me.tabAbout.Name = "tabAbout"
        Me.tabAbout.SelectedIndex = 0
        Me.tabAbout.Size = New System.Drawing.Size(399, 331)
        Me.tabAbout.TabIndex = 1
        '
        'tabpageAbout
        '
        Me.tabpageAbout.BackgroundImage = Global.fvexpress.My.Resources.Resources.Ice1
        Me.tabpageAbout.Controls.Add(Me.lblRegEmail)
        Me.tabpageAbout.Controls.Add(Me.lblRegOrg)
        Me.tabpageAbout.Controls.Add(Me.lblRegName)
        Me.tabpageAbout.Controls.Add(Me.lblRegInfo)
        Me.tabpageAbout.Controls.Add(Me.lblStatement)
        Me.tabpageAbout.Controls.Add(Me.lblCopy)
        Me.tabpageAbout.Controls.Add(Me.lblVersion)
        Me.tabpageAbout.Location = New System.Drawing.Point(4, 24)
        Me.tabpageAbout.Name = "tabpageAbout"
        Me.tabpageAbout.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageAbout.Size = New System.Drawing.Size(391, 303)
        Me.tabpageAbout.TabIndex = 0
        Me.tabpageAbout.Text = "關於"
        Me.tabpageAbout.UseVisualStyleBackColor = True
        '
        'lblRegEmail
        '
        Me.lblRegEmail.AutoSize = True
        Me.lblRegEmail.Location = New System.Drawing.Point(20, 229)
        Me.lblRegEmail.Name = "lblRegEmail"
        Me.lblRegEmail.Size = New System.Drawing.Size(69, 15)
        Me.lblRegEmail.TabIndex = 6
        Me.lblRegEmail.Text = "[RegEmail]"
        '
        'lblRegOrg
        '
        Me.lblRegOrg.AutoSize = True
        Me.lblRegOrg.Location = New System.Drawing.Point(20, 214)
        Me.lblRegOrg.Name = "lblRegOrg"
        Me.lblRegOrg.Size = New System.Drawing.Size(60, 15)
        Me.lblRegOrg.TabIndex = 5
        Me.lblRegOrg.Text = "[RegOrg]"
        '
        'lblRegName
        '
        Me.lblRegName.AutoSize = True
        Me.lblRegName.Location = New System.Drawing.Point(20, 199)
        Me.lblRegName.Name = "lblRegName"
        Me.lblRegName.Size = New System.Drawing.Size(73, 15)
        Me.lblRegName.TabIndex = 4
        Me.lblRegName.Text = "[RegName]"
        '
        'lblRegInfo
        '
        Me.lblRegInfo.AutoSize = True
        Me.lblRegInfo.Location = New System.Drawing.Point(20, 184)
        Me.lblRegInfo.Name = "lblRegInfo"
        Me.lblRegInfo.Size = New System.Drawing.Size(163, 15)
        Me.lblRegInfo.TabIndex = 3
        Me.lblRegInfo.Text = "本產品由以下使用者所註冊："
        '
        'lblStatement
        '
        Me.lblStatement.Location = New System.Drawing.Point(20, 86)
        Me.lblStatement.Name = "lblStatement"
        Me.lblStatement.Size = New System.Drawing.Size(350, 80)
        Me.lblStatement.TabIndex = 2
        Me.lblStatement.Text = "本產品雖為免費且開放原始碼之自由軟體，也歡迎使用者自行取得原始碼並修改之，然而我們嚴禁有任何許可範圍外之行為產生。違者可能遭致最大限度之民事及刑事訴訟。"
        '
        'lblCopy
        '
        Me.lblCopy.AutoSize = True
        Me.lblCopy.Location = New System.Drawing.Point(20, 46)
        Me.lblCopy.Name = "lblCopy"
        Me.lblCopy.Size = New System.Drawing.Size(92, 15)
        Me.lblCopy.TabIndex = 1
        Me.lblCopy.Text = "[textCopyright]"
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Location = New System.Drawing.Point(20, 19)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(78, 15)
        Me.lblVersion.TabIndex = 0
        Me.lblVersion.Text = "[textVersion]"
        '
        'tabpageProductVersion
        '
        Me.tabpageProductVersion.BackgroundImage = Global.fvexpress.My.Resources.Resources.Ice1
        Me.tabpageProductVersion.Controls.Add(Me.txtInfo)
        Me.tabpageProductVersion.Location = New System.Drawing.Point(4, 24)
        Me.tabpageProductVersion.Name = "tabpageProductVersion"
        Me.tabpageProductVersion.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageProductVersion.Size = New System.Drawing.Size(391, 303)
        Me.tabpageProductVersion.TabIndex = 1
        Me.tabpageProductVersion.Text = "產品版本"
        Me.tabpageProductVersion.UseVisualStyleBackColor = True
        '
        'txtInfo
        '
        Me.txtInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtInfo.Location = New System.Drawing.Point(3, 3)
        Me.txtInfo.Multiline = True
        Me.txtInfo.Name = "txtInfo"
        Me.txtInfo.ReadOnly = True
        Me.txtInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtInfo.Size = New System.Drawing.Size(385, 297)
        Me.txtInfo.TabIndex = 1
        '
        'tabpageLicense
        '
        Me.tabpageLicense.BackgroundImage = Global.fvexpress.My.Resources.Resources.Ice1
        Me.tabpageLicense.Controls.Add(Me.txtShowLicense)
        Me.tabpageLicense.Location = New System.Drawing.Point(4, 24)
        Me.tabpageLicense.Name = "tabpageLicense"
        Me.tabpageLicense.Size = New System.Drawing.Size(391, 303)
        Me.tabpageLicense.TabIndex = 2
        Me.tabpageLicense.Text = "產品授權合約"
        Me.tabpageLicense.UseVisualStyleBackColor = True
        '
        'txtShowLicense
        '
        Me.txtShowLicense.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtShowLicense.Location = New System.Drawing.Point(0, 0)
        Me.txtShowLicense.Multiline = True
        Me.txtShowLicense.Name = "txtShowLicense"
        Me.txtShowLicense.ReadOnly = True
        Me.txtShowLicense.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtShowLicense.Size = New System.Drawing.Size(391, 303)
        Me.txtShowLicense.TabIndex = 0
        '
        'tabpageGPL
        '
        Me.tabpageGPL.BackgroundImage = Global.fvexpress.My.Resources.Resources.Ice1
        Me.tabpageGPL.Controls.Add(Me.txtShowGPL)
        Me.tabpageGPL.Location = New System.Drawing.Point(4, 24)
        Me.tabpageGPL.Name = "tabpageGPL"
        Me.tabpageGPL.Size = New System.Drawing.Size(391, 303)
        Me.tabpageGPL.TabIndex = 3
        Me.tabpageGPL.Text = "GNU GPL"
        Me.tabpageGPL.UseVisualStyleBackColor = True
        '
        'txtShowGPL
        '
        Me.txtShowGPL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtShowGPL.Location = New System.Drawing.Point(0, 0)
        Me.txtShowGPL.Multiline = True
        Me.txtShowGPL.Name = "txtShowGPL"
        Me.txtShowGPL.ReadOnly = True
        Me.txtShowGPL.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtShowGPL.Size = New System.Drawing.Size(391, 303)
        Me.txtShowGPL.TabIndex = 1
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.BackgroundImage = Global.fvexpress.My.Resources.Resources.Ice1
        Me.btnClose.Location = New System.Drawing.Point(313, 424)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(98, 39)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "關閉(&C)"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'lnkDPWWebsite
        '
        Me.lnkDPWWebsite.AutoSize = True
        Me.lnkDPWWebsite.BackColor = System.Drawing.Color.Transparent
        Me.lnkDPWWebsite.Location = New System.Drawing.Point(12, 436)
        Me.lnkDPWWebsite.Name = "lnkDPWWebsite"
        Me.lnkDPWWebsite.Size = New System.Drawing.Size(103, 15)
        Me.lnkDPWWebsite.TabIndex = 3
        Me.lnkDPWWebsite.TabStop = True
        Me.lnkDPWWebsite.Text = "龍鳳之谷官方網站"
        '
        'aboutForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.fvexpress.My.Resources.Resources.Ice1
        Me.ClientSize = New System.Drawing.Size(423, 475)
        Me.Controls.Add(Me.lnkDPWWebsite)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.tabAbout)
        Me.Controls.Add(Me.picLogo)
        Me.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "aboutForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "關於 File Viewer Express™"
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabAbout.ResumeLayout(False)
        Me.tabpageAbout.ResumeLayout(False)
        Me.tabpageAbout.PerformLayout()
        Me.tabpageProductVersion.ResumeLayout(False)
        Me.tabpageProductVersion.PerformLayout()
        Me.tabpageLicense.ResumeLayout(False)
        Me.tabpageLicense.PerformLayout()
        Me.tabpageGPL.ResumeLayout(False)
        Me.tabpageGPL.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picLogo As PictureBox
    Friend WithEvents tabAbout As TabControl
    Friend WithEvents tabpageAbout As TabPage
    Friend WithEvents tabpageProductVersion As TabPage
    Friend WithEvents btnClose As Button
    Friend WithEvents tabpageLicense As TabPage
    Friend WithEvents tabpageGPL As TabPage
    Friend WithEvents lblRegEmail As Label
    Friend WithEvents lblRegOrg As Label
    Friend WithEvents lblRegName As Label
    Friend WithEvents lblRegInfo As Label
    Friend WithEvents lblStatement As Label
    Friend WithEvents lblCopy As Label
    Friend WithEvents lblVersion As Label
    Friend WithEvents txtShowLicense As TextBox
    Friend WithEvents txtShowGPL As TextBox
    Friend WithEvents txtInfo As TextBox
    Friend WithEvents lnkDPWWebsite As LinkLabel
End Class
