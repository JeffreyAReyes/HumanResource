<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
    Inherits MetroFramework.Forms.MetroForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.mtlClose = New MetroFramework.Controls.MetroLink()
        Me.mtlLogin = New MetroFramework.Controls.MetroLink()
        Me.mtxLoginName = New MetroFramework.Controls.MetroTextBox()
        Me.mtxPassword = New MetroFramework.Controls.MetroTextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mtlClose
        '
        Me.mtlClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mtlClose.FontSize = MetroFramework.MetroLinkSize.Medium
        Me.mtlClose.Image = CType(resources.GetObject("mtlClose.Image"), System.Drawing.Image)
        Me.mtlClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mtlClose.Location = New System.Drawing.Point(394, 250)
        Me.mtlClose.Name = "mtlClose"
        Me.mtlClose.Size = New System.Drawing.Size(75, 23)
        Me.mtlClose.TabIndex = 3
        Me.mtlClose.TabStop = False
        Me.mtlClose.Text = "&Close"
        Me.mtlClose.UseSelectable = True
        '
        'mtlLogin
        '
        Me.mtlLogin.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mtlLogin.FontSize = MetroFramework.MetroLinkSize.Medium
        Me.mtlLogin.Image = CType(resources.GetObject("mtlLogin.Image"), System.Drawing.Image)
        Me.mtlLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mtlLogin.Location = New System.Drawing.Point(313, 250)
        Me.mtlLogin.Name = "mtlLogin"
        Me.mtlLogin.Size = New System.Drawing.Size(75, 23)
        Me.mtlLogin.TabIndex = 2
        Me.mtlLogin.TabStop = False
        Me.mtlLogin.Text = "&Login"
        Me.mtlLogin.UseSelectable = True
        '
        'mtxLoginName
        '
        '
        '
        '
        Me.mtxLoginName.CustomButton.Image = Nothing
        Me.mtxLoginName.CustomButton.Location = New System.Drawing.Point(341, 1)
        Me.mtxLoginName.CustomButton.Name = ""
        Me.mtxLoginName.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtxLoginName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtxLoginName.CustomButton.TabIndex = 1
        Me.mtxLoginName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtxLoginName.CustomButton.UseSelectable = True
        Me.mtxLoginName.CustomButton.Visible = False
        Me.mtxLoginName.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.mtxLoginName.Location = New System.Drawing.Point(106, 125)
        Me.mtxLoginName.MaxLength = 32767
        Me.mtxLoginName.Name = "mtxLoginName"
        Me.mtxLoginName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtxLoginName.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtxLoginName.SelectedText = ""
        Me.mtxLoginName.SelectionLength = 0
        Me.mtxLoginName.SelectionStart = 0
        Me.mtxLoginName.ShowClearButton = True
        Me.mtxLoginName.Size = New System.Drawing.Size(363, 23)
        Me.mtxLoginName.TabIndex = 0
        Me.mtxLoginName.UseSelectable = True
        Me.mtxLoginName.WaterMark = "Enter your login name"
        Me.mtxLoginName.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtxLoginName.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'mtxPassword
        '
        '
        '
        '
        Me.mtxPassword.CustomButton.Image = Nothing
        Me.mtxPassword.CustomButton.Location = New System.Drawing.Point(341, 1)
        Me.mtxPassword.CustomButton.Name = ""
        Me.mtxPassword.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtxPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtxPassword.CustomButton.TabIndex = 1
        Me.mtxPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtxPassword.CustomButton.UseSelectable = True
        Me.mtxPassword.CustomButton.Visible = False
        Me.mtxPassword.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.mtxPassword.Location = New System.Drawing.Point(106, 154)
        Me.mtxPassword.MaxLength = 32767
        Me.mtxPassword.Name = "mtxPassword"
        Me.mtxPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.mtxPassword.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtxPassword.SelectedText = ""
        Me.mtxPassword.SelectionLength = 0
        Me.mtxPassword.SelectionStart = 0
        Me.mtxPassword.ShowClearButton = True
        Me.mtxPassword.Size = New System.Drawing.Size(363, 23)
        Me.mtxPassword.TabIndex = 1
        Me.mtxPassword.UseSelectable = True
        Me.mtxPassword.WaterMark = "Password"
        Me.mtxPassword.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtxPassword.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(30, 58)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(71, 61)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(573, 307)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.mtxPassword)
        Me.Controls.Add(Me.mtxLoginName)
        Me.Controls.Add(Me.mtlLogin)
        Me.Controls.Add(Me.mtlClose)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmLogin"
        Me.Padding = New System.Windows.Forms.Padding(27, 74, 27, 25)
        Me.Resizable = False
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents mtlClose As MetroFramework.Controls.MetroLink
    Friend WithEvents mtlLogin As MetroFramework.Controls.MetroLink
    Friend WithEvents mtxLoginName As MetroFramework.Controls.MetroTextBox
    Friend WithEvents mtxPassword As MetroFramework.Controls.MetroTextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
