Imports MySql.Data.MySqlClient

Public Class formAdmin
    ' Ini WAJIB agar komponen dari Designer muncul di runtime
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub formAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadStatistik()
    End Sub

    Public Sub LoadStatistik()
        koneksi()

        Try
            CMD = New MySqlCommand("SELECT COUNT(*) FROM users", CONN)
            Dim totalUsers As Integer = CInt(CMD.ExecuteScalar())

            CMD = New MySqlCommand("SELECT COUNT(*) FROM cards", CONN)
            Dim totalCards As Integer = CInt(CMD.ExecuteScalar())

            CMD = New MySqlCommand("SELECT COUNT(*) FROM packs", CONN)
            Dim totalPacks As Integer = CInt(CMD.ExecuteScalar())

            CMD = New MySqlCommand("SELECT COUNT(*) FROM transactions", CONN)
            Dim totalTransaksi As Integer = CInt(CMD.ExecuteScalar())

            CMD = New MySqlCommand("SELECT COUNT(*) FROM user_card", CONN)
            Dim totalUserCards As Integer = CInt(CMD.ExecuteScalar())

            lblStat1.Text = $"👥 Total Users Terdaftar: {totalUsers}"
            lblStat2.Text = $"🃏 Total Kartu Pokémon: {totalCards}"
            lblStat3.Text = $"📦 Total Pack Gacha: {totalPacks}"
            lblStat4.Text = $"🔁 Total Transaksi Gacha: {totalTransaksi}"
            lblStat5.Text = $"📁 Total Kartu Dimiliki User: {totalUserCards}"

        Catch ex As Exception
            MessageBox.Show("Gagal mengambil statistik: " & ex.Message)
        End Try
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        formLogin.Show()
        Me.Close()
    End Sub

    Private Sub btnCrudPack_Click(sender As Object, e As EventArgs) Handles btnCrudPack.Click
        formCrudPack.Show()
    End Sub

    Private Sub btnCrudCard_Click(sender As Object, e As EventArgs) Handles btnCrudCard.Click
        MessageBox.Show("Gagal mengambil statistik: ")
    End Sub
End Class
