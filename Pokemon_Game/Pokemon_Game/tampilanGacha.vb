Public Class tampilanGacha
    Public Sub TampilkanKartu(kartuList As List(Of DataRow))
        Dim pictureBoxes() As PictureBox = {PictureBox1, PictureBox2, PictureBox5, PictureBox3, PictureBox4}
        For i = 0 To kartuList.Count - 1
            Dim imgPath As String = kartuList(i)("image_path").ToString()
            If System.IO.File.Exists(imgPath) Then
                pictureBoxes(i).Image = Image.FromFile(imgPath)
            Else
                MessageBox.Show("File tidak ditemukan: " & imgPath)
            End If
        Next

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class