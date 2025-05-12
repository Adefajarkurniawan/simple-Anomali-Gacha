Imports MySql.Data.MySqlClient
Imports System.IO

Public Class tambahKartu
    Private imagePath As String = ""
    Private tempImagePath As String = ""
    Private mouseOffset As Point
    Private isMouseDown As Boolean = False

    Private Sub tambahKartu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCardData()

        ' Menghapus item sebelumnya sebelum menambahkan lagi
        cmbKategori.Items.Clear()

        ' Setting untuk ComboBox Kategori dengan Placeholder
        cmbKategori.DropDownStyle = ComboBoxStyle.DropDownList
        cmbKategori.ForeColor = Color.Gray
        cmbKategori.Items.Add("Pilih Kategori")
        cmbKategori.Items.AddRange(New Object() {"rare", "epic", "legend", "mythic"})
        cmbKategori.SelectedIndex = 0

        ' Event handler untuk mengubah warna teks saat memilih item
        AddHandler cmbKategori.SelectedIndexChanged, AddressOf cmbKategori_SelectedIndexChanged
    End Sub

    ' Event handler untuk mengatur warna teks saat dipilih
    Private Sub cmbKategori_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbKategori.SelectedIndexChanged
        If cmbKategori.SelectedIndex = 0 Then
            cmbKategori.ForeColor = Color.Gray
        Else
            cmbKategori.ForeColor = Color.Black
        End If
    End Sub

    Private Sub LoadCardData()
        koneksi()

        Try
            lstCards.Columns.Clear()
            lstCards.Items.Clear()

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
            lstCards.Columns.Add("Kategori", 100)

            ' Ambil data dari tabel cards
            CMD = New MySqlCommand("SELECT id, name, rarity, type, price, kategori FROM cards", CONN)
            RD = CMD.ExecuteReader()

            ' Tambahkan data ke ListView
            While RD.Read()
                Dim item As New ListViewItem(RD("id").ToString())
                item.SubItems.Add(RD("name").ToString())
                item.SubItems.Add(RD("rarity").ToString())
                item.SubItems.Add(RD("type").ToString())
                item.SubItems.Add(RD("price").ToString())
                item.SubItems.Add(RD("kategori").ToString())
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
        Dim kategori As String = cmbKategori.SelectedItem.ToString()
        Dim price As Integer

        ' Validasi kategori
        If kategori = "Pilih Kategori" Then
            MessageBox.Show("Silakan pilih kategori terlebih dahulu.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

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
            CMD = New MySqlCommand("INSERT INTO cards (name, type, rarity, price, image_path, kategori) VALUES (@name, @type, @rarity, @price, @image_path, @kategori)", CONN)
            CMD.Parameters.AddWithValue("@name", name)
            CMD.Parameters.AddWithValue("@type", type)
            CMD.Parameters.AddWithValue("@rarity", rarity)
            CMD.Parameters.AddWithValue("@price", price)
            CMD.Parameters.AddWithValue("@image_path", imagePath)
            CMD.Parameters.AddWithValue("@kategori", kategori)

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

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If lstCards.SelectedItems.Count > 0 Then
            Dim selectedItem As ListViewItem = lstCards.SelectedItems(0)
            Dim id As Integer = Convert.ToInt32(selectedItem.SubItems(0).Text)

            Dim name As String = txtName.Text
            Dim type As String = txtType.Text
            Dim rarity As String = txtRarity.Text
            Dim kategori As String = cmbKategori.SelectedItem.ToString()

            If name = "" Or type = "" Or rarity = "" Then
                MessageBox.Show("Mohon isi semua kolom.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Try
                ' Jika gambar diubah
                If PictureBox1.Image IsNot Nothing AndAlso tempImagePath <> "" Then
                    Dim assetsFolder As String = Path.Combine(Application.StartupPath, "Cards")
                    If Not Directory.Exists(assetsFolder) Then
                        Directory.CreateDirectory(assetsFolder)
                    End If

                    Dim fileName As String = Path.GetFileName(tempImagePath)
                    Dim finalPath As String = Path.Combine(assetsFolder, fileName)

                    ' Jika file sudah ada, tambahkan timestamp
                    If File.Exists(finalPath) Then
                        fileName = Path.GetFileNameWithoutExtension(tempImagePath) & "_" & DateTime.Now.ToString("yyyyMMddHHmmss") & Path.GetExtension(tempImagePath)
                        finalPath = Path.Combine(assetsFolder, fileName)
                    End If

                    File.Copy(tempImagePath, finalPath, True)
                    imagePath = Path.Combine("Cards", fileName)
                Else
                    ' Jika gambar tidak diubah, dapatkan path yang ada dari database
                    koneksi()
                    Dim getPathCmd As New MySqlCommand("SELECT image_path FROM cards WHERE id = @id", CONN)
                    getPathCmd.Parameters.AddWithValue("@id", id)
                    imagePath = getPathCmd.ExecuteScalar().ToString()
                End If

                ' Update database
                koneksi()
                Dim query As String = "UPDATE cards SET name = @name, type = @type, rarity = @rarity, kategori = @kategori, image_path = @image_path WHERE id = @id"

                CMD = New MySqlCommand(query, CONN)
                CMD.Parameters.AddWithValue("@id", id)
                CMD.Parameters.AddWithValue("@name", name)
                CMD.Parameters.AddWithValue("@type", type)
                CMD.Parameters.AddWithValue("@rarity", rarity)
                CMD.Parameters.AddWithValue("@kategori", kategori)
                CMD.Parameters.AddWithValue("@image_path", imagePath)

                CMD.ExecuteNonQuery()

                MessageBox.Show("Card berhasil diperbarui.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ClearForm()
                LoadCardData()
                formAdmin.LoadStatistik()
            Catch ex As Exception
                MessageBox.Show("Gagal mengedit card: " & ex.Message)
            Finally
                If CONN.State = ConnectionState.Open Then
                    CONN.Close()
                End If
            End Try
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If lstCards.SelectedItems.Count > 0 Then
            Dim selectedItem As ListViewItem = lstCards.SelectedItems(0)
            Dim id As Integer = Convert.ToInt32(selectedItem.SubItems(0).Text)

            If MessageBox.Show("Apakah Anda yakin ingin menghapus kartu ?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                Try
                    koneksi()

                    ' Hapus terlebih dahulu dari tabel user_card
                    CMD = New MySqlCommand("DELETE FROM user_card WHERE card_id = @id", CONN)
                    CMD.Parameters.AddWithValue("@id", id)
                    CMD.ExecuteNonQuery()

                    ' Lanjutkan menghapus dari tabel cards
                    CMD = New MySqlCommand("DELETE FROM cards WHERE id = @id", CONN)
                    CMD.Parameters.AddWithValue("@id", id)
                    CMD.ExecuteNonQuery()

                    MessageBox.Show("Kartu berhasil dihapus.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ClearForm()
                    LoadCardData()
                    formAdmin.LoadStatistik()
                Catch ex As Exception
                    MessageBox.Show("Gagal menghapus kartu: " & ex.Message)
                Finally
                    If CONN.State = ConnectionState.Open Then
                        CONN.Close()
                    End If
                End Try
            End If
        End If
    End Sub



    ' Fungsi untuk membersihkan form
    Private Sub ClearForm()
        txtName.Clear()
        txtType.Clear()
        txtRarity.Clear()
        PictureBox1.Image = Nothing
        tempImagePath = ""
        imagePath = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        formAdmin.Show()
        Me.Close()
    End Sub

    Private Sub PanelHeader_MouseDown(sender As Object, e As MouseEventArgs) Handles panelHeader.MouseDown
        If e.Button = MouseButtons.Left Then
            mouseOffset = New Point(-e.X, -e.Y)
            isMouseDown = True
        End If
    End Sub

    Private Sub PanelHeader_MouseMove(sender As Object, e As MouseEventArgs) Handles panelHeader.MouseMove
        If isMouseDown Then
            Dim mousePos As Point = Control.MousePosition
            mousePos.Offset(mouseOffset.X, mouseOffset.Y)
            Me.Location = mousePos
        End If
    End Sub

    Private Sub PanelHeader_MouseUp(sender As Object, e As MouseEventArgs) Handles panelHeader.MouseUp
        If e.Button = MouseButtons.Left Then
            isMouseDown = False
        End If
    End Sub

End Class