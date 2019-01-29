Namespace Read.Menu.Local

    Public Class OpenFile
        Private Shared bookpath = ""


        Shared Sub SetConfig()
            Dim OpenDialog As New OpenFileDialog
            For index As Integer = 0 To 1
                OpenDialog.Title = "打开小说"
                OpenDialog.ShowDialog()

                If OpenDialog.FileName = "" Then
                    MsgBox("你什么小说也没选啊！")
                    index -= 1
                Else
                    'MsgBox("确认打开这本小说吗?" + OpenDialog.FileName)
                    bookpath = OpenDialog.FileName
                    index += 1
                End If
            Next index
        End Sub

        Shared Function getBookPath() As String
            Return bookpath
        End Function

    End Class

End Namespace
