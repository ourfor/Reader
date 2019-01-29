Namespace Read.Menu.tools
    Public Class DoNothing
        Inherits HandleKey

        Protected Overrides Sub Deal()
            MyBase.Deal()
        End Sub

        Protected Overrides Function CanDo(e As KeyEventArgs) As Boolean
            Return True
        End Function

    End Class
End Namespace
