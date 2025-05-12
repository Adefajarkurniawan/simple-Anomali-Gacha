Imports MySql.Data.MySqlClient

Public Class formTopup
    Private Sub btnTopup_Click(sender As Object, e As EventArgs) Handles btnTopup.Click
        Dim jumlahCoin As Integer
        If Not Integer.TryParse(txtAmount.Text, jumlahCoin) OrElse jumlahCoin <= 0 Then
            MessageBox.Show("Masukkan jumlah coin yang valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Cek apakah user login sudah menyimpan ID
        If currentUserId <= 0 Then
            MessageBox.Show("User tidak dikenali. Silakan login ulang.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim connStr As String = "server=localhost;user id=root;password=;database=pokemon_gacha"
        Using conn As New MySqlConnection(connStr)
            Try
                conn.Open()

                ' Pastikan user ID ada di database
                Dim checkUser As New MySqlCommand("SELECT COUNT(*) FROM users WHERE id = @user_id", conn)
                checkUser.Parameters.AddWithValue("@user_id", currentUserId)
                Dim userExists As Integer = Convert.ToInt32(checkUser.ExecuteScalar())

                If userExists = 0 Then
                    MessageBox.Show("User tidak ditemukan di database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If

                ' Tambahkan permintaan top-up
                Dim query As String = "INSERT INTO topup_requests (user_id, amount, status) VALUES (@user_id, @amount, 'pending')"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@user_id", currentUserId)
                    cmd.Parameters.AddWithValue("@amount", jumlahCoin)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Permintaan top-up dikirim! Tunggu persetujuan admin.", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtAmount.Text = ""
                End Using

            Catch ex As Exception
                MessageBox.Show("Gagal mengirim permintaan top-up: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
