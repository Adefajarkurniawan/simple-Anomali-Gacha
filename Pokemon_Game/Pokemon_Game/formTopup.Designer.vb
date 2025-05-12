<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formTopup
    Inherits System.Windows.Forms.Form

    Private Sub InitializeComponent()
        lblTitle = New Label()
        txtAmount = New TextBox()
        btnTopup = New Button()
        btnClose = New Button()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        lblTitle.ForeColor = Color.DarkSlateBlue
        lblTitle.Location = New Point(26, 15)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(218, 25)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Masukkan Jumlah Coin"
        ' 
        ' txtAmount
        ' 
        txtAmount.Font = New Font("Segoe UI", 13.0F)
        txtAmount.Location = New Point(31, 52)
        txtAmount.Margin = New Padding(3, 2, 3, 2)
        txtAmount.Name = "txtAmount"
        txtAmount.Size = New Size(237, 31)
        txtAmount.TabIndex = 0
        txtAmount.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnTopup
        ' 
        btnTopup.BackColor = Color.SeaGreen
        btnTopup.FlatStyle = FlatStyle.Flat
        btnTopup.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        btnTopup.ForeColor = Color.White
        btnTopup.Location = New Point(31, 98)
        btnTopup.Margin = New Padding(3, 2, 3, 2)
        btnTopup.Name = "btnTopup"
        btnTopup.Size = New Size(236, 34)
        btnTopup.TabIndex = 1
        btnTopup.Text = "Topup Sekarang"
        btnTopup.UseVisualStyleBackColor = False
        ' 
        ' btnClose
        ' 
        btnClose.BackColor = Color.Transparent
        btnClose.FlatStyle = FlatStyle.Flat
        btnClose.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnClose.ForeColor = Color.DarkRed
        btnClose.Location = New Point(271, 8)
        btnClose.Margin = New Padding(3, 2, 3, 2)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(26, 22)
        btnClose.TabIndex = 2
        btnClose.Text = "X"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' formTopup
        ' 
        AcceptButton = btnTopup
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(315, 150)
        Controls.Add(lblTitle)
        Controls.Add(txtAmount)
        Controls.Add(btnTopup)
        Controls.Add(btnClose)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 2, 3, 2)
        Name = "formTopup"
        StartPosition = FormStartPosition.CenterParent
        Text = "Topup Coin"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents btnTopup As Button
    Friend WithEvents btnClose As Button
End Class