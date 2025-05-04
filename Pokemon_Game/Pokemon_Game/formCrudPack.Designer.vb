<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formCrudPack
    Inherits System.Windows.Forms.Form

    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtImagePath = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.lstPacks = New System.Windows.Forms.ListView()
        Me.pnlControls = New System.Windows.Forms.Panel()
        Me.pnlControls.SuspendLayout()
        Me.SuspendLayout()

        ' Form settings
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Text = "CRUD Pack"

        ' Title
        Me.lblTitle.Text = "Manage Packs"
        Me.lblTitle.Font = New Font("Segoe UI", 14.0, FontStyle.Bold)
        Me.lblTitle.Location = New Point(20, 20)

        ' Controls Panel
        Me.pnlControls.Controls.Add(Me.txtName)
        Me.pnlControls.Controls.Add(Me.txtDescription)
        Me.pnlControls.Controls.Add(Me.txtPrice)
        Me.pnlControls.Controls.Add(Me.txtImagePath)
        Me.pnlControls.Controls.Add(Me.btnAdd)
        Me.pnlControls.Controls.Add(Me.btnEdit)
        Me.pnlControls.Controls.Add(Me.btnDelete)
        Me.pnlControls.Size = New Size(300, 250)
        Me.pnlControls.Location = New Point(20, 60)

        ' ListView for displaying packs
        Me.lstPacks.Size = New Size(450, 400)
        Me.lstPacks.Location = New Point(340, 60)
        Me.lstPacks.View = View.Details
        Me.lstPacks.Columns.Add("ID", 50)
        Me.lstPacks.Columns.Add("Name", 150)
        Me.lstPacks.Columns.Add("Description", 200)
        Me.lstPacks.Columns.Add("Price", 100)
        Me.lstPacks.Columns.Add("Image Path", 150)

        ' Name input
        Me.txtName.Location = New Point(10, 30)
        Me.txtName.Size = New Size(250, 30)
        Me.txtName.PlaceholderText = "Pack Name"

        ' Description input
        Me.txtDescription.Location = New Point(10, 70)
        Me.txtDescription.Size = New Size(250, 30)
        Me.txtDescription.PlaceholderText = "Description"

        ' Price input
        Me.txtPrice.Location = New Point(10, 110)
        Me.txtPrice.Size = New Size(250, 30)
        Me.txtPrice.PlaceholderText = "Price"

        ' Image Path input
        Me.txtImagePath.Location = New Point(10, 150)
        Me.txtImagePath.Size = New Size(250, 30)
        Me.txtImagePath.PlaceholderText = "Image Path"

        ' Add button
        Me.btnAdd.Location = New Point(10, 190)
        Me.btnAdd.Size = New Size(75, 30)
        Me.btnAdd.Text = "Add"

        ' Edit button
        Me.btnEdit.Location = New Point(90, 190)
        Me.btnEdit.Size = New Size(75, 30)
        Me.btnEdit.Text = "Edit"

        ' Delete button
        Me.btnDelete.Location = New Point(170, 190)
        Me.btnDelete.Size = New Size(75, 30)
        Me.btnDelete.Text = "Delete"

        ' Add controls
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.pnlControls)
        Me.Controls.Add(Me.lstPacks)

        ' Finalize
        Me.pnlControls.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtImagePath As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents lstPacks As ListView
    Friend WithEvents pnlControls As Panel
End Class
