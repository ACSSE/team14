Public Class generateQuotation
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnReg_Click(sender As Object, e As EventArgs) Handles btnReg.ServerClick

        'Dim description As String = ""
        'Dim hours As String = ""
        'Dim amount As String = ""


        'Dim tempClient As Worker = New Worker(username, password)

        'If tempClient.getUsername() = "" Then
        '    username = txtUsername.Text()
        '    password = txtPassword.Text()
        '    name = txtName.Text()
        '    surname = txtSurname.Text()
        '    email = txtEmail.Text()
        '    numbers = txtMobile.Text()
        '    ' category  'categoriesList.SelectedValue() 'txtTitle.Text()

        '    'To obtain string with all the selected categories
        '    For i As Integer = 0 To lstCategory.Items.Count() - 1
        '        If lstCategory.Items(i).Selected() Then 'list of selsected items
        '            If category = "" Then
        '                category = lstCategory.Items(i).Text() 'getting the slected item
        '            Else
        '                category &= " & " & lstCategory.Items(i).Text()
        '            End If
        '        End If
        '    Next i

        '    MsgBox("RegisterWorker():btnReg- category = " & category)

        '    description = txtDescription.Text()

        '    Dim worker As Worker = New Worker(username, password, name, surname, email, numbers, region, description, category, Nothing)
        '    worker.saveUser()
        '    Dim cUser As User = worker
        '    Session("user") = cUser
        '    'Session("UserName") = User
        '    Response.Redirect("WorkerProfile.aspx")
        'End If

    End Sub

End Class