Imports System.Data
Imports System.Data.SqlClient
Public Class apply
    Inherits System.Web.UI.Page

    Private connection As SqlConnection
    Private command As SqlCommand
    Private reader As SqlDataReader

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not Page.IsPostBack Then
            txtUsername.Focus()
        End If

    End Sub

    Protected Sub btnReg_Click(sender As Object, e As EventArgs) Handles btnSubmitWorker.ServerClick


        Dim username As String = ""
        Dim password As String = ""
        Dim name As String = ""
        Dim surname As String = ""
        Dim email As String = ""
        Dim numbers As String = ""
        Dim region As String = ""
        Dim category As String = ""
        Dim description As String = ""
        Dim image As Image = Nothing



        Dim tempClient As Worker = New Worker(username, password)

        If tempClient.getUsername() = "" Then

            username = txtUsername.Text()
            password = txtPassword.Text()
            name = txtName.Text()
            surname = txtSurname.Text()
            email = txtEmail.Text()
            numbers = txtMobile.Text()
            region = regionList.SelectedItem().ToString()



            ' category  'categoriesList.SelectedValue() 'txtTitle.Text()

            'To obtain string with all the selected categories
            For i As Integer = 0 To lstCategory.Items.Count() - 1
                If lstCategory.Items(i).Selected() Then 'list of selsected items
                    If category = "" Then
                        category = lstCategory.Items(i).Text() 'getting the slected item
                    Else
                        category &= " & " & lstCategory.Items(i).Text()
                    End If
                End If
            Next i

            MsgBox("RegisterWorker():btnReg- category = " & category)

            description = txtDescription.Text()

            Dim worker As Worker = New Worker(username, password, name, surname, email, numbers, region, Date.Today.Date, description, category, Nothing)
            worker.saveUser()
            Dim cUser As User = worker
            Session("user") = cUser
            'Session("UserName") = User
            Response.Redirect("WorkerProfile.aspx")
        End If

    End Sub

    'Protected Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.ServerClick


    'End Sub

End Class