
Imports MySql.Data.MySqlClient

Public Class frmMain

#Region "Database"


#End Region
    Private Sub frmMain_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown

        Dim newfrm As New frmLogin

        With newfrm
            .Owner = Me
            .ShowDialog()
            If .IsLogged = True Then
                mtEmployees.Visible = True
                mtDepartments.Visible = True
                hmpWelcome.Text = "Welcome, " & CurrentUserName
            End If
        End With

        'Form visual settings
        With Me
            '.msmManager.Theme = MetroFramework.MetroThemeStyle.Dark
            '.msmManager.Style = MetroFramework.MetroColorStyle.Black
        End With
    End Sub

    Private Sub mtEmployees_Click(sender As Object, e As EventArgs) Handles mtEmployees.Click
        Dim newfrm As New frmListOfEmployees

        With newfrm
            .Owner = Me
            .ShowDialog()
        End With
    End Sub

    Private Sub mtDepartments_Click(sender As Object, e As EventArgs) Handles mtDepartments.Click
        Dim newfrm As New frmListOfDepartments

        With newfrm
            .Owner = Me
            .ShowDialog()
        End With
    End Sub
End Class
