Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Imports MySql.Data.MySqlClient

Public Class formLogin
    Private Sub formLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim gambarPath As String = Path.Combine(Application.StartupPath, "Assets", "anomali.jpg")
        If File.Exists(gambarPath) Then
            picLogo.Image = Image.FromFile(gambarPath)
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username = txtUsername.Text.Trim()
        Dim password = txtPassword.Text.Trim()

        ' === Validasi input ===
        Dim errorMsg = ValidateInput(username, password)
        If errorMsg IsNot Nothing Then
            MessageBox.Show(errorMsg, "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' === Login admin langsung ===
        If username = "admin123" AndAlso password = "admin123" Then
            currentUsername = "admin123"
            MessageBox.Show("Login sebagai Admin!", "Admin Login", MessageBoxButtons.OK, MessageBoxIcon.Information)
            formAdmin.Show()
            Me.Hide()
            Exit Sub
        End If

        ' === Login user dari database ===
        koneksi()
        Try
            Dim hashed = HashPassword(password)
            CMD = New MySqlCommand("SELECT * FROM users WHERE username=@user AND password=@pass", CONN)
            CMD.Parameters.AddWithValue("@user", username)
            CMD.Parameters.AddWithValue("@pass", hashed)
            RD = CMD.ExecuteReader()

            If RD.Read() Then
                currentUsername = username
                currentUserId = Convert.ToInt32(RD("id")) ' ✅ Simpan ID user

                MessageBox.Show("Login berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                formHome.Show()
                Me.Hide()
            Else
                MessageBox.Show("Username atau password salah!", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            RD.Close()
        Catch ex As Exception
            MessageBox.Show("Kesalahan saat login: " & ex.Message)
        End Try

    End Sub

    Private Sub btnToRegister_Click(sender As Object, e As EventArgs) Handles btnToRegister.Click
        formRegis.Show()
        Me.Hide()
    End Sub

    ' ================================
    ' 🔐 Fungsi Validasi dan Hashing
    ' ================================

    Private Function ValidateInput(username As String, password As String) As String
        If username.Length < 5 Then Return "Username minimal 5 karakter."
        If password.Length < 5 Then Return "Password minimal 5 karakter."

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
