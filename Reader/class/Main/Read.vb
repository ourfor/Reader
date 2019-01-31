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
        Private Shared Chapter As Chapter = New Chapter()
        Private Shared xmlPath As String = "C:\Users\Sagit\Documents\VS_Code\XML\noval.xml"


        '方法
        Public Sub getBookContent(path As String)
            '显示14行小说
            BookFile = New _
            FileStream(path, FileMode.Open, FileAccess.Read)
            BookRead = New _
                    StreamReader(BookFile)
        End Sub

        Public Shared Sub getContent()
            If CurrentLine < UBound(SaveRead) Then
                CurrentLine += 1
                Form1.TextBox1.Text = SaveRead(CurrentLine)
            Else
                Form1.TextBox1.TextAlign = HorizontalAlignment.Center
                Form1.TextBox1.Text = "小说读完了，换一本吧"
            End If
        End Sub

        Public Shared Sub getPreviousContent()
            If CurrentLine >= 2 Then
                CurrentLine -= 1
                Form1.TextBox1.Text = SaveRead(CurrentLine)
            Else
                Form1.TextBox1.Text = SaveRead(1)
            End If
        End Sub

        Public Shared Sub Book2Array()
            Dim indexA As Integer = 1
            Dim lineNum As Integer = 1
            Chapter.setKeywords("^第.{1,9}章")
            While BookRead.EndOfStream <> True
                ReDim Preserve SaveRead(indexA)
                Dim Line(13) As String
                For Index As Integer = 0 To UBound(Line) - 1
                    lineNum += 1
                    Line(Index) = BookRead.ReadLine() + ""
                    If Chapter.IsMatch(Line(Index)) Then
                        Chapter.WriteXml(Line(Index), indexA)
                    End If
                    Line(UBound(Line)) += Line(Index) + vbCrLf
                Next Index
                SaveRead(indexA) = Line(UBound(Line))
                indexA += 1
            End While
            Chapter.Save(xmlPath)
        End Sub

        Public Shared Function getXMLPath() As String
            Return xmlPath
        End Function

        Public Shared Sub GoToSelectLine(line As Long)
            CurrentLine = line - 1
            getContent()
        End Sub

        Public Shared Function getCurrentLine()
            Return CurrentLine
        End Function

    End Class
End Namespace
