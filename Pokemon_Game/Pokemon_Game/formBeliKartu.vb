Imports MySql.Data.MySqlClient
Imports System.IO

Public Class formBeliKartu
    Private cardList As New List(Of Dictionary(Of String, String))

    Private Sub formBeliKartu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAvailableCards()
        UpdateUserCoins()
    End Sub

    ' Load kartu yang tersedia dari database
    Private Sub LoadAvailableCards()
        pnlAvailableCards.Controls.Clear()
        cardList.Clear()
        koneksi()

        Try
            CMD = New MySqlCommand("SELECT * FROM cards", CONN)
            RD = CMD.ExecuteReader()

            ' Simpan data ke dalam list sementara
            While RD.Read()
                Dim cardData As New Dictionary(Of String, String) From {
                    {"id", RD("id").ToString()},
                    {"name", RD("name").ToString()},
                    {"image_path", RD("image_path").ToString()},
                    {"price", RD("price").ToString()}
                }
                cardList.Add(cardData)
            End While
            RD.Close()

            ' Tampilkan kartu dari list
            For Each card In cardList
                Dim cardPanel As New Panel With {
                    .Size = New Size(150, 240),
                    .BackColor = Color.WhiteSmoke,
                    .Margin = New Padding(10),
                    .BorderStyle = BorderStyle.FixedSingle
                }

                Dim pb As New PictureBox With {
                    .Size = New Size(120, 100),
                    .Location = New Point(15, 10),
                    .SizeMode = PictureBoxSizeMode.StretchImage,
                    .BackColor = Color.Gainsboro
                }

                Dim imgPath = Path.Combine(Application.StartupPath, card("image_path"))
                If File.Exists(imgPath) Then
                    pb.Image = Image.FromFile(imgPath)
                End If

                Dim lblName As New Label With {
                    .Text = card("name"),
                    .Font = New Font("Segoe UI", 10.0F, FontStyle.Bold),
                    .AutoSize = False,
                    .TextAlign = ContentAlignment.MiddleCenter,
                    .Size = New Size(120, 20),
                    .Location = New Point(15, 120)
                }

                Dim lblPrice As New Label With {
                    .Text = "Harga: " & card("price") & " coins",
                    .Font = New Font("Segoe UI", 9.0F),
                    .AutoSize = False,
                    .TextAlign = ContentAlignment.MiddleCenter,
                    .Size = New Size(120, 20),
                    .Location = New Point(15, 145)
                }

                Dim btnBuy As New Button With {
                    .Text = "Beli",
                    .Size = New Size(120, 30),
                    .Location = New Point(15, 180)
                }

                ' Menambahkan event handler untuk tombol Beli
                AddHandler btnBuy.Click, Sub(sender2, e2) BuyCard(card("id"), card("name"), card("price"))

                cardPanel.Controls.Add(pb)
                cardPanel.Controls.Add(lblName)
                cardPanel.Controls.Add(lblPrice)
                cardPanel.Controls.Add(btnBuy)
                pnlAvailableCards.Controls.Add(cardPanel)
            Next

        Catch ex As Exception
            MessageBox.Show("Gagal memuat kartu: " & ex.Message)
        End Try
    End Sub

    ' Fungsi untuk membeli kartu
    Private Sub BuyCard(cardID As String, cardName As String, cardPrice As String)
        koneksi()

        Try
            ' Cek jumlah koin user
            CMD = New MySqlCommand("SELECT coin FROM users WHERE username = @username", CONN)
            CMD.Parameters.AddWithValue("@username", currentUsername)
            Dim userCoins As Integer = Convert.ToInt32(CMD.ExecuteScalar())

            If userCoins >= Convert.ToInt32(cardPrice) Then
                ' Kurangi koin user
                CMD = New MySqlCommand("UPDATE users SET coin = coin - @price WHERE username = @username", CONN)
                CMD.Parameters.AddWithValue("@price", cardPrice)
                CMD.Parameters.AddWithValue("@username", currentUsername)
                CMD.ExecuteNonQuery()

                ' Cek apakah user sudah memiliki kartu tersebut
                CMD = New MySqlCommand("SELECT COUNT(*) FROM user_card WHERE user_id = (SELECT id FROM users WHERE username = @username) AND card_id = @cardID", CONN)
                CMD.Parameters.AddWithValue("@username", currentUsername)
                CMD.Parameters.AddWithValue("@cardID", cardID)
                Dim cardExists As Integer = Convert.ToInt32(CMD.ExecuteScalar())

                If cardExists > 0 Then
                    ' Jika sudah ada, tambahkan jumlah kartu
                    CMD = New MySqlCommand("UPDATE user_card SET jumlah_kartu = jumlah_kartu + 1 WHERE user_id = (SELECT id FROM users WHERE username = @username) AND card_id = @cardID", CONN)
                Else
                    ' Jika belum ada, tambahkan kartu baru
                    CMD = New MySqlCommand("INSERT INTO user_card (user_id, card_id, jumlah_kartu) VALUES ((SELECT id FROM users WHERE username = @username), @cardID, 1)", CONN)
                End If

                CMD.Parameters.AddWithValue("@username", currentUsername)
                CMD.Parameters.AddWithValue("@cardID", cardID)
                CMD.ExecuteNonQuery()

                ' Update coin display di formHome
                formHome.UpdateCoinDisplay()

                MessageBox.Show("Berhasil membeli kartu: " & cardName, "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                UpdateUserCoins()
            Else
                MessageBox.Show("Koin tidak cukup!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show("Gagal membeli kartu: " & ex.Message)
        Finally
            If CONN.State = ConnectionState.Open Then
                CONN.Close()
            End If
        End Try
    End Sub


    ' Update jumlah koin user
    Private Sub UpdateUserCoins()
        koneksi()
        Try
            CMD = New MySqlCommand("SELECT coin FROM users WHERE username = @username", CONN)
            CMD.Parameters.AddWithValue("@username", currentUsername)
            Dim userCoins As Integer = Convert.ToInt32(CMD.ExecuteScalar())
            lblCoins.Text = "Coins: " & userCoins.ToString()
        Catch ex As Exception
            MessageBox.Show("Gagal memuat koin: " & ex.Message)
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
