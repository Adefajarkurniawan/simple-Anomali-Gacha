<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formRecycle
    Inherits System.Windows.Forms.Form

    Private Sub InitializeComponent()
        pnlCardList = New FlowLayoutPanel()
        lblTitle = New Label()
        lblCoins = New Label()
        btnClose = New Button()
        SuspendLayout()
        ' 
        ' pnlCardList
        ' 
        pnlCardList.AutoScroll = True
        pnlCardList.BackColor = Color.White
        pnlCardList.Location = New Point(20, 70)
        pnlCardList.Name = "pnlCardList"
        pnlCardList.Size = New Size(760, 420)
        pnlCardList.TabIndex = 0
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 18.0F, FontStyle.Bold)
        lblTitle.Location = New Point(20, 15)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(347, 41)
        lblTitle.TabIndex = 1
        lblTitle.Text = "Recycle Kartu Pokémon"
        ' 
        ' lblCoins
        ' 
        lblCoins.AutoSize = True
        lblCoins.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        lblCoins.Location = New Point(600, 20)
        lblCoins.Name = "lblCoins"
        lblCoins.Size = New Size(86, 28)
        lblCoins.TabIndex = 2
        lblCoins.Text = "Coins: 0"
        ' 
        ' btnClose
        ' 
        btnClose.BackColor = Color.LightGray
        btnClose.FlatStyle = FlatStyle.Flat
        btnClose.Location = New Point(680, 496)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(100, 30)
        btnClose.TabIndex = 4
        btnClose.Text = "Tutup"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' formRecycle
        ' 
        ClientSize = New Size(800, 530)
        Controls.Add(btnClose)
        Controls.Add(lblTitle)
        Controls.Add(lblCoins)
        Controls.Add(pnlCardList)
        FormBorderStyle = FormBorderStyle.None
        Name = "formRecycle"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Recycle Kartu - Pokémon Gacha"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pnlCardList As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblCoins As System.Windows.Forms.Label
    Friend WithEvents btnClose As Button
End Class
