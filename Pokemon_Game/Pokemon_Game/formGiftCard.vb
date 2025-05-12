Imports MySql.Data.MySqlClient

Public Class formGiftCard
    Private connection As New MySqlConnection("server=localhost;user id=root;password=;database=pokemon_gacha")
    Private mouseOffset As Point
    Private isMouseDown As Boolean = False

    Private Sub FormAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUserData()
    End Sub

    ' Load semua data user ke DataGridView
    Private Sub LoadUserData()
        Try
            Dim query As String = "SELECT id, username FROM users"
            Dim adapter As New MySqlDataAdapter(query, connection)
            Dim table As New DataTable()
            adapter.Fill(table)
            dgvUsers.DataSource = table
            dgvUsers.Columns("id").Visible = False
        Catch ex As Exception
            MessageBox.Show("Gagal memuat data user: " & ex.Message)
        End Try
    End Sub

    ' Load kartu yang dimiliki oleh user yang dipilih
    Private Sub LoadUserCards(userId As Integer)
        Try
            Dim query As String = "SELECT c.name AS 'Nama Kartu', uc.Jumlah_Kartu AS 'Jumlah' FROM user_card uc JOIN cards c ON uc.card_id = c.id WHERE uc.user_id = @user_id"
            Dim adapter As New MySqlDataAdapter(query, connection)
            adapter.SelectCommand.Parameters.AddWithValue("@user_id", userId)
            Dim table As New DataTable()
            adapter.Fill(table)
            dgvCard.DataSource = table ' Mengisi dgvCards dengan data kartu
        Catch ex As Exception
            MessageBox.Show("Error saat memuat kartu user: " & ex.Message)
        End Try
    End Sub

    ' Saat baris user dipilih
    Private Sub dgvUsers_SelectionChanged(sender As Object, e As EventArgs) Handles dgvUsers.SelectionChanged
        If dgvUsers.SelectedRows.Count > 0 Then
            Dim userId As Integer = Convert.ToInt32(dgvUsers.SelectedRows(0).Cells("id").Value)
            LoadUserCards(userId) ' Load kartu berdasarkan user yang dipilih
        End If
    End Sub

    ' Berikan kartu ke user
    Private Sub btnBerikan_Click(sender As Object, e As EventArgs) Handles btnBerikan.Click
        If dgvUsers.SelectedRows.Count = 0 Then
            MessageBox.Show("Pilih user terlebih dahulu.")
            Return
        End If

        If cbKartu.SelectedItem Is Nothing Then
            MessageBox.Show("Pilih kartu terlebih dahulu.")
            Return
        End If

        Dim selectedCard = CType(cbKartu.SelectedItem, Card)
        Dim jumlah = Convert.ToInt32(txtJumlah.Text) ' Pastikan txtJumlah adalah TextBox
        Dim userId = Convert.ToInt32(dgvUsers.SelectedRows(0).Cells("id").Value)

        Try
            connection.Open()

            ' Cek apakah user sudah memiliki kartu tersebut
            Dim checkQuery = "SELECT Jumlah_Kartu FROM user_card WHERE user_id = @user_id AND card_id = @card_id"
            Dim checkCommand As New MySqlCommand(checkQuery, connection)
            checkCommand.Parameters.AddWithValue("@user_id", userId)
            checkCommand.Parameters.AddWithValue("@card_id", selectedCard.Id)

            Dim result = checkCommand.ExecuteScalar

            If result IsNot Nothing Then
                ' Sudah punya kartu, update jumlah
                Dim updateQuery = "UPDATE user_card SET Jumlah_Kartu = Jumlah_Kartu + @jumlah WHERE user_id = @user_id AND card_id = @card_id"
                Dim updateCommand As New MySqlCommand(updateQuery, connection)
                updateCommand.Parameters.AddWithValue("@jumlah", jumlah)
                updateCommand.Parameters.AddWithValue("@user_id", userId)
                updateCommand.Parameters.AddWithValue("@card_id", selectedCard.Id)
                updateCommand.ExecuteNonQuery()
            Else
                ' Belum punya kartu, insert baru
                Dim insertQuery = "INSERT INTO user_card (user_id, card_id, Jumlah_Kartu) VALUES (@user_id, @card_id, @jumlah)"
                Dim insertCommand As New MySqlCommand(insertQuery, connection)
                insertCommand.Parameters.AddWithValue("@user_id", userId)
                insertCommand.Parameters.AddWithValue("@card_id", selectedCard.Id)
                insertCommand.Parameters.AddWithValue("@jumlah", jumlah)
                insertCommand.ExecuteNonQuery()
            End If

            MessageBox.Show("Kartu berhasil diberikan.")
            LoadUserCards(userId) ' Refresh data kartu setelah pemberian
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    ' Kelas untuk menyimpan info kartu dalam ComboBox
    Private Class Card
        Public Property Id As Integer
        Public Property Name As String

        Public Overrides Function ToString() As String
            Return Name
        End Function
    End Class

    ' Load daftar kartu ke ComboBox saat Form dibuka
    Private Sub cbKartu_DropDown(sender As Object, e As EventArgs) Handles cbKartu.DropDown
        Try
            cbKartu.Items.Clear()
            Dim query = "SELECT id, name FROM cards"
            Dim cmd As New MySqlCommand(query, connection)
            connection.Open()
            Dim reader = cmd.ExecuteReader
            While reader.Read
                Dim card As New Card With {
                    .Id = reader.GetInt32("id"),
                    .Name = reader.GetString("name")
                }
                cbKartu.Items.Add(card)
            End While
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Gagal memuat daftar kartu: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        SearchUser(txtUsername.Text)
    End Sub

    Private Sub txtUsername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsername.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            SearchUser(txtUsername.Text)
            e.Handled = True
        End If
    End Sub

    ' Method untuk mencari user berdasarkan username atau ID
    Private Sub SearchUser(searchTerm As String)
        Try
            ' Jika search kosong, load semua data
            If String.IsNullOrWhiteSpace(searchTerm) Then
                LoadUserData()
                Return
            End If

            Dim query As String = "SELECT id, username FROM users WHERE "

            ' Cek apakah searchTerm berupa angka (mungkin ID)
            Dim isNumericSearch As Boolean = Integer.TryParse(searchTerm, Nothing)

            If isNumericSearch Then
                query += "id = @searchTerm OR username LIKE @searchTermWildcard"
            Else
                query += "username LIKE @searchTermWildcard"
            End If

            Dim adapter As New MySqlDataAdapter(query, connection)
            adapter.SelectCommand.Parameters.AddWithValue("@searchTerm", searchTerm)
            adapter.SelectCommand.Parameters.AddWithValue("@searchTermWildcard", "%" & searchTerm & "%")

            Dim table As New DataTable()
            adapter.Fill(table)

            dgvUsers.DataSource = table
            dgvUsers.Columns("id").Visible = False

            ' Reset kartu yang ditampilkan jika tidak ada user yang dipilih
            If dgvUsers.Rows.Count = 0 Then
                dgvCard.DataSource = Nothing
            End If

        Catch ex As Exception
            MessageBox.Show("Gagal melakukan pencarian: " & ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        formAdmin.Show()
        Me.Close()
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
    Private Sub PanelHeader_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelHeader.MouseDown
        Form_MouseDown(sender, e)
    End Sub

    Private Sub PanelHeader_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelHeader.MouseMove
        Form_MouseMove(sender, e)
    End Sub

    Private Sub PanelHeader_MouseUp(sender As Object, e As MouseEventArgs) Handles PanelHeader.MouseUp
        Form_MouseUp(sender, e)
    End Sub

    Private Sub panelHeader_Paint(sender As Object, e As PaintEventArgs) Handles panelHeader.Paint

    End Sub
End Class