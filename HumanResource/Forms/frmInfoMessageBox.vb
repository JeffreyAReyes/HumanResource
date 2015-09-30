


Public Class frmInfoMessageBox

#Region "Properties"

    Public Property Message As String
    Public Property MessageType As String
    Public Property FormCaption As String

#End Region

    Private Sub frmInfoMessageBox_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        With Me
            'mtlErrorMessage.Text = Message
            .Text = FormCaption
            .hmpMessage.Text = Message
        End With
    End Sub

    Private Sub mtbOk_Click(sender As Object, e As EventArgs) Handles mtbOk.Click
        Me.Close()
    End Sub
End Class