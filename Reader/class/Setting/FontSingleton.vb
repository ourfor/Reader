Imports System.Drawing.Text
Imports System.Runtime.InteropServices

Namespace Read.Menu.tools
    '自定义字体的单例模式
    Public Class FontSingleton
        Private Sub New()
            Me.Draw()
        End Sub

        Private Ins As FontSingleton
        Private fontSource As Byte() = My.Resources.NotoSans
        Private fontLength As Integer = My.Resources.NotoSans.Length
        Private FontFace As Font
        Private FontSize As Single

        Private Function Draw() As Font
            Dim _pfc = New PrivateFontCollection()
            Dim fontPoint As IntPtr = Marshal.AllocCoTaskMem(fontLength)
            Marshal.Copy(fontSource, 0, fontPoint, fontLength)
            _pfc.AddMemoryFont(fontPoint, fontLength)
            Marshal.FreeCoTaskMem(fontPoint)
            FontFace = New Font(_pfc.Families(0), FontSize, FontStyle.Regular)
            Return FontFace
        End Function

        Public Function getInstance() As FontSingleton
            If Ins Is Nothing Then
                Ins = New FontSingleton
            End If
            Return Ins
        End Function

    End Class
End Namespace
