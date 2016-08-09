Imports System.Data.SqlClient

Public Class Client
    Inherits User

    Private address As String

    Public Sub New(vusername As String, vpassword As String, vname As String, vsurname As String, vemail As String, mnumbers As String, vaddress As String, vregion As String)
        MyBase.New(vusername, vpassword, vname, vusername, vemail, mnumbers, vregion)
        address = vaddress
    End Sub

    Public Sub New(username As String, password As String)
        MyBase.New()
        getClient(username, password)
    End Sub

    Public Sub New(username As String)
        getPartialClientInfo(username)
    End Sub

    Private Sub getClient(username As String, password As String)
        Dim connection As SqlConnection
        Dim command As SqlCommand
        Dim reader As SqlDataReader
        password = Secrecy.HashPassword(password)

        connection = New SqlConnection(ValidationClass.CONNECTIONSTRING)
        Dim commandstring As String = "SELECT * From Clients WHERE Username = @user AND Password = @pass"
        command = New SqlCommand(commandstring, connection)
        command.Parameters.AddWithValue("@user", username)
        command.Parameters.AddWithValue("@pass", password)

        command.Connection.Open()
        reader = command.ExecuteReader()

        If reader.HasRows Then
            reader.Read()
            Me.username = username
            Me.password = reader("Password")
            name = reader("Name")
            surname = reader("Surname")
            email = reader("Email")
            numbers = reader("MobileNumber")
            region = ""
            address = reader("Address")
        End If

    End Sub

    Private Sub getPartialClientInfo(username As String) 'to be used when obtaining part of the client's information
        Dim connection As SqlConnection
        Dim command As SqlCommand
        Dim reader As SqlDataReader

        connection = New SqlConnection(ValidationClass.CONNECTIONSTRING)
        Dim commandstring As String = "SELECT * From Clients WHERE Username = @user"
        command = New SqlCommand(commandstring, connection)
        command.Parameters.AddWithValue("@user", username)

        command.Connection.Open()
        reader = command.ExecuteReader()

        If reader.HasRows Then
            reader.Read()
            Me.username = username
            name = reader("Name")
            surname = reader("Surname")
            'email = reader("Email")
            email = ""
            ' numbers = reader("MobileNumber")
            numbers = 0
            region = ""
            'address = reader("Address")
            address = ""
        End If
    End Sub

    Public Function getAddress() As String
        Return address
    End Function

    Public Sub updateAddress(address As String)
        Me.address = address
    End Sub

    'for svaing a new record intoi the database
    Public Overrides Sub saveUser()

        Dim connection As SqlConnection
        Dim command As SqlCommand
        Dim reader As SqlDataReader

        Dim tempClient As Client = New Client(username, password)

        If tempClient.getUsername() = "" Then

            MsgBox("In Client-saveUser(): name = " & name)
            Dim commandstring As String = "INSERT INTO Clients ( Username, Password, Name, Surname,  MobileNumber, Email, Address) VALUES (@username, @password, @name, @surname, @mobil, @email, @address)"
            connection = New SqlConnection(ValidationClass.CONNECTIONSTRING)
            connection.Open()
            command = New SqlCommand(commandstring, connection)

            command.Parameters.AddWithValue("@name", name)
            command.Parameters.AddWithValue("@surname", surname)
            command.Parameters.AddWithValue("@username", username)
            command.Parameters.AddWithValue("@password", password)
            command.Parameters.AddWithValue("@address", address)
            command.Parameters.AddWithValue("@mobil", numbers)
            command.Parameters.AddWithValue("@email", email)

            reader = command.ExecuteReader()

            connection.Close()
        End If

    End Sub

    'for updating the record in the database
    Public Overrides Sub updateUser()
        Dim connection As SqlConnection
        Dim command As SqlCommand
        Dim reader As SqlDataReader
        'UPDATE LoginClient Set [] WHERE Username = @user
        Dim commandstring As String = "UPDATE Clients SET Username = @username, Name = @name,  Surname = @surname,  Address = @address, MobileNumber = @mobil, Email = @email WHERE Username = @username"
        connection = New SqlConnection(ValidationClass.CONNECTIONSTRING)
        connection.Open()
        command = New SqlCommand(commandstring, connection)

        MsgBox("In Client -updateUser(): " & name) 'program messages
        command.Parameters.AddWithValue("@username", username)
        command.Parameters.AddWithValue("@name", name)
        command.Parameters.AddWithValue("@surname", surname)
        command.Parameters.AddWithValue("@password", password)
        command.Parameters.AddWithValue("@address", address)
        command.Parameters.AddWithValue("@mobil", numbers)
        command.Parameters.AddWithValue("@email", email)

        reader = command.ExecuteReader()

        connection.Close()

    End Sub

    Protected Overrides Function getRating() As Integer
        Dim connection As SqlConnection
        Dim command As SqlCommand
        Dim reader As SqlDataReader

        connection = New SqlConnection(ValidationClass.CONNECTIONSTRING)
        Dim commandstring As String = "SELECT * From AverageClientRating WHERE Client = @user"
        command = New SqlCommand(commandstring, connection)
        command.Parameters.AddWithValue("@user", username)

        command.Connection.Open()
        reader = command.ExecuteReader()

        If reader.HasRows Then
            Dim rating As Integer = 0
            If Not IsDBNull(reader("AverageRating")) Then
                rating = reader("AverageRating")
            End If
            connection.Close()
            Return rating 'returning rating value
        End If
        Return 0
    End Function
End Class
