Module mod_conn
    Public rec As New ADODB.Recordset
    Public con As New ADODB.Connection
    Sub connect_database()
        Try
            con = New ADODB.Connection
            ''con.ConnectionString = "Driver={MYSQL ODBC 5.1 Driver}; server=192.168.0.109; port=8457;uid=jhong; pwd=test; database=db_sorting_machine"
            con.ConnectionString = "Driver={MYSQL ODBC 5.1 Driver}; server=localhost;uid=root; database=db_test"

            con.Open()
        Catch ex As Exception
            Try
                con = New ADODB.Connection
                con.ConnectionString = "Driver={MYSQL ODBC 3.51 Driver}; server=192.168.0.109; port=8457;uid=jhong; pwd=test; database=db_sorting_machine"
                con.Open()
                MsgBox("qwe")
            Catch exq As Exception
                MsgBox("Database not found")
            End Try

        End Try
    End Sub

End Module
