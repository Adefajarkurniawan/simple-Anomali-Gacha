<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formLogin
    Inherits System.Windows.Forms.Form

    Private Sub InitializeComponent()
        panelLogin = New Panel()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        btnLogin = New Button()
        btnToRegister = New Button()
        lblUser = New Label()
        lblPass = New Label()
        lblTitle = New Label()
        picLogo = New PictureBox()
        panelLogin.SuspendLayout()
        CType(picLogo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' panelLogin
        ' 
        panelLogin.BackColor = Color.White
        panelLogin.BorderStyle = BorderStyle.FixedSingle
        panelLogin.Controls.Add(txtUsername)
        panelLogin.Controls.Add(txtPassword)
        panelLogin.Controls.Add(btnLogin)
        panelLogin.Controls.Add(btnToRegister)
        panelLogin.Controls.Add(lblUser)
        panelLogin.Controls.Add(lblPass)
        panelLogin.Location = New Point(50, 110)
        panelLogin.Name = "panelLogin"
        panelLogin.Size = New Size(360, 230)
        panelLogin.TabIndex = 0
        ' 
        ' txtUsername
        ' 
        txtUsername.Font = New Font("Segoe UI", 10.0F)
        txtUsername.Location = New Point(30, 50)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(300, 30)
        txtUsername.TabIndex = 0
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Segoe UI", 10.0F)
        txtPassword.Location = New Point(30, 110)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(300, 30)
        txtPassword.TabIndex = 1

        '
        ' Tambahkan di panelLogin.Controls
        '
        chkShowPassword = New CheckBox()
        chkShowPassword.Text = "Lihat Password"
        chkShowPassword.Font = New Font("Segoe UI", 9.0F)
        chkShowPassword.Location = New Point(30, 145)
        chkShowPassword.Size = New Size(150, 20)
        AddHandler chkShowPassword.CheckedChanged, AddressOf chkShowPassword_CheckedChanged
        panelLogin.Controls.Add(chkShowPassword)

        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.Gold
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnLogin.Location = New Point(30, 175)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(130, 40)
        btnLogin.TabIndex = 2
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' btnToRegister
        ' 
        btnToRegister.BackColor = Color.LightSkyBlue
        btnToRegister.FlatStyle = FlatStyle.Flat
        btnToRegister.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnToRegister.Location = New Point(200, 175)
        btnToRegister.Name = "btnToRegister"
        btnToRegister.Size = New Size(130, 40)
        btnToRegister.TabIndex = 3
        btnToRegister.Text = "Register"
        btnToRegister.UseVisualStyleBackColor = False
        ' 
        ' lblUser
        ' 
        lblUser.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblUser.ForeColor = Color.DarkSlateGray
        lblUser.Location = New Point(30, 30)
        lblUser.Name = "lblUser"
        lblUser.Size = New Size(100, 23)
        lblUser.TabIndex = 4
        lblUser.Text = "Username"
        ' 
        ' lblPass
        ' 
        lblPass.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
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
        lblTitle.Font = New Font("Comic Sans MS", 18.0F, FontStyle.Bold)
        lblTitle.ForeColor = Color.DarkBlue
        lblTitle.Location = New Point(80, 70)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(323, 41)
        lblTitle.TabIndex = 4
        lblTitle.Text = "Anomali Gacha Login"
        lblTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' picLogo
        ' 
        picLogo.BackColor = Color.WhiteSmoke
        picLogo.Location = New Point(170, 10)
        picLogo.Name = "picLogo"
        picLogo.Size = New Size(120, 60)
        picLogo.SizeMode = PictureBoxSizeMode.StretchImage
        picLogo.TabIndex = 5
        picLogo.TabStop = False
        ' 
        ' formLogin
        ' 
        BackColor = Color.FromArgb(CByte(240), CByte(248), CByte(255))
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(472, 373)
        Controls.Add(panelLogin)
        Controls.Add(lblTitle)
        Controls.Add(picLogo)
        FormBorderStyle = FormBorderStyle.None
        MaximizeBox = False
        Name = "formLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login - Pokémon Gacha"
        panelLogin.ResumeLayout(False)
        panelLogin.PerformLayout()
        CType(picLogo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnToRegister As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents panelLogin As Panel
    Friend WithEvents lblUser As Label
    Friend WithEvents lblPass As Label
    Friend WithEvents chkShowPassword As CheckBox

End Class