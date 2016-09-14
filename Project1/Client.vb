Imports System.Data.SqlClient

Public Class Client
    Inherits User

    Private address As String

    Public Sub New(vusername As String, vpassword As String, vname As String, vsurname As String, vemail As String, mnumbers As String, vaddress As String, vregion As String, vsuburb As String, vdate As Date)
        MyBase.New(vusername, vpassword, vname, vsurname, vemail, mnumbers, vregion, vsuburb, vdate)
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

        connection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\HandymanDatabase.mdf;Integrated Security=True")
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
            region = reader("Region")
            suburb = reader("Suburb")
            address = reader("Address")
            JoinDate = reader("JoinDate")
        End If

    End Sub

    Private Sub getPartialClientInfo(username As String) 'to be used when obtaining part of the client's information
        Dim connection As SqlConnection
        Dim command As SqlCommand
        Dim reader As SqlDataReader

        connection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\HandymanDatabase.mdf;Integrated Security=True")
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
            email = ""
            numbers = 0
            region = ""
            address = ""
            suburb = ""
            JoinDate = ""

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

            Dim commandstring As String = "INSERT INTO Clients ( Username, Password, Name, Surname,  MobileNumber, Email, Address, Region , Suburb, JoinDate) VALUES (@username, @password, @name, @surname, @mobil, @email, @address, @region, @suburb, @date)"
            connection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\HandymanDatabase.mdf;Integrated Security=True")
            connection.Open()
            command = New SqlCommand(commandstring, connection)

            command.Parameters.AddWithValue("@name", name)
            command.Parameters.AddWithValue("@surname", surname)
            command.Parameters.AddWithValue("@username", username)
            command.Parameters.AddWithValue("@password", password)
            command.Parameters.AddWithValue("@address", address)
            command.Parameters.AddWithValue("@mobil", numbers)
            command.Parameters.AddWithValue("@email", email)
            command.Parameters.AddWithValue("@region", region)
            command.Parameters.AddWithValue("@suburb", suburb)
            command.Parameters.AddWithValue("@date", JoinDate.Date)
            reader = command.ExecuteReader()

            connection.Close()
        End If
        addToAverageDatabase() 'to add the client to rating so that he/she can be rated
    End Sub

    'for updating the record in the database
    Public Overrides Sub updateUser()
        Dim connection As SqlConnection
        Dim command As SqlCommand
        Dim reader As SqlDataReader
        'UPDATE LoginClient Set [] WHERE Username = @user
        Dim commandstring As String = "UPDATE Clients SET Username = @username, Name = @name,  Surname = @surname,  Address = @address, MobileNumber = @mobil, Email = @email, Region = @region, Suburb = @suburb  WHERE Username = @username"
        connection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\HandymanDatabase.mdf;Integrated Security=True")
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
        command.Parameters.AddWithValue("@region", region)
        command.Parameters.AddWithValue("@suburb", suburb)

        reader = command.ExecuteReader()

        connection.Close()

    End Sub

    Public Overrides Function getRating() As Integer
        Dim connection As SqlConnection
        Dim command As SqlCommand
        Dim reader As SqlDataReader

        connection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\HandymanDatabase.mdf;Integrated Security=True")
        Dim commandstring As String = "SELECT * From AverageClientRating WHERE Client = @user"
        command = New SqlCommand(commandstring, connection)
        command.Parameters.AddWithValue("@user", username)

        command.Connection.Open()
        reader = command.ExecuteReader()

        If reader.HasRows Then
            reader.Read()
            Me.username = username
            'Me.password = reader("Password")
            name = reader("Name")
            surname = reader("Surname")
            email = reader("Email")
            numbers = reader("MobileNumber")
            region = reader("Region")
            suburb = reader("Suburb")
            address = reader("Address")
            JoinDate = reader("JoinDate")
        End If
        Return 0
    End Function

    

    Public Overrides Sub updateAverage(average As Integer)
        'update average rating
        Dim adconnection As SqlConnection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\HandymanDatabase.mdf;Integrated Security=True")
        adconnection.Open()
        Dim query As String = "UPDATE AverageClientRating SET AverageRating = @average WHERE Client = @worker;"
        Dim command As SqlCommand = New SqlCommand(query, adconnection)
        command.Parameters.AddWithValue("@average", average)
        command.Parameters.AddWithValue("@worker", username)
        Dim reader As SqlDataReader = command.ExecuteReader()
        adconnection.Close()
    End Sub



    Private Sub addToAverageDatabase()
        Dim adconnection As SqlConnection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\HandymanDatabase.mdf;Integrated Security=True")
        adconnection.Open()
        Dim query As String = "INSERT INTO AverageClientRating (Client, AverageRating) VALUES (@worker, @average);"
        Dim command As SqlCommand = New SqlCommand(query, adconnection)
        command.Parameters.AddWithValue("@average", 0)
        command.Parameters.AddWithValue("@worker", username)
        Dim reader As SqlDataReader = command.ExecuteReader()
        adconnection.Close()
    End Sub

    



End Class
