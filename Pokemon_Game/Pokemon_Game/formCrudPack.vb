Imports MySql.Data.MySqlClient
Imports System.IO

Public Class formCrudPack
    ' Variabel untuk drag form
    Dim drag As Boolean
    Dim mouseX As Integer
    Dim mouseY As Integer

    Private Sub formCrudPack_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPackData()
    End Sub

    Private Sub LoadPackData()
        koneksi()
        Try
            CMD = New MySqlCommand("SELECT * FROM packs", CONN)
            RD = CMD.ExecuteReader()

            lstPacks.Items.Clear()
            While RD.Read()
                lstPacks.Items.Add(New ListViewItem(New String() {
                    RD("id").ToString(),
                    RD("name").ToString(),
                    RD("description").ToString(),
                    RD("price").ToString(),
                    RD("image_path").ToString()
                }))
            End While
            RD.Close()
        Catch ex As Exception
            MessageBox.Show("Gagal mengambil data packs: " & ex.Message)
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim name As String = txtName.Text
        Dim description As String = txtDescription.Text
        Dim price As Integer = Convert.ToInt32(txtPrice.Text)

        Dim imagePath As String = ""
        Using openFileDialog As New OpenFileDialog()
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif"
            If openFileDialog.ShowDialog() = DialogResult.OK Then
                imagePath = Path.Combine(Application.StartupPath, "Assets", Path.GetFileName(openFileDialog.FileName))
                File.Copy(openFileDialog.FileName, imagePath, True)
            End If
        End Using

        If name = "" Or description = "" Or price <= 0 Or imagePath = "" Then
            MessageBox.Show("Mohon isi semua kolom.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            koneksi()
            CMD = New MySqlCommand("INSERT INTO packs (name, description, price, image_path) VALUES (@name, @description, @price, @image_path)", CONN)
            CMD.Parameters.AddWithValue("@name", name)
            CMD.Parameters.AddWithValue("@description", description)
            CMD.Parameters.AddWithValue("@price", price)
            CMD.Parameters.AddWithValue("@image_path", imagePath)

            CMD.ExecuteNonQuery()
            MessageBox.Show("Pack berhasil ditambahkan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadPackData()
            formAdmin.LoadStatistik()

        Catch ex As Exception
            MessageBox.Show("Gagal menambah pack: " & ex.Message)
        End Try
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If lstPacks.SelectedItems.Count > 0 Then
            Dim selectedItem As ListViewItem = lstPacks.SelectedItems(0)
            Dim id As Integer = Convert.ToInt32(selectedItem.SubItems(0).Text)
            Dim name As String = txtName.Text
            Dim description As String = txtDescription.Text
            Dim price As Integer = Convert.ToInt32(txtPrice.Text)

            Dim imagePath As String = ""
            Using openFileDialog As New OpenFileDialog()
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif"
                If openFileDialog.ShowDialog() = DialogResult.OK Then
                    imagePath = Path.Combine(Application.StartupPath, "Assets", Path.GetFileName(openFileDialog.FileName))
                    File.Copy(openFileDialog.FileName, imagePath, True)
                End If
            End Using

            If name = "" Or description = "" Or price <= 0 Or imagePath = "" Then
                MessageBox.Show("Mohon isi semua kolom.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Try
                koneksi()
                CMD = New MySqlCommand("UPDATE packs SET name = @name, description = @description, price = @price, image_path = @image_path WHERE id = @id", CONN)
                CMD.Parameters.AddWithValue("@id", id)
                CMD.Parameters.AddWithValue("@name", name)
                CMD.Parameters.AddWithValue("@description", description)
                CMD.Parameters.AddWithValue("@price", price)
                CMD.Parameters.AddWithValue("@image_path", imagePath)

                CMD.ExecuteNonQuery()
                MessageBox.Show("Pack berhasil diperbarui.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadPackData()
                formAdmin.LoadStatistik()

            Catch ex As Exception
                MessageBox.Show("Gagal mengedit pack: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If lstPacks.SelectedItems.Count > 0 Then
            Dim selectedItem As ListViewItem = lstPacks.SelectedItems(0)
            Dim id As Integer = Convert.ToInt32(selectedItem.SubItems(0).Text)

            If MessageBox.Show("Apakah Anda yakin ingin menghapus pack ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                Try
                    koneksi()
                    CMD = New MySqlCommand("DELETE FROM packs WHERE id = @id", CONN)
                    CMD.Parameters.AddWithValue("@id", id)

                    CMD.ExecuteNonQuery()
                    MessageBox.Show("Pack berhasil dihapus.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LoadPackData()
                    formAdmin.LoadStatistik()

                Catch ex As Exception
                    MessageBox.Show("Gagal menghapus pack: " & ex.Message)
                End Try
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        formAdmin.Show()
        Me.Close()
    End Sub

    ' === KODE UNTUK GESER FORM DENGAN PANEL HEADER ===
    Private Sub panelHeader_MouseDown(sender As Object, e As MouseEventArgs) Handles panelHeader.MouseDown
        drag = True
        mouseX = Cursor.Position.X - Me.Left
        mouseY = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub panelHeader_MouseMove(sender As Object, e As MouseEventArgs) Handles panelHeader.MouseMove
        If drag Then
            Me.Top = Cursor.Position.Y - mouseY
            Me.Left = Cursor.Position.X - mouseX
        End If
    End Sub

    Private Sub panelHeader_MouseUp(sender As Object, e As MouseEventArgs) Handles panelHeader.MouseUp
        drag = False
    End Sub

End Class
