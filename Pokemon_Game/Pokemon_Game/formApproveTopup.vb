Imports MySql.Data.MySqlClient

Public Class FormApproveTopup
    Private mouseOffset As Point
    Private isMouseDown As Boolean = False

    Private Sub FormApproveTopup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Atur selection mode dan style DataGridView
        dgvTopups.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvTopups.MultiSelect = False
        dgvTopups.ReadOnly = True

        ' Load data pending topup
        LoadPendingTopups()
    End Sub

    Private Sub LoadPendingTopups(Optional searchTerm As String = "")
        dgvTopups.Rows.Clear()

        Dim connStr As String = "server=localhost;user id=root;password=;database=pokemon_gacha"
        Using conn As New MySqlConnection(connStr)
            Try
                conn.Open()
                Dim query As String = "SELECT tr.request_id, u.id AS user_id, u.username, tr.amount " &
                                      "FROM topup_requests tr " &
                                      "JOIN users u ON tr.user_id = u.id " &
                                      "WHERE tr.status = 'pending'"

                If Not String.IsNullOrEmpty(searchTerm) Then
                    query += " AND (u.username LIKE @searchTerm OR u.id LIKE @searchTerm)"
                End If

                Using cmd As New MySqlCommand(query, conn)
                    If Not String.IsNullOrEmpty(searchTerm) Then
                        cmd.Parameters.AddWithValue("@searchTerm", "%" & searchTerm & "%")
                    End If

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            dgvTopups.Rows.Add(
                                reader("request_id"),
                                reader("user_id"),
                                reader("username"),
                                reader("amount")
                            )
                        End While
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Gagal memuat data: " & ex.Message)
            End Try
        End Using

        ' Reset detail panel jika tidak ada data
        If dgvTopups.Rows.Count = 0 Then
            ResetDetailPanel()
        End If
    End Sub

    Private Sub dgvTopups_SelectionChanged(sender As Object, e As EventArgs) Handles dgvTopups.SelectionChanged
        If dgvTopups.SelectedRows.Count > 0 Then
            Dim row = dgvTopups.SelectedRows(0)
            lblUsername.Text = "Username: " & row.Cells(2).Value.ToString()
            lblCoinAmount.Text = "Jumlah Coin: " & row.Cells(3).Value.ToString()

            ' Aktifkan tombol approve
            btnApprove.Enabled = True
        Else
            ResetDetailPanel()
        End If
    End Sub

    Private Sub ResetDetailPanel()
        lblUsername.Text = "Username: -"
        lblCoinAmount.Text = "Jumlah Coin: -"
        btnApprove.Enabled = False
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadPendingTopups()
        txtSearch.Clear()
    End Sub

    Private Sub btnApprove_Click(sender As Object, e As EventArgs) Handles btnApprove.Click
        If dgvTopups.SelectedRows.Count = 0 Then
            MessageBox.Show("Pilih permintaan yang ingin disetujui!")
            Return
        End If

        Dim row = dgvTopups.SelectedRows(0)
        Dim topupId As Integer = Convert.ToInt32(row.Cells(0).Value)
        Dim userId As Integer = Convert.ToInt32(row.Cells(1).Value)
        Dim amount As Integer = Convert.ToInt32(row.Cells(3).Value)

        Dim connStr As String = "server=localhost;user id=root;password=;database=pokemon_gacha"
        Using conn As New MySqlConnection(connStr)
            Try
                conn.Open()

                Dim transaction As MySqlTransaction = conn.BeginTransaction()

                Try
                    ' 1. Cek status topup
                    Dim checkStatusCmd As New MySqlCommand(
                        "SELECT status FROM topup_requests WHERE request_id = @request_id", conn, transaction)
                    checkStatusCmd.Parameters.AddWithValue("@request_id", topupId)
                    Dim status As String = Convert.ToString(checkStatusCmd.ExecuteScalar())

                    If status = "approved" Then
                        MessageBox.Show("Top-up ini sudah disetujui sebelumnya!")
                        transaction.Rollback()
                        Return
                    End If

                    ' 2. Update coin user
                    Dim updateCoin As New MySqlCommand(
                        "UPDATE users SET coin = coin + @amount WHERE id = @user_id", conn, transaction)
                    updateCoin.Parameters.AddWithValue("@amount", amount)
                    updateCoin.Parameters.AddWithValue("@user_id", userId)
                    updateCoin.ExecuteNonQuery()

                    ' 3. Update status topup
                    Dim updateStatus As New MySqlCommand(
                        "UPDATE topup_requests SET status = 'approved' WHERE request_id = @request_id", conn, transaction)
                    updateStatus.Parameters.AddWithValue("@request_id", topupId)
                    updateStatus.ExecuteNonQuery()

                    transaction.Commit()

                    MessageBox.Show("Top-up berhasil disetujui!")
                    LoadPendingTopups(txtSearch.Text)
                    ResetDetailPanel()

                Catch ex As Exception
                    transaction.Rollback()
                    MessageBox.Show("Gagal menyetujui top-up: " & ex.Message)
                End Try

            Catch ex As Exception
                MessageBox.Show("Gagal terhubung ke database: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        LoadPendingTopups(txtSearch.Text)
    End Sub

    Private Sub txtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            LoadPendingTopups(txtSearch.Text)
            e.Handled = True
        End If
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