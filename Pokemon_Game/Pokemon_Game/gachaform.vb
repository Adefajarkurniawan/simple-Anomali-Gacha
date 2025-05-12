Imports MySql.Data.MySqlClient

Public Class gachaform
    Private Sub LoadEventImages()
        Try
            koneksi()
            Dim cmd As New MySqlCommand("SELECT image_path, nama_event FROM event LIMIT 1", CONN)
            Dim rd As MySqlDataReader = cmd.ExecuteReader()

            If rd.Read() Then
                Dim imgPath As String = rd("image_path").ToString()
                Dim fullPath As String = System.IO.Path.Combine(Application.StartupPath, imgPath)

                If System.IO.File.Exists(fullPath) Then
                    PictureBox1.Image = Image.FromFile(fullPath)
                    PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
                Else
                    MessageBox.Show("Gambar tidak ditemukan di path: " & fullPath)
                End If
            End If

            rd.Close()
        Catch ex As Exception
            MessageBox.Show("Gagal memuat event image: " & ex.Message)
        Finally
            If CONN.State = ConnectionState.Open Then CONN.Close()
        End Try
    End Sub


    Private Sub gachaform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadEventImages()
    End Sub

    Private Sub Gacha10_Click(sender As Object, e As EventArgs) Handles Gacha10.Click
        Try
            koneksi()

            ' Ambil user_id berdasarkan session username
            Dim userId As Integer = -1
            Using cmdUser As New MySqlCommand("SELECT id FROM users WHERE username = @username", CONN)
                cmdUser.Parameters.AddWithValue("@username", modSession.currentUsername)
                Using rdUser As MySqlDataReader = cmdUser.ExecuteReader()
                    If rdUser.Read() Then
                        userId = Convert.ToInt32(rdUser("id"))
                    Else
                        MessageBox.Show("User tidak ditemukan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                End Using
            End Using

            ' Ambil semua kartu
            Dim dt As New DataTable()
            Using cmdCards As New MySqlCommand("SELECT * FROM cards", CONN)
                Dim da As New MySqlDataAdapter(cmdCards)
                da.Fill(dt)
            End Using

            If dt.Rows.Count = 0 Then
                MessageBox.Show("Belum ada data kartu yang tersedia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim hasilGacha As New List(Of DataRow)
            Dim rnd As New Random()

            ' Gacha 5 kali
            For i As Integer = 1 To 5
                Dim chosenCard As DataRow = GetRandomCardByRarity(dt, rnd)
                hasilGacha.Add(chosenCard)

                Dim cardId As Integer = Convert.ToInt32(chosenCard("id"))
                Dim jumlahKartu As Integer = 1

                ' Cek apakah user sudah memiliki kartu tersebut
                Using cmdCheck As New MySqlCommand("SELECT id, Jumlah_Kartu FROM user_card WHERE user_id = @user_id AND card_id = @card_id", CONN)
                    cmdCheck.Parameters.AddWithValue("@user_id", userId)
                    cmdCheck.Parameters.AddWithValue("@card_id", cardId)

                    Using rdCheck As MySqlDataReader = cmdCheck.ExecuteReader()
                        If rdCheck.Read() Then
                            ' Kartu sudah dimiliki, update Jumlah_Kartu
                            Dim existingId As Integer = Convert.ToInt32(rdCheck("id"))
                            Dim existingJumlah As Integer = Convert.ToInt32(rdCheck("Jumlah_Kartu"))
                            jumlahKartu = existingJumlah + 1

                            rdCheck.Close()

                            Using cmdUpdate As New MySqlCommand("UPDATE user_card SET Jumlah_Kartu = @jumlah WHERE id = @id", CONN)
                                cmdUpdate.Parameters.AddWithValue("@jumlah", jumlahKartu)
                                cmdUpdate.Parameters.AddWithValue("@id", existingId)
                                cmdUpdate.ExecuteNonQuery()
                            End Using
                        Else
                            rdCheck.Close()

                            ' Kartu belum dimiliki, insert baru
                            Using cmdInsert As New MySqlCommand("INSERT INTO user_card (user_id, card_id, Jumlah_Kartu) VALUES (@user_id, @card_id, 1)", CONN)
                                cmdInsert.Parameters.AddWithValue("@user_id", userId)
                                cmdInsert.Parameters.AddWithValue("@card_id", cardId)
                                cmdInsert.ExecuteNonQuery()
                            End Using
                        End If
                    End Using
                End Using
            Next

            ' Tampilkan hasil gacha
            Dim tg As New tampilanGacha()
            tg.TampilkanKartu(hasilGacha)
            tg.Show()

        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If CONN.State = ConnectionState.Open Then CONN.Close()
        End Try
    End Sub

    Private Function GetRandomCardByRarity(dt As DataTable, rnd As Random) As DataRow
        If dt.Rows.Count = 0 Then
            Throw New Exception("Tidak ada data kartu untuk digacha.")
        End If

        Dim totalWeight As Integer = dt.AsEnumerable().Sum(Function(r) Convert.ToInt32(r("rarity")))
        If totalWeight <= 0 Then
            Throw New Exception("Total rarity semua kartu adalah 0.")
        End If

        Dim randomValue As Integer = rnd.Next(1, totalWeight + 1)
        Dim cumulative As Integer = 0

        For Each row As DataRow In dt.Rows
            cumulative += Convert.ToInt32(row("rarity"))
            If randomValue <= cumulative Then
                Return row
            End If
        Next

        ' Fallback aman
        Return dt.Rows(0)
    End Function


    Private Sub Gacha1_Click(sender As Object, e As EventArgs) Handles Gacha1.Click
        Try
            koneksi()

            ' Ambil user_id berdasarkan session username
            Dim userId As Integer = -1
            Using cmdUser As New MySqlCommand("SELECT id FROM users WHERE username = @username", CONN)
                cmdUser.Parameters.AddWithValue("@username", modSession.currentUsername)
                Using rdUser As MySqlDataReader = cmdUser.ExecuteReader()
                    If rdUser.Read() Then
                        userId = Convert.ToInt32(rdUser("id"))
                    Else
                        MessageBox.Show("User tidak ditemukan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                End Using
            End Using

            ' Ambil semua kartu
            Dim dt As New DataTable()
            Using cmdCards As New MySqlCommand("SELECT * FROM cards", CONN)
                Dim da As New MySqlDataAdapter(cmdCards)
                da.Fill(dt)
            End Using

            If dt.Rows.Count = 0 Then
                MessageBox.Show("Belum ada data kartu yang tersedia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim rnd As New Random()
            Dim chosenCard As DataRow = GetRandomCardByRarity(dt, rnd)
            Dim cardId As Integer = Convert.ToInt32(chosenCard("id"))
            Dim jumlahKartu As Integer = 1

            ' Cek apakah user sudah memiliki kartu tersebut
            Using cmdCheck As New MySqlCommand("SELECT id, Jumlah_Kartu FROM user_card WHERE user_id = @user_id AND card_id = @card_id", CONN)
                cmdCheck.Parameters.AddWithValue("@user_id", userId)
                cmdCheck.Parameters.AddWithValue("@card_id", cardId)

                Using rdCheck As MySqlDataReader = cmdCheck.ExecuteReader()
                    If rdCheck.Read() Then
                        ' Update kartu yang sudah dimiliki
                        Dim existingId As Integer = Convert.ToInt32(rdCheck("id"))
                        Dim existingJumlah As Integer = Convert.ToInt32(rdCheck("Jumlah_Kartu"))
                        jumlahKartu = existingJumlah + 1
                        rdCheck.Close()

                        Using cmdUpdate As New MySqlCommand("UPDATE user_card SET Jumlah_Kartu = @jumlah WHERE id = @id", CONN)
                            cmdUpdate.Parameters.AddWithValue("@jumlah", jumlahKartu)
                            cmdUpdate.Parameters.AddWithValue("@id", existingId)
                            cmdUpdate.ExecuteNonQuery()
                        End Using
                    Else
                        rdCheck.Close()
                        ' Insert kartu baru
                        Using cmdInsert As New MySqlCommand("INSERT INTO user_card (user_id, card_id, Jumlah_Kartu) VALUES (@user_id, @card_id, 1)", CONN)
                            cmdInsert.Parameters.AddWithValue("@user_id", userId)
                            cmdInsert.Parameters.AddWithValue("@card_id", cardId)
                            cmdInsert.ExecuteNonQuery()
                        End Using
                    End If
                End Using
            End Using

            ' Tampilkan hasil ke form tampilanGacha1
            Dim tg1 As New tampilanGacha1()
            tg1.TampilkanKartu(chosenCard)
            tg1.Show()

        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If CONN.State = ConnectionState.Open Then CONN.Close()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
