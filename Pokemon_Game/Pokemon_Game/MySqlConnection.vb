Imports MySql.Data.MySqlClient

Module modKoneksi
    Public CONN As MySqlConnection
    Public CMD As MySqlCommand
    Public RD As MySqlDataReader
    Public DA As MySqlDataAdapter
    Public DS As DataSet
    Public STR As String

    Sub koneksi()
        Try
            STR = "server=localhost;userid=root;password=;database=pokemon_gacha;"
            CONN = New MySqlConnection(STR)
            If CONN.State <> ConnectionState.Open Then
                CONN.Open()
            End If
        Catch ex As Exception
            MessageBox.Show("Koneksi ke database gagal: " & ex.Message)
        End Try
    End Sub
End Module
