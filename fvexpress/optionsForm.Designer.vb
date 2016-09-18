<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class optionsForm
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
        Me.tabOptions = New System.Windows.Forms.TabControl()
        Me.tabGeneral = New System.Windows.Forms.TabPage()
        Me.chkAutoUpdate = New System.Windows.Forms.CheckBox()
        Me.tabVersionInfo = New System.Windows.Forms.TabPage()
        Me.txtInfo = New System.Windows.Forms.TextBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.tabOptions.SuspendLayout()
        Me.tabGeneral.SuspendLayout()
        Me.tabVersionInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabOptions
        '
        Me.tabOptions.Controls.Add(Me.tabGeneral)
        Me.tabOptions.Controls.Add(Me.tabVersionInfo)
        Me.tabOptions.Location = New System.Drawing.Point(12, 12)
        Me.tabOptions.Name = "tabOptions"
        Me.tabOptions.SelectedIndex = 0
        Me.tabOptions.Size = New System.Drawing.Size(461, 365)
        Me.tabOptions.TabIndex = 0
        '
        'tabGeneral
        '
        Me.tabGeneral.BackgroundImage = Global.fvexpress.My.Resources.Resources.Ice1
        Me.tabGeneral.Controls.Add(Me.chkAutoUpdate)
        Me.tabGeneral.Location = New System.Drawing.Point(4, 24)
        Me.tabGeneral.Name = "tabGeneral"
        Me.tabGeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.tabGeneral.Size = New System.Drawing.Size(453, 337)
        Me.tabGeneral.TabIndex = 0
        Me.tabGeneral.Text = "一般"
        Me.tabGeneral.UseVisualStyleBackColor = True
        '
        'chkAutoUpdate
        '
        Me.chkAutoUpdate.AutoSize = True
        Me.chkAutoUpdate.Location = New System.Drawing.Point(22, 25)
        Me.chkAutoUpdate.Name = "chkAutoUpdate"
        Me.chkAutoUpdate.Size = New System.Drawing.Size(114, 19)
        Me.chkAutoUpdate.TabIndex = 0
        Me.chkAutoUpdate.Text = "自動檢查更新(&A)"
        Me.chkAutoUpdate.UseVisualStyleBackColor = True
        '
        'tabVersionInfo
        '
        Me.tabVersionInfo.BackgroundImage = Global.fvexpress.My.Resources.Resources.Ice1
        Me.tabVersionInfo.Controls.Add(Me.txtInfo)
        Me.tabVersionInfo.Location = New System.Drawing.Point(4, 24)
        Me.tabVersionInfo.Name = "tabVersionInfo"
        Me.tabVersionInfo.Padding = New System.Windows.Forms.Padding(3)
        Me.tabVersionInfo.Size = New System.Drawing.Size(453, 337)
        Me.tabVersionInfo.TabIndex = 1
        Me.tabVersionInfo.Text = "版本資訊"
        Me.tabVersionInfo.UseVisualStyleBackColor = True
        '
        'txtInfo
        '
        Me.txtInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtInfo.Location = New System.Drawing.Point(3, 3)
        Me.txtInfo.Multiline = True
        Me.txtInfo.Name = "txtInfo"
        Me.txtInfo.ReadOnly = True
        Me.txtInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtInfo.Size = New System.Drawing.Size(447, 331)
        Me.txtInfo.TabIndex = 0
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.BackgroundImage = Global.fvexpress.My.Resources.Resources.Ice1
        Me.btnClose.Location = New System.Drawing.Point(377, 388)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(96, 33)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "關閉"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'optionsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.fvexpress.My.Resources.Resources.Ice1
        Me.ClientSize = New System.Drawing.Size(485, 433)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.tabOptions)
        Me.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "optionsForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "選項"
        Me.tabOptions.ResumeLayout(False)
        Me.tabGeneral.ResumeLayout(False)
        Me.tabGeneral.PerformLayout()
        Me.tabVersionInfo.ResumeLayout(False)
        Me.tabVersionInfo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabOptions As TabControl
    Friend WithEvents tabGeneral As TabPage
    Friend WithEvents tabVersionInfo As TabPage
    Friend WithEvents btnClose As Button
    Friend WithEvents chkAutoUpdate As CheckBox
    Friend WithEvents txtInfo As TextBox
End Class
