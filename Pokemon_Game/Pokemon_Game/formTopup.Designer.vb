<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formTopup
    Inherits System.Windows.Forms.Form

    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.btnTopup = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        ' lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New Font("Segoe UI", 14.0!, FontStyle.Bold)
        Me.lblTitle.ForeColor = Color.DarkSlateBlue
        Me.lblTitle.Location = New Point(30, 20)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New Size(260, 32)
        Me.lblTitle.Text = "Masukkan Jumlah Coin"
        '
        ' txtAmount
        '
        Me.txtAmount.Font = New Font("Segoe UI", 13.0!)
        Me.txtAmount.Location = New Point(35, 70)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New Size(270, 36)
        Me.txtAmount.TabIndex = 0
        Me.txtAmount.TextAlign = HorizontalAlignment.Center
        '
        ' btnTopup
        '
        Me.btnTopup.BackColor = Color.SeaGreen
        Me.btnTopup.FlatStyle = FlatStyle.Flat
        Me.btnTopup.Font = New Font("Segoe UI", 12.0!, FontStyle.Bold)
        Me.btnTopup.ForeColor = Color.White
        Me.btnTopup.Location = New Point(35, 130)
        Me.btnTopup.Name = "btnTopup"
        Me.btnTopup.Size = New Size(270, 45)
        Me.btnTopup.TabIndex = 1
        Me.btnTopup.Text = "Topup Sekarang"
        Me.btnTopup.UseVisualStyleBackColor = False
        '
        ' btnClose
        '
        Me.btnClose.Text = "X"
        Me.btnClose.Font = New Font("Segoe UI", 9.0!, FontStyle.Bold)
        Me.btnClose.ForeColor = Color.DarkRed
        Me.btnClose.FlatStyle = FlatStyle.Flat
        Me.btnClose.Location = New Point(310, 10)
        Me.btnClose.Size = New Size(30, 30)
        Me.btnClose.BackColor = Color.Transparent
        Me.btnClose.Name = "btnClose"
        '
        ' formTopup
        '
        Me.AcceptButton = Me.btnTopup
        Me.AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.BackColor = Color.White
        Me.ClientSize = New Size(360, 200)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.btnTopup)
        Me.Controls.Add(Me.btnClose)
        Me.FormBorderStyle = FormBorderStyle.None
        Me.Name = "formTopup"
        Me.StartPosition = FormStartPosition.CenterParent
        Me.Text = "Topup Coin"
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents btnTopup As Button
    Friend WithEvents btnClose As Button
End Class