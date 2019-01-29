Namespace Read.Menu.tools
    Public Class HiddenMenu
        Inherits HandleKey

        Protected Overrides Sub Deal()
            Form1.MenuStrip1.Visible = Not Form1.MenuStrip1.Visible
            Form1.AdjustTextBox()
        End Sub

    End Class
End Namespace
