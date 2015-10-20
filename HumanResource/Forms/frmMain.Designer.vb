<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.msmManager = New MetroFramework.Components.MetroStyleManager(Me.components)
        Me.mtlHelp = New MetroFramework.Controls.MetroLink()
        Me.mtEmployees = New MetroFramework.Controls.MetroTile()
        Me.mtlSettings = New MetroFramework.Controls.MetroLink()
        Me.hmpWelcome = New MetroFramework.Drawing.Html.HtmlPanel()
        Me.mtDepartments = New MetroFramework.Controls.MetroTile()
        Me.mtPayroll = New MetroFramework.Controls.MetroTile()
        CType(Me.msmManager, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'msmManager
        '
        Me.msmManager.Owner = Me
        '
        'mtlHelp
        '
        Me.mtlHelp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mtlHelp.Image = CType(resources.GetObject("mtlHelp.Image"), System.Drawing.Image)
        Me.mtlHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mtlHelp.Location = New System.Drawing.Point(867, 34)
        Me.mtlHelp.Name = "mtlHelp"
        Me.mtlHelp.Size = New System.Drawing.Size(81, 30)
        Me.mtlHelp.TabIndex = 0
        Me.mtlHelp.TabStop = False
        Me.mtlHelp.Text = "Help"
        Me.mtlHelp.UseSelectable = True
        '
        'mtEmployees
        '
        Me.mtEmployees.ActiveControl = Nothing
        Me.mtEmployees.Location = New System.Drawing.Point(174, 126)
        Me.mtEmployees.Name = "mtEmployees"
        Me.mtEmployees.Size = New System.Drawing.Size(138, 87)
        Me.mtEmployees.Style = MetroFramework.MetroColorStyle.Green
        Me.mtEmployees.TabIndex = 1
        Me.mtEmployees.Text = "Employees"
        Me.mtEmployees.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.mtEmployees.TileImage = CType(resources.GetObject("mtEmployees.TileImage"), System.Drawing.Image)
        Me.mtEmployees.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.mtEmployees.UseSelectable = True
        Me.mtEmployees.UseStyleColors = True
        Me.mtEmployees.UseTileImage = True
        Me.mtEmployees.Visible = False
        '
        'mtlSettings
        '
        Me.mtlSettings.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mtlSettings.Image = CType(resources.GetObject("mtlSettings.Image"), System.Drawing.Image)
        Me.mtlSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mtlSettings.Location = New System.Drawing.Point(755, 34)
        Me.mtlSettings.Name = "mtlSettings"
        Me.mtlSettings.Size = New System.Drawing.Size(90, 30)
        Me.mtlSettings.TabIndex = 2
        Me.mtlSettings.TabStop = False
        Me.mtlSettings.Text = "Settings"
        Me.mtlSettings.UseSelectable = True
        '
        'hmpWelcome
        '
        Me.hmpWelcome.AutoScroll = True
        Me.hmpWelcome.AutoScrollMinSize = New System.Drawing.Size(702, 18)
        Me.hmpWelcome.BackColor = System.Drawing.SystemColors.Window
        Me.hmpWelcome.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hmpWelcome.Location = New System.Drawing.Point(30, 65)
        Me.hmpWelcome.Name = "hmpWelcome"
        Me.hmpWelcome.Size = New System.Drawing.Size(702, 23)
        Me.hmpWelcome.TabIndex = 3
        Me.hmpWelcome.TabStop = False
        Me.hmpWelcome.Text = "Welcome"
        '
        'mtDepartments
        '
        Me.mtDepartments.ActiveControl = Nothing
        Me.mtDepartments.Location = New System.Drawing.Point(30, 126)
        Me.mtDepartments.Name = "mtDepartments"
        Me.mtDepartments.Size = New System.Drawing.Size(138, 87)
        Me.mtDepartments.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtDepartments.TabIndex = 4
        Me.mtDepartments.Text = "Departments"
        Me.mtDepartments.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.mtDepartments.TileImage = CType(resources.GetObject("mtDepartments.TileImage"), System.Drawing.Image)
        Me.mtDepartments.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.mtDepartments.UseSelectable = True
        Me.mtDepartments.UseStyleColors = True
        Me.mtDepartments.UseTileImage = True
        Me.mtDepartments.Visible = False
        '
        'mtPayroll
        '
        Me.mtPayroll.ActiveControl = Nothing
        Me.mtPayroll.Location = New System.Drawing.Point(174, 219)
        Me.mtPayroll.Name = "mtPayroll"
        Me.mtPayroll.Size = New System.Drawing.Size(138, 87)
        Me.mtPayroll.Style = MetroFramework.MetroColorStyle.Green
        Me.mtPayroll.TabIndex = 5
        Me.mtPayroll.Text = "Payroll"
        Me.mtPayroll.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.mtPayroll.TileImage = CType(resources.GetObject("mtPayroll.TileImage"), System.Drawing.Image)
        Me.mtPayroll.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.mtPayroll.UseSelectable = True
        Me.mtPayroll.UseStyleColors = True
        Me.mtPayroll.UseTileImage = True
        Me.mtPayroll.Visible = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(978, 467)
        Me.Controls.Add(Me.mtPayroll)
        Me.Controls.Add(Me.mtDepartments)
        Me.Controls.Add(Me.hmpWelcome)
        Me.Controls.Add(Me.mtlSettings)
        Me.Controls.Add(Me.mtEmployees)
        Me.Controls.Add(Me.mtlHelp)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmMain"
        Me.Padding = New System.Windows.Forms.Padding(27, 74, 27, 25)
        Me.Style = MetroFramework.MetroColorStyle.[Default]
        Me.Text = "Human Resource System"
        Me.Theme = MetroFramework.MetroThemeStyle.[Default]
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.msmManager, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents msmManager As MetroFramework.Components.MetroStyleManager
    Friend WithEvents mtlHelp As MetroFramework.Controls.MetroLink
    Friend WithEvents mtEmployees As MetroFramework.Controls.MetroTile
    Friend WithEvents mtlSettings As MetroFramework.Controls.MetroLink
    Friend WithEvents hmpWelcome As MetroFramework.Drawing.Html.HtmlPanel
    Friend WithEvents mtDepartments As MetroFramework.Controls.MetroTile
    Friend WithEvents mtPayroll As MetroFramework.Controls.MetroTile
End Class
