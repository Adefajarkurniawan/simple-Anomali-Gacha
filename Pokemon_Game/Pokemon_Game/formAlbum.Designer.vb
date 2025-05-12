<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formAlbum
    Inherits System.Windows.Forms.Form

    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formAlbum))
        pnlCardAlbum = New FlowLayoutPanel()
        lblTitle = New Label()
        btnPrint = New Button()
        PrintDocument1 = New Printing.PrintDocument()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        btnClose = New Button()
        SuspendLayout()
        ' 
        ' pnlCardAlbum
        ' 
        pnlCardAlbum.AutoScroll = True
        pnlCardAlbum.BackColor = Color.White
        pnlCardAlbum.Location = New Point(20, 60)
        pnlCardAlbum.Name = "pnlCardAlbum"
        pnlCardAlbum.Size = New Size(1100, 600)
        pnlCardAlbum.TabIndex = 2
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 18.0F, FontStyle.Bold)
        lblTitle.Location = New Point(20, 10)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(321, 41)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Album Kartu Saya 🌟"
        lblTitle.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' btnPrint
        ' 
        btnPrint.Location = New Point(980, 20)
        btnPrint.Name = "btnPrint"
        btnPrint.Size = New Size(100, 30)
        btnPrint.TabIndex = 1
        btnPrint.Text = "Print Album"
        ' 
        ' PrintDocument1
        ' 
        ' 
        ' PrintPreviewDialog1
        ' 
        PrintPreviewDialog1.AutoScrollMargin = New Size(0, 0)
        PrintPreviewDialog1.AutoScrollMinSize = New Size(0, 0)
        PrintPreviewDialog1.ClientSize = New Size(800, 600)
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.Enabled = True
        PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), Icon)
        PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        PrintPreviewDialog1.Visible = False
        ' 
        ' btnClose
        ' 
        btnClose.BackColor = Color.LightGray
        btnClose.FlatStyle = FlatStyle.Flat
        btnClose.Location = New Point(1020, 666)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(100, 30)
        btnClose.TabIndex = 4
        btnClose.Text = "Tutup"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' formAlbum
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(240), CByte(248), CByte(255))
        ClientSize = New Size(1140, 700)
        Controls.Add(btnClose)
        Controls.Add(lblTitle)
        Controls.Add(btnPrint)
        Controls.Add(pnlCardAlbum)
        FormBorderStyle = FormBorderStyle.None
        MaximizeBox = False
        Name = "formAlbum"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Album Kartu - Pokemon Gacha"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pnlCardAlbum As FlowLayoutPanel
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnPrint As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents btnClose As Button
End Class