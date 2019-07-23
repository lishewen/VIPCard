Imports LSW.Windows.Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserListForm
    Inherits LSW.Windows.Controls.Forms.MDIChildFormBase

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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserListForm))
        'Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridView1 = New DoubleBufferDataGridView
        Me.编号 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.用户名 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.手机DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.卡号 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.余额 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.性别DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.激活时间 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.级别DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.年DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.职业DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QQ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.消费额 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.积分消费额DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.现金消费额DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.发卡人 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.状态DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EntityDataSource1 = New LSW.Windows.Controls.EntityDataSource(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripComboBox1 = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.DgvHelper1 = New LSW.Windows.Controls.DGVPaste.DGVHelper()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.编号, Me.用户名, Me.手机DataGridViewTextBoxColumn, Me.卡号, Me.余额, Me.性别DataGridViewTextBoxColumn, Me.激活时间, Me.级别DataGridViewTextBoxColumn, Me.年DataGridViewTextBoxColumn, Me.职业DataGridViewTextBoxColumn, Me.QQ, Me.消费额, Me.积分消费额DataGridViewTextBoxColumn, Me.现金消费额DataGridViewTextBoxColumn, Me.发卡人, Me.状态DataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.BindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 28)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 23
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(873, 426)
        Me.DataGridView1.TabIndex = 0
        '
        '编号
        '
        Me.编号.DataPropertyName = "编号"
        Me.编号.HeaderText = "编号"
        Me.编号.Name = "编号"
        Me.编号.ReadOnly = True
        '
        '用户名
        '
        Me.用户名.DataPropertyName = "用户名"
        Me.用户名.HeaderText = "用户名"
        Me.用户名.Name = "用户名"
        Me.用户名.ReadOnly = True
        '
        '手机DataGridViewTextBoxColumn
        '
        Me.手机DataGridViewTextBoxColumn.DataPropertyName = "手机"
        Me.手机DataGridViewTextBoxColumn.HeaderText = "手机"
        Me.手机DataGridViewTextBoxColumn.Name = "手机DataGridViewTextBoxColumn"
        Me.手机DataGridViewTextBoxColumn.ReadOnly = True
        '
        '卡号
        '
        Me.卡号.DataPropertyName = "卡号"
        Me.卡号.HeaderText = "卡号"
        Me.卡号.Name = "卡号"
        Me.卡号.ReadOnly = True
        '
        '余额
        '
        Me.余额.DataPropertyName = "余额"
        Me.余额.HeaderText = "余额"
        Me.余额.Name = "余额"
        Me.余额.ReadOnly = True
        Me.余额.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        '性别DataGridViewTextBoxColumn
        '
        Me.性别DataGridViewTextBoxColumn.DataPropertyName = "性别"
        Me.性别DataGridViewTextBoxColumn.HeaderText = "性别"
        Me.性别DataGridViewTextBoxColumn.Name = "性别DataGridViewTextBoxColumn"
        Me.性别DataGridViewTextBoxColumn.ReadOnly = True
        Me.性别DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.性别DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        '
        '激活时间
        '
        Me.激活时间.DataPropertyName = "激活时间"
        Me.激活时间.HeaderText = "激活时间"
        Me.激活时间.Name = "激活时间"
        Me.激活时间.ReadOnly = True
        '
        '级别DataGridViewTextBoxColumn
        '
        Me.级别DataGridViewTextBoxColumn.DataPropertyName = "级别"
        Me.级别DataGridViewTextBoxColumn.HeaderText = "级别"
        Me.级别DataGridViewTextBoxColumn.Name = "级别DataGridViewTextBoxColumn"
        Me.级别DataGridViewTextBoxColumn.ReadOnly = True
        Me.级别DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.级别DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        '
        '年DataGridViewTextBoxColumn
        '
        Me.年DataGridViewTextBoxColumn.DataPropertyName = "年"
        Me.年DataGridViewTextBoxColumn.HeaderText = "年"
        Me.年DataGridViewTextBoxColumn.Name = "年DataGridViewTextBoxColumn"
        Me.年DataGridViewTextBoxColumn.ReadOnly = True
        Me.年DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.年DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        '
        '职业DataGridViewTextBoxColumn
        '
        Me.职业DataGridViewTextBoxColumn.DataPropertyName = "职业"
        Me.职业DataGridViewTextBoxColumn.HeaderText = "职业"
        Me.职业DataGridViewTextBoxColumn.Name = "职业DataGridViewTextBoxColumn"
        Me.职业DataGridViewTextBoxColumn.ReadOnly = True
        Me.职业DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.职业DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        '
        'QQ
        '
        Me.QQ.DataPropertyName = "QQ"
        Me.QQ.HeaderText = "QQ"
        Me.QQ.Name = "QQ"
        Me.QQ.ReadOnly = True
        '
        '消费额
        '
        Me.消费额.DataPropertyName = "消费额"
        Me.消费额.HeaderText = "消费额"
        Me.消费额.Name = "消费额"
        Me.消费额.ReadOnly = True
        Me.消费额.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        '积分消费额DataGridViewTextBoxColumn
        '
        Me.积分消费额DataGridViewTextBoxColumn.DataPropertyName = "积分消费额"
        Me.积分消费额DataGridViewTextBoxColumn.HeaderText = "积分消费额"
        Me.积分消费额DataGridViewTextBoxColumn.Name = "积分消费额DataGridViewTextBoxColumn"
        Me.积分消费额DataGridViewTextBoxColumn.ReadOnly = True
        Me.积分消费额DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        '现金消费额DataGridViewTextBoxColumn
        '
        Me.现金消费额DataGridViewTextBoxColumn.DataPropertyName = "现金消费额"
        Me.现金消费额DataGridViewTextBoxColumn.HeaderText = "现金消费额"
        Me.现金消费额DataGridViewTextBoxColumn.Name = "现金消费额DataGridViewTextBoxColumn"
        Me.现金消费额DataGridViewTextBoxColumn.ReadOnly = True
        Me.现金消费额DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        '发卡人
        '
        Me.发卡人.DataPropertyName = "发卡人"
        Me.发卡人.HeaderText = "发卡人"
        Me.发卡人.Name = "发卡人"
        Me.发卡人.ReadOnly = True
        Me.发卡人.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.发卡人.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        '
        '状态DataGridViewTextBoxColumn
        '
        Me.状态DataGridViewTextBoxColumn.DataPropertyName = "状态"
        Me.状态DataGridViewTextBoxColumn.HeaderText = "状态"
        Me.状态DataGridViewTextBoxColumn.Name = "状态DataGridViewTextBoxColumn"
        Me.状态DataGridViewTextBoxColumn.ReadOnly = True
        Me.状态DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.状态DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        '
        'BindingSource
        '
        Me.BindingSource.AllowNew = False
        Me.BindingSource.DataMember = "V_User"
        Me.BindingSource.DataSource = Me.EntityDataSource1
        Me.BindingSource.Position = 0
        '
        'EntityDataSource1
        '
        Me.EntityDataSource1.ObjectContextType = GetType(VIPCard短信平台.SMSVIPCardEntities)
        '
        'ToolStrip1
        '
        Me.ToolStrip1.CanOverflow = False
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripLabel2, Me.ToolStripButton2, Me.ToolStripSeparator4, Me.ToolStripLabel3, Me.ToolStripComboBox1, Me.ToolStripSeparator2, Me.ToolStripLabel4, Me.ToolStripTextBox1, Me.ToolStripButton3, Me.ToolStripSeparator5, Me.ToolStripButton4, Me.ToolStripSeparator3, Me.ToolStripButton7, Me.ToolStripSeparator1, Me.ToolStripButton1})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(873, 28)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("宋体", 9.0!)
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.ToolStripLabel1.Size = New System.Drawing.Size(17, 22)
        Me.ToolStripLabel1.Text = "从"
        Me.ToolStripLabel1.Visible = False
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.ToolStripLabel2.Size = New System.Drawing.Size(19, 25)
        Me.ToolStripLabel2.Text = "到"
        Me.ToolStripLabel2.Visible = False
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(51, 20)
        Me.ToolStripButton2.Text = "查看"
        Me.ToolStripButton2.Visible = False
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 23)
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.ToolStripLabel3.Size = New System.Drawing.Size(43, 25)
        Me.ToolStripLabel3.Text = "店铺："
        '
        'ToolStripComboBox1
        '
        Me.ToolStripComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ToolStripComboBox1.Name = "ToolStripComboBox1"
        Me.ToolStripComboBox1.Size = New System.Drawing.Size(121, 23)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 23)
        '
        'ToolStripLabel4
        '
        Me.ToolStripLabel4.Name = "ToolStripLabel4"
        Me.ToolStripLabel4.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.ToolStripLabel4.Size = New System.Drawing.Size(43, 25)
        Me.ToolStripLabel4.Text = "搜索："
        Me.ToolStripLabel4.Visible = False
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(100, 23)
        Me.ToolStripTextBox1.Visible = False
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(51, 20)
        Me.ToolStripButton3.Text = "查找"
        Me.ToolStripButton3.Visible = False
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 23)
        Me.ToolStripSeparator5.Visible = False
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(75, 20)
        Me.ToolStripButton4.Text = "显示全部"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 23)
        '
        'ToolStripButton7
        '
        Me.ToolStripButton7.Image = CType(resources.GetObject("ToolStripButton7.Image"), System.Drawing.Image)
        Me.ToolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton7.Name = "ToolStripButton7"
        Me.ToolStripButton7.Size = New System.Drawing.Size(80, 20)
        Me.ToolStripButton7.Text = "导出Excel"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 23)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(75, 20)
        Me.ToolStripButton1.Text = "发送短信"
        '
        'DgvHelper1
        '
        Me.DgvHelper1.BackColor = System.Drawing.Color.Ivory
        Me.DgvHelper1.Location = New System.Drawing.Point(0, 0)
        Me.DgvHelper1.Name = "DgvHelper1"
        Me.DgvHelper1.Size = New System.Drawing.Size(10, 10)
        Me.DgvHelper1.TabIndex = 2
        '
        'UserListForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(873, 454)
        Me.Controls.Add(Me.DgvHelper1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.KeyPreview = True
        Me.Name = "UserListForm"
        Me.Text = "用户清单"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EntityDataSource1 As LSW.Windows.Controls.EntityDataSource
    Friend WithEvents 编号DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 用户名DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 卡号DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 余额DataGridViewTextBoxColumn As LSW.Windows.Controls.DataGridViewAutoFilterNumTextBoxColumn
    Friend WithEvents 发卡人DataGridViewTextBoxColumn As LSW.Windows.Controls.DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents 激活时间DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 消费额DataGridViewTextBoxColumn As LSW.Windows.Controls.DataGridViewAutoFilterNumTextBoxColumn
    Friend WithEvents ToolStripButton7 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripComboBox1 As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel4 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents DgvHelper1 As LSW.Windows.Controls.DGVPaste.DGVHelper
    Friend WithEvents 编号 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 用户名 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 手机DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 卡号 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 余额 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 性别DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 激活时间 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 级别DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 年DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 职业DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QQ As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 消费额 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 积分消费额DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 现金消费额DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 发卡人 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 状态DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
