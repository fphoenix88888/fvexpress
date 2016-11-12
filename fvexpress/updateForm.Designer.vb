<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class updateForm
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.txtChangelog = New System.Windows.Forms.TextBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblStatusLabel = New System.Windows.Forms.Label()
        Me.lblStatusText = New System.Windows.Forms.Label()
        Me.prgUpdateProgress = New System.Windows.Forms.ProgressBar()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.prgUpdateProgress)
        Me.GroupBox1.Controls.Add(Me.lblStatusText)
        Me.GroupBox1.Controls.Add(Me.lblStatusLabel)
        Me.GroupBox1.Controls.Add(Me.btnUpdate)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(518, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "更新狀態"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.txtChangelog)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 122)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(518, 339)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "版本歷程記錄"
        '
        'btnUpdate
        '
        Me.btnUpdate.Enabled = False
        Me.btnUpdate.Location = New System.Drawing.Point(437, 22)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 72)
        Me.btnUpdate.TabIndex = 0
        Me.btnUpdate.Text = "更新(&U)"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'txtChangelog
        '
        Me.txtChangelog.Location = New System.Drawing.Point(6, 22)
        Me.txtChangelog.Multiline = True
        Me.txtChangelog.Name = "txtChangelog"
        Me.txtChangelog.ReadOnly = True
        Me.txtChangelog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtChangelog.Size = New System.Drawing.Size(506, 311)
        Me.txtChangelog.TabIndex = 0
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(428, 467)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(102, 31)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "關閉(&C)"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblStatusLabel
        '
        Me.lblStatusLabel.AutoSize = True
        Me.lblStatusLabel.Location = New System.Drawing.Point(6, 22)
        Me.lblStatusLabel.Name = "lblStatusLabel"
        Me.lblStatusLabel.Size = New System.Drawing.Size(43, 15)
        Me.lblStatusLabel.TabIndex = 1
        Me.lblStatusLabel.Text = "狀態："
        '
        'lblStatusText
        '
        Me.lblStatusText.Location = New System.Drawing.Point(55, 22)
        Me.lblStatusText.Name = "lblStatusText"
        Me.lblStatusText.Size = New System.Drawing.Size(376, 46)
        Me.lblStatusText.TabIndex = 2
        Me.lblStatusText.Text = "{statusText}"
        '
        'prgUpdateProgress
        '
        Me.prgUpdateProgress.Location = New System.Drawing.Point(6, 71)
        Me.prgUpdateProgress.Name = "prgUpdateProgress"
        Me.prgUpdateProgress.Size = New System.Drawing.Size(425, 23)
        Me.prgUpdateProgress.TabIndex = 3
        '
        'updateForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.fvexpress.My.Resources.Resources.Ice1
        Me.ClientSize = New System.Drawing.Size(542, 506)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "updateForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "線上更新"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents prgUpdateProgress As ProgressBar
    Friend WithEvents lblStatusText As Label
    Friend WithEvents lblStatusLabel As Label
    Friend WithEvents btnUpdate As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtChangelog As TextBox
    Friend WithEvents btnClose As Button
End Class
