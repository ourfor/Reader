<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.开始ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.查找ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.目录ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.上一页ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.下一页ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.本地ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.打开ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.工具ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.隐藏工具栏ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.全屏ESCToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.打开关闭全屏F6ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.设置ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.字体ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotoSansToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RobotoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.字号ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.增大ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.减小ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.背景ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.帮助ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.查看帮助ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.检查更新ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.技术支持ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.关于ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Noto Sans CJK JP Regular", 10.28571!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.开始ToolStripMenuItem, Me.本地ToolStripMenuItem, Me.工具ToolStripMenuItem, Me.设置ToolStripMenuItem, Me.帮助ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(10, 5, 0, 5)
        Me.MenuStrip1.Size = New System.Drawing.Size(1137, 39)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '开始ToolStripMenuItem
        '
        Me.开始ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.查找ToolStripMenuItem, Me.目录ToolStripMenuItem, Me.上一页ToolStripMenuItem, Me.下一页ToolStripMenuItem})
        Me.开始ToolStripMenuItem.Name = "开始ToolStripMenuItem"
        Me.开始ToolStripMenuItem.Size = New System.Drawing.Size(56, 29)
        Me.开始ToolStripMenuItem.Text = "开始"
        '
        '查找ToolStripMenuItem
        '
        Me.查找ToolStripMenuItem.Name = "查找ToolStripMenuItem"
        Me.查找ToolStripMenuItem.Size = New System.Drawing.Size(215, 30)
        Me.查找ToolStripMenuItem.Text = "查找"
        '
        '目录ToolStripMenuItem
        '
        Me.目录ToolStripMenuItem.Name = "目录ToolStripMenuItem"
        Me.目录ToolStripMenuItem.Size = New System.Drawing.Size(215, 30)
        Me.目录ToolStripMenuItem.Text = "目录"
        '
        '上一页ToolStripMenuItem
        '
        Me.上一页ToolStripMenuItem.Name = "上一页ToolStripMenuItem"
        Me.上一页ToolStripMenuItem.Size = New System.Drawing.Size(215, 30)
        Me.上一页ToolStripMenuItem.Text = "上一页([)"
        '
        '下一页ToolStripMenuItem
        '
        Me.下一页ToolStripMenuItem.Name = "下一页ToolStripMenuItem"
        Me.下一页ToolStripMenuItem.Size = New System.Drawing.Size(215, 30)
        Me.下一页ToolStripMenuItem.Text = "下一页(])"
        '
        '本地ToolStripMenuItem
        '
        Me.本地ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.打开ToolStripMenuItem})
        Me.本地ToolStripMenuItem.Name = "本地ToolStripMenuItem"
        Me.本地ToolStripMenuItem.Size = New System.Drawing.Size(56, 29)
        Me.本地ToolStripMenuItem.Text = "本地"
        '
        '打开ToolStripMenuItem
        '
        Me.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem"
        Me.打开ToolStripMenuItem.Size = New System.Drawing.Size(122, 30)
        Me.打开ToolStripMenuItem.Text = "打开"
        '
        '工具ToolStripMenuItem
        '
        Me.工具ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.隐藏工具栏ToolStripMenuItem, Me.全屏ESCToolStripMenuItem, Me.打开关闭全屏F6ToolStripMenuItem})
        Me.工具ToolStripMenuItem.Name = "工具ToolStripMenuItem"
        Me.工具ToolStripMenuItem.Size = New System.Drawing.Size(56, 29)
        Me.工具ToolStripMenuItem.Text = "工具"
        '
        '隐藏工具栏ToolStripMenuItem
        '
        Me.隐藏工具栏ToolStripMenuItem.Name = "隐藏工具栏ToolStripMenuItem"
        Me.隐藏工具栏ToolStripMenuItem.Size = New System.Drawing.Size(244, 30)
        Me.隐藏工具栏ToolStripMenuItem.Text = "显示/隐藏工具栏(F4)"
        '
        '全屏ESCToolStripMenuItem
        '
        Me.全屏ESCToolStripMenuItem.Name = "全屏ESCToolStripMenuItem"
        Me.全屏ESCToolStripMenuItem.Size = New System.Drawing.Size(244, 30)
        Me.全屏ESCToolStripMenuItem.Text = "显示/隐藏标题栏(F5)"
        '
        '打开关闭全屏F6ToolStripMenuItem
        '
        Me.打开关闭全屏F6ToolStripMenuItem.Name = "打开关闭全屏F6ToolStripMenuItem"
        Me.打开关闭全屏F6ToolStripMenuItem.Size = New System.Drawing.Size(244, 30)
        Me.打开关闭全屏F6ToolStripMenuItem.Text = "打开/关闭全屏(F6)"
        '
        '设置ToolStripMenuItem
        '
        Me.设置ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.字体ToolStripMenuItem, Me.字号ToolStripMenuItem, Me.背景ToolStripMenuItem})
        Me.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem"
        Me.设置ToolStripMenuItem.Size = New System.Drawing.Size(56, 29)
        Me.设置ToolStripMenuItem.Text = "设置"
        '
        '字体ToolStripMenuItem
        '
        Me.字体ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NotoSansToolStripMenuItem, Me.RobotoToolStripMenuItem})
        Me.字体ToolStripMenuItem.Name = "字体ToolStripMenuItem"
        Me.字体ToolStripMenuItem.Size = New System.Drawing.Size(122, 30)
        Me.字体ToolStripMenuItem.Text = "字形"
        '
        'NotoSansToolStripMenuItem
        '
        Me.NotoSansToolStripMenuItem.Name = "NotoSansToolStripMenuItem"
        Me.NotoSansToolStripMenuItem.Size = New System.Drawing.Size(157, 30)
        Me.NotoSansToolStripMenuItem.Text = "NotoSans"
        '
        'RobotoToolStripMenuItem
        '
        Me.RobotoToolStripMenuItem.Name = "RobotoToolStripMenuItem"
        Me.RobotoToolStripMenuItem.Size = New System.Drawing.Size(157, 30)
        Me.RobotoToolStripMenuItem.Text = "Roboto"
        '
        '字号ToolStripMenuItem
        '
        Me.字号ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.增大ToolStripMenuItem, Me.减小ToolStripMenuItem})
        Me.字号ToolStripMenuItem.Name = "字号ToolStripMenuItem"
        Me.字号ToolStripMenuItem.Size = New System.Drawing.Size(122, 30)
        Me.字号ToolStripMenuItem.Text = "字号"
        '
        '增大ToolStripMenuItem
        '
        Me.增大ToolStripMenuItem.Name = "增大ToolStripMenuItem"
        Me.增大ToolStripMenuItem.Size = New System.Drawing.Size(147, 30)
        Me.增大ToolStripMenuItem.Text = "增大(=)"
        '
        '减小ToolStripMenuItem
        '
        Me.减小ToolStripMenuItem.Name = "减小ToolStripMenuItem"
        Me.减小ToolStripMenuItem.Size = New System.Drawing.Size(147, 30)
        Me.减小ToolStripMenuItem.Text = "减小(-)"
        '
        '背景ToolStripMenuItem
        '
        Me.背景ToolStripMenuItem.Name = "背景ToolStripMenuItem"
        Me.背景ToolStripMenuItem.Size = New System.Drawing.Size(122, 30)
        Me.背景ToolStripMenuItem.Text = "背景"
        '
        '帮助ToolStripMenuItem
        '
        Me.帮助ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.查看帮助ToolStripMenuItem, Me.检查更新ToolStripMenuItem, Me.技术支持ToolStripMenuItem, Me.关于ToolStripMenuItem})
        Me.帮助ToolStripMenuItem.Font = New System.Drawing.Font("Noto Sans CJK JP Regular", 10.28571!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem"
        Me.帮助ToolStripMenuItem.Size = New System.Drawing.Size(56, 29)
        Me.帮助ToolStripMenuItem.Text = "帮助"
        '
        '查看帮助ToolStripMenuItem
        '
        Me.查看帮助ToolStripMenuItem.Name = "查看帮助ToolStripMenuItem"
        Me.查看帮助ToolStripMenuItem.Size = New System.Drawing.Size(154, 30)
        Me.查看帮助ToolStripMenuItem.Text = "查看帮助"
        '
        '检查更新ToolStripMenuItem
        '
        Me.检查更新ToolStripMenuItem.Name = "检查更新ToolStripMenuItem"
        Me.检查更新ToolStripMenuItem.Size = New System.Drawing.Size(154, 30)
        Me.检查更新ToolStripMenuItem.Text = "检查更新"
        '
        '技术支持ToolStripMenuItem
        '
        Me.技术支持ToolStripMenuItem.Name = "技术支持ToolStripMenuItem"
        Me.技术支持ToolStripMenuItem.Size = New System.Drawing.Size(154, 30)
        Me.技术支持ToolStripMenuItem.Text = "技术支持"
        '
        '关于ToolStripMenuItem
        '
        Me.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem"
        Me.关于ToolStripMenuItem.Size = New System.Drawing.Size(154, 30)
        Me.关于ToolStripMenuItem.Text = "关于"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Moccasin
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Noto Sans CJK JP Regular", 13.91597!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(0, 39)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(1137, 663)
        Me.TextBox1.TabIndex = 1
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.NavajoWhite
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 34
        Me.ListBox1.Location = New System.Drawing.Point(1, 39)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(226, 650)
        Me.ListBox1.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 34.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1137, 700)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.TextBox1)
        Me.Font = New System.Drawing.Font("Noto Sans CJK JP Regular", 13.91597!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.Name = "Form1"
        Me.Text = "Reader"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents 开始ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 本地ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 打开ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 工具ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 帮助ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 查看帮助ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 检查更新ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 技术支持ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents 设置ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 字体ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 背景ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 隐藏工具栏ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 查找ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 目录ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 上一页ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 下一页ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 全屏ESCToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NotoSansToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RobotoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 字号ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 增大ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 减小ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 打开关闭全屏F6ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 关于ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListBox1 As ListBox
End Class
