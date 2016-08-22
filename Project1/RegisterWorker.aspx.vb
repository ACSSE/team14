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

    Protected Sub btnReg_Click(sender As Object, e As EventArgs) Handles btnSubmit.ServerClick

0:
        Dim username As String = ""
        Dim password As String = ""
        Dim name As String = ""
        Dim surname As String = ""
        Dim email As String = ""
        Dim numbers As String = ""
        Dim region As String = ""
        Dim category As String = ""
        Dim description As String = ""


        Dim tempClient As Worker = New Worker(username, password)

        If tempClient.getUsername() = "" Then
            username = txtUsername.Text()
            password = txtPassword.Text()
            name = txtName.Text()
            surname = txtSurname.Text()
            email = txtEmail.Text()
            numbers = txtMobile.Text()
            ' category  'categoriesList.SelectedValue() 'txtTitle.Text()

            'To obtain string with all the selected categories
            For i As Integer = 0 To lstCategory.Items.Count() - 1
                If lstCategory.Items(i).Selected() Then 'list of selsected items
                    If category = "" Then
                        category = lstCategory.Items(i).Text() 'getting the slected item
                    Else
                        category &= "&" & lstCategory.Items(i).Text()
                    End If
                End If
            Next i

            'MsgBox("RegisterWorker():btnReg- category = " & category)

            description = txtDescription.Text()

            Dim worker As Worker = New Worker(username, password, name, surname, email, numbers, region, description, category, Nothing)
            worker.saveUser()
            Dim cUser As User = worker
            Session("user") = cUser
            'Session("UserName") = User
            Response.Redirect("WorkerProfile.aspx")
        End If

        'If Page.IsValid Then
        '    If txtUsername.Text = "" Then
        '        lblCheck.InnerText = "Username Invalid"
        '    Else
        '        connection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Data.mdf;Integrated Security=True")

        '        Dim userExist As SqlCommand = New SqlCommand("SELECT * FROM LoginWorker WHERE UserName=@UN")
        '        userExist.Parameters.AddWithValue("@UN", txtUsername.Text)

        '        userExist.Connection = connection
        '        connection.Open()

        '        reader = userExist.ExecuteReader(CommandBehavior.CloseConnection)

        '        If reader.HasRows Then
        '            lblCheck.InnerText = "Username already exists"
        '            userExist.Dispose()
        '            reader.Close()
        '        Else
        '            userExist.Dispose()
        '            reader.Close()

        '            command = New SqlCommand("INSERT INTO LoginWorker (Name, SurName, UserName, Password, MobileNumber, Email, Category, Region, JobTitle, Description) VALUES (@name, @surname, @username, @password, @mobil, @email, @category, @region, @jobtitle, @description)")
        '            command.Parameters.AddWithValue("@name", txtName.Text)
        '            command.Parameters.AddWithValue("@surname", txtSurname.Text)
        '            command.Parameters.AddWithValue("@username", txtUsername.Text)
        '            command.Parameters.AddWithValue("@password", Secrecy.HashPassword(txtPassword.Text))
        '            command.Parameters.AddWithValue("@mobil", txtMobile.Text)
        '            command.Parameters.AddWithValue("@email", txtEmail.Text)
        '            command.Parameters.AddWithValue("@category", categoriesList.Text)
        '            command.Parameters.AddWithValue("@region", regionList.Text)
        '            command.Parameters.AddWithValue("@JobTitle", txtTitle.Text)
        '            command.Parameters.AddWithValue("@description", txtDescription.Text)
        '            'command.Parameters.AddWithValue("@logo", fileSelect.PostedFile)


        '            command.Connection = connection
        '            connection.Open()
        '            command.ExecuteNonQuery()

        '            Session("UserName") = txtUsername.Text

        '            Response.Redirect("WorkerProfile.aspx? UserName=" & txtUsername.Text)

        '            command.Connection.Close()
        '            command.Dispose()
        '            connection.Dispose()

        '        End If
        '    End If
        'End If


        'Response.Redirect("WorkerProfile.aspx? UserName=" & txtUsername.Text)
    End Sub

    Protected Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.ServerClick

       
    End Sub

End Class