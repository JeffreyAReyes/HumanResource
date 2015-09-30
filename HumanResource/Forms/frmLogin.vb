
Imports MySql.Data.MySqlClient

Public Class frmLogin

#Region "Properties"

    Public Property IsLogged As Boolean

#End Region

#Region "Global Variables"

    Dim mytable As New DataTable

#End Region

#Region "Database"

    Private Function GetListOfUsers() As Boolean

        Dim boolSuccess As Boolean


        Dim strQuery As String = "GetUsers"

        Dim paramList As New Dictionary(Of String, String)

        paramList.Add("pIsActive", "0")

        Try
            mytable = DALGetDataAndReturnADataTable(GetConnectionString, strQuery, 4, paramList)
            boolSuccess = True

        Catch ex As Exception
            Dim newfrm As New frmInfoMessageBox

            With newfrm
                .Message = ex.Message & vbCrLf & ex.StackTrace
                .MessageType = "Error"
                .FormCaption = "Error. MySqlException"
                .ShowDialog()
            End With
        End Try

        Return boolSuccess

    End Function

#End Region

    Private Sub mtlClose_Click(sender As Object, e As EventArgs) Handles mtlClose.Click
        IsLogged = False
        Me.Close()
    End Sub

    Private Sub mtlLogin_Click(sender As Object, e As EventArgs) Handles mtlLogin.Click

        If Me.mtxLoginName.Text.Length <= 0 Then
            Me.mtxLoginName.Focus()
            Exit Sub
        End If

        If Me.mtxPassword.Text.Length <= 0 Then
            Me.mtxPassword.Focus()
            Exit Sub
        End If

        Dim strName As String = Me.mtxLoginName.Text
        Dim strPassword As String = Me.mtxPassword.Text

        For Each row As DataRow In mytable.Rows
            If row("UserName") = Me.mtxLoginName.Text Then
                If row("UserPassword") = Me.mtxPassword.Text Then
                    CurrentUserName = row("FullName").ToString
                    CurrentPrivilege = row("SysPrivilege").ToString
                    Me.IsLogged = True
                    Me.Close()
                    Exit For

                End If
            Else

            End If
        Next

    End Sub

    Private Sub frmLogin_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp

        Select Case e.KeyCode
            Case Keys.Enter
                SendKeys.Send(vbTab)
        End Select
    End Sub

    Private Sub frmLogin_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        'Get list of users from the database
        If GetListOfUsers() = True Then
            Debug.Print("Got list of users")
        Else
            Debug.Print("Error getting list of users.")
        End If
    End Sub

    Private Sub mtxPassword_Click(sender As Object, e As EventArgs) Handles mtxPassword.Click

    End Sub
End Class