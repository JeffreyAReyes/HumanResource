<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListOfEmployees
    Inherits MetroFramework.Forms.MetroForm

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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListOfEmployees))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.mtgEmployees = New MetroFramework.Controls.MetroGrid()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.mtlClose = New MetroFramework.Controls.MetroLink()
        Me.mtlDelete = New MetroFramework.Controls.MetroLink()
        Me.mtlEdit = New MetroFramework.Controls.MetroLink()
        Me.mtlAdd = New MetroFramework.Controls.MetroLink()
        Me.EmpID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FullName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MiddleName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Suffix = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BirthDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Gender = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaritalStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HireDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.mtgEmployees, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mtgEmployees
        '
        Me.mtgEmployees.AllowUserToDeleteRows = False
        Me.mtgEmployees.AllowUserToResizeRows = False
        Me.mtgEmployees.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mtgEmployees.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mtgEmployees.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mtgEmployees.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.mtgEmployees.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.mtgEmployees.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.mtgEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.mtgEmployees.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EmpID, Me.IDNumber, Me.FullName, Me.LastName, Me.FirstName, Me.MiddleName, Me.Suffix, Me.BirthDate, Me.Gender, Me.MaritalStatus, Me.HireDate})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.mtgEmployees.DefaultCellStyle = DataGridViewCellStyle4
        Me.mtgEmployees.EnableHeadersVisualStyles = False
        Me.mtgEmployees.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.mtgEmployees.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mtgEmployees.Location = New System.Drawing.Point(17, 132)
        Me.mtgEmployees.Name = "mtgEmployees"
        Me.mtgEmployees.ReadOnly = True
        Me.mtgEmployees.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.mtgEmployees.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.mtgEmployees.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.mtgEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.mtgEmployees.Size = New System.Drawing.Size(1158, 396)
        Me.mtgEmployees.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(26, 54)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(81, 72)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'mtlClose
        '
        Me.mtlClose.FontSize = MetroFramework.MetroLinkSize.Medium
        Me.mtlClose.FontWeight = MetroFramework.MetroLinkWeight.Regular
        Me.mtlClose.Location = New System.Drawing.Point(1084, 35)
        Me.mtlClose.Name = "mtlClose"
        Me.mtlClose.Size = New System.Drawing.Size(75, 23)
        Me.mtlClose.TabIndex = 2
        Me.mtlClose.TabStop = False
        Me.mtlClose.Text = "&Close"
        Me.mtlClose.UseSelectable = True
        '
        'mtlDelete
        '
        Me.mtlDelete.FontSize = MetroFramework.MetroLinkSize.Medium
        Me.mtlDelete.FontWeight = MetroFramework.MetroLinkWeight.Regular
        Me.mtlDelete.Location = New System.Drawing.Point(1008, 35)
        Me.mtlDelete.Name = "mtlDelete"
        Me.mtlDelete.Size = New System.Drawing.Size(75, 23)
        Me.mtlDelete.TabIndex = 3
        Me.mtlDelete.TabStop = False
        Me.mtlDelete.Text = "&Delete"
        Me.mtlDelete.UseSelectable = True
        '
        'mtlEdit
        '
        Me.mtlEdit.FontSize = MetroFramework.MetroLinkSize.Medium
        Me.mtlEdit.FontWeight = MetroFramework.MetroLinkWeight.Regular
        Me.mtlEdit.Location = New System.Drawing.Point(932, 35)
        Me.mtlEdit.Name = "mtlEdit"
        Me.mtlEdit.Size = New System.Drawing.Size(75, 23)
        Me.mtlEdit.TabIndex = 4
        Me.mtlEdit.TabStop = False
        Me.mtlEdit.Text = "&Edit"
        Me.mtlEdit.UseSelectable = True
        '
        'mtlAdd
        '
        Me.mtlAdd.FontSize = MetroFramework.MetroLinkSize.Medium
        Me.mtlAdd.FontWeight = MetroFramework.MetroLinkWeight.Regular
        Me.mtlAdd.Image = CType(resources.GetObject("mtlAdd.Image"), System.Drawing.Image)
        Me.mtlAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mtlAdd.Location = New System.Drawing.Point(856, 35)
        Me.mtlAdd.Name = "mtlAdd"
        Me.mtlAdd.Size = New System.Drawing.Size(75, 23)
        Me.mtlAdd.TabIndex = 5
        Me.mtlAdd.TabStop = False
        Me.mtlAdd.Text = "&Add"
        Me.mtlAdd.UseSelectable = True
        '
        'EmpID
        '
        Me.EmpID.Frozen = True
        Me.EmpID.HeaderText = "EmpID"
        Me.EmpID.Name = "EmpID"
        Me.EmpID.ReadOnly = True
        Me.EmpID.Visible = False
        '
        'IDNumber
        '
        Me.IDNumber.HeaderText = "ID Number"
        Me.IDNumber.Name = "IDNumber"
        Me.IDNumber.ReadOnly = True
        '
        'FullName
        '
        Me.FullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.FullName.HeaderText = "Name"
        Me.FullName.Name = "FullName"
        Me.FullName.ReadOnly = True
        '
        'LastName
        '
        Me.LastName.HeaderText = "Last Name"
        Me.LastName.Name = "LastName"
        Me.LastName.ReadOnly = True
        Me.LastName.Visible = False
        '
        'FirstName
        '
        Me.FirstName.HeaderText = "First Name"
        Me.FirstName.Name = "FirstName"
        Me.FirstName.ReadOnly = True
        Me.FirstName.Visible = False
        '
        'MiddleName
        '
        Me.MiddleName.HeaderText = "Middle Name"
        Me.MiddleName.Name = "MiddleName"
        Me.MiddleName.ReadOnly = True
        Me.MiddleName.Visible = False
        '
        'Suffix
        '
        Me.Suffix.HeaderText = "Suffix"
        Me.Suffix.Name = "Suffix"
        Me.Suffix.ReadOnly = True
        Me.Suffix.Visible = False
        '
        'BirthDate
        '
        DataGridViewCellStyle2.Format = "MMM/dd/yyyy"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.BirthDate.DefaultCellStyle = DataGridViewCellStyle2
        Me.BirthDate.HeaderText = "Birth Date"
        Me.BirthDate.Name = "BirthDate"
        Me.BirthDate.ReadOnly = True
        Me.BirthDate.Visible = False
        '
        'Gender
        '
        Me.Gender.HeaderText = "Gender"
        Me.Gender.Name = "Gender"
        Me.Gender.ReadOnly = True
        '
        'MaritalStatus
        '
        Me.MaritalStatus.HeaderText = "Marital Status"
        Me.MaritalStatus.Name = "MaritalStatus"
        Me.MaritalStatus.ReadOnly = True
        '
        'HireDate
        '
        DataGridViewCellStyle3.Format = "MMM/dd/yyyy"
        Me.HireDate.DefaultCellStyle = DataGridViewCellStyle3
        Me.HireDate.HeaderText = "Hire Date"
        Me.HireDate.Name = "HireDate"
        Me.HireDate.ReadOnly = True
        '
        'frmListOfEmployees
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1185, 596)
        Me.Controls.Add(Me.mtlAdd)
        Me.Controls.Add(Me.mtlEdit)
        Me.Controls.Add(Me.mtlDelete)
        Me.Controls.Add(Me.mtlClose)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.mtgEmployees)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmListOfEmployees"
        Me.Padding = New System.Windows.Forms.Padding(23, 78, 23, 26)
        Me.Text = "Employees"
        CType(Me.mtgEmployees, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents mtgEmployees As MetroFramework.Controls.MetroGrid
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents mtlClose As MetroFramework.Controls.MetroLink
    Friend WithEvents mtlDelete As MetroFramework.Controls.MetroLink
    Friend WithEvents mtlEdit As MetroFramework.Controls.MetroLink
    Friend WithEvents mtlAdd As MetroFramework.Controls.MetroLink
    Friend WithEvents EmpID As DataGridViewTextBoxColumn
    Friend WithEvents IDNumber As DataGridViewTextBoxColumn
    Friend WithEvents FullName As DataGridViewTextBoxColumn
    Friend WithEvents LastName As DataGridViewTextBoxColumn
    Friend WithEvents FirstName As DataGridViewTextBoxColumn
    Friend WithEvents MiddleName As DataGridViewTextBoxColumn
    Friend WithEvents Suffix As DataGridViewTextBoxColumn
    Friend WithEvents BirthDate As DataGridViewTextBoxColumn
    Friend WithEvents Gender As DataGridViewTextBoxColumn
    Friend WithEvents MaritalStatus As DataGridViewTextBoxColumn
    Friend WithEvents HireDate As DataGridViewTextBoxColumn
End Class
