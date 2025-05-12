<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormApproveTopup
    Inherits System.Windows.Forms.Form

    ' Dispose untuk membersihkan komponen
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    ' Komponen designer
    Private components As System.ComponentModel.IContainer

    ' Inisialisasi komponen UI
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormApproveTopup))
        lblTitle = New Label()
        panelDetails = New Panel()
        lblUsername = New Label()
        lblCoinAmount = New Label()
        btnApprove = New Button()
        btnRefresh = New Button()
        picCoin = New PictureBox()
        txtSearch = New TextBox()
        btnSearch = New Button()
        dgvTopups = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Button2 = New Button()
        panelHeader = New Panel()
        panelDetails.SuspendLayout()
        CType(picCoin, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvTopups, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(54, 9)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(160, 33)
        lblTitle.TabIndex = 4
        lblTitle.Text = "Topup"
        ' 
        ' panelDetails
        ' 
        panelDetails.BackColor = Color.White
        panelDetails.BorderStyle = BorderStyle.FixedSingle
        panelDetails.Controls.Add(lblUsername)
        panelDetails.Controls.Add(lblCoinAmount)
        panelDetails.Location = New Point(232, 109)
        panelDetails.Name = "panelDetails"
        panelDetails.Size = New Size(221, 85)
        panelDetails.TabIndex = 2
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblUsername.Location = New Point(20, 16)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(106, 23)
        lblUsername.TabIndex = 0
        lblUsername.Text = "Username: -"
        ' 
        ' lblCoinAmount
        ' 
        lblCoinAmount.AutoSize = True
        lblCoinAmount.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCoinAmount.Location = New Point(20, 48)
        lblCoinAmount.Name = "lblCoinAmount"
        lblCoinAmount.Size = New Size(126, 23)
        lblCoinAmount.TabIndex = 1
        lblCoinAmount.Text = "Jumlah Coin: -"
        ' 
        ' btnApprove
        ' 
        btnApprove.BackColor = Color.Gold
        btnApprove.FlatStyle = FlatStyle.Popup
        btnApprove.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnApprove.Location = New Point(363, 218)
        btnApprove.Name = "btnApprove"
        btnApprove.Size = New Size(90, 37)
        btnApprove.TabIndex = 0
        btnApprove.Text = "Setujui"
        btnApprove.UseVisualStyleBackColor = False
        ' 
        ' btnRefresh
        ' 
        btnRefresh.BackColor = Color.LightSeaGreen
        btnRefresh.FlatStyle = FlatStyle.Popup
        btnRefresh.Font = New Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnRefresh.Location = New Point(232, 218)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(90, 37)
        btnRefresh.TabIndex = 1
        btnRefresh.Text = "Refresh"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' picCoin
        ' 
        picCoin.BackColor = Color.Transparent
        picCoin.Image = My.Resources.Resources.coin
        picCoin.Location = New Point(12, 10)
        picCoin.Margin = New Padding(3, 2, 3, 2)
        picCoin.Name = "picCoin"
        picCoin.Size = New Size(36, 32)
        picCoin.SizeMode = PictureBoxSizeMode.StretchImage
        picCoin.TabIndex = 5
        picCoin.TabStop = False
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(232, 65)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(158, 28)
        txtSearch.TabIndex = 6
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.Gold
        btnSearch.FlatStyle = FlatStyle.Popup
        btnSearch.Location = New Point(396, 65)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(57, 25)
        btnSearch.TabIndex = 7
        btnSearch.Text = "Cari"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' dgvTopups
        ' 
        dgvTopups.BackgroundColor = Color.White
        dgvTopups.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvTopups.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4})
        dgvTopups.Location = New Point(12, 65)
        dgvTopups.Name = "dgvTopups"
        dgvTopups.RowHeadersVisible = False
        dgvTopups.RowHeadersWidth = 51
        dgvTopups.ScrollBars = ScrollBars.Vertical
        dgvTopups.Size = New Size(202, 233)
        dgvTopups.TabIndex = 8
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Column1"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.Visible = False
        Column1.Width = 125
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Column2"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.Visible = False
        Column2.Width = 125
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Username"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.Width = 125
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Jumlah"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.Width = 125
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Transparent
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatAppearance.MouseDownBackColor = Color.Transparent
        Button2.FlatAppearance.MouseOverBackColor = Color.Transparent
        Button2.FlatStyle = FlatStyle.Flat
        Button2.ForeColor = Color.Transparent
        Button2.Image = CType(resources.GetObject("Button2.Image"), Image)
        Button2.Location = New Point(431, 10)
        Button2.Margin = New Padding(3, 2, 3, 2)
        Button2.Name = "Button2"
        Button2.Size = New Size(27, 31)
        Button2.TabIndex = 16
        Button2.TabStop = False
        Button2.UseVisualStyleBackColor = False
        ' 
        ' panelHeader
        ' 
        panelHeader.Location = New Point(1, 0)
        panelHeader.Name = "panelHeader"
        panelHeader.Size = New Size(466, 323)
        panelHeader.TabIndex = 17
        ' 
        ' FormApproveTopup
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(468, 317)
        Controls.Add(Button2)
        Controls.Add(dgvTopups)
        Controls.Add(btnSearch)
        Controls.Add(txtSearch)
        Controls.Add(picCoin)
        Controls.Add(btnApprove)
        Controls.Add(btnRefresh)
        Controls.Add(panelDetails)
        Controls.Add(lblTitle)
        Controls.Add(panelHeader)
        Font = New Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ForeColor = SystemColors.ControlText
        FormBorderStyle = FormBorderStyle.None
        Name = "FormApproveTopup"
        Text = "Top-up Approval"
        panelDetails.ResumeLayout(False)
        panelDetails.PerformLayout()
        CType(picCoin, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvTopups, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents panelDetails As Panel
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblCoinAmount As Label
    Friend WithEvents btnApprove As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents picCoin As PictureBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents dgvTopups As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Button2 As Button
    Friend WithEvents panelHeader As Panel
End Class
