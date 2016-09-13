Imports System.Data.SqlClient

Public Class Job

    Private JobID As Integer
    Private category As String
    Private title As String
    Private description As String
    'ClientID and HandymanID is in the form of unique username
    Private client As String
    Private Handyman As String
    Private OpenDate As Date
    Private messenges() As Messenge

    'When job already exists in database, inclusion of JOBID
    Public Sub New(jobID As Integer, category As String, title As String, description As String, client As String, Handyman As String, OpenDate As Date)
        Me.JobID = jobID
        Me.category = category
        Me.title = title
        Me.description = description
        Me.client = client
        Me.Handyman = Handyman
        Me.OpenDate = OpenDate
    End Sub

    'When job is being newly created and added to the database
    Public Sub New(category As String, title As String, description As String, client As String, Handyman As String, OpenDate As Date)
        'MsgBox("Job:New()- category = " & ValidationClass.stringCategory(category))
        Me.category = category
        Me.title = title
        Me.description = description
        Me.client = client
        Me.Handyman = Handyman
        Me.OpenDate = OpenDate
    End Sub

    Public Function getClient() As String
        Return client
    End Function

    Public Sub updateHandyman(Handyman As String) 'to change handyman assigned to the job
        Me.Handyman = Handyman
    End Sub

    Public Function getHandyman() As String
        Return Handyman
    End Function

    Public Function getTitle() As String
        Return title
    End Function

    Public Function getDescription() As String
        Return description
    End Function

    Public Function getID() As Integer
        Return JobID
    End Function

    Public Function getCategory() As String
        Return category
    End Function

    Public Function getDate() As Date
        Return OpenDate
    End Function

    Public Sub saveJob()
        Dim connection As SqlConnection
        Dim command As SqlCommand
        Dim reader As SqlDataReader

        connection = New SqlConnection(ValidationClass.CONNECTIONSTRING)
        'Dim query As String = "SELECT * FROM PostAdClient WHERE PostAdId = @post;"
        connection.Open()

        'JobId not included as it is autoincremented variable
        command = New SqlCommand("INSERT INTO AdTable (Category, AdTitle, AdDescription, Client) VALUES (@category, @adtitle, @description, @user)")
        command.Connection = connection

        command.Parameters.AddWithValue("@category", category)
        command.Parameters.AddWithValue("@AdTitle", title)
        command.Parameters.AddWithValue("@description", description)
        command.Parameters.AddWithValue("@user", client)
        'command.Parameters.AddWithValue("@img", fileSelect.PostedFile)
        'command.Parameters.AddWithValue("@logo", fileSelect.PostedFile)

        reader = command.ExecuteReader()

        command.Connection.Close()
        'MsgBox("Job:saveJob(): Job Saved!")
    End Sub

    Public Sub updateJob()
        Dim connection As SqlConnection
        Dim command As SqlCommand
        Dim reader As SqlDataReader

        connection = New SqlConnection(ValidationClass.CONNECTIONSTRING)
        Dim query As String = "UPDATE AdTable SET Category = @category, AdTitle = @AdTitle, @description, Client = @user, Handyman = @hand WHERE Client = @user"
        connection.Open()


        command = New SqlCommand(query, connection)

        command.Parameters.AddWithValue("@category", category)
        command.Parameters.AddWithValue("@AdTitle", title)
        command.Parameters.AddWithValue("@description", description)
        command.Parameters.AddWithValue("@user", client)
        command.Parameters.AddWithValue("@hand", Handyman)
        'command.Parameters.AddWithValue("@img", fileSelect.PostedFile)
        'command.Parameters.AddWithValue("@logo", fileSelect.PostedFile)

        reader = command.ExecuteReader()

        command.Connection.Close()
    End Sub

    Public Sub deleteJob()
        Dim connection As SqlConnection
        Dim command As SqlCommand
        Dim reader As SqlDataReader

        connection = New SqlConnection(ValidationClass.CONNECTIONSTRING)
        Dim query As String = "DELETE FROM AdTable WHERE PostAdId = @name;"
        connection.Open()
        ' MsgBox("Job:deleteJob()-JobID = " & JobID)

        command = New SqlCommand(query, connection)
        command.Parameters.AddWithValue("@name", JobID)
        reader = command.ExecuteReader()
        command.Connection.Close()

        JobID = 0
        category = ""
        title = ""
        description = ""
        'ClientID and HandymanID is in the form of unique username
        client = ""
        Handyman = ""


    End Sub
End Class


