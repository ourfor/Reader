Imports System.Xml
Imports System.Text.RegularExpressions


Namespace Read.Menu.Main
    Public Class Chapter
        Private xdoc As XmlDocument = New XmlDocument()
        Private declaration As XmlDeclaration = xdoc.CreateXmlDeclaration("1.0", "UTF-8", "yes")
        Private root As XmlElement = xdoc.CreateElement("book")
        Private reg As Regex
        Private keywords As String

        '无参构造，init
        Public Sub New()
            xdoc.AppendChild(declaration)
            xdoc.AppendChild(root)
        End Sub

        Public Sub WriteXml(ByRef content As String, ByVal line As Integer)
            Dim node As XmlElement = xdoc.CreateElement("chapter")
            node.SetAttribute("title", content)
            root.AppendChild(node)
            Dim child As XmlElement = xdoc.CreateElement("line")
            child.InnerText = line
            node.AppendChild(child)
        End Sub

        Public Sub Save(path As String)
            xdoc.Save(path)
        End Sub

        Public Function IsMatch(ByVal input As String) As Boolean
            Try
                Return reg.IsMatch(input)
            Catch e As Exception
                Return False
            End Try
        End Function

        Public Sub setKeywords(keywords As String)
            Me.keywords = keywords
            reg = New Regex(keywords)
        End Sub

    End Class
End Namespace
