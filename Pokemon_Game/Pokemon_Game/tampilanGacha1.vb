Public Class tampilanGacha1
    Public Sub TampilkanKartu(card As DataRow)
        ' Misalnya Anda punya PictureBox dan Label di form ini
        Dim imgPath As String = System.IO.Path.Combine(Application.StartupPath, card("image_path").ToString())
        If System.IO.File.Exists(imgPath) Then
            PictureBoxKartu.Image = Image.FromFile(imgPath)
            PictureBoxKartu.SizeMode = PictureBoxSizeMode.Zoom
        Else
            MessageBox.Show("Gambar kartu tidak ditemukan.")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class
