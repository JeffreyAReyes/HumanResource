<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddEditEmployee
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddEditEmployee))
        Me.mtlClose = New MetroFramework.Controls.MetroLink()
        Me.mtlSave = New MetroFramework.Controls.MetroLink()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.mtxEmpID = New MetroFramework.Controls.MetroTextBox()
        Me.mtxLastName = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.mtxtFirstName = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.mtxMiddleName = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.mtxSuffix = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.dtpBirthdate = New MetroFramework.Controls.MetroDateTime()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.cboGender = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.cboMarital = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.dtpHireDate = New MetroFramework.Controls.MetroDateTime()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.cboDepartment = New MetroFramework.Controls.MetroComboBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mtlClose
        '
        Me.mtlClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mtlClose.FontSize = MetroFramework.MetroLinkSize.Medium
        Me.mtlClose.FontWeight = MetroFramework.MetroLinkWeight.Regular
        Me.mtlClose.Image = CType(resources.GetObject("mtlClose.Image"), System.Drawing.Image)
        Me.mtlClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mtlClose.Location = New System.Drawing.Point(813, 458)
        Me.mtlClose.Name = "mtlClose"
        Me.mtlClose.Size = New System.Drawing.Size(66, 24)
        Me.mtlClose.TabIndex = 21
        Me.mtlClose.TabStop = False
        Me.mtlClose.Text = "&Close"
        Me.mtlClose.UseSelectable = True
        '
        'mtlSave
        '
        Me.mtlSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mtlSave.FontSize = MetroFramework.MetroLinkSize.Medium
        Me.mtlSave.FontWeight = MetroFramework.MetroLinkWeight.Regular
        Me.mtlSave.Image = CType(resources.GetObject("mtlSave.Image"), System.Drawing.Image)
        Me.mtlSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mtlSave.Location = New System.Drawing.Point(726, 458)
        Me.mtlSave.Name = "mtlSave"
        Me.mtlSave.Size = New System.Drawing.Size(66, 24)
        Me.mtlSave.TabIndex = 20
        Me.mtlSave.TabStop = False
        Me.mtlSave.Text = "&Save"
        Me.mtlSave.UseSelectable = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(29, 140)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(86, 19)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "Employee ID:"
        '
        'mtxEmpID
        '
        Me.mtxEmpID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.mtxEmpID.CustomButton.Image = Nothing
        Me.mtxEmpID.CustomButton.Location = New System.Drawing.Point(172, 1)
        Me.mtxEmpID.CustomButton.Name = ""
        Me.mtxEmpID.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.mtxEmpID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtxEmpID.CustomButton.TabIndex = 1
        Me.mtxEmpID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtxEmpID.CustomButton.UseSelectable = True
        Me.mtxEmpID.CustomButton.Visible = False
        Me.mtxEmpID.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.mtxEmpID.Location = New System.Drawing.Point(29, 162)
        Me.mtxEmpID.MaxLength = 32767
        Me.mtxEmpID.Name = "mtxEmpID"
        Me.mtxEmpID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtxEmpID.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtxEmpID.SelectedText = ""
        Me.mtxEmpID.SelectionLength = 0
        Me.mtxEmpID.SelectionStart = 0
        Me.mtxEmpID.Size = New System.Drawing.Size(200, 29)
        Me.mtxEmpID.TabIndex = 1
        Me.mtxEmpID.UseSelectable = True
        Me.mtxEmpID.WaterMark = "Please enter Employee ID"
        Me.mtxEmpID.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtxEmpID.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'mtxLastName
        '
        '
        '
        '
        Me.mtxLastName.CustomButton.Image = Nothing
        Me.mtxLastName.CustomButton.Location = New System.Drawing.Point(172, 1)
        Me.mtxLastName.CustomButton.Name = ""
        Me.mtxLastName.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.mtxLastName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtxLastName.CustomButton.TabIndex = 1
        Me.mtxLastName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtxLastName.CustomButton.UseSelectable = True
        Me.mtxLastName.CustomButton.Visible = False
        Me.mtxLastName.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.mtxLastName.Location = New System.Drawing.Point(29, 226)
        Me.mtxLastName.MaxLength = 32767
        Me.mtxLastName.Name = "mtxLastName"
        Me.mtxLastName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtxLastName.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtxLastName.SelectedText = ""
        Me.mtxLastName.SelectionLength = 0
        Me.mtxLastName.SelectionStart = 0
        Me.mtxLastName.Size = New System.Drawing.Size(200, 29)
        Me.mtxLastName.TabIndex = 5
        Me.mtxLastName.UseSelectable = True
        Me.mtxLastName.WaterMark = "Last Name"
        Me.mtxLastName.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtxLastName.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(29, 204)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(74, 19)
        Me.MetroLabel2.TabIndex = 4
        Me.MetroLabel2.Text = "Last Name:"
        '
        'mtxtFirstName
        '
        '
        '
        '
        Me.mtxtFirstName.CustomButton.Image = Nothing
        Me.mtxtFirstName.CustomButton.Location = New System.Drawing.Point(172, 1)
        Me.mtxtFirstName.CustomButton.Name = ""
        Me.mtxtFirstName.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.mtxtFirstName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtxtFirstName.CustomButton.TabIndex = 1
        Me.mtxtFirstName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtxtFirstName.CustomButton.UseSelectable = True
        Me.mtxtFirstName.CustomButton.Visible = False
        Me.mtxtFirstName.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.mtxtFirstName.Location = New System.Drawing.Point(235, 226)
        Me.mtxtFirstName.MaxLength = 32767
        Me.mtxtFirstName.Name = "mtxtFirstName"
        Me.mtxtFirstName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtxtFirstName.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtxtFirstName.SelectedText = ""
        Me.mtxtFirstName.SelectionLength = 0
        Me.mtxtFirstName.SelectionStart = 0
        Me.mtxtFirstName.Size = New System.Drawing.Size(200, 29)
        Me.mtxtFirstName.TabIndex = 7
        Me.mtxtFirstName.UseSelectable = True
        Me.mtxtFirstName.WaterMark = "First Name"
        Me.mtxtFirstName.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtxtFirstName.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(235, 204)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(76, 19)
        Me.MetroLabel3.TabIndex = 6
        Me.MetroLabel3.Text = "First Name:"
        '
        'mtxMiddleName
        '
        '
        '
        '
        Me.mtxMiddleName.CustomButton.Image = Nothing
        Me.mtxMiddleName.CustomButton.Location = New System.Drawing.Point(172, 1)
        Me.mtxMiddleName.CustomButton.Name = ""
        Me.mtxMiddleName.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.mtxMiddleName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtxMiddleName.CustomButton.TabIndex = 1
        Me.mtxMiddleName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtxMiddleName.CustomButton.UseSelectable = True
        Me.mtxMiddleName.CustomButton.Visible = False
        Me.mtxMiddleName.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.mtxMiddleName.Location = New System.Drawing.Point(443, 226)
        Me.mtxMiddleName.MaxLength = 32767
        Me.mtxMiddleName.Name = "mtxMiddleName"
        Me.mtxMiddleName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtxMiddleName.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtxMiddleName.SelectedText = ""
        Me.mtxMiddleName.SelectionLength = 0
        Me.mtxMiddleName.SelectionStart = 0
        Me.mtxMiddleName.Size = New System.Drawing.Size(200, 29)
        Me.mtxMiddleName.TabIndex = 9
        Me.mtxMiddleName.UseSelectable = True
        Me.mtxMiddleName.WaterMark = "Middle Name"
        Me.mtxMiddleName.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtxMiddleName.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(443, 204)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(93, 19)
        Me.MetroLabel4.TabIndex = 8
        Me.MetroLabel4.Text = "Middle Name:"
        '
        'mtxSuffix
        '
        '
        '
        '
        Me.mtxSuffix.CustomButton.Image = Nothing
        Me.mtxSuffix.CustomButton.Location = New System.Drawing.Point(172, 1)
        Me.mtxSuffix.CustomButton.Name = ""
        Me.mtxSuffix.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.mtxSuffix.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtxSuffix.CustomButton.TabIndex = 1
        Me.mtxSuffix.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtxSuffix.CustomButton.UseSelectable = True
        Me.mtxSuffix.CustomButton.Visible = False
        Me.mtxSuffix.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.mtxSuffix.Location = New System.Drawing.Point(652, 226)
        Me.mtxSuffix.MaxLength = 32767
        Me.mtxSuffix.Name = "mtxSuffix"
        Me.mtxSuffix.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtxSuffix.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtxSuffix.SelectedText = ""
        Me.mtxSuffix.SelectionLength = 0
        Me.mtxSuffix.SelectionStart = 0
        Me.mtxSuffix.Size = New System.Drawing.Size(200, 29)
        Me.mtxSuffix.TabIndex = 11
        Me.mtxSuffix.UseSelectable = True
        Me.mtxSuffix.WaterMark = "Suffix"
        Me.mtxSuffix.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtxSuffix.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(652, 204)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(43, 19)
        Me.MetroLabel5.TabIndex = 10
        Me.MetroLabel5.Text = "Suffix:"
        '
        'dtpBirthdate
        '
        Me.dtpBirthdate.CustomFormat = "MMM/dd/yyyy"
        Me.dtpBirthdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpBirthdate.Location = New System.Drawing.Point(29, 286)
        Me.dtpBirthdate.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtpBirthdate.Name = "dtpBirthdate"
        Me.dtpBirthdate.Size = New System.Drawing.Size(200, 29)
        Me.dtpBirthdate.TabIndex = 13
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(29, 264)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(71, 19)
        Me.MetroLabel6.TabIndex = 12
        Me.MetroLabel6.Text = "Birth Date:"
        '
        'cboGender
        '
        Me.cboGender.FormattingEnabled = True
        Me.cboGender.ItemHeight = 23
        Me.cboGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cboGender.Location = New System.Drawing.Point(235, 286)
        Me.cboGender.Name = "cboGender"
        Me.cboGender.PromptText = "Gender"
        Me.cboGender.Size = New System.Drawing.Size(200, 29)
        Me.cboGender.TabIndex = 15
        Me.cboGender.UseSelectable = True
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(235, 264)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(56, 19)
        Me.MetroLabel7.TabIndex = 14
        Me.MetroLabel7.Text = "Gender:"
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Location = New System.Drawing.Point(445, 264)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(91, 19)
        Me.MetroLabel8.TabIndex = 16
        Me.MetroLabel8.Text = "Marital Status:"
        '
        'cboMarital
        '
        Me.cboMarital.FormattingEnabled = True
        Me.cboMarital.ItemHeight = 23
        Me.cboMarital.Items.AddRange(New Object() {"Single", "Married", "Widow", "Separated"})
        Me.cboMarital.Location = New System.Drawing.Point(443, 286)
        Me.cboMarital.Name = "cboMarital"
        Me.cboMarital.PromptText = "Marital Status"
        Me.cboMarital.Size = New System.Drawing.Size(200, 29)
        Me.cboMarital.TabIndex = 17
        Me.cboMarital.UseSelectable = True
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.Location = New System.Drawing.Point(652, 264)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(67, 19)
        Me.MetroLabel9.TabIndex = 18
        Me.MetroLabel9.Text = "Hire Date:"
        '
        'dtpHireDate
        '
        Me.dtpHireDate.CustomFormat = "MMM/dd/yyyy"
        Me.dtpHireDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpHireDate.Location = New System.Drawing.Point(649, 286)
        Me.dtpHireDate.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtpHireDate.Name = "dtpHireDate"
        Me.dtpHireDate.Size = New System.Drawing.Size(200, 29)
        Me.dtpHireDate.TabIndex = 19
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(29, 60)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 61)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'MetroLabel10
        '
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.Location = New System.Drawing.Point(237, 140)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(83, 19)
        Me.MetroLabel10.TabIndex = 2
        Me.MetroLabel10.Text = "Department:"
        '
        'cboDepartment
        '
        Me.cboDepartment.FormattingEnabled = True
        Me.cboDepartment.ItemHeight = 23
        Me.cboDepartment.Items.AddRange(New Object() {"Single", "Married", "Widow", "Separated"})
        Me.cboDepartment.Location = New System.Drawing.Point(235, 162)
        Me.cboDepartment.Name = "cboDepartment"
        Me.cboDepartment.PromptText = "Department"
        Me.cboDepartment.Size = New System.Drawing.Size(200, 29)
        Me.cboDepartment.TabIndex = 3
        Me.cboDepartment.UseSelectable = True
        '
        'frmAddEditEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(896, 500)
        Me.ControlBox = False
        Me.Controls.Add(Me.MetroLabel10)
        Me.Controls.Add(Me.cboDepartment)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MetroLabel9)
        Me.Controls.Add(Me.dtpHireDate)
        Me.Controls.Add(Me.MetroLabel8)
        Me.Controls.Add(Me.cboMarital)
        Me.Controls.Add(Me.MetroLabel7)
        Me.Controls.Add(Me.cboGender)
        Me.Controls.Add(Me.MetroLabel6)
        Me.Controls.Add(Me.dtpBirthdate)
        Me.Controls.Add(Me.mtxSuffix)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.mtxMiddleName)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.mtxtFirstName)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.mtxLastName)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.mtxEmpID)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.mtlSave)
        Me.Controls.Add(Me.mtlClose)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmAddEditEmployee"
        Me.Padding = New System.Windows.Forms.Padding(24, 79, 24, 27)
        Me.Resizable = False
        Me.Text = "Add Employee"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mtlClose As MetroFramework.Controls.MetroLink
    Friend WithEvents mtlSave As MetroFramework.Controls.MetroLink
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mtxEmpID As MetroFramework.Controls.MetroTextBox
    Friend WithEvents mtxLastName As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mtxtFirstName As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mtxMiddleName As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mtxSuffix As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents dtpBirthdate As MetroFramework.Controls.MetroDateTime
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cboGender As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cboMarital As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents dtpHireDate As MetroFramework.Controls.MetroDateTime
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cboDepartment As MetroFramework.Controls.MetroComboBox
End Class
