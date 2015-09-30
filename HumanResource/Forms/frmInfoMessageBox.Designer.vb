<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInfoMessageBox
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
        Me.mtlError = New MetroFramework.Controls.MetroLabel()
        Me.mtlErrorMessage = New MetroFramework.Controls.MetroLabel()
        Me.mtbOk = New MetroFramework.Controls.MetroButton()
        Me.hmpMessage = New MetroFramework.Drawing.Html.HtmlPanel()
        Me.SuspendLayout()
        '
        'mtlError
        '
        Me.mtlError.AutoSize = True
        Me.mtlError.Location = New System.Drawing.Point(26, 58)
        Me.mtlError.Name = "mtlError"
        Me.mtlError.Size = New System.Drawing.Size(43, 19)
        Me.mtlError.TabIndex = 0
        Me.mtlError.Text = "Error:"
        '
        'mtlErrorMessage
        '
        Me.mtlErrorMessage.AutoSize = True
        Me.mtlErrorMessage.FontSize = MetroFramework.MetroLabelSize.Small
        Me.mtlErrorMessage.Location = New System.Drawing.Point(26, 109)
        Me.mtlErrorMessage.Name = "mtlErrorMessage"
        Me.mtlErrorMessage.Size = New System.Drawing.Size(80, 15)
        Me.mtlErrorMessage.TabIndex = 1
        Me.mtlErrorMessage.Text = "Error Message"
        Me.mtlErrorMessage.Visible = False
        '
        'mtbOk
        '
        Me.mtbOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mtbOk.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.mtbOk.Location = New System.Drawing.Point(586, 341)
        Me.mtbOk.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.mtbOk.Name = "mtbOk"
        Me.mtbOk.Size = New System.Drawing.Size(148, 42)
        Me.mtbOk.TabIndex = 2
        Me.mtbOk.Text = "Ok"
        Me.mtbOk.UseSelectable = True
        '
        'hmpMessage
        '
        Me.hmpMessage.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.hmpMessage.AutoScroll = True
        Me.hmpMessage.AutoScrollMinSize = New System.Drawing.Size(703, 18)
        Me.hmpMessage.BackColor = System.Drawing.SystemColors.Window
        Me.hmpMessage.Location = New System.Drawing.Point(31, 81)
        Me.hmpMessage.Name = "hmpMessage"
        Me.hmpMessage.Size = New System.Drawing.Size(703, 243)
        Me.hmpMessage.TabIndex = 3
        Me.hmpMessage.Text = "HtmlPanel1"
        '
        'frmInfoMessageBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(764, 399)
        Me.ControlBox = False
        Me.Controls.Add(Me.hmpMessage)
        Me.Controls.Add(Me.mtbOk)
        Me.Controls.Add(Me.mtlErrorMessage)
        Me.Controls.Add(Me.mtlError)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmInfoMessageBox"
        Me.Padding = New System.Windows.Forms.Padding(23, 78, 23, 26)
        Me.ShowInTaskbar = False
        Me.Text = "frmInfoMessageBox"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mtlError As MetroFramework.Controls.MetroLabel
    Friend WithEvents mtlErrorMessage As MetroFramework.Controls.MetroLabel
    Friend WithEvents mtbOk As MetroFramework.Controls.MetroButton
    Friend WithEvents hmpMessage As MetroFramework.Drawing.Html.HtmlPanel
End Class
