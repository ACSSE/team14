Imports System.Data
Imports System.Data.SqlClient



Public Class Register
    Inherits System.Web.UI.Page

    Private connection As SqlConnection
    Private command As SqlCommand
    Private reader As SqlDataReader

    Protected Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not IsPostBack Then

            Dim command As SqlCommand
            Dim reader As SqlDataReader
            Dim connection As SqlConnection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\HandymanDatabase.mdf;Integrated Security=True")

            Dim commandstring As String = "SELECT DISTINCT (Town) FROM Location"

            connection.Open()
            command = New SqlCommand(commandstring, connection)
            reader = command.ExecuteReader()

            While reader.Read()
                regionList.Items.Add(reader.GetValue(0).ToString)
            End While
            connection.Close()
        End If
    End Sub

    Protected Sub btnReg_Click(sender As Object, e As EventArgs) Handles btnReg.ServerClick


        Dim username As String = ""
        Dim password As String = ""
        Dim name As String = ""
        Dim surname As String = ""
        Dim email As String = ""
        Dim numbers As String = ""
        Dim region As String = ""
        Dim address As String = ""


        Dim tempClient As Client = New Client(username)

        If tempClient.getUsername() = "" Then
            username = txtUsername.Text()
            password = txtPassword.Text()
            name = txtName.Text()
            surname = txtSurname.Text()
            email = txtEmail.Text()
            numbers = txtMobile.Text()
            address = txtAddress.Text()

            Dim client As Client = New Client(username, password, name, surname, email, numbers, address, region)

            client.saveUser()
            Dim cUser As User = client
            Session("user") = cUser
            'Session("UserName") = User
            Response.Redirect("ClientProfile.aspx")
        End If

    End Sub

   

    Protected Sub regionList_SelectedIndexChanged(sender As Object, e As EventArgs)



    End Sub
End Class