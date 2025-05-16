Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Imports MySql.Data.MySqlClient

Public Class formRegis
    Private Sub formRegis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim gambarPath As String = Path.Combine(Application.StartupPath, "Assets", "anomali.png")
        If File.Exists(gambarPath) Then
            picLogo.Image = Image.FromFile(gambarPath)
        End If
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim errorMsg = ValidateInput(txtUsername.Text, txtPassword.Text)
        If errorMsg IsNot Nothing Then
            MessageBox.Show(errorMsg, "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        koneksi()
        Try
            ' Cek apakah username sudah digunakan
            CMD = New MySqlCommand("SELECT * FROM users WHERE username=@user", CONN)
            CMD.Parameters.AddWithValue("@user", txtUsername.Text)
            RD = CMD.ExecuteReader()
            If RD.HasRows Then
                RD.Close()
                MessageBox.Show("Username sudah digunakan.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            RD.Close()

            ' Simpan user baru
            Dim hashed = HashPassword(txtPassword.Text)
            CMD = New MySqlCommand("INSERT INTO users (username, password) VALUES (@user, @pass)", CONN)
            CMD.Parameters.AddWithValue("@user", txtUsername.Text)
            CMD.Parameters.AddWithValue("@pass", hashed)
            CMD.ExecuteNonQuery()

            MessageBox.Show("Registrasi berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            formLogin.Show()
            Me.Hide()
        Catch ex As Exception
            MessageBox.Show("Gagal registrasi: " & ex.Message)
        End Try
    End Sub

    Private Sub btnToLogin_Click(sender As Object, e As EventArgs) Handles btnToLogin.Click
        formLogin.Show()
        Me.Hide()
    End Sub

    Private Function ValidateInput(username As String, password As String) As String
        If username.Length < 5 Then Return "Username minimal 5 karakter."
        If password.Length < 5 Then Return "Password minimal 5 karakter."
        If username.Contains("'") Or username.Contains(";") Or username.Contains("\") Or username.Contains("""") Or password.Contains("'") Then
            Return "Username dan password tidak boleh mengandung karakter spesial seperti ; ' "" \"
        End If
        Return Nothing
    End Function

    Private Function HashPassword(password As String) As String
        Using sha256 As SHA256 = SHA256.Create()
            Dim bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password))
            Return BitConverter.ToString(bytes).Replace("-", "").ToLower()
        End Using
    End Function
    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs)
        If chkShowPassword.Checked Then
            txtPassword.PasswordChar = ControlChars.NullChar ' Tampilkan password
        Else
            txtPassword.PasswordChar = "*"c ' Sembunyikan password
        End If
    End Sub


End Class
