Imports System.IO
Imports MySql.Data.MySqlClient

Public Class formHome

    Private Sub LoadEventBanner()
        Try
            koneksi()
            CMD = New MySqlCommand("SELECT * FROM event LIMIT 1", CONN)
            RD = CMD.ExecuteReader()

            If RD.Read() Then
                Dim imgPath As String = Path.Combine(Application.StartupPath, RD("image_path").ToString())

                If IO.File.Exists(imgPath) Then
                    PictureBox1.Image = Image.FromFile(imgPath)
                Else
                    MessageBox.Show("Gambar tidak ditemukan: " & imgPath)
                End If
            End If

            RD.Close()
        Catch ex As Exception
            MessageBox.Show("Gagal memuat event banner: " & ex.Message)
        End Try
    End Sub
    Private Sub formHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCoinIcon()
        'LoadPacksFromDatabase()
        LoadEventBanner()
        UpdateCoinDisplay()
    End Sub

    Private Sub LoadCoinIcon()
        Dim coinPath As String = Path.Combine(Application.StartupPath, "Assets", "coin.png")
        If File.Exists(coinPath) Then
            picCoin.Image = Image.FromFile(coinPath)
        End If
    End Sub

    'Private Sub LoadPacksFromDatabase()
    '    koneksi()
    '    pnlPacksContainer.Controls.Clear()
    '    Try
    '        CMD = New MySqlCommand("SELECT * FROM packs", CONN)
    '        RD = CMD.ExecuteReader()

    '        Dim x = 10, y = 10, count = 0

    '        While RD.Read()
    '            Dim cardPanel As New Panel With {
    '                .Size = New Size(160, 270),
    '                .BackColor = Color.White,
    '                .BorderStyle = BorderStyle.FixedSingle,
    '                .Location = New Point(x, y)
    '            }

    '            Dim pb As New PictureBox With {
    '                .Size = New Size(140, 100),
    '                .Location = New Point(10, 10),
    '                .SizeMode = PictureBoxSizeMode.StretchImage,
    '                .BackColor = Color.LightGray
    '            }

    '            Dim imgPath = Path.Combine(Application.StartupPath, "Assets", RD("image_path").ToString())
    '            If File.Exists(imgPath) Then pb.Image = Image.FromFile(imgPath)

    '            Dim lblTitle As New Label With {
    '                .Text = RD("name").ToString(),
    '                .Font = New Font("Segoe UI", 9.5F, FontStyle.Bold),
    '                .ForeColor = Color.DarkBlue,
    '                .AutoSize = False,
    '                .TextAlign = ContentAlignment.MiddleCenter,
    '                .Size = New Size(140, 20),
    '                .Location = New Point(10, 115)
    '            }

    '            Dim lblDesc As New Label With {
    '                .Text = RD("description").ToString(),
    '                .Font = New Font("Segoe UI", 8.5F),
    '                .ForeColor = Color.Black,
    '                .AutoSize = False,
    '                .TextAlign = ContentAlignment.MiddleCenter,
    '                .Size = New Size(140, 35),
    '                .Location = New Point(10, 140)
    '            }

    '            Dim lblPrice As New Label With {
    '                .Text = $"Price: {RD("price")} 🪙",
    '                .Font = New Font("Segoe UI", 9.0F, FontStyle.Italic),
    '                .ForeColor = Color.DarkGreen,
    '                .AutoSize = False,
    '                .TextAlign = ContentAlignment.MiddleCenter,
    '                .Size = New Size(140, 20),
    '                .Location = New Point(10, 175)
    '            }

    '            Dim btnBuy As New Button With {
    '                .Text = "Buy Pack",
    '                .Size = New Size(140, 35),
    '                .Location = New Point(10, 210),
    '                .BackColor = Color.Gold,
    '                .FlatStyle = FlatStyle.Flat,
    '                .Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
    '            }

    '            Dim packName = RD("name").ToString()
    '            Dim packPrice = RD("price").ToString()

    '            AddHandler btnBuy.Click, Sub()
    '                                         MessageBox.Show($"Buying {packName} for {packPrice} coins!", "Buy Pack")
    '                                     End Sub

    '            cardPanel.Controls.Add(pb)
    '            cardPanel.Controls.Add(lblTitle)
    '            cardPanel.Controls.Add(lblDesc)
    '            cardPanel.Controls.Add(lblPrice)
    '            cardPanel.Controls.Add(btnBuy)
    '            pnlPacksContainer.Controls.Add(cardPanel)

    '            x += 180 : count += 1
    '            If count Mod 6 = 0 Then x = 10 : y += 290
    '        End While
    '        RD.Close()

    '    Catch ex As Exception
    '        MessageBox.Show("Gagal load pack: " & ex.Message)
    '    End Try
    'End Sub

    Public Sub UpdateCoinDisplay()
        Try
            koneksi()
            CMD = New MySqlCommand("SELECT coin FROM users WHERE username = @username", CONN)
            CMD.Parameters.AddWithValue("@username", currentUsername)
            Dim coin As Object = CMD.ExecuteScalar()
            lblCoins.Text = "Coins: " & coin.ToString()
        Catch
            lblCoins.Text = "Coins: ?"
        End Try
    End Sub


    Private Sub btnTopup_Click(sender As Object, e As EventArgs) Handles btnTopup.Click
        formTopup.ShowDialog()
    End Sub

    Private Sub btnAllCards_Click(sender As Object, e As EventArgs) Handles btnAllCards.Click
        formAllCards.Show()
    End Sub

    Private Sub btnMyAlbum_Click(sender As Object, e As EventArgs) Handles btnMyAlbum.Click
        formAlbum.Show()
    End Sub




    Private Sub btnGacha_Click_1(sender As Object, e As EventArgs) Handles btnGacha.Click
        gachaform.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        formLogin.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnClosed.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        formBeliKartu.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        formRecycle.Show()
    End Sub
End Class
