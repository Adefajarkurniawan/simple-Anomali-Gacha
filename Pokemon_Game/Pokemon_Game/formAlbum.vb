Imports System.IO
Imports MySql.Data.MySqlClient

Public Class formAlbum
    Private Sub formAlbum_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUserCards()
    End Sub

    Private Sub LoadUserCards()
        pnlCardAlbum.Controls.Clear()
        koneksi()

        Try
            ' Menampilkan semua kartu yang dimiliki user saat ini berdasarkan currentUsername
            Dim query As String = "
                SELECT c.name, c.image_path, c.type, c.rarity
                FROM user_card uc
                JOIN users u ON uc.user_id = u.id
                JOIN cards c ON uc.card_id = c.id
                WHERE u.username = @username
                ORDER BY uc.obtained_at DESC
            "

            CMD = New MySqlCommand(query, CONN)
            CMD.Parameters.AddWithValue("@username", currentUsername)
            RD = CMD.ExecuteReader()

            While RD.Read()
                Dim cardPanel As New Panel With {
                    .Size = New Size(150, 220),
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

                Dim imgPath = Path.Combine(Application.StartupPath, "Assets", RD("image_path").ToString())
                If File.Exists(imgPath) Then pb.Image = Image.FromFile(imgPath)

                Dim lblName As New Label With {
                    .Text = RD("name").ToString(),
                    .Font = New Font("Segoe UI", 10.0F, FontStyle.Bold),
                    .ForeColor = Color.DarkBlue,
                    .AutoSize = False,
                    .TextAlign = ContentAlignment.MiddleCenter,
                    .Size = New Size(120, 25),
                    .Location = New Point(15, 115)
                }

                Dim lblType As New Label With {
                    .Text = "Type: " & RD("type").ToString(),
                    .Font = New Font("Segoe UI", 9.0F),
                    .ForeColor = Color.DimGray,
                    .AutoSize = False,
                    .TextAlign = ContentAlignment.MiddleCenter,
                    .Size = New Size(120, 20),
                    .Location = New Point(15, 145)
                }

                Dim lblRarity As New Label With {
                    .Text = "Rarity: " & RD("rarity").ToString(),
                    .Font = New Font("Segoe UI", 9.0F, FontStyle.Italic),
                    .ForeColor = Color.DarkGoldenrod,
                    .AutoSize = False,
                    .TextAlign = ContentAlignment.MiddleCenter,
                    .Size = New Size(120, 20),
                    .Location = New Point(15, 170)
                }

                cardPanel.Controls.Add(pb)
                cardPanel.Controls.Add(lblName)
                cardPanel.Controls.Add(lblType)
                cardPanel.Controls.Add(lblRarity)
                pnlCardAlbum.Controls.Add(cardPanel)
            End While

            RD.Close()
        Catch ex As Exception
            MessageBox.Show("Gagal memuat kartu: " & ex.Message)
        End Try
    End Sub
End Class
