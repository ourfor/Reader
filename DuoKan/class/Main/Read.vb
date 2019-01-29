Imports System.IO
Namespace Read.Menu.Main
    Public Class Read
        ' 属性
        Private Shared Words As String = “”
        Private Shared LineNub As Long = 0
        Private Shared CurrentLine As Long = 0
        Private Shared BookFile As FileStream
        Private Shared BookRead As StreamReader
        Private Shared SaveRead As String()

        '方法
        Public Sub getBookContent(path As String)
            '显示14行小说
            BookFile = New _
            FileStream(path, FileMode.Open, FileAccess.Read)
            BookRead = New _
                    StreamReader(BookFile)
        End Sub

        Public Shared Sub getContent()
            If CurrentLine = LineNub Then
                LineNub += 1
                CurrentLine += 1
                ReDim Preserve SaveRead(LineNub)

                Dim Line(13) As String
                For Index As Integer = 0 To UBound(Line) - 1
                    Line(Index) = BookRead.ReadLine()
                    Line(UBound(Line)) += Line(Index) + vbCrLf
                Next Index
                Form1.TextBox1.Text = Line(UBound(Line))

                SaveRead(LineNub) = Line(UBound(Line))
                'MsgBox(BookFile.Position.ToString)
            Else
                CurrentLine += 1
                Form1.TextBox1.Text = SaveRead(CurrentLine)
            End If

        End Sub

        Public Shared Sub getPreviousContent()
            If CurrentLine >= 1 Then
                CurrentLine -= 1
                Form1.TextBox1.Text = SaveRead(CurrentLine)
                ' MsgBox(BookFile.Position.ToString)
            Else
                Form1.TextBox1.Text = SaveRead(1)
            End If

        End Sub

    End Class
End Namespace
