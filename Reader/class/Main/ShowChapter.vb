Imports System.Xml
Namespace Read.Menu.Main
    Public Class item
        Private text As String = ""
        Private value As String = ""

        Sub New(text As String, line As String)
            Me.text = text
            Me.value = line
        End Sub

        Public ReadOnly Property MyText
            Get
                Return Me.text
            End Get
        End Property
        Public ReadOnly Property MyValue
            Get
                Return Me.value
            End Get
        End Property

    End Class
    Public Class ShowChapter
            Dim xdoc As XmlDocument = New XmlDocument()
            Dim xmlPath As String = ""
            Dim rootPath As String = ""

            Public Sub showChapter()
            xdoc.Load(xmlPath)
            Dim root As XmlElement = xdoc.DocumentElement()
            Dim book As XmlNodeList = root.ChildNodes
            Dim Myitems = New ArrayList()

            For Each index As XmlNode In book
                Dim text = index.Attributes("title").Value
                Dim value = index.Item("line").InnerText
                Dim obj = New item(text, value)
                Myitems.Add(obj)
                'MsgBox(title)
            Next
            Form1.ListBox1.DataSource = Myitems
        End Sub

        Public Sub setPath(xmlPath As String, Optional rootpath As String = "/book")
                Me.rootPath = rootpath
                Me.xmlPath = xmlPath
            End Sub

        End Class
End Namespace
