
Imports MySql.Data.MySqlClient

Public Class frmAddEditEmployee

#Region "Properties"

    Public Property IsAdding As Boolean
    Public Property MustUpdateListForm As Boolean
    Public Property CurrentEmpID As Integer

#End Region

#Region "Database"

    Private Function AddEditData() As Boolean

        Dim boolResult As Boolean

        Dim paramList As New Dictionary(Of String, String)
        Dim strSQL As String = "AddEditEmployee"

        Try
            With paramList


                If Me.IsAdding = True Then
                    .Add("pIsAdding", 0)
                    .Add("pEmpID", 0)
                ElseIf Me.IsAdding = False Then
                    .Add("pIsAdding", 1)
                    .Add("pEmpID", CurrentEmpID)
                End If

                .Add("pIDNumber", Me.mtxEmpID.Text)
                .Add("pLastName", Me.mtxLastName.Text)
                .Add("pFirstName", Me.mtxtFirstName.Text)
                .Add("pMiddleName", Me.mtxMiddleName.Text)
                .Add("pSuffix", Me.mtxSuffix.Text)

                'convert date for mysql date type

                .Add("pBirthDate", Me.dtpBirthdate.Value.Date.Year & "/" & Me.dtpBirthdate.Value.Date.Month & "/" &
                     Me.dtpBirthdate.Value.Date.Day)
                .Add("pHireDate", Me.dtpHireDate.Value.Date.Year & "/" & Me.dtpHireDate.Value.Date.Month & "/" &
                     Me.dtpHireDate.Value.Date.Day)

                .Add("pGender", Me.cboGender.Text.Substring(0, 1))
                .Add("pMaritalStatus", Me.cboMarital.Text)


                .Add("pCurrentFlag", "1")

                boolResult = DalExecuteSPNonQuery(GetConnectionString, strSQL, 4, paramList)

            End With
        Catch ex As Exception

            boolResult = False

            Dim newfrm As New frmInfoMessageBox

            With newfrm
                .Message = ex.Message & vbCrLf & ex.StackTrace
                .MessageType = "Error"
                .FormCaption = "Error. Exception"
                .ShowDialog()
            End With
        End Try

        Return boolResult

    End Function

#End Region

    Private Sub mtlClose_Click(sender As Object, e As EventArgs) Handles mtlClose.Click
        Me.Close()
    End Sub

    Private Sub mtlSave_Click(sender As Object, e As EventArgs) Handles mtlSave.Click

        If AddEditData() = True Then
            Me.MustUpdateListForm = True
            Me.Close()
        Else

        End If
    End Sub

    Private Sub frmAddEditEmployee_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        Select Case e.KeyCode
            Case Keys.Enter
                SendKeys.Send(vbTab)
        End Select
    End Sub
End Class