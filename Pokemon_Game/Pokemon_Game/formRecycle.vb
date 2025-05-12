Imports MySql.Data.MySqlClient
Imports System.IO

Public Class formRecycle
    Private cardList As New List(Of Dictionary(Of String, String))

    Private Sub formRecycle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUserCards()
        UpdateUserCoins()
    End Sub

    ' Fungsi untuk menukar kartu menjadi coin
    Private Sub RecycleCard(cardID As String, cardName As String, cardPrice As String, jumlahKartu As String)
        Dim recyclePrice As Integer = CInt(cardPrice) / 2

        Dim result = MessageBox.Show("Apakah Anda yakin ingin menukar kartu " & cardName & " menjadi " & recyclePrice & " coin?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            koneksi()
            Try
                ' Jika jumlah kartu hanya 1, hapus kartu tersebut
                If CInt(jumlahKartu) = 1 Then
                    CMD = New MySqlCommand("DELETE FROM user_card WHERE user_id = (SELECT id FROM users WHERE username = @username) AND card_id = @cardID", CONN)
                Else
                    ' Jika lebih dari 1, kurangi jumlah kartu
                    CMD = New MySqlCommand("UPDATE user_card SET jumlah_kartu = jumlah_kartu - 1 WHERE user_id = (SELECT id FROM users WHERE username = @username) AND card_id = @cardID", CONN)
                End If
                CMD.Parameters.AddWithValue("@username", currentUsername)
                CMD.Parameters.AddWithValue("@cardID", cardID)
                CMD.ExecuteNonQuery()

                ' Tambahkan coin ke user
                CMD = New MySqlCommand("UPDATE users SET coin = coin + @recyclePrice WHERE username = @username", CONN)
                CMD.Parameters.AddWithValue("@recyclePrice", recyclePrice)
                CMD.Parameters.AddWithValue("@username", currentUsername)
                CMD.ExecuteNonQuery()

                MessageBox.Show("Kartu berhasil direcycle: " & cardName, "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Update coin display di formHome dan formRecycle
                formHome.UpdateCoinDisplay()
                UpdateUserCoins()
                LoadUserCards()

            Catch ex As Exception
                MessageBox.Show("Gagal melakukan recycle: " & ex.Message)
            Finally
                If CONN.State = ConnectionState.Open Then
                    CONN.Close()
                End If
            End Try
        End If
    End Sub


    Private Sub LoadUserCards()
        pnlCardList.Controls.Clear()
        cardList.Clear()
        koneksi()

        Try
            ' Ambil kartu yang dimiliki user saat ini berdasarkan username
            CMD = New MySqlCommand("
                SELECT c.id, c.name, c.image_path, c.price, uc.jumlah_kartu 
                FROM user_card uc 
                JOIN cards c ON uc.card_id = c.id 
                JOIN users u ON uc.user_id = u.id 
                WHERE u.username = @username", CONN)
            CMD.Parameters.AddWithValue("@username", currentUsername)
            RD = CMD.ExecuteReader()

            ' Simpan data ke dalam list sementara
            While RD.Read()
                Dim cardData As New Dictionary(Of String, String) From {
                    {"id", RD("id").ToString()},
                    {"name", RD("name").ToString()},
                    {"image_path", RD("image_path").ToString()},
                    {"price", RD("price").ToString()},
                    {"jumlah_kartu", RD("jumlah_kartu").ToString()}
                }
                cardList.Add(cardData)
            End While
            RD.Close()

            ' Tampilkan kartu dari list
            For Each card In cardList
                Dim cardPanel As New Panel With {
                    .Size = New Size(150, 280),
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

                ' Hitung harga recycle (50% dari harga beli)
                Dim recyclePrice As Integer = CInt(card("price")) / 2

                Dim lblRecyclePrice As New Label With {
                    .Text = "Recycle: " & recyclePrice & " coins",
                    .Font = New Font("Segoe UI", 9.0F),
                    .ForeColor = Color.DarkGreen,
                    .AutoSize = False,
                    .TextAlign = ContentAlignment.MiddleCenter,
                    .Size = New Size(120, 20),
                    .Location = New Point(15, 145)
                }

                ' Menampilkan jumlah kartu yang dimiliki
                Dim lblJumlah As New Label With {
                    .Text = "Jumlah: " & card("jumlah_kartu"),
                    .Font = New Font("Segoe UI", 9.0F, FontStyle.Italic),
                    .ForeColor = Color.DarkBlue,
                    .AutoSize = False,
                    .TextAlign = ContentAlignment.MiddleCenter,
                    .Size = New Size(120, 20),
                    .Location = New Point(15, 170)
                }

                Dim btnRecycle As New Button With {
                    .Text = "Recycle",
                    .Size = New Size(120, 30),
                    .Location = New Point(15, 210)
                }

                ' Event handler untuk tombol Recycle
                AddHandler btnRecycle.Click, Sub(sender2, e2) RecycleCard(card("id"), card("name"), card("price"), card("jumlah_kartu"))

                cardPanel.Controls.Add(pb)
                cardPanel.Controls.Add(lblName)
                cardPanel.Controls.Add(lblRecyclePrice)
                cardPanel.Controls.Add(lblJumlah)
                cardPanel.Controls.Add(btnRecycle)
                pnlCardList.Controls.Add(cardPanel)
            Next

        Catch ex As Exception
            MessageBox.Show("Gagal memuat kartu: " & ex.Message)
        End Try
    End Sub

    ' Update jumlah koin user
    Private Sub UpdateUserCoins()
        Try
            koneksi()
            CMD = New MySqlCommand("SELECT coin FROM users WHERE username = @username", CONN)
            CMD.Parameters.AddWithValue("@username", currentUsername)
            Dim userCoins As Integer = Convert.ToInt32(CMD.ExecuteScalar())
            lblCoins.Text = "Coins: " & userCoins.ToString()
        Catch ex As Exception
            lblCoins.Text = "Coins: ?"
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class