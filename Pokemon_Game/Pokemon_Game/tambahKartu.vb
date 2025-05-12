Imports MySql.Data.MySqlClient
Imports System.IO

Public Class tambahKartu
    Private imagePath As String = ""
    Private tempImagePath As String = ""
    Private mouseOffset As Point
    Private isMouseDown As Boolean = False

    Private Sub tambahKartu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCardData()
    End Sub

    Private Sub LoadCardData()
        koneksi()
        Try
            ' Set ListView ke mode Details dan siapkan kolom
            lstCards.View = View.Details
            lstCards.FullRowSelect = True
            lstCards.GridLines = True
            lstCards.Columns.Clear()
            lstCards.Items.Clear()

            ' Tambahkan kolom
            lstCards.Columns.Add("ID", 50)
            lstCards.Columns.Add("Name", 100)
            lstCards.Columns.Add("Rarity", 80)
            lstCards.Columns.Add("Type", 100)
            lstCards.Columns.Add("Price", 80)

            ' Ambil data dari tabel cards
            CMD = New MySqlCommand("SELECT id, name, rarity, type, price FROM cards", CONN)
            RD = CMD.ExecuteReader()

            ' Tambahkan data ke ListView
            While RD.Read()
                Dim item As New ListViewItem(RD("id").ToString())
                item.SubItems.Add(RD("name").ToString())
                item.SubItems.Add(RD("rarity").ToString())
                item.SubItems.Add(RD("type").ToString())
                item.SubItems.Add(RD("price").ToString())
                lstCards.Items.Add(item)
            End While
            RD.Close()

        Catch ex As Exception
            MessageBox.Show("Gagal mengambil data cards: " & ex.Message)
        Finally
            If CONN.State = ConnectionState.Open Then
                CONN.Close()
            End If
        End Try
    End Sub

    ' Tombol untuk upload gambar
    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        Using openFileDialog As New OpenFileDialog
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif"
            If openFileDialog.ShowDialog() = DialogResult.OK Then
                Try
                    PictureBox1.Image = Image.FromFile(openFileDialog.FileName)
                    tempImagePath = openFileDialog.FileName
                Catch ex As Exception
                    MessageBox.Show("Gagal memuat gambar: " & ex.Message)
                End Try
            End If
        End Using
    End Sub

    ' Tombol untuk menambahkan kartu
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim name = txtName.Text
        Dim type = txtType.Text
        Dim rarity = txtRarity.Text
        Dim price As Integer

        If Not Integer.TryParse(txtPrice.Text, price) Then
            MessageBox.Show("Harga harus berupa angka.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If name = "" Or type = "" Or rarity = "" Or price <= 0 Then
            MessageBox.Show("Mohon isi semua kolom dengan benar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If PictureBox1.Image Is Nothing Then
            MessageBox.Show("Mohon upload gambar terlebih dahulu.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Dim assetsFolder = Path.Combine(Application.StartupPath, "Cards")
            If Not Directory.Exists(assetsFolder) Then
                Directory.CreateDirectory(assetsFolder)
            End If

            Dim fileName = Path.GetFileName(tempImagePath)
            Dim finalPath = Path.Combine(assetsFolder, fileName)

            If File.Exists(finalPath) Then
                fileName = Path.GetFileNameWithoutExtension(tempImagePath) & "_" & DateTime.Now.ToString("yyyyMMddHHmmss") & Path.GetExtension(tempImagePath)
                finalPath = Path.Combine(assetsFolder, fileName)
            End If

            File.Copy(tempImagePath, finalPath, True)
            imagePath = Path.Combine("Cards", fileName)

            koneksi()
            CMD = New MySqlCommand("INSERT INTO cards (name, type, rarity, price, image_path) VALUES (@name, @type, @rarity, @price, @image_path)", CONN)
            CMD.Parameters.AddWithValue("@name", name)
            CMD.Parameters.AddWithValue("@type", type)
            CMD.Parameters.AddWithValue("@rarity", rarity)
            CMD.Parameters.AddWithValue("@price", price)
            CMD.Parameters.AddWithValue("@image_path", imagePath)

            CMD.ExecuteNonQuery()

            MessageBox.Show("Card berhasil ditambahkan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadCardData()
        Catch ex As Exception
            MessageBox.Show("Gagal menambah card: " & ex.Message)
        Finally
            If CONN.State = ConnectionState.Open Then
                CONN.Close()
            End If
        End Try
    End Sub
End Class
