Imports MySql.Data.MySqlClient
Imports MySql.Data

Namespace Read.Database
    Public Class ConnectDB
        Private conn As MySqlConnection
        Private dbName As String = "DynamicWeather"
        Private user As String = "root"
        Private password As String = "2320813747DBmm$$"
        Private connStr As String = "server=db.ourfor.top;userid=root;password=2320813747DBmm$$;database=DynamicWeather"

        Public Sub Start()
            Try
                conn = New MySqlConnection(connStr)
                conn.Open()
                Dim strSQL = "SELECT * FROM Year2019;"

                Dim cmd As MySqlCommand = New MySqlCommand(strSQL, conn)

                Dim ResultSet As MySqlDataReader = cmd.ExecuteReader()
                Dim display As String = ""
                While ResultSet.Read()
                    display += ResultSet(0).ToString() + " "
                    display += ResultSet(1).ToString() + " "
                    display += ResultSet(2).ToString() + vbCrLf
                End While

                MsgBox(display)

                MsgBox("数据库连接成功")
            Catch e As Exception
                MsgBox("数据库连接失败")
            End Try


        End Sub




    End Class
End Namespace
