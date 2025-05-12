<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formEvent
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    ' UI Komponen
    Private lblNamaEvent As Label
    Private txtNamaEvent As TextBox
    Private lblBanner As Label
    Private picBanner As PictureBox
    Private openFileDialog1 As OpenFileDialog

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formEvent))
        lblNamaEvent = New Label()
        txtNamaEvent = New TextBox()
        lblBanner = New Label()
        picBanner = New PictureBox()
        openFileDialog1 = New OpenFileDialog()
        btnPilih = New Button()
        btnSave = New Button()
        Button2 = New Button()
        panelHeader = New Panel()
        CType(picBanner, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblNamaEvent
        ' 
        lblNamaEvent.AutoSize = True
        lblNamaEvent.Font = New Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNamaEvent.ForeColor = Color.White
        lblNamaEvent.Location = New Point(18, 47)
        lblNamaEvent.Name = "lblNamaEvent"
        lblNamaEvent.Size = New Size(110, 23)
        lblNamaEvent.TabIndex = 0
        lblNamaEvent.Text = "Nama Event:"
        ' 
        ' txtNamaEvent
        ' 
        txtNamaEvent.Location = New Point(18, 73)
        txtNamaEvent.Name = "txtNamaEvent"
        txtNamaEvent.Size = New Size(300, 24)
        txtNamaEvent.TabIndex = 1
        ' 
        ' lblBanner
        ' 
        lblBanner.AutoSize = True
        lblBanner.Font = New Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblBanner.ForeColor = Color.White
        lblBanner.Location = New Point(18, 109)
        lblBanner.Name = "lblBanner"
        lblBanner.Size = New Size(69, 23)
        lblBanner.TabIndex = 2
        lblBanner.Text = "Banner:"
        ' 
        ' picBanner
        ' 
        picBanner.BackColor = Color.White
        picBanner.BorderStyle = BorderStyle.FixedSingle
        picBanner.Location = New Point(18, 135)
        picBanner.Name = "picBanner"
        picBanner.Size = New Size(300, 150)
        picBanner.SizeMode = PictureBoxSizeMode.StretchImage
        picBanner.TabIndex = 3
        picBanner.TabStop = False
        ' 
        ' btnPilih
        ' 
        btnPilih.BackColor = Color.LightSeaGreen
        btnPilih.FlatStyle = FlatStyle.Popup
        btnPilih.Location = New Point(18, 305)
        btnPilih.Name = "btnPilih"
        btnPilih.Size = New Size(94, 29)
        btnPilih.TabIndex = 4
        btnPilih.Text = "Button1"
        btnPilih.UseVisualStyleBackColor = False
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.Gold
        btnSave.FlatStyle = FlatStyle.Popup
        btnSave.Location = New Point(224, 305)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(94, 29)
        btnSave.TabIndex = 5
        btnSave.Text = "Button1"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Transparent
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatAppearance.MouseDownBackColor = Color.Transparent
        Button2.FlatAppearance.MouseOverBackColor = Color.Transparent
        Button2.FlatStyle = FlatStyle.Flat
        Button2.ForeColor = Color.Transparent
        Button2.Image = CType(resources.GetObject("Button2.Image"), Image)
        Button2.Location = New Point(298, 8)
        Button2.Margin = New Padding(3, 2, 3, 2)
        Button2.Name = "Button2"
        Button2.Size = New Size(27, 31)
        Button2.TabIndex = 18
        Button2.TabStop = False
        Button2.UseVisualStyleBackColor = False
        ' 
        ' panelHeader
        ' 
        panelHeader.Location = New Point(1, -3)
        panelHeader.Name = "panelHeader"
        panelHeader.Size = New Size(334, 362)
        panelHeader.TabIndex = 19
        ' 
        ' formEvent
        ' 
        BackColor = Color.Black
        ClientSize = New Size(335, 355)
        Controls.Add(Button2)
        Controls.Add(btnSave)
        Controls.Add(btnPilih)
        Controls.Add(lblNamaEvent)
        Controls.Add(txtNamaEvent)
        Controls.Add(lblBanner)
        Controls.Add(picBanner)
        Controls.Add(panelHeader)
        Font = New Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.None
        Name = "formEvent"
        Text = "formEvent"
        CType(picBanner, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnPilih As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents panelHeader As Panel
End Class
