Imports System

Public Class Form1
    Dim afont As New Read.Menu.Setting.setFont

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "多看阅读，让阅读更快乐!"
        Me.TextBox1.Text = vbCrLf + vbCrLf + "高尔基说过: "" 书籍是人类进步的阶梯 """
        Me.TextBox1.TextAlign = HorizontalAlignment.Center
        Dim titleHeight = Me.Height - Me.ClientSize.Height
        TextBox1.Height = Me.Height - MenuStrip1.Height - titleHeight
        TextBox1.Font = afont.getFonts()
        '隐藏标题栏
        'Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        '最大化
        'Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Form1_Resize() Handles MyBase.Resize
        AdjustTextBox()
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
End Class
