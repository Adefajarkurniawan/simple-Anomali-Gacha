Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing
Imports System.IO

Public Class formAlbum
    Dim currentIndex As Integer = 0

    Private Sub formAlbum_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUserCards()
    End Sub

    Private Sub LoadUserCards()
        pnlCardAlbum.Controls.Clear()
        koneksi()

        Try
            ' Query untuk mengambil kartu milik user berdasarkan username saat ini
            Dim query As String = "
            SELECT c.name, c.image_path, c.type, c.kategori, uc.Jumlah_Kartu
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

                ' Perbaikan path gambar sesuai struktur penyimpanan di form tambahKartu.vb
                Dim imgPath = Path.Combine(Application.StartupPath, RD("image_path").ToString())
                If File.Exists(imgPath) Then
                    pb.Image = Image.FromFile(imgPath)
                End If

                Dim lblName As New Label With {
                    .Text = RD("name").ToString(),
                    .Font = New Font("Segoe UI", 10.0F, FontStyle.Bold),
                    .ForeColor = Color.DarkBlue,
                    .AutoSize = False,
                    .TextAlign = ContentAlignment.MiddleCenter,
                    .Size = New Size(120, 25),
                    .Location = New Point(15, 115)
                }

                Dim lblJumlah As New Label With {
                    .Text = "Jumlah: " & RD("Jumlah_Kartu").ToString(),
                    .Font = New Font("Segoe UI", 9.0F, FontStyle.Italic),
                    .ForeColor = Color.DarkGreen,
                    .AutoSize = False,
                    .TextAlign = ContentAlignment.MiddleCenter,
                    .Size = New Size(120, 20),
                    .Location = New Point(15, 195)
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

                ' Menambahkan label untuk kategori
                Dim lblKategori As New Label With {
                    .Text = "Kategori: " & RD("kategori").ToString(),
                    .Font = New Font("Segoe UI", 9.0F),
                    .ForeColor = Color.DarkRed,
                    .AutoSize = False,
                    .TextAlign = ContentAlignment.MiddleCenter,
                    .Size = New Size(120, 20),
                    .Location = New Point(15, 170)
                }



                cardPanel.Controls.Add(pb)
                cardPanel.Controls.Add(lblName)
                cardPanel.Controls.Add(lblKategori)
                cardPanel.Controls.Add(lblType)
                cardPanel.Controls.Add(lblJumlah)
                pnlCardAlbum.Controls.Add(cardPanel)
            End While

            RD.Close()
        Catch ex As Exception
            MessageBox.Show("Gagal memuat kartu: " & ex.Message)
        Finally
            If CONN.State = ConnectionState.Open Then
                CONN.Close()
            End If
        End Try
    End Sub

    ' Print Kartu
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    ' PrintDocument1 PrintPage Event
    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim Fheader As New Font("Arial", 22, FontStyle.Bold)
        Dim FsubHeader As New Font("Arial", 14, FontStyle.Italic)
        Dim Fbody As New Font("Arial", 12)
        Dim Flabel As New Font("Arial", 10, FontStyle.Bold)
        Dim Fdetail As New Font("Arial", 10)
        Dim y As Integer = 50
        Dim x As Integer = 50
        Dim cardsPerPage As Integer = 7  ' Jumlah kartu per halaman
        Dim cardsPrinted As Integer = 0  ' Kartu yang sudah dicetak pada halaman ini

        ' Header
        e.Graphics.DrawString("Daftar Kartu Pokémon " & currentUsername, Fheader, Brushes.Black, x, y)
        y += 40
        e.Graphics.DrawLine(New Pen(Color.Black, 2), x, y, e.PageBounds.Width - 50, y)
        y += 20

        koneksi()
        CMD = New MySqlCommand("SELECT c.name, c.type, c.kategori, uc.jumlah_kartu, c.image_path FROM user_card uc JOIN cards c ON uc.card_id = c.id WHERE uc.user_id = (SELECT id FROM users WHERE username = @username)", CONN)
        CMD.Parameters.AddWithValue("@username", currentUsername)
        RD = CMD.ExecuteReader()

        ' Abaikan kartu yang sudah dicetak pada halaman sebelumnya
        For i As Integer = 0 To currentIndex - 1
            If Not RD.Read() Then Exit For
        Next

        While RD.Read()
            ' Cek apakah jumlah kartu yang dicetak sudah mencapai batas per halaman
            If cardsPrinted >= cardsPerPage Then
                e.HasMorePages = True
                currentIndex += cardsPrinted  ' Menambah indeks berdasarkan jumlah kartu yang dicetak
                RD.Close()
                Return
            End If

            ' Kotak kartu
            e.Graphics.FillRectangle(Brushes.LightGray, x, y, 400, 130)
            e.Graphics.DrawRectangle(Pens.Black, x, y, 400, 130)

            ' Mengambil informasi kartu
            Dim cardName As String = RD("name").ToString()
            Dim cardType As String = RD("type").ToString()
            Dim cardRarity As String = RD("kategori").ToString()
            Dim cardJumlah As String = RD("jumlah_kartu").ToString()
            Dim imgPath = Path.Combine(Application.StartupPath, RD("image_path").ToString())

            ' Menampilkan gambar kartu
            Try
                If File.Exists(imgPath) Then
                    Using cardImage As Image = Image.FromFile(imgPath)
                        e.Graphics.DrawImage(cardImage, New Rectangle(x + 10, y + 10, 100, 100))
                    End Using
                Else
                    e.Graphics.DrawString("Gambar tidak ditemukan", Fbody, Brushes.Red, x + 10, y + 40)
                End If
            Catch ex As Exception
                e.Graphics.DrawString("Error saat memuat gambar", Fbody, Brushes.Red, x + 10, y + 40)
            End Try

            ' Menampilkan informasi kartu
            e.Graphics.DrawString("Nama: " & cardName, Flabel, Brushes.Black, x + 120, y + 10)
            e.Graphics.DrawString("Tipe: " & cardType, Flabel, Brushes.Black, x + 120, y + 35)
            e.Graphics.DrawString("Kategori: " & cardRarity, Flabel, Brushes.Black, x + 120, y + 60)
            e.Graphics.DrawString("Jumlah: " & cardJumlah, Flabel, Brushes.Black, x + 120, y + 85)

            ' Menambahkan border dan jarak antar kartu
            y += 140
            cardsPrinted += 1  ' Menambah jumlah kartu yang dicetak
        End While

        RD.Close()

        ' Jika tidak ada lagi halaman berikutnya
        e.HasMorePages = False
        currentIndex = 0
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
