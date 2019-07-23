<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits LSW.Windows.Controls.Forms.MDIParentFormBase

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.功能ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.用户清单ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.系统设置ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.设置ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.功能ToolStripMenuItem, Me.系统设置ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 24)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(609, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '功能ToolStripMenuItem
        '
        Me.功能ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.用户清单ToolStripMenuItem})
        Me.功能ToolStripMenuItem.Name = "功能ToolStripMenuItem"
        Me.功能ToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.功能ToolStripMenuItem.Text = "功能"
        '
        '用户清单ToolStripMenuItem
        '
        Me.用户清单ToolStripMenuItem.Name = "用户清单ToolStripMenuItem"
        Me.用户清单ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.用户清单ToolStripMenuItem.Text = "用户清单"
        '
        '系统设置ToolStripMenuItem
        '
        Me.系统设置ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.设置ToolStripMenuItem})
        Me.系统设置ToolStripMenuItem.Name = "系统设置ToolStripMenuItem"
        Me.系统设置ToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.系统设置ToolStripMenuItem.Text = "系统设置"
        '
        '设置ToolStripMenuItem
        '
        Me.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem"
        Me.设置ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.设置ToolStripMenuItem.Text = "设置"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(609, 449)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.Text = "梧州金银阁投资管理有限公司　一卡通消费平台 短信平台"
        Me.Controls.SetChildIndex(Me.MenuStrip1, 0)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents 功能ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 用户清单ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 系统设置ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 设置ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
