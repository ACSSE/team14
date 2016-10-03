Imports System.Data.SqlClient

Public Class UpdateProfile
    Inherits System.Web.UI.Page

    'Private user As String = ""
    Private type As String = ""

    Private name As String = ""
    Private surname As String = ""
    Private numbers As Integer
    Private mail As String = ""
    Private password As String = ""
    Private username As String = ""

    Private sqlString As String = ""
    Private paramString As String = "("


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        ' user = Request.QueryString("username") 'update link will carry either user=handyman or client
        type = Request.QueryString("user")
        'MsgBox(type)
        workerDetails.Visible = False
        clientDetails.Visible = False

        'for displayinmg initial information for respective handyan and client
        If type = "client" Then
            displayClient()
        Else
            displayHandyman()
        End If
    End Sub


    Protected Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.ServerClick
        '  MsgBox("button pressed")
        ' If Page.IsPostBack Then
        If type = "handyman" Then
            'MsgBox("In worker if tag")
            updateWorker()
        Else
            '   MsgBox("In client if tag")
            updateClient()
        End If


        'End If

    End Sub

    Private Sub displayClient()

        'Dim connection As SqlConnection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Data.mdf;Integrated Security=True")
        'Dim query As String = "SELECT * FROM LoginClient WHERE UserName = @name;"
        'connection.Open()

        'Dim command As SqlCommand = New SqlCommand(query, connection)
        'command.Parameters.AddWithValue("@name", Session("UserName"))

        'Dim reader As SqlDataReader = command.ExecuteReader()

        'If reader.HasRows Then
        'reader.Read()

        Dim c As User = Session("User")
        Dim client As Client = c
        clientDetails.Visible = True

        lblName.Visible = True
        lblSurname.Visible = True
        lblNumber.Visible = True
        lblAddress.Visible = True
        lblEmail.Visible = True

        lblUsername.InnerText = client.getUsername()
        lblName.InnerText = client.getName()
        lblSurname.InnerHtml = client.getSurname()
        lblNumber.InnerText = client.getNumbers()
        lblAddress.InnerText = client.getAddress()
        lblEmail.InnerText = client.getEmail()



        'End If

        ''For adding ads that client mades
        'connection.Close()
        'Command = Nothing
        'reader = Nothing
    End Sub

    Private Sub displayHandyman()
        'MsgBox("Inside the displayHandyman()")
        'Dim connection As SqlConnection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Data.mdf;Integrated Security=True")
        'Dim query As String = "SELECT * FROM LoginWorker WHERE UserName = @name;"
        'connection.Open()

        'Dim command As SqlCommand = New SqlCommand(query, connection)
        'command.Parameters.AddWithValue("@name", Session("UserName"))

        'Dim reader As SqlDataReader = command.ExecuteReader()

        Dim category As String = "" 'to assist in displaying the correct types of jobs

        'If reader.HasRows Then

        '    reader.Read()

        workerDetails.Visible = True

        ' lblRegion.Visible = True

        Dim c As User = Session("user")
        Dim worker As Worker = c
        lblName.Visible = True
        lblSurname.Visible = True
        lblNumber.Visible = True
        lblEmail.Visible = True
        lblDescription.Visible = True
        lblTitle.Visible = True
        category = worker.getCategory()
        lblTitle.InnerText = category 'setting the correct heading category
        'lblRegion.InnerText = reader("Region")


        lblName.InnerText = worker.getName()
        lblSurname.InnerHtml = worker.getSurname()
        lblNumber.InnerText = worker.getNumbers()
        lblEmail.InnerText = worker.getEmail()
        lblDescription.InnerText = worker.getDescription()
        '   End If

    End Sub




    'common elements to be changed here
    Private Sub getBasics()


        Dim user As User = Session("user")

        Dim name As String = ""
        Dim surname As String = ""
        Dim numbers As String = ""
        Dim email As String = ""
        Dim username As String = ""
        Dim password As String = ""

        'updating fields that have been filled out
        If ValidationClass.equateText(name, txtName.Value) Then
            user.updateName(name)
        End If
        If ValidationClass.equateText(surname, txtSurname.Value) Then
            user.updateSurname(surname)
        End If
        If ValidationClass.equateText(numbers, txtNumber.Value) Then
            user.updateNumbers(numbers)
        End If
        If ValidationClass.equateText(email, txtEmail.Value) Then
            user.updateEmail(email)
        End If
        If ValidationClass.equateText(password, txtPassword.Value) Then
            user.updatePassword(password)
        End If

        Session("user") = user
        'Dim bracket As Integer = 0


        'If txtName.Value IsNot "" Then
        '    name = txtName.Value
        '    sqlString &= "Name = @name"
        '    paramString &= ""
        '    bracket += 1
        'End If



        'If Not txtSurname.Value = "" Then
        '    surname = txtSurname.Value
        '    If bracket > 0 Then 'if there is a value before
        '        sqlString &= ", "
        '        paramString &= ", "
        '    End If

        '    sqlString &= "SurName = @surname"
        '    paramString &= ""
        '    bracket += 1
        'End If


        'If txtUsername.Value IsNot "" Then
        '    username = txtUsername.Value()
        '    If bracket > 0 Then 'if there is a value before
        '        sqlString &= ", "
        '        paramString &= ", "
        '    End If

        '    sqlString &= "UserName = @username"
        '    paramString &= ""
        '    bracket += 1
        'End If


        'If txtPassword.Value IsNot "" Then
        '    password = txtPassword.Value
        '    If bracket > 0 Then 'if there is a value before
        '        sqlString &= ", "
        '        paramString &= ", "
        '    End If

        '    sqlString &= "Password = @password"
        '    paramString &= ""
        '    bracket += 1
        'End If


        'If txtNumber.Value IsNot "" Then
        '    numbers = txtNumber.Value
        '    If bracket > 0 Then 'if there is a value before
        '        sqlString &= ", "
        '        paramString &= ", "
        '    End If

        '    sqlString &= "MobileNumber = @number"
        '    paramString &= ""
        '    bracket += 1
        'End If


        'If txtEmail.Value IsNot "" Then
        '    mail = txtEmail.Value
        '    If bracket > 0 Then 'if there is a value before
        '        sqlString &= ", "
        '        paramString &= ", "
        '    End If

        '    sqlString &= "Email = @mail"
        '    paramString &= ""
        'End If


    End Sub

    Private Sub updateWorker()
        getBasics()

        Dim user As User = Session("user")
        Dim worker As Worker = user

        Dim jobDescription As String = ""
        Dim category As String = ""

        If ValidationClass.equateText(jobDescription, txtDescription.Value) Then
            worker.updateDescription(jobDescription)
        End If

        Response.Redirect("WorkerProfile.aspx")
        'Dim bracket As Integer = 0
        'Dim title As String = ""
        'Dim descritpion As String = ""

        'If sqlString = "" Then
        '    If txtTitle.Value IsNot "" Then
        '        sqlString &= "JobTitle = @title"
        '        ' paramString &= ""
        '        bracket += 1
        '    End If

        'Else
        '    If txtTitle.Value IsNot "" Then
        '        sqlString &= ", JobTitle = @title"
        '        paramString &= ", "
        '        bracket += 1
        '    End If

        'End If

        'If bracket = 0 Then
        '    '   MsgBox("Bracket = 0")
        '    If Not txtDescription.Value = "" Then
        '        ' MsgBox("Description has value")
        '        descritpion = txtDescription.Value
        '        sqlString &= "Description = @des"
        '        paramString &= ""
        '    End If
        'Else
        '    If Not txtDescription.Value = "" Then
        '        descritpion = txtDescription.Value
        '        sqlString &= ", Description = @des"
        '        paramString &= ""
        '    End If
        'End If
        '' sqlString &= ") "
        'Dim connection As SqlConnection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Data.mdf;Integrated Security=True")
        'Dim query As String = "UPDATE LoginWorker SET " & sqlString & " WHERE UserName = @user;"
        ''MsgBox(query)

        'connection.Open()

        'Dim command As SqlCommand = New SqlCommand(query, connection)
        'command.Parameters.AddWithValue("@user", Session("UserName"))
        'command.Parameters.AddWithValue("@name", name)
        'command.Parameters.AddWithValue("@surname", surname)
        'command.Parameters.AddWithValue("@password", password)
        'command.Parameters.AddWithValue("@mail", mail)
        'command.Parameters.AddWithValue("@number", numbers)
        'command.Parameters.AddWithValue("@title", title)
        'command.Parameters.AddWithValue("@des", descritpion)

        'Dim reader As SqlDataReader = command.ExecuteReader()

        ''closing database
        'connection.Close()
        'command = Nothing
        'reader = Nothing

    End Sub

    Private Sub updateClient()
        '  MsgBox("In updateClient()")
        getBasics()



        Dim user As User = Session("user")
        Dim client As Client = user

        Dim address As String = ""


        If ValidationClass.equateText(address, txtAddress.Value) Then
            client.updateAddress(address)
        End If

        client.updateUser()
        user = client
        Session("user") = user

        Response.Redirect("ClientProfile.aspx")

    End Sub


End Class