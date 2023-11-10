Imports MySql.Data.MySqlClient
Module Database
    Dim connectionString As String = "datasource=localhost;port=3306;user=root;password=;database=administratordb"
    Dim mysqlConnect As New MySqlConnection
    Public Sub connect()
        Try
            mysqlConnect.ConnectionString = connectionString
            mysqlConnect.Open()
        Catch ex As Exception
            MessageBox.Show("An error occured while connecting to Database", "Connection Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            mysqlConnect.Close()
        End Try
    End Sub
End Module
