<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListOfDepartments
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListOfDepartments))
        Me.mtgEmployees = New MetroFramework.Controls.MetroGrid()
        Me.DeptNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeptName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mtlAdd = New MetroFramework.Controls.MetroLink()
        Me.mtlEdit = New MetroFramework.Controls.MetroLink()
        Me.mtlDelete = New MetroFramework.Controls.MetroLink()
        Me.mtlClose = New MetroFramework.Controls.MetroLink()
        CType(Me.mtgEmployees, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.mtgEmployees.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DeptNo, Me.DeptName})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.mtgEmployees.DefaultCellStyle = DataGridViewCellStyle2
        Me.mtgEmployees.EnableHeadersVisualStyles = False
        Me.mtgEmployees.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.mtgEmployees.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mtgEmployees.Location = New System.Drawing.Point(23, 79)
        Me.mtgEmployees.Name = "mtgEmployees"
        Me.mtgEmployees.ReadOnly = True
        Me.mtgEmployees.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.mtgEmployees.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.mtgEmployees.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.mtgEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.mtgEmployees.Size = New System.Drawing.Size(787, 301)
        Me.mtgEmployees.TabIndex = 1
        '
        'DeptNo
        '
        Me.DeptNo.Frozen = True
        Me.DeptNo.HeaderText = "Dept. No"
        Me.DeptNo.Name = "DeptNo"
        Me.DeptNo.ReadOnly = True
        '
        'DeptName
        '
        Me.DeptName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DeptName.HeaderText = "Dept Name"
        Me.DeptName.Name = "DeptName"
        Me.DeptName.ReadOnly = True
        '
        'mtlAdd
        '
        Me.mtlAdd.FontSize = MetroFramework.MetroLinkSize.Medium
        Me.mtlAdd.FontWeight = MetroFramework.MetroLinkWeight.Regular
        Me.mtlAdd.Image = CType(resources.GetObject("mtlAdd.Image"), System.Drawing.Image)
        Me.mtlAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mtlAdd.Location = New System.Drawing.Point(507, 26)
        Me.mtlAdd.Name = "mtlAdd"
        Me.mtlAdd.Size = New System.Drawing.Size(75, 23)
        Me.mtlAdd.TabIndex = 9
        Me.mtlAdd.TabStop = False
        Me.mtlAdd.Text = "&Add"
        Me.mtlAdd.UseSelectable = True
        '
        'mtlEdit
        '
        Me.mtlEdit.FontSize = MetroFramework.MetroLinkSize.Medium
        Me.mtlEdit.FontWeight = MetroFramework.MetroLinkWeight.Regular
        Me.mtlEdit.Location = New System.Drawing.Point(583, 26)
        Me.mtlEdit.Name = "mtlEdit"
        Me.mtlEdit.Size = New System.Drawing.Size(75, 23)
        Me.mtlEdit.TabIndex = 8
        Me.mtlEdit.TabStop = False
        Me.mtlEdit.Text = "&Edit"
        Me.mtlEdit.UseSelectable = True
        '
        'mtlDelete
        '
        Me.mtlDelete.FontSize = MetroFramework.MetroLinkSize.Medium
        Me.mtlDelete.FontWeight = MetroFramework.MetroLinkWeight.Regular
        Me.mtlDelete.Location = New System.Drawing.Point(659, 26)
        Me.mtlDelete.Name = "mtlDelete"
        Me.mtlDelete.Size = New System.Drawing.Size(75, 23)
        Me.mtlDelete.TabIndex = 7
        Me.mtlDelete.TabStop = False
        Me.mtlDelete.Text = "&Delete"
        Me.mtlDelete.UseSelectable = True
        '
        'mtlClose
        '
        Me.mtlClose.FontSize = MetroFramework.MetroLinkSize.Medium
        Me.mtlClose.FontWeight = MetroFramework.MetroLinkWeight.Regular
        Me.mtlClose.Location = New System.Drawing.Point(735, 26)
        Me.mtlClose.Name = "mtlClose"
        Me.mtlClose.Size = New System.Drawing.Size(75, 23)
        Me.mtlClose.TabIndex = 6
        Me.mtlClose.TabStop = False
        Me.mtlClose.Text = "&Close"
        Me.mtlClose.UseSelectable = True
        '
        'frmListOfDepartments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 403)
        Me.Controls.Add(Me.mtlAdd)
        Me.Controls.Add(Me.mtlEdit)
        Me.Controls.Add(Me.mtlDelete)
        Me.Controls.Add(Me.mtlClose)
        Me.Controls.Add(Me.mtgEmployees)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmListOfDepartments"
        Me.Text = "Departments"
        CType(Me.mtgEmployees, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents mtgEmployees As MetroFramework.Controls.MetroGrid
    Friend WithEvents DeptNo As DataGridViewTextBoxColumn
    Friend WithEvents DeptName As DataGridViewTextBoxColumn
    Friend WithEvents mtlAdd As MetroFramework.Controls.MetroLink
    Friend WithEvents mtlEdit As MetroFramework.Controls.MetroLink
    Friend WithEvents mtlDelete As MetroFramework.Controls.MetroLink
    Friend WithEvents mtlClose As MetroFramework.Controls.MetroLink
End Class
