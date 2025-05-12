
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formAdmin
    Inherits System.Windows.Forms.Form

    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formAdmin))
        pnlHeader = New Panel()
        Button4 = New Button()
        lblHeader = New Label()
        pnlSidebar = New Panel()
        btnLogout = New Button()
        Button3 = New Button()
        btnTopup = New Button()
        Button2 = New Button()
        Button1 = New Button()
        btnCrudPack = New Button()
        btnCrudCard = New Button()
        pnlMain = New Panel()
        lblTitle = New Label()
        lblStat1 = New Label()
        lblStat2 = New Label()
        lblStat3 = New Label()
        lblStat4 = New Label()
        lblStat5 = New Label()
        pnlHeader.SuspendLayout()
        pnlSidebar.SuspendLayout()
        pnlMain.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.DarkBlue
        pnlHeader.Controls.Add(Button4)
        pnlHeader.Controls.Add(lblHeader)
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(1200, 60)
        pnlHeader.TabIndex = 0
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.LightSeaGreen
        Button4.FlatAppearance.BorderSize = 0
        Button4.FlatAppearance.MouseDownBackColor = Color.Transparent
        Button4.FlatAppearance.MouseOverBackColor = Color.Transparent
        Button4.FlatStyle = FlatStyle.Flat
        Button4.ForeColor = Color.Transparent
        Button4.Image = CType(resources.GetObject("Button4.Image"), Image)
        Button4.Location = New Point(1161, 11)
        Button4.Margin = New Padding(3, 2, 3, 2)
        Button4.Name = "Button4"
        Button4.Size = New Size(27, 31)
        Button4.TabIndex = 16
        Button4.TabStop = False
        Button4.UseVisualStyleBackColor = False
        ' 
        ' lblHeader
        ' 
        lblHeader.BackColor = Color.LightSeaGreen
        lblHeader.Font = New Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHeader.ForeColor = Color.Gold
        lblHeader.Location = New Point(0, 0)
        lblHeader.Name = "lblHeader"
        lblHeader.Size = New Size(1200, 60)
        lblHeader.TabIndex = 0
        lblHeader.Text = "Admin Dashboard - Pokémon Gacha"
        lblHeader.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' pnlSidebar
        ' 
        pnlSidebar.BackColor = Color.Black
        pnlSidebar.Controls.Add(btnLogout)
        pnlSidebar.Controls.Add(Button3)
        pnlSidebar.Controls.Add(btnTopup)
        pnlSidebar.Controls.Add(Button2)
        pnlSidebar.Controls.Add(Button1)
        pnlSidebar.Controls.Add(btnCrudPack)
        pnlSidebar.Controls.Add(btnCrudCard)
        pnlSidebar.Location = New Point(0, 60)
        pnlSidebar.Name = "pnlSidebar"
        pnlSidebar.Size = New Size(250, 640)
        pnlSidebar.TabIndex = 1
        ' 
        ' btnLogout
        ' 
        btnLogout.BackColor = Color.Red
        btnLogout.FlatStyle = FlatStyle.Popup
        btnLogout.Font = New Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogout.ForeColor = Color.White
        btnLogout.Location = New Point(15, 547)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(220, 37)
        btnLogout.TabIndex = 12
        btnLogout.Text = "Logout"
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Gold
        Button3.FlatStyle = FlatStyle.Popup
        Button3.Font = New Font("Comic Sans MS", 11.25F, FontStyle.Bold)
        Button3.Location = New Point(15, 334)
        Button3.Name = "Button3"
        Button3.Size = New Size(220, 40)
        Button3.TabIndex = 6
        Button3.Text = "🎴 Gift Card"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' btnTopup
        ' 
        btnTopup.BackColor = Color.Gold
        btnTopup.FlatStyle = FlatStyle.Popup
        btnTopup.Font = New Font("Comic Sans MS", 11.25F, FontStyle.Bold)
        btnTopup.Location = New Point(15, 288)
        btnTopup.Name = "btnTopup"
        btnTopup.Size = New Size(220, 40)
        btnTopup.TabIndex = 5
        btnTopup.Text = ChrW(55358) & ChrW(56985) & "  Kelola Topup"
        btnTopup.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Gold
        Button2.FlatStyle = FlatStyle.Popup
        Button2.Font = New Font("Comic Sans MS", 11.25F, FontStyle.Bold)
        Button2.Location = New Point(15, 242)
        Button2.Name = "Button2"
        Button2.Size = New Size(220, 40)
        Button2.TabIndex = 4
        Button2.Text = ChrW(55358) & ChrW(56809) & " Kelola Event"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Gold
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Comic Sans MS", 11.25F, FontStyle.Bold)
        Button1.Location = New Point(15, 196)
        Button1.Name = "Button1"
        Button1.Size = New Size(220, 40)
        Button1.TabIndex = 3
        Button1.Text = ChrW(55358) & ChrW(56809) & " Tambah Card"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' btnCrudPack
        ' 
        btnCrudPack.BackColor = Color.Gold
        btnCrudPack.FlatStyle = FlatStyle.Popup
        btnCrudPack.Font = New Font("Comic Sans MS", 11.25F, FontStyle.Bold)
        btnCrudPack.Location = New Point(15, 100)
        btnCrudPack.Name = "btnCrudPack"
        btnCrudPack.Size = New Size(220, 40)
        btnCrudPack.TabIndex = 0
        btnCrudPack.Text = ChrW(55358) & ChrW(56809) & " Kelola Packs"
        btnCrudPack.UseVisualStyleBackColor = False
        ' 
        ' btnCrudCard
        ' 
        btnCrudCard.BackColor = Color.Gold
        btnCrudCard.FlatStyle = FlatStyle.Popup
        btnCrudCard.Font = New Font("Comic Sans MS", 11.25F, FontStyle.Bold)
        btnCrudCard.Location = New Point(15, 150)
        btnCrudCard.Name = "btnCrudCard"
        btnCrudCard.Size = New Size(220, 40)
        btnCrudCard.TabIndex = 1
        btnCrudCard.Text = "🎴 Kelola Cards"
        btnCrudCard.UseVisualStyleBackColor = False
        ' 
        ' pnlMain
        ' 
        pnlMain.BackColor = Color.Black
        pnlMain.BorderStyle = BorderStyle.FixedSingle
        pnlMain.Controls.Add(lblTitle)
        pnlMain.Location = New Point(251, 60)
        pnlMain.Name = "pnlMain"
        pnlMain.Size = New Size(961, 653)
        pnlMain.TabIndex = 2
        ' 
        ' lblTitle
        ' 
        lblTitle.Font = New Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(32, 37)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(400, 40)
        lblTitle.TabIndex = 0
        lblTitle.Text = "📊 Statistik Sistem"
        ' 
        ' lblStat1
        ' 
        lblStat1.Location = New Point(0, 0)
        lblStat1.Name = "lblStat1"
        lblStat1.Size = New Size(100, 23)
        lblStat1.TabIndex = 0
        ' 
        ' lblStat2
        ' 
        lblStat2.Location = New Point(0, 0)
        lblStat2.Name = "lblStat2"
        lblStat2.Size = New Size(100, 23)
        lblStat2.TabIndex = 0
        ' 
        ' lblStat3
        ' 
        lblStat3.Location = New Point(0, 0)
        lblStat3.Name = "lblStat3"
        lblStat3.Size = New Size(100, 23)
        lblStat3.TabIndex = 0
        ' 
        ' lblStat4
        ' 
        lblStat4.Location = New Point(0, 0)
        lblStat4.Name = "lblStat4"
        lblStat4.Size = New Size(100, 23)
        lblStat4.TabIndex = 0
        ' 
        ' lblStat5
        ' 
        lblStat5.Location = New Point(0, 0)
        lblStat5.Name = "lblStat5"
        lblStat5.Size = New Size(100, 23)
        lblStat5.TabIndex = 0
        ' 
        ' formAdmin
        ' 
        BackColor = Color.White
        ClientSize = New Size(1200, 700)
        Controls.Add(pnlHeader)
        Controls.Add(pnlSidebar)
        Controls.Add(pnlMain)
        Font = New Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.None
        MaximizeBox = False
        Name = "formAdmin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Admin Dashboard"
        pnlHeader.ResumeLayout(False)
        pnlSidebar.ResumeLayout(False)
        pnlMain.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblHeader As Label
    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents btnCrudPack As Button
    Friend WithEvents btnCrudCard As Button
    Friend WithEvents pnlMain As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblStat1 As Label
    Friend WithEvents lblStat2 As Label
    Friend WithEvents lblStat3 As Label
    Friend WithEvents lblStat4 As Label
    Friend WithEvents lblStat5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnTopup As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents Button4 As Button
End Class
