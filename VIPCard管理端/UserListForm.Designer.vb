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
        Me.DataGridView1 = New LSW.Windows.Controls.DoubleBufferDataGridView
        Me.编号DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.用户名DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.卡号DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.余额DataGridViewTextBoxColumn = New LSW.Windows.Controls.DataGridViewAutoFilterNumTextBoxColumn()
        Me.发卡人DataGridViewTextBoxColumn = New LSW.Windows.Controls.DataGridViewAutoFilterTextBoxColumn()
        Me.状态 = New LSW.Windows.Controls.DataGridViewAutoFilterTextBoxColumn()
        Me.激活时间DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.消费额DataGridViewTextBoxColumn = New LSW.Windows.Controls.DataGridViewAutoFilterNumTextBoxColumn()
        Me.BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EntityDataSource1 = New LSW.Windows.Controls.EntityDataSource(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
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
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.编号DataGridViewTextBoxColumn, Me.用户名DataGridViewTextBoxColumn, Me.卡号DataGridViewTextBoxColumn, Me.余额DataGridViewTextBoxColumn, Me.发卡人DataGridViewTextBoxColumn, Me.状态, Me.激活时间DataGridViewTextBoxColumn, Me.消费额DataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.BindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 25)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 23
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(873, 429)
        Me.DataGridView1.TabIndex = 0
        '
        '编号DataGridViewTextBoxColumn
        '
        Me.编号DataGridViewTextBoxColumn.DataPropertyName = "编号"
        Me.编号DataGridViewTextBoxColumn.HeaderText = "编号"
        Me.编号DataGridViewTextBoxColumn.Name = "编号DataGridViewTextBoxColumn"
        Me.编号DataGridViewTextBoxColumn.ReadOnly = True
        Me.编号DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        '用户名DataGridViewTextBoxColumn
        '
        Me.用户名DataGridViewTextBoxColumn.DataPropertyName = "用户名"
        Me.用户名DataGridViewTextBoxColumn.HeaderText = "用户名"
        Me.用户名DataGridViewTextBoxColumn.Name = "用户名DataGridViewTextBoxColumn"
        Me.用户名DataGridViewTextBoxColumn.ReadOnly = True
        Me.用户名DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        '卡号DataGridViewTextBoxColumn
        '
        Me.卡号DataGridViewTextBoxColumn.DataPropertyName = "卡号"
        Me.卡号DataGridViewTextBoxColumn.HeaderText = "卡号"
        Me.卡号DataGridViewTextBoxColumn.Name = "卡号DataGridViewTextBoxColumn"
        Me.卡号DataGridViewTextBoxColumn.ReadOnly = True
        Me.卡号DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        '余额DataGridViewTextBoxColumn
        '
        Me.余额DataGridViewTextBoxColumn.DataPropertyName = "余额"
        Me.余额DataGridViewTextBoxColumn.HeaderText = "余额"
        Me.余额DataGridViewTextBoxColumn.Name = "余额DataGridViewTextBoxColumn"
        Me.余额DataGridViewTextBoxColumn.ReadOnly = True
        Me.余额DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.余额DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        '
        '发卡人DataGridViewTextBoxColumn
        '
        Me.发卡人DataGridViewTextBoxColumn.AutomaticSortingEnabled = False
        Me.发卡人DataGridViewTextBoxColumn.DataPropertyName = "发卡人"
        Me.发卡人DataGridViewTextBoxColumn.HeaderText = "发卡人"
        Me.发卡人DataGridViewTextBoxColumn.Name = "发卡人DataGridViewTextBoxColumn"
        Me.发卡人DataGridViewTextBoxColumn.ReadOnly = True
        Me.发卡人DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.发卡人DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        '状态
        '
        Me.状态.AutomaticSortingEnabled = False
        Me.状态.DataPropertyName = "状态"
        Me.状态.HeaderText = "状态"
        Me.状态.Name = "状态"
        Me.状态.ReadOnly = True
        Me.状态.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.状态.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        '激活时间DataGridViewTextBoxColumn
        '
        Me.激活时间DataGridViewTextBoxColumn.DataPropertyName = "激活时间"
        Me.激活时间DataGridViewTextBoxColumn.HeaderText = "激活时间"
        Me.激活时间DataGridViewTextBoxColumn.Name = "激活时间DataGridViewTextBoxColumn"
        Me.激活时间DataGridViewTextBoxColumn.ReadOnly = True
        '
        '消费额DataGridViewTextBoxColumn
        '
        Me.消费额DataGridViewTextBoxColumn.DataPropertyName = "消费额"
        Me.消费额DataGridViewTextBoxColumn.HeaderText = "消费额"
        Me.消费额DataGridViewTextBoxColumn.Name = "消费额DataGridViewTextBoxColumn"
        Me.消费额DataGridViewTextBoxColumn.ReadOnly = True
        Me.消费额DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.消费额DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
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
        Me.EntityDataSource1.ObjectContextType = GetType(VIPCard管理端.VIPCardEntities)
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripSeparator1, Me.ToolStripButton2, Me.ToolStripSeparator2, Me.ToolStripTextBox1, Me.ToolStripButton3, Me.ToolStripSeparator3, Me.ToolStripButton4, Me.ToolStripSeparator4, Me.ToolStripButton5, Me.ToolStripSeparator5, Me.ToolStripButton6, Me.ToolStripButton7})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(873, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(73, 22)
        Me.ToolStripButton1.Text = "添加会员"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(73, 22)
        Me.ToolStripButton2.Text = "删除会员"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(100, 25)
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(49, 22)
        Me.ToolStripButton3.Text = "查找"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(73, 22)
        Me.ToolStripButton4.Text = "充值(F2)"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(73, 22)
        Me.ToolStripButton5.Text = "批量添加"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), System.Drawing.Image)
        Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.Size = New System.Drawing.Size(49, 22)
        Me.ToolStripButton6.Text = "打印"
        '
        'ToolStripButton7
        '
        Me.ToolStripButton7.Image = CType(resources.GetObject("ToolStripButton7.Image"), System.Drawing.Image)
        Me.ToolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton7.Name = "ToolStripButton7"
        Me.ToolStripButton7.Size = New System.Drawing.Size(79, 22)
        Me.ToolStripButton7.Text = "导出Excel"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(268, 216)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(336, 23)
        Me.ProgressBar1.TabIndex = 2
        Me.ProgressBar1.Visible = False
        '
        'UserListForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(873, 454)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.KeyPreview = True
        Me.Name = "UserListForm"
        Me.Text = "用户列表"
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
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents EntityDataSource1 As LSW.Windows.Controls.EntityDataSource
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton6 As System.Windows.Forms.ToolStripButton
    Friend WithEvents 编号DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 用户名DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 卡号DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 余额DataGridViewTextBoxColumn As LSW.Windows.Controls.DataGridViewAutoFilterNumTextBoxColumn
    Friend WithEvents 发卡人DataGridViewTextBoxColumn As LSW.Windows.Controls.DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents 状态 As LSW.Windows.Controls.DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents 激活时间DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 消费额DataGridViewTextBoxColumn As LSW.Windows.Controls.DataGridViewAutoFilterNumTextBoxColumn
    Friend WithEvents ToolStripButton7 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
End Class
