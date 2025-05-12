<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formGiftCard
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formGiftCard))
        txtUsername = New TextBox()
        lblUserInfo = New Label()
        Label2 = New Label()
        cbKartu = New ComboBox()
        Label3 = New Label()
        txtJumlah = New TextBox()
        dgvUsers = New DataGridView()
        dgvCard = New DataGridView()
        btnBerikan = New Button()
        btnCari = New Button()
        Panel1 = New Panel()
        Button2 = New Button()
        panelHeader = New Panel()
        CType(dgvUsers, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvCard, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(15, 42)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(238, 24)
        txtUsername.TabIndex = 1
        ' 
        ' lblUserInfo
        ' 
        lblUserInfo.AutoSize = True
        lblUserInfo.Location = New Point(15, 67)
        lblUserInfo.Name = "lblUserInfo"
        lblUserInfo.Size = New Size(0, 16)
        lblUserInfo.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(46, 8)
        Label2.Name = "Label2"
        Label2.Size = New Size(76, 19)
        Label2.TabIndex = 4
        Label2.Text = "Pilih Kartu"
        ' 
        ' cbKartu
        ' 
        cbKartu.DropDownStyle = ComboBoxStyle.DropDownList
        cbKartu.FormattingEnabled = True
        cbKartu.Location = New Point(46, 28)
        cbKartu.Name = "cbKartu"
        cbKartu.Size = New Size(207, 24)
        cbKartu.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(46, 58)
        Label3.Name = "Label3"
        Label3.Size = New Size(119, 19)
        Label3.TabIndex = 6
        Label3.Text = "Jumlah Diberikan"
        ' 
        ' txtJumlah
        ' 
        txtJumlah.Location = New Point(46, 78)
        txtJumlah.Name = "txtJumlah"
        txtJumlah.Size = New Size(100, 24)
        txtJumlah.TabIndex = 7
        ' 
        ' dgvUsers
        ' 
        dgvUsers.AllowUserToAddRows = False
        dgvUsers.AllowUserToDeleteRows = False
        dgvUsers.AllowUserToResizeColumns = False
        dgvUsers.AllowUserToResizeRows = False
        dgvUsers.BackgroundColor = Color.White
        dgvUsers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvUsers.ColumnHeadersVisible = False
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Window
        DataGridViewCellStyle1.Font = New Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = Color.Black
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.ButtonShadow
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.False
        dgvUsers.DefaultCellStyle = DataGridViewCellStyle1
        dgvUsers.GridColor = Color.White
        dgvUsers.Location = New Point(15, 79)
        dgvUsers.Name = "dgvUsers"
        dgvUsers.ReadOnly = True
        dgvUsers.RowHeadersVisible = False
        dgvUsers.ScrollBars = ScrollBars.Vertical
        dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvUsers.Size = New Size(103, 117)
        dgvUsers.TabIndex = 9
        ' 
        ' dgvCard
        ' 
        dgvCard.AllowUserToDeleteRows = False
        dgvCard.AllowUserToResizeColumns = False
        dgvCard.AllowUserToResizeRows = False
        dgvCard.BackgroundColor = Color.White
        dgvCard.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        dgvCard.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = Color.Black
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.ButtonShadow
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvCard.DefaultCellStyle = DataGridViewCellStyle2
        dgvCard.GridColor = Color.White
        dgvCard.Location = New Point(124, 79)
        dgvCard.MultiSelect = False
        dgvCard.Name = "dgvCard"
        dgvCard.ReadOnly = True
        dgvCard.RowHeadersVisible = False
        dgvCard.ScrollBars = ScrollBars.None
        dgvCard.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvCard.Size = New Size(192, 117)
        dgvCard.TabIndex = 12
        ' 
        ' btnBerikan
        ' 
        btnBerikan.BackColor = Color.Gold
        btnBerikan.FlatStyle = FlatStyle.Flat
        btnBerikan.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnBerikan.Location = New Point(175, 73)
        btnBerikan.Name = "btnBerikan"
        btnBerikan.Size = New Size(78, 29)
        btnBerikan.TabIndex = 12
        btnBerikan.Text = "Gift"
        btnBerikan.UseVisualStyleBackColor = False
        ' 
        ' btnCari
        ' 
        btnCari.BackColor = Color.Gold
        btnCari.FlatStyle = FlatStyle.Flat
        btnCari.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCari.Location = New Point(259, 41)
        btnCari.Name = "btnCari"
        btnCari.Size = New Size(57, 24)
        btnCari.TabIndex = 13
        btnCari.Text = "Cari"
        btnCari.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(cbKartu)
        Panel1.Controls.Add(btnBerikan)
        Panel1.Controls.Add(txtJumlah)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(15, 205)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(301, 117)
        Panel1.TabIndex = 14
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
        Button2.Location = New Point(299, 2)
        Button2.Margin = New Padding(3, 2, 3, 2)
        Button2.Name = "Button2"
        Button2.Size = New Size(27, 31)
        Button2.TabIndex = 15
        Button2.TabStop = False
        Button2.UseVisualStyleBackColor = False
        ' 
        ' panelHeader
        ' 
        panelHeader.Location = New Point(0, 2)
        panelHeader.Name = "panelHeader"
        panelHeader.Size = New Size(340, 354)
        panelHeader.TabIndex = 16
        ' 
        ' formGiftCard
        ' 
        BackColor = Color.Black
        ClientSize = New Size(333, 345)
        Controls.Add(Button2)
        Controls.Add(Panel1)
        Controls.Add(btnCari)
        Controls.Add(dgvCard)
        Controls.Add(dgvUsers)
        Controls.Add(lblUserInfo)
        Controls.Add(txtUsername)
        Controls.Add(panelHeader)
        Font = New Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.None
        MaximizeBox = False
        MinimizeBox = False
        Name = "formGiftCard"
        Text = "Admin Gift Card"
        CType(dgvUsers, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvCard, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lblUserInfo As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cbKartu As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtJumlah As TextBox
    Friend WithEvents dgvUsers As DataGridView
    Friend WithEvents dgvCard As DataGridView
    Friend WithEvents btnBerikan As Button
    Friend WithEvents btnCari As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents panelHeader As Panel
End Class
