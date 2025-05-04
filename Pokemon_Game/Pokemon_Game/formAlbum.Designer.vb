<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formAlbum
    Inherits System.Windows.Forms.Form

    Private Sub InitializeComponent()
        Me.pnlCardAlbum = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        ' 
        ' pnlCardAlbum
        ' 
        Me.pnlCardAlbum.AutoScroll = True
        Me.pnlCardAlbum.BackColor = System.Drawing.Color.White
        Me.pnlCardAlbum.Location = New System.Drawing.Point(20, 60)
        Me.pnlCardAlbum.Name = "pnlCardAlbum"
        Me.pnlCardAlbum.Size = New System.Drawing.Size(1100, 600)
        Me.pnlCardAlbum.TabIndex = 0
        ' 
        ' lblTitle
        ' 
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.lblTitle.Location = New System.Drawing.Point(20, 15)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(292, 37)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Album Kartu Saya 🌟"
        ' 
        ' formAlbum
        ' 
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1140, 680)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.pnlCardAlbum)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "formAlbum"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Album Kartu - Pokemon Gacha"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlCardAlbum As FlowLayoutPanel
    Friend WithEvents lblTitle As Label
End Class
