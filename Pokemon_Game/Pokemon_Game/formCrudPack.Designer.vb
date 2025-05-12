<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formCrudPack
    Inherits System.Windows.Forms.Form

    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formCrudPack))
        lblTitle = New Label()
        txtName = New TextBox()
        txtDescription = New TextBox()
        txtPrice = New TextBox()
        txtImagePath = New TextBox()
        btnAdd = New Button()
        btnEdit = New Button()
        btnDelete = New Button()
        lstPacks = New ListView()
        pnlControls = New Panel()
        Button2 = New Button()
        panelHeader = New Panel()
        pnlControls.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        lblTitle.Location = New Point(20, 9)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(146, 37)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Manage Packs"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(10, 30)
        txtName.Name = "txtName"
        txtName.PlaceholderText = "Pack Name"
        txtName.Size = New Size(250, 23)
        txtName.TabIndex = 0
        ' 
        ' txtDescription
        ' 
        txtDescription.Location = New Point(10, 70)
        txtDescription.Name = "txtDescription"
        txtDescription.PlaceholderText = "Description"
        txtDescription.Size = New Size(250, 23)
        txtDescription.TabIndex = 1
        ' 
        ' txtPrice
        ' 
        txtPrice.Location = New Point(10, 110)
        txtPrice.Name = "txtPrice"
        txtPrice.PlaceholderText = "Price"
        txtPrice.Size = New Size(250, 23)
        txtPrice.TabIndex = 2
        ' 
        ' txtImagePath
        ' 
        txtImagePath.Location = New Point(10, 150)
        txtImagePath.Name = "txtImagePath"
        txtImagePath.PlaceholderText = "Image Path"
        txtImagePath.Size = New Size(250, 23)
        txtImagePath.TabIndex = 3
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(10, 190)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(75, 30)
        btnAdd.TabIndex = 4
        btnAdd.Text = "Add"
        ' 
        ' btnEdit
        ' 
        btnEdit.Location = New Point(90, 190)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(75, 30)
        btnEdit.TabIndex = 5
        btnEdit.Text = "Edit"
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(170, 190)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(75, 30)
        btnDelete.TabIndex = 6
        btnDelete.Text = "Delete"
        ' 
        ' lstPacks
        ' 
        lstPacks.Location = New Point(326, 49)
        lstPacks.Name = "lstPacks"
        lstPacks.Size = New Size(450, 250)
        lstPacks.TabIndex = 2
        lstPacks.UseCompatibleStateImageBehavior = False
        lstPacks.View = View.Details
        ' 
        ' pnlControls
        ' 
        pnlControls.Controls.Add(txtName)
        pnlControls.Controls.Add(txtDescription)
        pnlControls.Controls.Add(txtPrice)
        pnlControls.Controls.Add(txtImagePath)
        pnlControls.Controls.Add(btnAdd)
        pnlControls.Controls.Add(btnEdit)
        pnlControls.Controls.Add(btnDelete)
        pnlControls.Location = New Point(20, 49)
        pnlControls.Name = "pnlControls"
        pnlControls.Size = New Size(300, 250)
        pnlControls.TabIndex = 1
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
        Button2.Location = New Point(755, 6)
        Button2.Margin = New Padding(3, 2, 3, 2)
        Button2.Name = "Button2"
        Button2.Size = New Size(27, 31)
        Button2.TabIndex = 16
        Button2.TabStop = False
        Button2.UseVisualStyleBackColor = False
        ' 
        ' panelHeader
        ' 
        panelHeader.Location = New Point(1, 2)
        panelHeader.Name = "panelHeader"
        panelHeader.Size = New Size(793, 315)
        panelHeader.TabIndex = 17
        ' 
        ' formCrudPack
        ' 
        BackColor = Color.LightSkyBlue
        ClientSize = New Size(791, 310)
        Controls.Add(Button2)
        Controls.Add(lblTitle)
        Controls.Add(pnlControls)
        Controls.Add(lstPacks)
        Controls.Add(panelHeader)
        FormBorderStyle = FormBorderStyle.None
        Name = "formCrudPack"
        Text = "CRUD Pack"
        pnlControls.ResumeLayout(False)
        pnlControls.PerformLayout()
        ResumeLayout(False)
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
    Friend WithEvents Button2 As Button
    Friend WithEvents panelHeader As Panel
End Class
