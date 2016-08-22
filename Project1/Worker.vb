<<<<<<< HEAD
﻿Imports System.Data.SqlClient

Public Class Worker
    Inherits User


    Private description As String
    Private logo As Image
    Private category As String

    'specialised constructor
    Public Sub New(vusername As String, vpassword As String, vname As String, vsurname As String, vemail As String, mnumbers As String, vregion As String, description As String, category As String, logo As Image)
        MyBase.New(vusername, vpassword, vname, vsurname, vemail, mnumbers, vregion)
        Me.description = description
        Me.logo = logo
        Me.category = category
    End Sub

    'basic constructor
    Public Sub New(username As String, password As String)
        MyBase.New()
        getWorker(username, password)
    End Sub

    Public Sub New(username As String)
        getPartialWorkerInfo(username)
    End Sub

    'getting handyman from database
    Private Sub getWorker(username As String, password As String)
        Dim connection As SqlConnection
        Dim command As SqlCommand
        Dim reader As SqlDataReader
        password = Secrecy.HashPassword(password)

        connection = New SqlConnection(ValidationClass.CONNECTIONSTRING)
        Dim commandstring As String = "SELECT * From Workers WHERE Username = @user AND Password = @pass"
        command = New SqlCommand(commandstring, connection)
        command.Parameters.AddWithValue("@user", username)
        command.Parameters.AddWithValue("@pass", password)

        command.Connection.Open()
        reader = command.ExecuteReader()
        If reader.HasRows Then
            reader.Read()
            Me.username = username
            name = reader("Name")
            surname = reader("Surname")
            email = reader("Email")
            numbers = reader("MobileNumber")
            region = ""
            'jobTitle = reader("JobTitle")
            description = reader("Description")
            category = reader("Category")

        End If
    End Sub

    Public Overrides Sub saveUser()
        ' MsgBox("Worker:saveUser()-inside function saveUser()")
        Dim connection As SqlConnection
        Dim command As SqlCommand
        Dim reader As SqlDataReader

        Dim commandstring As String = "INSERT INTO Workers (Name, Surname, Username, Password, MobileNumber, Email, Category, Region, Description) VALUES (@name, @surname, @username, @password, @mobil, @email, @category, @region, @description)"
        connection = New SqlConnection(ValidationClass.CONNECTIONSTRING)
        connection.Open()
        command = New SqlCommand(commandstring, connection)

        command.Parameters.AddWithValue("@name", name)
        command.Parameters.AddWithValue("@surname", surname)
        command.Parameters.AddWithValue("@username", username)
        command.Parameters.AddWithValue("@password", password)
        command.Parameters.AddWithValue("@mobil", numbers)
        command.Parameters.AddWithValue("@email", email)
        command.Parameters.AddWithValue("@category", category)
        command.Parameters.AddWithValue("@region", region)
        'command.Parameters.AddWithValue("@JobTitle", jobTitle)
        command.Parameters.AddWithValue("@description", description)
        reader = command.ExecuteReader()

        connection.Close()
        addToAverageDatabase()

    End Sub

    Public Overrides Sub updateUser()
        ' MsgBox("Worker:updateUser() - name = " & name)
        Dim connection As SqlConnection
        Dim command As SqlCommand
        Dim reader As SqlDataReader

        Dim commandstring As String = "UPDATE Workers SET Username = @username, Name = @name, Surname = @surname, Password = @password, MobileNumber = @mobil, Email = @email, Category = @category, Description = @des WHERE Username = @user"
        connection = New SqlConnection(ValidationClass.CONNECTIONSTRING)
        connection.Open()
        command = New SqlCommand(commandstring, connection)

        command.Parameters.AddWithValue("@name", name)
        command.Parameters.AddWithValue("@surname", surname)
        command.Parameters.AddWithValue("@user", username)
        command.Parameters.AddWithValue("@password", password)
        command.Parameters.AddWithValue("@mobil", numbers)
        command.Parameters.AddWithValue("@email", email)
        'command.Parameters.AddWithValue("@title", jobTitle)
        command.Parameters.AddWithValue("@des", description)
        command.Parameters.AddWithValue("@dcategory", category)

        reader = command.ExecuteReader()

        connection.Close()
    End Sub


    Private Sub getPartialWorkerInfo(username As String) 'to be used when obtaining part of the worker's information
        Dim connection As SqlConnection
        Dim command As SqlCommand
        Dim reader As SqlDataReader

        connection = New SqlConnection(ValidationClass.CONNECTIONSTRING)
        Dim commandstring As String = "SELECT * From Workers WHERE Username = @user"
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
            email = reader("Email")
            ' numbers = reader("MobileNumber")
            numbers = 0
            region = ""

        End If
        rating = getRating()
        connection.Close()
    End Sub


    Public Overrides Function getRating() As Integer
        Dim connection As SqlConnection
        Dim command As SqlCommand
        Dim reader As SqlDataReader

        connection = New SqlConnection(ValidationClass.CONNECTIONSTRING)
        Dim commandstring As String = "SELECT * From AverageWorkerRating WHERE Worker = @user"
        command = New SqlCommand(commandstring, connection)
        command.Parameters.AddWithValue("@user", username)

        command.Connection.Open()
        reader = command.ExecuteReader()

        If reader.HasRows Then
            reader.Read()
            Dim rating As Integer = 0
            If Not IsDBNull(reader("AverageRating")) Then
                rating = reader("AverageRating")
            End If
            connection.Close()
            Return rating 'returning rating value
        End If
        Return 0
    End Function
    
    'gettoers
    Public Function getCategory() As String
        Return category
    End Function

    Public Function getDescription() As String
        Return description
    End Function

    'setters
    Public Sub updateCategory(category As String)
        Me.category = category
    End Sub

    Public Sub updateDescription(description As String)
        Me.description = description
    End Sub

    Public Overrides Sub updateAverage(average As Integer)
        'update average rating
        Dim adconnection As SqlConnection = New SqlConnection(ValidationClass.CONNECTIONSTRING)
        adconnection.Open()
        Dim query As String = "UPDATE AverageWorkerRating SET AverageRating = @average WHERE Worker = @worker;"
        Dim command As SqlCommand = New SqlCommand(query, adconnection)
        command.Parameters.AddWithValue("@average", average)
        command.Parameters.AddWithValue("@worker", username)
        Dim reader As SqlDataReader = command.ExecuteReader()
        adconnection.Close()
        rating = average
    End Sub


    Private Sub addToAverageDatabase()
        Dim adconnection As SqlConnection = New SqlConnection(ValidationClass.CONNECTIONSTRING)
        adconnection.Open()
        Dim query As String = "INSERT INTO AverageWorkerRating (Worker, AverageRating) VALUES (@worker, @average);"
        Dim command As SqlCommand = New SqlCommand(query, adconnection)
        command.Parameters.AddWithValue("@average", 0)
        command.Parameters.AddWithValue("@worker", username)
        Dim reader As SqlDataReader = command.ExecuteReader()
        adconnection.Close()
    End Sub

End Class
=======
﻿Imports System.Data.SqlClient

Public Class Worker
    Inherits User


    Private description As String
    Private logo As Image
    Private category As String

    'specialised constructor
    Public Sub New(vusername As String, vpassword As String, vname As String, vsurname As String, vemail As String, mnumbers As String, vregion As String, description As String, category As String, logo As Image)
        MyBase.New(vusername, vpassword, vname, vsurname, vemail, mnumbers, vregion)
        Me.description = description
        Me.logo = logo
        Me.category = category
    End Sub

    'basic constructor
    Public Sub New(username As String, password As String)
        MyBase.New()
        getWorker(username, password)
    End Sub

    Public Sub New(username As String)
        getPartialWorkerInfo(username)
    End Sub

    'getting handyman from database
    Private Sub getWorker(username As String, password As String)
        Dim connection As SqlConnection
        Dim command As SqlCommand
        Dim reader As SqlDataReader
        password = Secrecy.HashPassword(password)

        connection = New SqlConnection(ValidationClass.CONNECTIONSTRING)
        Dim commandstring As String = "SELECT * From Workers WHERE Username = @user AND Password = @pass"
        command = New SqlCommand(commandstring, connection)
        command.Parameters.AddWithValue("@user", username)
        command.Parameters.AddWithValue("@pass", password)

        command.Connection.Open()
        reader = command.ExecuteReader()
        If reader.HasRows Then
            reader.Read()
            Me.username = username
            name = reader("Name")
            surname = reader("Surname")
            email = reader("Email")
            numbers = reader("MobileNumber")
            region = ""
            'jobTitle = reader("JobTitle")
            description = reader("Description")
            category = reader("Category")

        End If
    End Sub

    Public Overrides Sub saveUser()
        '  MsgBox("Worker:saveUser()-inside function saveUser()")
        Dim connection As SqlConnection
        Dim command As SqlCommand
        Dim reader As SqlDataReader

        Dim commandstring As String = "INSERT INTO Workers (Name, Surname, Username, Password, MobileNumber, Email, Category, Region, Description) VALUES (@name, @surname, @username, @password, @mobil, @email, @category, @region, @description)"
        connection = New SqlConnection(ValidationClass.CONNECTIONSTRING)
        connection.Open()
        command = New SqlCommand(commandstring, connection)

        command.Parameters.AddWithValue("@name", name)
        command.Parameters.AddWithValue("@surname", surname)
        command.Parameters.AddWithValue("@username", username)
        command.Parameters.AddWithValue("@password", password)
        command.Parameters.AddWithValue("@mobil", numbers)
        command.Parameters.AddWithValue("@email", email)
        command.Parameters.AddWithValue("@category", category)
        command.Parameters.AddWithValue("@region", region)
        'command.Parameters.AddWithValue("@JobTitle", jobTitle)
        command.Parameters.AddWithValue("@description", description)
        reader = command.ExecuteReader()

        connection.Close()
        addToAverageDatabase()

    End Sub

    Public Overrides Sub updateUser()
        '  MsgBox("Worker:updateUser() - name = " & name)
        Dim connection As SqlConnection
        Dim command As SqlCommand
        Dim reader As SqlDataReader

        Dim commandstring As String = "UPDATE Workers SET Username = @username, Name = @name, Surname = @surname, Password = @password, MobileNumber = @mobil, Email = @email, Category = @category, Description = @des WHERE Username = @user"
        connection = New SqlConnection(ValidationClass.CONNECTIONSTRING)
        connection.Open()
        command = New SqlCommand(commandstring, connection)

        command.Parameters.AddWithValue("@name", name)
        command.Parameters.AddWithValue("@surname", surname)
        command.Parameters.AddWithValue("@user", username)
        command.Parameters.AddWithValue("@password", password)
        command.Parameters.AddWithValue("@mobil", numbers)
        command.Parameters.AddWithValue("@email", email)
        'command.Parameters.AddWithValue("@title", jobTitle)
        command.Parameters.AddWithValue("@des", description)
        command.Parameters.AddWithValue("@dcategory", category)

        reader = command.ExecuteReader()

        connection.Close()
    End Sub


    Private Sub getPartialWorkerInfo(username As String) 'to be used when obtaining part of the worker's information
        Dim connection As SqlConnection
        Dim command As SqlCommand
        Dim reader As SqlDataReader

        connection = New SqlConnection(ValidationClass.CONNECTIONSTRING)
        Dim commandstring As String = "SELECT * From Workers WHERE Username = @user"
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
            email = reader("Email")
            ' numbers = reader("MobileNumber")
            numbers = 0
            region = ""

        End If
        rating = getRating()
        connection.Close()
    End Sub


    Public Overrides Function getRating() As Integer
        Dim connection As SqlConnection
        Dim command As SqlCommand
        Dim reader As SqlDataReader

        connection = New SqlConnection(ValidationClass.CONNECTIONSTRING)
        Dim commandstring As String = "SELECT * From AverageWorkerRating WHERE Worker = @user"
        command = New SqlCommand(commandstring, connection)
        command.Parameters.AddWithValue("@user", username)

        command.Connection.Open()
        reader = command.ExecuteReader()

        If reader.HasRows Then
            reader.Read()
            Dim rating As Integer = 0
            If Not IsDBNull(reader("AverageRating")) Then
                rating = reader("AverageRating")
            End If
            connection.Close()
            Return rating 'returning rating value
        End If
        Return 0
    End Function
    
    'gettoers
    Public Function getCategory() As String
        Return category
    End Function

    Public Function getDescription() As String
        Return description
    End Function

    'setters
    Public Sub updateCategory(category As String)
        Me.category = category
    End Sub

    Public Sub updateDescription(description As String)
        Me.description = description
    End Sub

    Public Overrides Sub updateAverage(average As Integer)
        'update average rating
        Dim adconnection As SqlConnection = New SqlConnection(ValidationClass.CONNECTIONSTRING)
        adconnection.Open()
        Dim query As String = "UPDATE AverageWorkerRating SET AverageRating = @average WHERE Worker = @worker;"
        Dim command As SqlCommand = New SqlCommand(query, adconnection)
        command.Parameters.AddWithValue("@average", average)
        command.Parameters.AddWithValue("@worker", username)
        Dim reader As SqlDataReader = command.ExecuteReader()
        adconnection.Close()
        rating = average
    End Sub


    Private Sub addToAverageDatabase()
        Dim adconnection As SqlConnection = New SqlConnection(ValidationClass.CONNECTIONSTRING)
        adconnection.Open()
        Dim query As String = "INSERT INTO AverageWorkerRating (Worker, AverageRating) VALUES (@worker, @average);"
        Dim command As SqlCommand = New SqlCommand(query, adconnection)
        command.Parameters.AddWithValue("@average", 0)
        command.Parameters.AddWithValue("@worker", username)
        Dim reader As SqlDataReader = command.ExecuteReader()
        adconnection.Close()
    End Sub

End Class
>>>>>>> 3924db60ce15290221df9b838aeba9dff3fe785d
