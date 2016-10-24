Imports System.Data.SqlClient

Public Class Quotation

    Private quoteId As Integer
    Private quoteDescription As String
    Private quoteHours As Integer
    Private quoteAmount As Integer
    Private worker As String
    Private checked As String



    Public Sub New(vquoteId As Integer, vquoteDescription As String, vquoteHours As Integer, vquoteAmount As Integer, vworker As String, vchecked As String)
        'MyBase.New()
        Me.quoteId = vquoteId
        Me.quoteDescription = vquoteDescription
        Me.quoteHours = vquoteHours
        Me.quoteAmount = vquoteAmount
        Me.worker = vworker
        Me.checked = vchecked
    End Sub
    Public Sub New(username As String)
        getPartialQuotationInfo(username)
    End Sub

    Public Sub New(vquoteDescription As String, vquoteHours As Integer, vquoteAmount As Integer, vworker As String)
        'MyBase.New()
        'Me.quoteId = vquoteId
        Me.quoteDescription = vquoteDescription
        Me.quoteHours = vquoteHours
        Me.quoteAmount = vquoteAmount
        Me.worker = vworker


    End Sub

    'Public Sub New(ID As Integer)
    '    MyBase.New()
    '    getQuotation(quoteId)
    'End Sub

    Public Function getquoteId() As Integer
        Return quoteId
    End Function

    Public Function getquoteDescription() As String
        Return quoteDescription
    End Function

    Public Function getquoteHours() As Integer
        Return quoteHours
    End Function
    Public Function getquoteAmount() As Integer
        Return quoteAmount
    End Function
    Public Function getWorker() As Integer
        Return worker
    End Function
    Public Function getChecked() As Integer
        Return checked
    End Function


    Public Sub savequoteDescription()


        Dim connection As SqlConnection = New SqlConnection(ValidationClass.CONNECTIONSTRING)
        Dim query As String = "INSERT INTO Quotation (quoteID, quoteDescription, quoteHours, quoteAmount, Worker, Checked) Values (@ID, @quoteDescription, @quoteHours, @quoteAmount, @worker, @checked)"
        connection.Open()

        Dim command As SqlCommand = New SqlCommand(query, connection)
        command.Parameters.AddWithValue("@ID", quoteId)
        command.Parameters.AddWithValue("@quoteDescription", quoteDescription)
        command.Parameters.AddWithValue("@quoteHours", quoteHours)
        command.Parameters.AddWithValue("@quoteAmount", quoteAmount)
        command.Parameters.AddWithValue("@worker", worker)
        command.Parameters.AddWithValue("@checked", "unchecked")


        Dim reader As SqlDataReader = command.ExecuteReader()
        connection.Close()

        'Response.Redirect("QuotationDisplay.aspx")

    End Sub
    Public Function getQuotation(ID As Integer)

        Dim connection As SqlConnection
        Dim command As SqlCommand
        Dim reader As SqlDataReader

        connection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\HandymanDatabase.mdf;Integrated Security=True")
        Dim commandstring As String = "SELECT * From Quotation WHERE QuoteId = @quoteId"
        command = New SqlCommand(commandstring, connection)
        command.Parameters.AddWithValue("@quoteId", ID)

        command.Connection.Open()
        reader = command.ExecuteReader()

        If reader.HasRows Then
            reader.Read()
            Me.quoteId = quoteId
            quoteDescription = reader("quoteDescription")
            quoteHours = reader("quoteHours")
            quoteAmount = reader("quoteAmount")
            worker = reader("Worker")

        End If

        Return getQuotation(quoteId)
    End Function

    Public Function getMessageInfo() As String
        Dim info As String = ""
        'Dim myUser As Quotation

        info &= "Invoice Number: <strong>" & quoteId & "</strong>"
        info &= "<p>User : " & worker & "</p>"
        info &= "</br>Description: " & quoteDescription
        info &= "</br>Estimated Hours to Complete: " & quoteHours
        info &= "</br>Estimated Amount: " & quoteAmount

        Return info
    End Function

    Private Sub getPartialQuotationInfo(quotation As String)
        Dim connection As SqlConnection
        Dim command As SqlCommand
        Dim reader As SqlDataReader

        connection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\HandymanDatabase.mdf;Integrated Security=True")
        Dim commandstring As String = "SELECT * From Quotation WHERE Worker = @user"
        command = New SqlCommand(commandstring, connection)
        command.Parameters.AddWithValue("@user", quotation)

        command.Connection.Open()
        reader = command.ExecuteReader()

        If reader.HasRows Then
            reader.Read()
            Me.worker = worker
            quoteDescription = reader("quoteDescription")
            quoteAmount = reader("quoteAmount")
            'email = reader("Email")
            quoteHours = reader("quoteHours")
            ' numbers = reader("MobileNumber")
            

        End If

        connection.Close()
    End Sub

End Class
