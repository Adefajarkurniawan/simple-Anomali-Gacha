<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formRegis
    Inherits System.Windows.Forms.Form

    Private Sub InitializeComponent()
        panelRegis = New Panel()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        btnRegister = New Button()
        btnToLogin = New Button()
        lblUser = New Label()
        lblPass = New Label()
        lblTitle = New Label()
        picLogo = New PictureBox()
        panelRegis.SuspendLayout()
        CType(picLogo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' panelRegis
        ' 
        panelRegis.BackColor = Color.White
        panelRegis.BorderStyle = BorderStyle.FixedSingle
        panelRegis.Controls.Add(txtUsername)
        panelRegis.Controls.Add(txtPassword)
        panelRegis.Controls.Add(btnRegister)
        panelRegis.Controls.Add(btnToLogin)
        panelRegis.Controls.Add(lblUser)
        panelRegis.Controls.Add(lblPass)
        panelRegis.Location = New Point(100, 130)
        panelRegis.Name = "panelRegis"
        panelRegis.Size = New Size(400, 230)
        panelRegis.TabIndex = 0
        ' 
        ' txtUsername
        ' 
        txtUsername.Font = New Font("Segoe UI", 10F)
        txtUsername.Location = New Point(30, 50)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(340, 25)
        txtUsername.TabIndex = 0
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Segoe UI", 10F)
        txtPassword.Location = New Point(30, 110)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(340, 25)
        txtPassword.TabIndex = 1
        ' 
        ' btnRegister
        ' 
        btnRegister.BackColor = Color.Gold
        btnRegister.FlatStyle = FlatStyle.Flat
        btnRegister.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnRegister.Location = New Point(30, 160)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(150, 40)
        btnRegister.TabIndex = 2
        btnRegister.Text = "Register"
        btnRegister.UseVisualStyleBackColor = False
        ' 
        ' btnToLogin
        ' 
        btnToLogin.BackColor = Color.LightSkyBlue
        btnToLogin.FlatStyle = FlatStyle.Flat
        btnToLogin.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnToLogin.Location = New Point(220, 160)
        btnToLogin.Name = "btnToLogin"
        btnToLogin.Size = New Size(150, 40)
        btnToLogin.TabIndex = 3
        btnToLogin.Text = "Back to Login"
        btnToLogin.UseVisualStyleBackColor = False
        ' 
        ' lblUser
        ' 
        lblUser.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblUser.ForeColor = Color.DarkSlateGray
        lblUser.Location = New Point(30, 30)
        lblUser.Name = "lblUser"
        lblUser.Size = New Size(100, 23)
        lblUser.TabIndex = 4
        lblUser.Text = "Username"
        ' 
        ' lblPass
        ' 
        lblPass.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblPass.ForeColor = Color.DarkSlateGray
        lblPass.Location = New Point(30, 90)
        lblPass.Name = "lblPass"
        lblPass.Size = New Size(100, 23)
        lblPass.TabIndex = 5
        lblPass.Text = "Password"
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Comic Sans MS", 18F, FontStyle.Bold)
        lblTitle.ForeColor = Color.DarkBlue
        lblTitle.Location = New Point(172, 73)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(260, 35)
        lblTitle.TabIndex = 6
        lblTitle.Text = "Pokémon Gacha Regis"
        lblTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' picLogo
        ' 
        picLogo.BackColor = Color.WhiteSmoke
        picLogo.Location = New Point(240, 10)
        picLogo.Name = "picLogo"
        picLogo.Size = New Size(120, 60)
        picLogo.SizeMode = PictureBoxSizeMode.StretchImage
        picLogo.TabIndex = 7
        picLogo.TabStop = False
        ' 
        ' formRegis
        ' 
        BackColor = Color.FromArgb(CByte(240), CByte(248), CByte(255))
        ClientSize = New Size(600, 400)
        Controls.Add(panelRegis)
        Controls.Add(lblTitle)
        Controls.Add(picLogo)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "formRegis"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Register - Pokémon Gacha"
        panelRegis.ResumeLayout(False)
        panelRegis.PerformLayout()
        CType(picLogo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnRegister As Button
    Friend WithEvents btnToLogin As Button
    Friend WithEvents lblUser As Label
    Friend WithEvents lblPass As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents panelRegis As Panel
End Class
