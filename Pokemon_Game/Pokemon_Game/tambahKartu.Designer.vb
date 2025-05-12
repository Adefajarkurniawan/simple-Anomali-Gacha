<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class tambahKartu
    Inherits System.Windows.Forms.Form

    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(tambahKartu))
        lblTitle = New Label()
        txtName = New TextBox()
        txtType = New TextBox()
        txtRarity = New TextBox()
        txtImagePath = New TextBox()
        btnAdd = New Button()
        btnEdit = New Button()
        btnDelete = New Button()
        lstCards = New ListView()
        pnlControls = New Panel()
        btnUpload = New Button()
        PictureBox1 = New PictureBox()
        Panel1 = New Panel()
        FolderBrowserDialog1 = New FolderBrowserDialog()
        Button2 = New Button()
        panelHeader = New Panel()
        pnlControls.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.Font = New Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(20, 13)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(151, 37)
        lblTitle.TabIndex = 0
        lblTitle.Text = "🎴 Add Card"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(30, 222)
        txtName.Name = "txtName"
        txtName.PlaceholderText = "Card Name"
        txtName.Size = New Size(206, 24)
        txtName.TabIndex = 0
        ' 
        ' txtType
        ' 
        txtType.Location = New Point(30, 262)
        txtType.Name = "txtType"
        txtType.PlaceholderText = "Type"
        txtType.Size = New Size(206, 24)
        txtType.TabIndex = 1
        ' 
        ' txtRarity
        ' 
        txtRarity.AutoCompleteMode = AutoCompleteMode.Suggest
        txtRarity.Location = New Point(30, 302)
        txtRarity.Name = "txtRarity"
        txtRarity.PlaceholderText = "Rarity"
        txtRarity.Size = New Size(206, 24)
        txtRarity.TabIndex = 2
        ' 
        ' txtImagePath
        ' 
        txtImagePath.Location = New Point(351, 329)
        txtImagePath.Name = "txtImagePath"
        txtImagePath.PlaceholderText = "Image Path"
        txtImagePath.Size = New Size(206, 24)
        txtImagePath.TabIndex = 3
        '
        ' txtPrice
        '
        txtPrice = New TextBox()
        txtPrice.Location = New Point(30, 342)
        txtPrice.Name = "txtPrice"
        txtPrice.PlaceholderText = "Card Price"
        txtPrice.Size = New Size(206, 24)
        txtPrice.TabIndex = 4
        '
        ' btnAdd
        '
        btnAdd = New Button()
        btnAdd.BackColor = Color.Gold
        btnAdd.FlatStyle = FlatStyle.Popup
        btnAdd.Location = New Point(30, 382)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(59, 30)
        btnAdd.TabIndex = 5
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = False

        ' Adding controls to panel
        pnlControls.Controls.Add(txtPrice)
        pnlControls.Controls.Add(btnAdd)

        ' 
        ' btnEdit
        ' 
        btnEdit.BackColor = Color.LightSeaGreen
        btnEdit.FlatStyle = FlatStyle.Popup
        btnEdit.Location = New Point(104, 342)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(59, 30)
        btnEdit.TabIndex = 5
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.Red
        btnDelete.FlatStyle = FlatStyle.Popup
        btnDelete.Location = New Point(177, 342)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(59, 30)
        btnDelete.TabIndex = 6
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' lstCards
        ' 
        lstCards.Location = New Point(302, 60)
        lstCards.Name = "lstCards"
        lstCards.Size = New Size(299, 402)
        lstCards.TabIndex = 2
        lstCards.UseCompatibleStateImageBehavior = False
        lstCards.View = View.Details
        ' 
        ' pnlControls
        ' 
        pnlControls.BackColor = Color.White
        pnlControls.Controls.Add(btnUpload)
        pnlControls.Controls.Add(PictureBox1)
        pnlControls.Controls.Add(txtName)
        pnlControls.Controls.Add(txtType)
        pnlControls.Controls.Add(txtRarity)
        pnlControls.Controls.Add(btnDelete)
        pnlControls.Controls.Add(btnEdit)
        pnlControls.Controls.Add(btnAdd)
        pnlControls.Controls.Add(Panel1)
        pnlControls.Location = New Point(20, 60)
        pnlControls.Name = "pnlControls"
        pnlControls.Size = New Size(267, 402)
        pnlControls.TabIndex = 1
        ' 
        ' btnUpload
        ' 
        btnUpload.BackColor = Color.LightSeaGreen
        btnUpload.FlatStyle = FlatStyle.Popup
        btnUpload.Location = New Point(104, 156)
        btnUpload.Name = "btnUpload"
        btnUpload.Size = New Size(59, 25)
        btnUpload.TabIndex = 8
        btnUpload.Text = "Upload"
        btnUpload.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(33, 34)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(200, 164)
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Location = New Point(30, 31)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(206, 170)
        Panel1.TabIndex = 9
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
        Button2.Location = New Point(592, 8)
        Button2.Margin = New Padding(3, 2, 3, 2)
        Button2.Name = "Button2"
        Button2.Size = New Size(27, 31)
        Button2.TabIndex = 17
        Button2.TabStop = False
        Button2.UseVisualStyleBackColor = False
        ' 
        ' panelHeader
        ' 
        panelHeader.Location = New Point(0, 1)
        panelHeader.Name = "panelHeader"
        panelHeader.Size = New Size(630, 493)
        panelHeader.TabIndex = 18
        ' 
        ' tambahKartu
        ' 
        BackColor = Color.Black
        ClientSize = New Size(627, 494)
        Controls.Add(Button2)
        Controls.Add(lblTitle)
        Controls.Add(pnlControls)
        Controls.Add(lstCards)
        Controls.Add(txtImagePath)
        Controls.Add(panelHeader)
        Font = New Font("Comic Sans MS", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.None
        Name = "tambahKartu"
        Text = "CRUD Pack"
        pnlControls.ResumeLayout(False)
        pnlControls.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtType As TextBox
    Friend WithEvents txtRarity As TextBox
    Friend WithEvents txtImagePath As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents lstPacks As ListView
    Friend WithEvents pnlControls As Panel
    Friend WithEvents lstCards As ListView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents btnUpload As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents panelHeader As Panel
    Friend WithEvents txtPrice As TextBox
End Class
