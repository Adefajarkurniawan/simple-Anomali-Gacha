<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formAllCards
    Inherits System.Windows.Forms.Form

    Private Sub InitializeComponent()
        Me.pnlCardList = New FlowLayoutPanel()
        Me.lblTitle = New Label()
        Me.btnClose = New Button()
        Me.SuspendLayout()

        ' pnlCardList
        Me.pnlCardList.AutoScroll = True
        Me.pnlCardList.BackColor = Color.White
        Me.pnlCardList.Location = New Point(20, 60)
        Me.pnlCardList.Name = "pnlCardList"
        Me.pnlCardList.Size = New Size(740, 450)
        Me.pnlCardList.WrapContents = True
        Me.pnlCardList.FlowDirection = FlowDirection.LeftToRight

        ' lblTitle
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New Font("Segoe UI", 16.0F, FontStyle.Bold, GraphicsUnit.Point)
        Me.lblTitle.Location = New Point(20, 15)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New Size(350, 37)
        Me.lblTitle.Text = "Daftar Semua Kartu Anomali"

        ' btnClose
        Me.btnClose.Text = "Tutup"
        Me.btnClose.Location = New Point(660, 520)
        Me.btnClose.Size = New Size(100, 30)
        Me.btnClose.BackColor = Color.LightGray
        Me.btnClose.FlatStyle = FlatStyle.Flat
        AddHandler Me.btnClose.Click, AddressOf btnClose_Click

        ' formAllCards
        Me.ClientSize = New Size(800, 580)
        Me.Controls.Add(Me.pnlCardList)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnClose)
        Me.FormBorderStyle = FormBorderStyle.None
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.BackColor = Color.WhiteSmoke
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents pnlCardList As FlowLayoutPanel
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnClose As Button
End Class
