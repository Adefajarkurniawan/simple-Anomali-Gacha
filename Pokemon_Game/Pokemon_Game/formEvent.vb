Imports MySql.Data.MySqlClient
Imports System.IO

Public Class formEvent
    Dim selectedImagePath As String = ""
    Private mouseOffset As Point
    Private isMouseDown As Boolean = False

    Private Sub btnPilih_Click(sender As Object, e As EventArgs) Handles btnPilih.Click
        openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png"
        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            selectedImagePath = openFileDialog1.FileName
            picBanner.Image = Image.FromFile(selectedImagePath)
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtNamaEvent.Text = "" Or selectedImagePath = "" Then
            MessageBox.Show("Harap isi nama event dan pilih gambar.")
            Return
        End If

        Try
            koneksi() ' Panggil prosedur koneksi dari modul

            ' Hapus semua event lama
            CMD = New MySqlCommand("DELETE FROM event", CONN)
            CMD.ExecuteNonQuery()

            ' Simpan gambar ke folder lokal
            Dim imgFolder As String = Application.StartupPath & "\images\"
            MessageBox.Show("Folder path: " & imgFolder)
            If Not Directory.Exists(imgFolder) Then
                Directory.CreateDirectory(imgFolder)
            End If

            Dim fileName As String = Path.GetFileName(selectedImagePath)
            Dim finalPath As String = imgFolder & fileName
            File.Copy(selectedImagePath, finalPath, True)

            ' Simpan data ke database
            CMD = New MySqlCommand("INSERT INTO event (image_path, nama_event) VALUES (@img, @nama)", CONN)
            CMD.Parameters.AddWithValue("@img", "images/" & fileName)
            CMD.Parameters.AddWithValue("@nama", txtNamaEvent.Text)
            CMD.ExecuteNonQuery()

            MessageBox.Show("Event berhasil disimpan.")
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message)
        Finally
            If CONN.State = ConnectionState.Open Then
                CONN.Close()
            End If
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        formAdmin.Show()
        Me.Close()
    End Sub

    Private Sub formEvent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load data event jika ada
        Try
            koneksi()
            CMD = New MySqlCommand("SELECT * FROM event LIMIT 1", CONN)
            RD = CMD.ExecuteReader()
            If RD.Read() Then
                txtNamaEvent.Text = RD("nama_event").ToString()
                Dim imgPath As String = Application.StartupPath & "\" & RD("image_path").ToString()
                If File.Exists(imgPath) Then
                    picBanner.Image = Image.FromFile(imgPath)
                    selectedImagePath = imgPath
                End If
            End If
            RD.Close()
        Catch ex As Exception
            MessageBox.Show("Gagal memuat data event: " & ex.Message)
        Finally
            If CONN.State = ConnectionState.Open Then
                CONN.Close()
            End If
        End Try
    End Sub

    ' ==============================================
    ' Kode untuk drag form dengan cursor
    ' ==============================================

    Private Sub Form_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        ' Hanya respon klik kiri mouse
        If e.Button = MouseButtons.Left Then
            ' Simpan posisi mouse relatif terhadap form
            mouseOffset = New Point(-e.X, -e.Y)
            isMouseDown = True
        End If
    End Sub

    Private Sub Form_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        ' Jika mouse sedang ditahan (drag)
        If isMouseDown Then
            ' Dapatkan posisi mouse saat ini
            Dim mousePos As Point = Control.MousePosition
            ' Sesuaikan dengan offset awal
            mousePos.Offset(mouseOffset.X, mouseOffset.Y)
            ' Pindahkan form ke posisi baru
            Me.Location = mousePos
        End If
    End Sub

    Private Sub Form_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        ' Lepaskan drag ketika mouse dilepas
        If e.Button = MouseButtons.Left Then
            isMouseDown = False
        End If
    End Sub

    ' Handler untuk drag form melalui panel header (jika ada)
    Private Sub PanelHeader_MouseDown(sender As Object, e As MouseEventArgs) Handles panelHeader.MouseDown
        Form_MouseDown(sender, e)
    End Sub

    Private Sub PanelHeader_MouseMove(sender As Object, e As MouseEventArgs) Handles panelHeader.MouseMove
        Form_MouseMove(sender, e)
    End Sub

    Private Sub PanelHeader_MouseUp(sender As Object, e As MouseEventArgs) Handles panelHeader.MouseUp
        Form_MouseUp(sender, e)
    End Sub
End Class