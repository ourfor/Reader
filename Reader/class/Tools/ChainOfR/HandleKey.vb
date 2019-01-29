Namespace Read.Menu.tools
    Public Class HandleKey
        Protected NextObject As HandleKey
        Protected str As String
        Protected sender As Object = New Object()
        Protected e As EventArgs = New EventArgs()

        Public Sub setStr(ByVal e As String)
            str = e
        End Sub

        Public Sub setNextObject(e As HandleKey)
            NextObject = e
        End Sub

        Public Sub DoWith(key As KeyEventArgs)
            If CanDo(key) Then
                Deal()
            Else
                NextObject.DoWith(key)
            End If
        End Sub

        Protected Overridable Function CanDo(e As KeyEventArgs) As Boolean
            If e.KeyCode.ToString = Me.str Then
                Return True
            Else
                Return False
            End If
        End Function

        Protected Overridable Sub Deal()
        End Sub

    End Class
End Namespace
