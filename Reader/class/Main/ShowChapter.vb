Imports System.Xml
Namespace Read.Menu.Main
    Public Class ShowChapter
        Dim xdoc As XmlDocument = New XmlDocument()
        Dim xmlPath As String = ""
        Dim rootPath As String = ""

        Public Sub showChapter()
            xdoc.Load(xmlPath)
            Dim book As XmlNodeList = xdoc.SelectNodes(rootPath)
            Dim title As String = ""
            For Each index As XmlNode In book
                title = index.Attributes("title").Value()
                Form1.ListBox1.Items.Add(title + "")
            Next
        End Sub

        Public Sub setPath(xmlPath As String, Optional rootpath As String = "book")
            Me.rootPath = rootpath
            Me.xmlPath = xmlPath
        End Sub

    End Class
End Namespace
