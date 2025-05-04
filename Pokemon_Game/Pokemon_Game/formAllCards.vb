Imports MySql.Data.MySqlClient
Imports System.IO

Public Class formAllCards
    Private Sub formAllCards_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCards()
    End Sub

    Private Sub LoadCards()
        koneksi()
        flowCards.Controls.Clear()

        Try
            CMD = New MySqlCommand("SELECT * FROM cards", CONN)
            RD = CMD.ExecuteReader()

            While RD.Read()
                Dim panelCard As New Panel With {
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

                Dim imagePath = Path.Combine(Application.StartupPath, "Assets", RD("image_path").ToString())
                If File.Exists(imagePath) Then
                    pb.Image = Image.FromFile(imagePath)
                End If

                Dim lblName As New Label With {
                    .Text = RD("name").ToString(),
                    .Font = New Font("Segoe UI", 9, FontStyle.Bold),
                    .TextAlign = ContentAlignment.MiddleCenter,
                    .Location = New Point(10, 120),
                    .Size = New Size(130, 20)
                }

                Dim lblType As New Label With {
                    .Text = "Type: " & RD("type").ToString(),
                    .Font = New Font("Segoe UI", 8),
                    .Location = New Point(10, 145),
                    .Size = New Size(130, 20)
                }

                Dim lblRarity As New Label With {
                    .Text = "Rarity: " & RD("rarity").ToString(),
                    .Font = New Font("Segoe UI", 8),
                    .Location = New Point(10, 170),
                    .Size = New Size(130, 20)
                }

                panelCard.Controls.Add(pb)
                panelCard.Controls.Add(lblName)
                panelCard.Controls.Add(lblType)
                panelCard.Controls.Add(lblRarity)

                flowCards.Controls.Add(panelCard)
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
