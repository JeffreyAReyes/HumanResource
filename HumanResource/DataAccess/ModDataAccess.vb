
Imports MySql.Data.MySqlClient

''' <summary>
''' Group of procedures used in accessing database
''' </summary>

Module ModDataAccess

    ''' <summary>
    ''' Generates database connection string 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetConnectionString() As String

        Dim strConn As String = ""

        Dim strHost As String = My.Settings.DatabaseHost
        Dim strDatabase As String = My.Settings.DatabaseName
        Dim strUser As String = My.Settings.DatabaseUser
        Dim strPass As String = My.Settings.DatabasePass
        Dim strPort As String = My.Settings.DatabasePort

        'Server=myServerAddress;Database=myDataBase;Uid=myUsername;Pwd=myPassword;

        strConn = "Server=" & strHost & ";port=" & strPort & ";Database=" & strDatabase & ";" _
                & "Uid=" & strUser & ";Pwd=" & strPass & ";"

        Return strConn

    End Function

    ''' <summary>
    ''' Retrieve data and returns data table. intCommandType 1=Text,4=SP,512=TableDirect
    ''' 
    ''' </summary>
    ''' <param name="strConn"></param>
    ''' <param name="strQuery"></param>
    ''' <param name="intCommandType"></param>
    ''' <param name="paramList"></param>
    ''' <returns></returns>
    ''' <remarks>
    ''' A generic method of executing sql statement. Accepts any number of parameters to pass to the sql statement.
    ''' June 29, 2012 1:53 PM JA Reyes
    ''' </remarks>
    Public Function DALGetDataAndReturnADataTable(ByVal strConn As String, ByVal strQuery As String, ByVal intCommandType As Integer, ByVal paramList As Dictionary(Of String, String)) As DataTable

        Dim mytable As New DataTable

        Using myconn As New MySqlConnection(strConn)

            Using mycommand As New MySqlCommand
                With mycommand
                    .Connection = myconn
                    .CommandType = intCommandType
                    '.CommandType =
                    .CommandText = strQuery

                    'iterate parameters
                    For Each key In paramList.Keys
                        .Parameters.AddWithValue(key, paramList(key))
                    Next

                    myconn.Open()

                    Using myadapter As New MySqlDataAdapter
                        myadapter.SelectCommand = mycommand
                        myadapter.Fill(mytable)
                    End Using
                End With
            End Using
        End Using


        Return mytable

    End Function

    ''' <summary>
    ''' Executes a sql statement. Returns boolean, True if successful. intCommandType 1=Text,4=SP,512=TableDirect
    ''' </summary>
    ''' <param name="strConn"></param>
    ''' <param name="strQuery"></param>
    ''' <param name="intCommandType"></param>
    ''' <param name="paramList"></param>
    ''' <returns></returns>
    ''' <remarks>
    ''' A generic method of executing sql statement. Accepts any number of parameters to pass to the sql statement.
    ''' June 29, 2012 1:57 PM JA Reyes
    ''' </remarks>
    Public Function DalExecuteSPNonQuery(ByVal strConn As String, ByVal strQuery As String, ByVal intCommandType As Integer, ByVal paramList As Dictionary(Of String, String)) As Boolean

        Dim boolReturn As Boolean

        Try
            Using myconn As New MySqlConnection(strConn)

                Using mycommand As New MySqlCommand
                    With mycommand
                        .Connection = myconn
                        .CommandType = intCommandType
                        .CommandText = strQuery

                        'iterate parameters
                        For Each key In paramList.Keys
                            .Parameters.AddWithValue(key, paramList(key))
                        Next

                        myconn.Open()

                        mycommand.ExecuteNonQuery()

                    End With
                End Using
            End Using
            boolReturn = True
        Catch ex As MySqlException
            Dim newfrm As New frmInfoMessageBox

            With newfrm
                .Message = ex.Message & vbCrLf & ex.StackTrace
                .MessageType = "Error"
                .FormCaption = "Error. MySqlException"
                .ShowDialog()
            End With
            Debug.Print(ex.Message & vbCrLf & ex.StackTrace & vbCrLf & " MySqlException. In SIExecuteSPNonQuery." & strQuery)
            boolReturn = False

        Catch ex As Exception
            Dim newfrm As New frmInfoMessageBox

            With newfrm
                .Message = ex.Message & vbCrLf & ex.StackTrace
                .MessageType = "Error"
                .FormCaption = "Error. Exception"
                .ShowDialog()
            End With
            Debug.Print(ex.Message & vbCrLf & ex.StackTrace & vbCrLf & " MySqlException. In SIExecuteSPNonQuery." & strQuery)

            boolReturn = False
        End Try

        Return boolReturn

    End Function


End Module
