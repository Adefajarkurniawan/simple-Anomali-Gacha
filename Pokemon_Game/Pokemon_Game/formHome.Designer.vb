<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formHome
    Inherits System.Windows.Forms.Form

    Private Sub InitializeComponent()
        Me.lblCoins = New System.Windows.Forms.Label()
        Me.picCoin = New System.Windows.Forms.PictureBox()
        Me.btnMyAlbum = New System.Windows.Forms.Button()
        Me.btnAllCards = New System.Windows.Forms.Button()
        Me.btnTopup = New System.Windows.Forms.Button()
        Me.pnlPacksContainer = New System.Windows.Forms.Panel()
        CType(Me.picCoin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' lblCoins
        ' 
        Me.lblCoins.AutoSize = True
        Me.lblCoins.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        Me.lblCoins.ForeColor = Color.DarkSlateGray
        Me.lblCoins.Location = New Point(60, 20)
        Me.lblCoins.Name = "lblCoins"
        Me.lblCoins.Size = New Size(73, 23)
        Me.lblCoins.TabIndex = 0
        Me.lblCoins.Text = "Coins: 0"
        ' 
        ' picCoin
        ' 
        Me.picCoin.BackColor = Color.WhiteSmoke
        Me.picCoin.Location = New Point(20, 15)
        Me.picCoin.Name = "picCoin"
        Me.picCoin.Size = New Size(32, 32)
        Me.picCoin.SizeMode = PictureBoxSizeMode.StretchImage
        Me.picCoin.TabIndex = 1
        Me.picCoin.TabStop = False
        ' 
        ' btnMyAlbum
        ' 
        Me.btnMyAlbum.BackColor = Color.LightSkyBlue
        Me.btnMyAlbum.FlatStyle = FlatStyle.Flat
        Me.btnMyAlbum.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        Me.btnMyAlbum.ForeColor = Color.Black
        Me.btnMyAlbum.Location = New Point(1000, 15)
        Me.btnMyAlbum.Name = "btnMyAlbum"
        Me.btnMyAlbum.Size = New Size(150, 35)
        Me.btnMyAlbum.TabIndex = 2
        Me.btnMyAlbum.Text = "My Album"
        Me.btnMyAlbum.UseVisualStyleBackColor = False
        ' 
        ' btnAllCards
        ' 
        Me.btnAllCards.BackColor = Color.MediumSlateBlue
        Me.btnAllCards.FlatStyle = FlatStyle.Flat
        Me.btnAllCards.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        Me.btnAllCards.ForeColor = Color.White
        Me.btnAllCards.Location = New Point(820, 15)
        Me.btnAllCards.Name = "btnAllCards"
        Me.btnAllCards.Size = New Size(160, 35)
        Me.btnAllCards.TabIndex = 4
        Me.btnAllCards.Text = "Lihat Semua Kartu"
        Me.btnAllCards.UseVisualStyleBackColor = False
        ' 
        ' btnTopup
        ' 
        Me.btnTopup.BackColor = Color.SeaGreen
        Me.btnTopup.FlatStyle = FlatStyle.Flat
        Me.btnTopup.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        Me.btnTopup.ForeColor = Color.White
        Me.btnTopup.Location = New Point(650, 15)
        Me.btnTopup.Name = "btnTopup"
        Me.btnTopup.Size = New Size(160, 35)
        Me.btnTopup.TabIndex = 5
        Me.btnTopup.Text = "Topup Coin"
        Me.btnTopup.UseVisualStyleBackColor = False
        ' 
        ' pnlPacksContainer
        ' 
        Me.pnlPacksContainer.AutoScroll = True
        Me.pnlPacksContainer.BackColor = Color.White
        Me.pnlPacksContainer.BorderStyle = BorderStyle.FixedSingle
        Me.pnlPacksContainer.Location = New Point(20, 60)
        Me.pnlPacksContainer.Name = "pnlPacksContainer"
        Me.pnlPacksContainer.Size = New Size(1130, 600)
        Me.pnlPacksContainer.TabIndex = 3
        ' 
        ' formHome
        ' 
        Me.AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.BackColor = Color.FromArgb(CByte(240), CByte(248), CByte(255))
        Me.ClientSize = New Size(1182, 703)
        Me.Controls.Add(Me.btnTopup)
        Me.Controls.Add(Me.btnAllCards)
        Me.Controls.Add(Me.pnlPacksContainer)
        Me.Controls.Add(Me.btnMyAlbum)
        Me.Controls.Add(Me.picCoin)
        Me.Controls.Add(Me.lblCoins)
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "formHome"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Text = "Pokémon Gacha - Home"
        CType(Me.picCoin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents lblCoins As Label
    Friend WithEvents picCoin As PictureBox
    Friend WithEvents btnMyAlbum As Button
    Friend WithEvents btnAllCards As Button
    Friend WithEvents btnTopup As Button
    Friend WithEvents pnlPacksContainer As Panel
End Class
