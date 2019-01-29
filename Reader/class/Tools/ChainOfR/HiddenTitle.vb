Namespace Read.Menu.tools
    Public Class HiddenTitle
        Inherits HandleKey

        Protected Overrides Sub deal()
            If Form1.FormBorderStyle = System.Windows.
                Forms.FormBorderStyle.None Then
                Form1.FormBorderStyle = System.Windows.
                    Forms.FormBorderStyle.Sizable
            Else
                Form1.FormBorderStyle = System.Windows.
                    Forms.FormBorderStyle.None
                'Form1.WindowState = FormWindowState.Maximized
            End If
        End Sub

    End Class
End Namespace
