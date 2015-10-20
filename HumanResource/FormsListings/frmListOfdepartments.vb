
Imports MySql.Data.MySqlClient

Public Class frmListOfDepartments

#Region "Variables"

    Dim mytable As New DataTable

#End Region

#Region "Database"

    Private Function GetDepartments() As Boolean

        Dim boolSuccess As Boolean

        Dim strQuery As String = "GetDepartments"

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

        If GetDepartments() = True Then

            'insert data into datagridview

            If mytable.Rows.Count > 0 Then
                For Each row As DataRow In mytable.Rows
                    With Me.mtgEmployees.Rows
                        .Add(row("DeptNo"), row("DeptName"))
                    End With
                Next
            Else

            End If
        Else

        End If
    End Sub

#End Region

    Private Sub frmListOfDepartments_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        GetDataAndShowInGrid()
    End Sub




End Class