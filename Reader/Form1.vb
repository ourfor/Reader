Imports System

Public Class Form1
    Dim afont As New Read.Menu.Setting.setFont
    Dim bfont As New Read.Menu.Setting.setFont(10.285714)
    Public Shared ReadData As String = ""

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "多看阅读，让阅读更快乐!"
        Me.TextBox1.Text = vbCrLf + vbCrLf + "高尔基说过: "" 书籍是人类进步的阶梯 """
        Me.TextBox1.TextAlign = HorizontalAlignment.Center
        Me.Height = 900
        Me.Width = 1336
        Dim titleHeight = Me.Height - Me.ClientSize.Height
        TextBox1.Height = Me.Height - MenuStrip1.Height - titleHeight
        TextBox1.Font = afont.getFonts()
        '隐藏标题栏
        'Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        '最大化
        'Me.WindowState = FormWindowState.Maximized
        ListBox1.Visible = False
        ListBox1.Font = bfont.getFonts
        TextBox1.Select(0, 0)
        Dim UserName = System.Environment.UserName
        If Not My.Computer.FileSystem.DirectoryExists("C:\Users\" + UserName + "\.ReadData") Then
            My.Computer.FileSystem.CreateDirectory("C:\Users\" + UserName + "\.ReadData")
        End If
        ReadData = "C:\Users\" + UserName + "\.ReadData\"
        ReadData += "noval.xml"
        Read.Menu.Main.Read.setXmlPath(ReadData)
    End Sub

    Private Sub Form1_Resize() Handles MyBase.Resize
        AdjustTextBox()
        ListBox1.Height = TextBox1.Height
        ListBox1.Width = Me.Width / 3
    End Sub


    Sub Main()
        Dim help As New Read.Menu.Help
    End Sub

    Private Sub Help_CheckUpdate_Click(sender As Object, e As EventArgs) Handles 检查更新ToolStripMenuItem.Click
        MessageBox.Show("正在检查更新")
        'My.Computer.Network.DownloadFile("https://file.ourfor.top/youtube/Army1.mp4", "C:\Users\Sagit\Downloads\army.mp4")

    End Sub

    Private Sub Help_Support_Click(sender As Object, e As EventArgs) Handles 技术支持ToolStripMenuItem.Click
        Process.Start("https://ourfor.top")
    End Sub



    Public Sub Local_Open_Click(sender As Object, e As EventArgs) Handles 打开ToolStripMenuItem.Click
        Dim Newbook As New Read.Menu.Local.OpenFile
        Dim Text As Read.Menu.Main.Read = New _
            Read.Menu.Main.Read()
        Dim bookPath As String = ""

        Read.Menu.Local.OpenFile.SetConfig()
        bookPath = Read.Menu.Local.OpenFile.getBookPath()
        Me.TextBox1.TextAlign = HorizontalAlignment.Left
        Text.getBookContent(bookPath)
        Read.Menu.Main.Read.Book2Array()
        Read.Menu.Main.Read.getContent()
    End Sub

    Private Sub Tools_HiddenToolBar_Click(sender As Object, e As EventArgs) Handles 隐藏工具栏ToolStripMenuItem.Click
        Me.MenuStrip1.Visible = False
        TextBox1.Height = TextBox1.Height + MenuStrip1.Height
        TextBox1.Location = New Point(0.0)
    End Sub

    ' 处理快捷键
    Private Sub Form1_KeyDown(ByVal sender As System.Object,
                              ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Read.Menu.tools.KeyPress.Key(e)
    End Sub

    ' 翻页，上一页，下一页
    Private Sub PreviousPage_Click(sender As Object, e As EventArgs) Handles 上一页ToolStripMenuItem.Click
        '模拟按键
        Dim keydown = New KeyEventArgs(Keys.OemOpenBrackets)
        Read.Menu.tools.KeyPress.Key(KeyDown)
        'MsgBox(KeyDown.KeyCode.ToString())
    End Sub

    Private Sub NextPage_Click(sender As Object, e As EventArgs) Handles 下一页ToolStripMenuItem.Click
        Dim keydown = New KeyEventArgs(Keys.Oem6)
        Read.Menu.tools.KeyPress.Key(keydown)
    End Sub

    ' 调整窗体大小
    Public Sub AdjustTextBox()
        TextBox1.Width = Me.ClientSize.Width
        Dim titleHeight = Me.Height - Me.ClientSize.Height
        'TextBox1.Height = Me.Height - MenuStrip1.Height
        If MenuStrip1.Visible = False Then
            TextBox1.Height = Me.Height - titleHeight
            TextBox1.Location = New Point(0, 0)
        Else
            TextBox1.Height = Me.Height - MenuStrip1.Height - titleHeight
            TextBox1.Location = New Point(0, MenuStrip1.Height)
        End If
    End Sub

    Public Sub AdjustTextBox2()
        TextBox1.Width = Me.Width
        AdjustTextBox()
    End Sub

    ' 更改字体
    Private Sub NotoSansToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NotoSansToolStripMenuItem.Click
        afont.setFontBaseA()
        TextBox1.Font = afont.getFonts()
    End Sub

    Private Sub RobotoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RobotoToolStripMenuItem.Click
        afont.setFontBaseB()
        TextBox1.Font = afont.getFonts()
    End Sub

    Public Sub FontSizeAdd_Click(sender As Object, e As EventArgs) Handles 增大ToolStripMenuItem.Click
        If afont.getFontSize() < 50 Then
            afont.setFontSize(afont.getFontSize() + 1)
            TextBox1.Font = afont.getFonts()
        End If
    End Sub

    Public Sub FontSizeReduce_Click(sender As Object, e As EventArgs) Handles 减小ToolStripMenuItem.Click
        If afont.getFontSize() > 10 Then
            afont.setFontSize(afont.getFontSize() - 1)
            TextBox1.Font = afont.getFonts()
        End If
    End Sub

    Private Sub HiddenTitle_Click(sender As Object, e As EventArgs) Handles 全屏ESCToolStripMenuItem.Click
        Dim keydown = New KeyEventArgs(Keys.F5)
        Read.Menu.tools.KeyPress.Key(keydown)
    End Sub

    Private Sub NeedHelp_Click(sender As Object, e As EventArgs) Handles 查看帮助ToolStripMenuItem.Click
        MessageBox.Show("软件的使用方法可以看看菜单的快捷键")
    End Sub

    Private Sub About_Click(sender As Object, e As EventArgs) Handles 关于ToolStripMenuItem.Click
        MessageBox.Show("Version=1.0" + vbCrLf + "开发者:ourfor")
    End Sub

    Private Sub ShowChapter_Click(sender As Object, e As EventArgs) Handles 目录ToolStripMenuItem.Click
        'ListBox1.ClearSelected() 
        If Read.Menu.Local.OpenFile.getBookPath = "" Then
            Dim keydown = New KeyEventArgs(Keys.Oem6)
            Read.Menu.tools.KeyPress.Key(keydown)
        End If
        ListBox1.Visible = Not ListBox1.Visible
        ListBox1.Height = TextBox1.Height
        ListBox1.Width = 240
        If ListBox1.Visible Then

            Dim showLB = New Read.Menu.Main.ShowChapter()
                showLB.setPath(ReadData)
            ListBox1.DisplayMember = "MyText"
            ListBox1.ValueMember = "MyValue"
            showLB.showChapter()
            TextBox1.Location = New Point(ListBox1.Width, MenuStrip1.Height)
        End If
        'ListBox1.SelectedIndex = Read.Menu.Main.Read.getCurrentLine
        If Not ListBox1.Visible Then
            AdjustTextBox2()
        End If
        TextBox1.Select(0, 0)
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        'MessageBox.Show(ListBox1.SelectedValue.ToString)
        Dim line As Long = CType(ListBox1.SelectedValue.ToString(), Long)
        'MessageBox.Show(line.ToString())
        TextBox1.Width = Me.Width - ListBox1.Width
        TextBox1.Location = New Point(ListBox1.Width, MenuStrip1.Height)

        Read.Menu.Main.Read.GoToSelectLine(line)
    End Sub

    Private Sub GoToLine_Click(sender As Object, e As EventArgs) Handles 查找ToolStripMenuItem.Click
        Dim line As Integer
        line = InputBox("输入你要跳转的行:")
        Read.Menu.Main.Read.GoToSelectLine(line)

    End Sub

    Private Sub FullScreen_Click(sender As Object, e As EventArgs) Handles 打开关闭全屏F6ToolStripMenuItem.Click
        Dim keydown = New KeyEventArgs(Keys.F6)
        Read.Menu.tools.KeyPress.Key(keydown)
    End Sub
End Class
