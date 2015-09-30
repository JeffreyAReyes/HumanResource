
Imports MySql.Data.MySqlClient

Public Class frmListOfEmployees



#Region "Variables"

    Dim mytable As New DataTable

#End Region

#Region "Database"

    Private Function GetListOfUsers() As Boolean

        Dim boolSuccess As Boolean

        Dim strQuery As String = "GetEmployees"

        Dim paramList As New Dictionary(Of String, String)

        paramList.Add("pIsActive", "1")

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

            boolSuccess = False
        End Try

        Return boolSuccess

    End Function

#End Region

#Region "Helper"

    Private Sub GetDataAndShowInGrid()

        If GetListOfUsers() = True Then

            'insert data into datagridview

            If mytable.Rows.Count > 0 Then
                For Each row As DataRow In mytable.Rows
                    With Me.mtgEmployees.Rows
                        .Add(row("EmpID"), row("IDNumber"), row("EmpName"), row("LastName"), row("FirstName"), row("MiddleName"), row("Suffix"), row("BirthDate"),
                             row("Gender"), row("MaritalStatus"), row("HireDate"))
                    End With
                Next
            Else

            End If
        Else

        End If
    End Sub

#End Region

    Private Sub frmListOfEmployees_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        GetDataAndShowInGrid()

    End Sub

    Private Sub mtlAdd_Click(sender As Object, e As EventArgs) Handles mtlAdd.Click

        Dim newfrm As New frmAddEditEmployee

        With newfrm
            .IsAdding = True
            .Owner = Me
            .ShowDialog()
            If .MustUpdateListForm = True Then
                Me.mtgEmployees.Rows.Clear()
                GetDataAndShowInGrid()
                MessageBox.Show("Done saving new employee", "Added new employee", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End With
    End Sub

    Private Sub mtlClose_Click(sender As Object, e As EventArgs) Handles mtlClose.Click
        Me.Close()
    End Sub
End Class