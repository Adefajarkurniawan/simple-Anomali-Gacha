<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class gachaform
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(gachaform))
        Button2 = New Button()
        Button1 = New Button()
        pnlPacksContainer = New Panel()
        Gacha1 = New Button()
        Gacha10 = New Button()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Transparent
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatAppearance.MouseDownBackColor = Color.Transparent
        Button2.FlatAppearance.MouseOverBackColor = Color.Transparent
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Image = CType(resources.GetObject("Button2.Image"), Image)
        Button2.Location = New Point(1099, 39)
        Button2.Name = "Button2"
        Button2.Size = New Size(46, 37)
        Button2.TabIndex = 11
        Button2.TabStop = False
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.White
        Button1.Location = New Point(38, 626)
        Button1.Name = "Button1"
        Button1.Size = New Size(164, 37)
        Button1.TabIndex = 10
        Button1.Text = "Top Up"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' pnlPacksContainer
        ' 
        pnlPacksContainer.AutoScroll = True
        pnlPacksContainer.BackColor = Color.Transparent
        pnlPacksContainer.BorderStyle = BorderStyle.FixedSingle
        pnlPacksContainer.Location = New Point(161, 87)
        pnlPacksContainer.Name = "pnlPacksContainer"
        pnlPacksContainer.Size = New Size(0, 0)
        pnlPacksContainer.TabIndex = 9
        ' 
        ' Gacha1
        ' 
        Gacha1.BackColor = Color.White
        Gacha1.Location = New Point(744, 626)
        Gacha1.Name = "Gacha1"
        Gacha1.Size = New Size(164, 37)
        Gacha1.TabIndex = 8
        Gacha1.Text = "Gacha x1"
        Gacha1.UseVisualStyleBackColor = False
        ' 
        ' Gacha10
        ' 
        Gacha10.BackColor = Color.White
        Gacha10.Location = New Point(937, 626)
        Gacha10.Name = "Gacha10"
        Gacha10.Size = New Size(164, 37)
        Gacha10.TabIndex = 7
        Gacha10.Text = "Gacha x5"
        Gacha10.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(152, 87)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(880, 465)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 12
        PictureBox1.TabStop = False
        ' 
        ' gachaform
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1182, 703)
        Controls.Add(PictureBox1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(pnlPacksContainer)
        Controls.Add(Gacha1)
        Controls.Add(Gacha10)
        FormBorderStyle = FormBorderStyle.None
        Name = "gachaform"
        Text = "gachaform"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents pnlPacksContainer As Panel
    Friend WithEvents Gacha1 As Button
    Friend WithEvents Gacha10 As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
