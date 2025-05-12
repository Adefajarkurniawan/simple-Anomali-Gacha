Imports MySql.Data.MySqlClient
Imports System.IO

Public Class formAllCards
    Private Sub formAllCards_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCards()
    End Sub

    Private Sub LoadCards()
        pnlCardList.Controls.Clear()
        koneksi()

        Try
            CMD = New MySqlCommand("SELECT * FROM cards", CONN)
            RD = CMD.ExecuteReader()

            While RD.Read()
                Dim cardPanel As New Panel With {
                    .Size = New Size(150, 240),
                    .BackColor = Color.WhiteSmoke,
                    .BorderStyle = BorderStyle.FixedSingle,
                    .Margin = New Padding(10)
                }

                Dim pb As New PictureBox With {
                    .Size = New Size(130, 100),
                    .Location = New Point(10, 10),
                    .SizeMode = PictureBoxSizeMode.StretchImage
                }

                ' Mengambil path gambar sesuai struktur penyimpanan
                Dim imagePath = Path.Combine(Application.StartupPath, RD("image_path").ToString())
                If File.Exists(imagePath) Then
                    pb.Image = Image.FromFile(imagePath)
                End If

                Dim lblName As New Label With {
                    .Text = RD("name").ToString(),
                    .Font = New Font("Segoe UI", 10, FontStyle.Bold),
                    .TextAlign = ContentAlignment.MiddleCenter,
                    .Location = New Point(10, 120),
                    .Size = New Size(130, 20)
                }

                Dim lblType As New Label With {
                    .Text = "Type: " & RD("type").ToString(),
                    .Font = New Font("Segoe UI", 9),
                    .Location = New Point(10, 145),
                    .Size = New Size(130, 20)
                }

                Dim kategori As String = If(IsDBNull(RD("kategori")), "Tidak Ada", RD("kategori").ToString())
                Dim lblKategori As New Label With {
                    .Text = "Kategori: " & kategori,
                    .Font = New Font("Segoe UI", 9),
                    .Location = New Point(10, 170),
                    .Size = New Size(130, 20)
                }

                cardPanel.Controls.Add(pb)
                cardPanel.Controls.Add(lblName)
                cardPanel.Controls.Add(lblType)
                cardPanel.Controls.Add(lblKategori)

                pnlCardList.Controls.Add(cardPanel)
            End While
            RD.Close()

        Catch ex As Exception
            MessageBox.Show("Gagal memuat kartu: " & ex.Message)
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
