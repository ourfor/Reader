Namespace Read.Menu.tools
    Public Class KeyPress
        'Private Shared sender As Object
        'Private Shared e As EventArgs
        Public Shared Sub Key(ByVal e As _
                              System.Windows.Forms.KeyEventArgs)
            'MsgBox("" + e.KeyCode.ToString())

            Dim FontSizeAdd As HandleKey = New FontSizeAdd()
            Dim FontSizeReduce As HandleKey = New FontSizeReduce()
            Dim FullScreen As HandleKey = New FullScreen()
            Dim HiddenMenu As HandleKey = New HiddenMenu()
            Dim HiddenTitle As HandleKey = New HiddenTitle()
            Dim NextPage As HandleKey = New NextPage()
            Dim PreviousPage As HandleKey = New PreviousPage()
            Dim LastObject As HandleKey = New DoNothing()

            ' 确定组织关系
            FontSizeAdd.setNextObject(FontSizeReduce)
            FontSizeReduce.setNextObject(NextPage)
            NextPage.setNextObject(PreviousPage)
            PreviousPage.setNextObject(HiddenMenu)
            HiddenMenu.setNextObject(HiddenTitle)
            HiddenTitle.setNextObject(FullScreen)
            FullScreen.setNextObject(LastObject)

            '设定判断值
            FontSizeAdd.setStr("Oemplus")
            FontSizeReduce.setStr("OemMinus")
            FullScreen.setStr("F6")
            HiddenTitle.setStr("F5")
            HiddenMenu.setStr("F4")
            NextPage.setStr("Oem6")
            PreviousPage.setStr("OemOpenBrackets")

            '开始处理
            FontSizeAdd.DoWith(e)

        End Sub
    End Class
End Namespace
