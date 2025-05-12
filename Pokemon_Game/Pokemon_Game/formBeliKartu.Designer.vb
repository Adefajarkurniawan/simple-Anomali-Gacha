<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formBeliKartu
    Inherits System.Windows.Forms.Form

    Private Sub InitializeComponent()
        Me.pnlAvailableCards = New FlowLayoutPanel()
        Me.lblTitle = New Label()
        Me.lblCoins = New Label()
        Me.btnClose = New Button()

        ' pnlAvailableCards
        pnlAvailableCards.AutoScroll = True
        pnlAvailableCards.BackColor = Color.White
        pnlAvailableCards.Location = New Point(20, 70)
        pnlAvailableCards.Size = New Size(760, 420)

        ' lblTitle
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 18.0F, FontStyle.Bold)
        lblTitle.Text = "Beli Kartu Anomali"
        lblTitle.Location = New Point(20, 15)

        ' lblCoins
        lblCoins.AutoSize = True
        lblCoins.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        lblCoins.Location = New Point(600, 20)
        lblCoins.Text = "Coins: 0"

        ' Button Close
        btnClose.Text = "Tutup"
        btnClose.Location = New Point(650, 510)
        btnClose.Size = New Size(100, 30)
        btnClose.BackColor = Color.LightGray
        btnClose.FlatStyle = FlatStyle.Flat
        AddHandler btnClose.Click, AddressOf btnClose_Click

        ' formBeliKartu
        Me.ClientSize = New Size(800, 550)
        Me.Controls.Add(lblTitle)
        Me.Controls.Add(lblCoins)
        Me.Controls.Add(pnlAvailableCards)
        Me.Controls.Add(btnClose)
        Me.FormBorderStyle = FormBorderStyle.None
        Me.BackColor = Color.WhiteSmoke
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents pnlAvailableCards As FlowLayoutPanel
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblCoins As Label
    Friend WithEvents btnClose As Button
End Class
