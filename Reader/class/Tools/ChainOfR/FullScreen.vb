Namespace Read.Menu.tools
    Public Class FullScreen
        Inherits HandleKey

        Protected Overrides Sub Deal()
            If Form1.FormBorderStyle = System.Windows.
                   Forms.FormBorderStyle.None Then
                Form1.FormBorderStyle = System.Windows.
                    Forms.FormBorderStyle.Sizable
                Form1.WindowState = FormWindowState.Normal
            Else
                Form1.FormBorderStyle = System.Windows.
                    Forms.FormBorderStyle.None
                Form1.WindowState = FormWindowState.Maximized
            End If
        End Sub

    End Class
End Namespace
