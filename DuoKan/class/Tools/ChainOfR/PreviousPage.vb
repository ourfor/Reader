﻿Namespace Read.Menu.tools
    Public Class PreviousPage
        Inherits HandleKey

        Protected Overrides Sub Deal()
            If Menu.Local.OpenFile.getBookPath() = "" Then
                MessageBox.Show("请先打开一本小说")
                Form1.Local_Open_Click(sender, e)
            Else
                Read.Menu.Main.Read.getPreviousContent()
            End If
        End Sub

    End Class
End Namespace
