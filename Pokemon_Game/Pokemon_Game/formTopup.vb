Imports MySql.Data.MySqlClient

Public Class formTopup
    Private Sub formTopup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtAmount.Select()
    End Sub

    Private Sub btnTopup_Click(sender As Object, e As EventArgs) Handles btnTopup.Click
        Dim amountStr As String = txtAmount.Text.Trim()
        If Not IsNumeric(amountStr) OrElse CInt(amountStr) <= 0 Then
            MessageBox.Show("Masukkan jumlah coin yang valid!", "Error")
            Return
        End If

        Try
            koneksi()
            CMD = New MySqlCommand("UPDATE users SET coin = coin + @amount WHERE username = @username", CONN)
            CMD.Parameters.AddWithValue("@amount", CInt(amountStr))
            CMD.Parameters.AddWithValue("@username", currentUsername)
            CMD.ExecuteNonQuery()

            MessageBox.Show("Topup coin berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            formHome.UpdateCoinDisplay()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Gagal topup: " & ex.Message)
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
