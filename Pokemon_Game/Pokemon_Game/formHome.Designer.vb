<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formHome
    Inherits System.Windows.Forms.Form

    Private Sub InitializeComponent()
        Dim TextBox1 As TextBox
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formHome))
        lblCoins = New Label()
        picCoin = New PictureBox()
        btnMyAlbum = New Button()
        btnAllCards = New Button()
        pnlPacksContainer = New Panel()
        Button1 = New Button()
        lblTitle = New Label()
        Home = New Button()
        PictureBox1 = New PictureBox()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Button3 = New Button()
        PictureBox2 = New PictureBox()
        Panel3 = New Panel()
        btnGacha = New Button()
        PictureBox3 = New PictureBox()
        Panel4 = New Panel()
        Button5 = New Button()
        PictureBox4 = New PictureBox()
        btnTopup = New Button()
        TextBox1 = New TextBox()
        CType(picCoin, ComponentModel.ISupportInitialize).BeginInit()
        pnlPacksContainer.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.Location = New Point(39, 25)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(195, 29)
        TextBox1.TabIndex = 0
        TextBox1.Text = "Cari User"
        TextBox1.TextAlign = HorizontalAlignment.Center
        ' 
        ' lblCoins
        ' 
        lblCoins.AutoSize = True
        lblCoins.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblCoins.ForeColor = Color.White
        lblCoins.Location = New Point(95, 20)
        lblCoins.Name = "lblCoins"
        lblCoins.Size = New Size(73, 23)
        lblCoins.TabIndex = 0
        lblCoins.Text = "Coins: 0"
        ' 
        ' picCoin
        ' 
        picCoin.BackColor = Color.WhiteSmoke
        picCoin.Location = New Point(11, 12)
        picCoin.Name = "picCoin"
        picCoin.Size = New Size(32, 32)
        picCoin.SizeMode = PictureBoxSizeMode.StretchImage
        picCoin.TabIndex = 1
        picCoin.TabStop = False
        ' 
        ' btnMyAlbum
        ' 
        btnMyAlbum.BackColor = Color.FromArgb(CByte(4), CByte(6), CByte(8))
        btnMyAlbum.FlatStyle = FlatStyle.Popup
        btnMyAlbum.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnMyAlbum.ForeColor = Color.White
        btnMyAlbum.Location = New Point(3, 204)
        btnMyAlbum.Name = "btnMyAlbum"
        btnMyAlbum.Size = New Size(211, 67)
        btnMyAlbum.TabIndex = 2
        btnMyAlbum.Text = "My Album"
        btnMyAlbum.UseVisualStyleBackColor = False
        ' 
        ' btnAllCards
        ' 
        btnAllCards.BackColor = Color.FromArgb(CByte(4), CByte(6), CByte(8))
        btnAllCards.FlatStyle = FlatStyle.Popup
        btnAllCards.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnAllCards.ForeColor = Color.White
        btnAllCards.Location = New Point(3, 147)
        btnAllCards.Name = "btnAllCards"
        btnAllCards.Size = New Size(211, 67)
        btnAllCards.TabIndex = 4
        btnAllCards.Text = "Lihat Semua Kartu"
        btnAllCards.UseVisualStyleBackColor = False
        ' 
        ' pnlPacksContainer
        ' 
        pnlPacksContainer.BackColor = Color.FromArgb(CByte(12), CByte(12), CByte(12))
        pnlPacksContainer.BorderStyle = BorderStyle.FixedSingle
        pnlPacksContainer.Controls.Add(Button1)
        pnlPacksContainer.Controls.Add(lblTitle)
        pnlPacksContainer.Controls.Add(btnMyAlbum)
        pnlPacksContainer.Controls.Add(Home)
        pnlPacksContainer.Controls.Add(btnAllCards)
        pnlPacksContainer.Location = New Point(-1, 75)
        pnlPacksContainer.Name = "pnlPacksContainer"
        pnlPacksContainer.Size = New Size(216, 341)
        pnlPacksContainer.TabIndex = 14
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(4), CByte(6), CByte(8))
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(-1, 267)
        Button1.Name = "Button1"
        Button1.Size = New Size(213, 67)
        Button1.TabIndex = 16
        Button1.Text = "Logout"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Comic Sans MS", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = Color.WhiteSmoke
        lblTitle.Location = New Point(22, 24)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(177, 29)
        lblTitle.TabIndex = 15
        lblTitle.Text = "Pokémon Anomali"
        lblTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Home
        ' 
        Home.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(32))
        Home.FlatStyle = FlatStyle.Flat
        Home.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        Home.ForeColor = Color.White
        Home.ImageAlign = ContentAlignment.MiddleLeft
        Home.Location = New Point(3, 81)
        Home.Name = "Home"
        Home.Size = New Size(209, 67)
        Home.TabIndex = 5
        Home.Text = "Home"
        Home.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(217, 75)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(722, 340)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 15
        PictureBox1.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(12), CByte(12), CByte(12))
        Panel1.Controls.Add(TextBox1)
        Panel1.Location = New Point(939, 75)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(261, 677)
        Panel1.TabIndex = 16
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(12), CByte(12), CByte(12))
        Panel2.Controls.Add(Button3)
        Panel2.Controls.Add(PictureBox2)
        Panel2.Location = New Point(72, 491)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(170, 212)
        Panel2.TabIndex = 17
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Silver
        Button3.ForeColor = Color.Black
        Button3.Location = New Point(25, 149)
        Button3.Name = "Button3"
        Button3.Size = New Size(123, 35)
        Button3.TabIndex = 23
        Button3.Text = "Beli Kartu"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(24, 33)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(125, 111)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 22
        PictureBox2.TabStop = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(12), CByte(12), CByte(12))
        Panel3.Controls.Add(btnGacha)
        Panel3.Controls.Add(PictureBox3)
        Panel3.Location = New Point(333, 491)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(170, 212)
        Panel3.TabIndex = 18
        ' 
        ' btnGacha
        ' 
        btnGacha.BackColor = Color.Silver
        btnGacha.ForeColor = Color.Black
        btnGacha.Location = New Point(24, 151)
        btnGacha.Name = "btnGacha"
        btnGacha.Size = New Size(123, 35)
        btnGacha.TabIndex = 24
        btnGacha.Text = "Gacha Kartu"
        btnGacha.UseVisualStyleBackColor = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(23, 35)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(125, 111)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 23
        PictureBox3.TabStop = False
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(12), CByte(12), CByte(12))
        Panel4.Controls.Add(Button5)
        Panel4.Controls.Add(PictureBox4)
        Panel4.Location = New Point(614, 491)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(170, 212)
        Panel4.TabIndex = 19
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.Silver
        Button5.ForeColor = Color.Black
        Button5.Location = New Point(25, 151)
        Button5.Name = "Button5"
        Button5.Size = New Size(123, 35)
        Button5.TabIndex = 25
        Button5.Text = "Recycle  Kartu"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(24, 35)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(125, 111)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 24
        PictureBox4.TabStop = False
        ' 
        ' btnTopup
        ' 
        btnTopup.BackColor = Color.Transparent
        btnTopup.FlatAppearance.BorderSize = 0
        btnTopup.FlatAppearance.MouseDownBackColor = Color.Transparent
        btnTopup.FlatAppearance.MouseOverBackColor = Color.Transparent
        btnTopup.FlatStyle = FlatStyle.Flat
        btnTopup.ForeColor = Color.Transparent
        btnTopup.Image = CType(resources.GetObject("btnTopup.Image"), Image)
        btnTopup.Location = New Point(44, 12)
        btnTopup.Name = "btnTopup"
        btnTopup.Size = New Size(46, 37)
        btnTopup.TabIndex = 21
        btnTopup.TabStop = False
        btnTopup.UseVisualStyleBackColor = False
        ' 
        ' formHome
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(15), CByte(10), CByte(0))
        ClientSize = New Size(1200, 749)
        Controls.Add(btnTopup)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(PictureBox1)
        Controls.Add(pnlPacksContainer)
        Controls.Add(picCoin)
        Controls.Add(lblCoins)
        ForeColor = Color.Coral
        FormBorderStyle = FormBorderStyle.None
        MaximizeBox = False
        Name = "formHome"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Pokémon Gacha - Home"
        CType(picCoin, ComponentModel.ISupportInitialize).EndInit()
        pnlPacksContainer.ResumeLayout(False)
        pnlPacksContainer.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblCoins As Label
    Friend WithEvents picCoin As PictureBox
    Friend WithEvents btnMyAlbum As Button
    Friend WithEvents btnAllCards As Button
    Friend WithEvents pnlPacksContainer As Panel
    Friend WithEvents Home As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnTopup As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Button3 As Button
    Friend WithEvents btnGacha As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents TextBox1 As TextBox
End Class
