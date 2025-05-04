<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formAllCards
    Inherits System.Windows.Forms.Form

    Private Sub InitializeComponent()
        Me.flowCards = New FlowLayoutPanel()
        Me.btnClose = New Button()
        Me.SuspendLayout()
        '
        ' flowCards
        '
        Me.flowCards.AutoScroll = True
        Me.flowCards.BackColor = Color.White
        Me.flowCards.Location = New Point(20, 20)
        Me.flowCards.Name = "flowCards"
        Me.flowCards.Size = New Size(740, 450)
        Me.flowCards.WrapContents = True
        Me.flowCards.FlowDirection = FlowDirection.LeftToRight
        '
        ' btnClose
        '
        Me.btnClose.Text = "Tutup"
        Me.btnClose.Location = New Point(660, 480)
        Me.btnClose.Size = New Size(100, 30)
        Me.btnClose.BackColor = Color.LightGray
        AddHandler Me.btnClose.Click, AddressOf btnClose_Click
        '
        ' formAllCards
        '
        Me.ClientSize = New Size(800, 530)
        Me.Controls.Add(Me.flowCards)
        Me.Controls.Add(Me.btnClose)
        Me.Name = "formAllCards"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Text = "Daftar Semua Kartu Pokémon"
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents flowCards As FlowLayoutPanel
    Friend WithEvents btnClose As Button
End Class
