Public Class UserReturned
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim user As String = Request.QueryString("username")
        Dim type As String = Request.QueryString("type")
        'MsgBox("type=" & type)
        Dim cuser As User

        If type = "client" Then
            'MsgBox("in client if-statement")
            'blockClient(user)
            cuser = New Client(user, True)
        Else
            'MsgBox("in else if-statement")
            'blockWorker(user)
            cuser = New Worker(user, True)
        End If
        cuser.updateStatus("OPEN") 'changing user to blocked
        cuser.updateUser() 'updating user
        divMes.InnerHtml = "<p>User " & cuser.getUsername() & " is now unblocked</p>"
    End Sub

End Class