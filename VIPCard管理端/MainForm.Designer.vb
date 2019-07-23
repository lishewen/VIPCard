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
        Me.会员管理ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.会员列表ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.添加会员ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.会员卡充值ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.查找会员ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.批量添加会员ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.数据报表ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.消费明细ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.行业报表ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.店铺分成ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.发卡分成ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.插件ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.短信平台用户清单ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.系统设置ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.管理员ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.行业管理ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.店铺管理ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.发卡方管理ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.业务员管理ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.短信平台设置ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.会员管理ToolStripMenuItem, Me.数据报表ToolStripMenuItem, Me.插件ToolStripMenuItem, Me.系统设置ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 24)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(784, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '会员管理ToolStripMenuItem
        '
        Me.会员管理ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.会员列表ToolStripMenuItem, Me.添加会员ToolStripMenuItem, Me.会员卡充值ToolStripMenuItem, Me.查找会员ToolStripMenuItem, Me.批量添加会员ToolStripMenuItem})
        Me.会员管理ToolStripMenuItem.Name = "会员管理ToolStripMenuItem"
        Me.会员管理ToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.会员管理ToolStripMenuItem.Text = "会员管理"
        '
        '会员列表ToolStripMenuItem
        '
        Me.会员列表ToolStripMenuItem.Name = "会员列表ToolStripMenuItem"
        Me.会员列表ToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.会员列表ToolStripMenuItem.Text = "会员列表"
        '
        '添加会员ToolStripMenuItem
        '
        Me.添加会员ToolStripMenuItem.Name = "添加会员ToolStripMenuItem"
        Me.添加会员ToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.添加会员ToolStripMenuItem.Text = "添加会员"
        '
        '会员卡充值ToolStripMenuItem
        '
        Me.会员卡充值ToolStripMenuItem.Name = "会员卡充值ToolStripMenuItem"
        Me.会员卡充值ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.会员卡充值ToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.会员卡充值ToolStripMenuItem.Text = "会员卡充值"
        '
        '查找会员ToolStripMenuItem
        '
        Me.查找会员ToolStripMenuItem.Name = "查找会员ToolStripMenuItem"
        Me.查找会员ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.查找会员ToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.查找会员ToolStripMenuItem.Text = "刷卡查找会员"
        '
        '批量添加会员ToolStripMenuItem
        '
        Me.批量添加会员ToolStripMenuItem.Name = "批量添加会员ToolStripMenuItem"
        Me.批量添加会员ToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.批量添加会员ToolStripMenuItem.Text = "批量添加会员"
        '
        '数据报表ToolStripMenuItem
        '
        Me.数据报表ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.消费明细ToolStripMenuItem, Me.行业报表ToolStripMenuItem, Me.店铺分成ToolStripMenuItem, Me.发卡分成ToolStripMenuItem})
        Me.数据报表ToolStripMenuItem.Name = "数据报表ToolStripMenuItem"
        Me.数据报表ToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.数据报表ToolStripMenuItem.Text = "数据报表"
        '
        '消费明细ToolStripMenuItem
        '
        Me.消费明细ToolStripMenuItem.Name = "消费明细ToolStripMenuItem"
        Me.消费明细ToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.消费明细ToolStripMenuItem.Text = "消费明细"
        '
        '行业报表ToolStripMenuItem
        '
        Me.行业报表ToolStripMenuItem.Name = "行业报表ToolStripMenuItem"
        Me.行业报表ToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.行业报表ToolStripMenuItem.Text = "行业报表"
        '
        '店铺分成ToolStripMenuItem
        '
        Me.店铺分成ToolStripMenuItem.Name = "店铺分成ToolStripMenuItem"
        Me.店铺分成ToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.店铺分成ToolStripMenuItem.Text = "店铺分成"
        '
        '发卡分成ToolStripMenuItem
        '
        Me.发卡分成ToolStripMenuItem.Name = "发卡分成ToolStripMenuItem"
        Me.发卡分成ToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.发卡分成ToolStripMenuItem.Text = "发卡分成"
        '
        '插件ToolStripMenuItem
        '
        Me.插件ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.短信平台用户清单ToolStripMenuItem, Me.短信平台设置ToolStripMenuItem})
        Me.插件ToolStripMenuItem.Name = "插件ToolStripMenuItem"
        Me.插件ToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.插件ToolStripMenuItem.Text = "插件"
        '
        '短信平台用户清单ToolStripMenuItem
        '
        Me.短信平台用户清单ToolStripMenuItem.Name = "短信平台用户清单ToolStripMenuItem"
        Me.短信平台用户清单ToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.短信平台用户清单ToolStripMenuItem.Text = "短信平台.用户清单"
        '
        '系统设置ToolStripMenuItem
        '
        Me.系统设置ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.管理员ToolStripMenuItem, Me.行业管理ToolStripMenuItem, Me.店铺管理ToolStripMenuItem, Me.发卡方管理ToolStripMenuItem, Me.业务员管理ToolStripMenuItem})
        Me.系统设置ToolStripMenuItem.Name = "系统设置ToolStripMenuItem"
        Me.系统设置ToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.系统设置ToolStripMenuItem.Text = "系统设置"
        '
        '管理员ToolStripMenuItem
        '
        Me.管理员ToolStripMenuItem.Name = "管理员ToolStripMenuItem"
        Me.管理员ToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.管理员ToolStripMenuItem.Text = "管理员"
        '
        '行业管理ToolStripMenuItem
        '
        Me.行业管理ToolStripMenuItem.Name = "行业管理ToolStripMenuItem"
        Me.行业管理ToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.行业管理ToolStripMenuItem.Text = "行业管理"
        '
        '店铺管理ToolStripMenuItem
        '
        Me.店铺管理ToolStripMenuItem.Name = "店铺管理ToolStripMenuItem"
        Me.店铺管理ToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.店铺管理ToolStripMenuItem.Text = "店铺管理"
        '
        '发卡方管理ToolStripMenuItem
        '
        Me.发卡方管理ToolStripMenuItem.Name = "发卡方管理ToolStripMenuItem"
        Me.发卡方管理ToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.发卡方管理ToolStripMenuItem.Text = "发卡方管理"
        '
        '业务员管理ToolStripMenuItem
        '
        Me.业务员管理ToolStripMenuItem.Name = "业务员管理ToolStripMenuItem"
        Me.业务员管理ToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.业务员管理ToolStripMenuItem.Text = "业务员管理"
        '
        '短信平台设置ToolStripMenuItem
        '
        Me.短信平台设置ToolStripMenuItem.Name = "短信平台设置ToolStripMenuItem"
        Me.短信平台设置ToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.短信平台设置ToolStripMenuItem.Text = "短信平台.设置"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.Text = "梧州金银阁投资管理有限公司 一卡通消费平台管理端"
        Me.Controls.SetChildIndex(Me.MenuStrip1, 0)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents 系统设置ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 管理员ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 会员管理ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 会员列表ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 添加会员ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 会员卡充值ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 查找会员ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 行业管理ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 店铺管理ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 数据报表ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 消费明细ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 行业报表ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 店铺分成ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 发卡方管理ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 业务员管理ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 发卡分成ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 批量添加会员ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 插件ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 短信平台用户清单ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 短信平台设置ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
