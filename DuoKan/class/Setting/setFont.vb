Imports System.Drawing.Text
Imports System.Runtime.InteropServices

Namespace Read.Menu.Setting
    Public Class setFont
        Private f As Font
        '定义字体的属性
        Private fontSource As Byte() = My.Resources.NotoSans
        Private fontlength As Integer = My.Resources.NotoSans.Length
        Private fontSize As Integer = 18


        Public Sub setFontBaseA()
            fontSource = My.Resources.NotoSans
            fontlength = My.Resources.NotoSans.Length
        End Sub

        Public Sub setFontBaseB()
            fontSource = My.Resources.Roboto
            fontlength = My.Resources.Roboto.Length
        End Sub

        Private Sub NewFont()
            Dim g As Graphics = Form1.CreateGraphics ' PictureBox1.CreateGraphics
            Dim fontpath As String =
                ""
            Dim pfonts As PrivateFontCollection = New PrivateFontCollection()  'PrivateFontCollection类
            '该类提供一个字体系列集合，该集合是基于客户端应用程序提供的字体文件生成的。
            pfonts.AddFontFile(fontpath)   '<==重点，添加自己的字体文件

            If pfonts.Families(0).IsStyleAvailable(FontStyle.Regular) Then  '如果该字体支持普通文本字形信息，你也可以换成Bold（粗体）、Italic（斜体）等

                MyClass.f = New Font(pfonts.Families(0), fontSize, FontStyle.Regular)  '定义一个Font实例

                Dim fontname As String = f.Name
                Dim b As SolidBrush = New SolidBrush(Color.Red) '定义一个Brush实例
                g.DrawString(fontname, f, b, 0, 10)  '在窗体表面绘制字符串
            End If

        End Sub

        Private Sub NewFontMe()
            Dim _pfc = New PrivateFontCollection
            Dim fontMemPointer As IntPtr =
        Marshal.AllocCoTaskMem(fontlength)
            Marshal.Copy(fontSource, 0, fontMemPointer, fontlength)
            _pfc.AddMemoryFont(fontMemPointer,
                fontlength)
            Marshal.FreeCoTaskMem(fontMemPointer)
            MyClass.f = New Font(_pfc.Families(0), fontSize, FontStyle.Regular)
        End Sub

        Public Function getFonts() As Font
            NewFontMe()
            Return MyClass.f
        End Function

        Public Sub setFontSize(i As Integer)
            fontSize = i
            getFonts()
        End Sub

        Public Function getFontSize() As Integer
            Return fontSize
        End Function

    End Class
End Namespace
