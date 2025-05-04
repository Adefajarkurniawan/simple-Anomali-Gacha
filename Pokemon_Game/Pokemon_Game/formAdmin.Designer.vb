
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formAdmin
    Inherits System.Windows.Forms.Form

    Private Sub InitializeComponent()
        Me.pnlHeader = New Panel()
        Me.lblHeader = New Label()
        Me.pnlSidebar = New Panel()
        Me.btnLogout = New Button()
        Me.btnCrudPack = New Button()
        Me.btnCrudCard = New Button()
        Me.pnlMain = New Panel()
        Me.lblTitle = New Label()
        Me.lblStat1 = New Label()
        Me.lblStat2 = New Label()
        Me.lblStat3 = New Label()
        Me.lblStat4 = New Label()
        Me.lblStat5 = New Label()

        ' === Form ===
        Me.ClientSize = New Size(1200, 700)
        Me.BackColor = Color.FromArgb(240, 248, 255)
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Text = "Admin Dashboard"

        ' === Header ===
        pnlHeader.Size = New Size(1200, 60)
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.BackColor = Color.DarkBlue

        lblHeader.Text = "Admin Dashboard - Pokémon Gacha"
        lblHeader.Font = New Font("Segoe UI", 14, FontStyle.Bold)
        lblHeader.ForeColor = Color.White
        lblHeader.Size = pnlHeader.Size
        lblHeader.TextAlign = ContentAlignment.MiddleCenter

        pnlHeader.Controls.Add(lblHeader)
        Me.Controls.Add(pnlHeader)

        ' === Sidebar ===
        pnlSidebar.Size = New Size(250, 640)
        pnlSidebar.Location = New Point(0, 60)
        pnlSidebar.BackColor = Color.WhiteSmoke

        btnCrudPack.Text = "🧩 Kelola Packs"
        btnCrudPack.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        btnCrudPack.Size = New Size(220, 40)
        btnCrudPack.Location = New Point(15, 100)
        btnCrudPack.BackColor = Color.LightSteelBlue

        btnCrudCard.Text = "🎴 Kelola Cards"
        btnCrudCard.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        btnCrudCard.Size = New Size(220, 40)
        btnCrudCard.Location = New Point(15, 150)
        btnCrudCard.BackColor = Color.LightSteelBlue

        btnLogout.Text = "Logout"
        btnLogout.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        btnLogout.Size = New Size(220, 40)
        btnLogout.Location = New Point(15, 550)
        btnLogout.BackColor = Color.LightCoral

        pnlSidebar.Controls.Add(btnCrudPack)
        pnlSidebar.Controls.Add(btnCrudCard)
        pnlSidebar.Controls.Add(btnLogout)
        Me.Controls.Add(pnlSidebar)

        ' === Main Panel ===
        pnlMain.Size = New Size(920, 600)
        pnlMain.Location = New Point(260, 80)
        pnlMain.BackColor = Color.White
        pnlMain.BorderStyle = BorderStyle.FixedSingle

        lblTitle.Text = "📊 Statistik Sistem"
        lblTitle.Font = New Font("Segoe UI", 16, FontStyle.Bold)
        lblTitle.ForeColor = Color.DarkSlateGray
        lblTitle.Location = New Point(20, 20)
        lblTitle.Size = New Size(400, 40)

        ' Statistik Labels
        Dim statLabels = {lblStat1, lblStat2, lblStat3, lblStat4, lblStat5}
        Dim y = 80
        For Each lbl In statLabels
            lbl.Font = New Font("Segoe UI", 12)
            lbl.Size = New Size(800, 30)
            lbl.Location = New Point(20, y)
            pnlMain.Controls.Add(lbl)
            y += 40
        Next

        pnlMain.Controls.Add(lblTitle)
        Me.Controls.Add(pnlMain)
    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblHeader As Label
    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnCrudPack As Button
    Friend WithEvents btnCrudCard As Button
    Friend WithEvents pnlMain As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblStat1 As Label
    Friend WithEvents lblStat2 As Label
    Friend WithEvents lblStat3 As Label
    Friend WithEvents lblStat4 As Label
    Friend WithEvents lblStat5 As Label
End Class
