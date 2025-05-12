<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tampilanGacha1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(tampilanGacha1))
        PictureBoxKartu = New PictureBox()
        Button1 = New Button()
        CType(PictureBoxKartu, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBoxKartu
        ' 
        PictureBoxKartu.Location = New Point(350, 44)
        PictureBoxKartu.Name = "PictureBoxKartu"
        PictureBoxKartu.Size = New Size(144, 211)
        PictureBoxKartu.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBoxKartu.TabIndex = 3
        PictureBoxKartu.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.White
        Button1.Location = New Point(314, 328)
        Button1.Name = "Button1"
        Button1.Size = New Size(220, 50)
        Button1.TabIndex = 2
        Button1.Text = "TUTUP"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' tampilanGacha1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(862, 403)
        Controls.Add(PictureBoxKartu)
        Controls.Add(Button1)
        FormBorderStyle = FormBorderStyle.None
        Name = "tampilanGacha1"
        Text = "tampilanGacha1"
        CType(PictureBoxKartu, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBoxKartu As PictureBox
    Friend WithEvents Button1 As Button
End Class
