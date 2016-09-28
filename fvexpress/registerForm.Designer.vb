<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class registerForm
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
        Me.grpStep1 = New System.Windows.Forms.GroupBox()
        Me.txtRegOrg = New System.Windows.Forms.TextBox()
        Me.txtRegEmail = New System.Windows.Forms.TextBox()
        Me.txtRegName = New System.Windows.Forms.TextBox()
        Me.lblRegOrg = New System.Windows.Forms.Label()
        Me.lblRegEmail = New System.Windows.Forms.Label()
        Me.lblRegName = New System.Windows.Forms.Label()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.brpStep2 = New System.Windows.Forms.GroupBox()
        Me.txtActCode = New System.Windows.Forms.TextBox()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.grpStep1.SuspendLayout()
        Me.brpStep2.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpStep1
        '
        Me.grpStep1.BackColor = System.Drawing.Color.Transparent
        Me.grpStep1.Controls.Add(Me.txtRegOrg)
        Me.grpStep1.Controls.Add(Me.txtRegEmail)
        Me.grpStep1.Controls.Add(Me.txtRegName)
        Me.grpStep1.Controls.Add(Me.lblRegOrg)
        Me.grpStep1.Controls.Add(Me.lblRegEmail)
        Me.grpStep1.Controls.Add(Me.lblRegName)
        Me.grpStep1.Controls.Add(Me.btnConfirm)
        Me.grpStep1.Location = New System.Drawing.Point(12, 103)
        Me.grpStep1.Name = "grpStep1"
        Me.grpStep1.Size = New System.Drawing.Size(462, 157)
        Me.grpStep1.TabIndex = 0
        Me.grpStep1.TabStop = False
        Me.grpStep1.Text = "第一步：輸入基本資料"
        '
        'txtRegOrg
        '
        Me.txtRegOrg.Location = New System.Drawing.Point(106, 82)
        Me.txtRegOrg.Name = "txtRegOrg"
        Me.txtRegOrg.Size = New System.Drawing.Size(350, 23)
        Me.txtRegOrg.TabIndex = 7
        '
        'txtRegEmail
        '
        Me.txtRegEmail.Location = New System.Drawing.Point(106, 53)
        Me.txtRegEmail.Name = "txtRegEmail"
        Me.txtRegEmail.Size = New System.Drawing.Size(350, 23)
        Me.txtRegEmail.TabIndex = 6
        '
        'txtRegName
        '
        Me.txtRegName.Location = New System.Drawing.Point(106, 22)
        Me.txtRegName.Name = "txtRegName"
        Me.txtRegName.Size = New System.Drawing.Size(350, 23)
        Me.txtRegName.TabIndex = 5
        '
        'lblRegOrg
        '
        Me.lblRegOrg.AutoSize = True
        Me.lblRegOrg.BackColor = System.Drawing.Color.Transparent
        Me.lblRegOrg.Location = New System.Drawing.Point(4, 85)
        Me.lblRegOrg.Name = "lblRegOrg"
        Me.lblRegOrg.Size = New System.Drawing.Size(96, 15)
        Me.lblRegOrg.TabIndex = 4
        Me.lblRegOrg.Text = "公司/組織名稱："
        '
        'lblRegEmail
        '
        Me.lblRegEmail.AutoSize = True
        Me.lblRegEmail.BackColor = System.Drawing.Color.Transparent
        Me.lblRegEmail.Location = New System.Drawing.Point(50, 56)
        Me.lblRegEmail.Name = "lblRegEmail"
        Me.lblRegEmail.Size = New System.Drawing.Size(50, 15)
        Me.lblRegEmail.TabIndex = 3
        Me.lblRegEmail.Text = "Email："
        '
        'lblRegName
        '
        Me.lblRegName.AutoSize = True
        Me.lblRegName.BackColor = System.Drawing.Color.Transparent
        Me.lblRegName.Location = New System.Drawing.Point(57, 25)
        Me.lblRegName.Name = "lblRegName"
        Me.lblRegName.Size = New System.Drawing.Size(43, 15)
        Me.lblRegName.TabIndex = 2
        Me.lblRegName.Text = "名字："
        '
        'btnConfirm
        '
        Me.btnConfirm.BackColor = System.Drawing.Color.Transparent
        Me.btnConfirm.Enabled = False
        Me.btnConfirm.Location = New System.Drawing.Point(368, 111)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(88, 40)
        Me.btnConfirm.TabIndex = 1
        Me.btnConfirm.Text = "確認輸入(&O)"
        Me.btnConfirm.UseVisualStyleBackColor = False
        '
        'brpStep2
        '
        Me.brpStep2.BackColor = System.Drawing.Color.Transparent
        Me.brpStep2.Controls.Add(Me.txtActCode)
        Me.brpStep2.Location = New System.Drawing.Point(12, 266)
        Me.brpStep2.Name = "brpStep2"
        Me.brpStep2.Size = New System.Drawing.Size(462, 100)
        Me.brpStep2.TabIndex = 0
        Me.brpStep2.TabStop = False
        Me.brpStep2.Text = "第二步：貼上已複製到剪貼簿上的啟動碼"
        '
        'txtActCode
        '
        Me.txtActCode.Enabled = False
        Me.txtActCode.Font = New System.Drawing.Font("Microsoft JhengHei UI", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtActCode.Location = New System.Drawing.Point(14, 22)
        Me.txtActCode.Name = "txtActCode"
        Me.txtActCode.Size = New System.Drawing.Size(442, 58)
        Me.txtActCode.TabIndex = 0
        '
        'btnRegister
        '
        Me.btnRegister.BackColor = System.Drawing.Color.Transparent
        Me.btnRegister.Enabled = False
        Me.btnRegister.Location = New System.Drawing.Point(296, 379)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(97, 23)
        Me.btnRegister.TabIndex = 2
        Me.btnRegister.Text = "註冊(&R)"
        Me.btnRegister.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.Location = New System.Drawing.Point(399, 379)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "取消(&C)"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(9, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(271, 60)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "立即註冊，可享免費技術支援。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "另外，無論您有無註冊，所有功能皆可正常使用。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "註冊的過程中不會使用到網際網路，也無須付款。"
        '
        'registerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.fvexpress.My.Resources.Resources.Ice1
        Me.ClientSize = New System.Drawing.Size(486, 414)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.brpStep2)
        Me.Controls.Add(Me.grpStep1)
        Me.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "registerForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "註冊"
        Me.grpStep1.ResumeLayout(False)
        Me.grpStep1.PerformLayout()
        Me.brpStep2.ResumeLayout(False)
        Me.brpStep2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpStep1 As GroupBox
    Friend WithEvents brpStep2 As GroupBox
    Friend WithEvents btnConfirm As Button
    Friend WithEvents btnRegister As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents txtRegOrg As TextBox
    Friend WithEvents txtRegEmail As TextBox
    Friend WithEvents txtRegName As TextBox
    Friend WithEvents lblRegOrg As Label
    Friend WithEvents lblRegEmail As Label
    Friend WithEvents lblRegName As Label
    Friend WithEvents txtActCode As TextBox
    Friend WithEvents Label4 As Label
End Class
