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
        Me.报表中心ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.消费明细ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.设置ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.修改密码ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.报表中心ToolStripMenuItem, Me.设置ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 24)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(609, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '报表中心ToolStripMenuItem
        '
        Me.报表中心ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.消费明细ToolStripMenuItem})
        Me.报表中心ToolStripMenuItem.Name = "报表中心ToolStripMenuItem"
        Me.报表中心ToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.报表中心ToolStripMenuItem.Text = "报表中心"
        '
        '消费明细ToolStripMenuItem
        '
        Me.消费明细ToolStripMenuItem.Name = "消费明细ToolStripMenuItem"
        Me.消费明细ToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.消费明细ToolStripMenuItem.Text = "消费明细"
        '
        '设置ToolStripMenuItem
        '
        Me.设置ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.修改密码ToolStripMenuItem})
        Me.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem"
        Me.设置ToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.设置ToolStripMenuItem.Text = "设置"
        '
        '修改密码ToolStripMenuItem
        '
        Me.修改密码ToolStripMenuItem.Name = "修改密码ToolStripMenuItem"
        Me.修改密码ToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.修改密码ToolStripMenuItem.Text = "修改密码"
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
        Me.Text = "梧州金银阁投资管理有限公司　一卡通消费平台 业务端"
        Me.Controls.SetChildIndex(Me.MenuStrip1, 0)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents 报表中心ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 消费明细ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 设置ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 修改密码ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
