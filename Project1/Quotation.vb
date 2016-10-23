Imports System.Data.SqlClient

Public Class Quotation

    Private quoteId As Integer
    Private quoteDescription As String
    Private quoteHours As Integer
    Private quoteAmount As Integer
    Private worker As String



    Public Sub New(vquoteId As Integer, vquoteDescription As String, vquoteHours As Integer, vquoteAmount As Integer, vworker As String)
        'MyBase.New()
        Me.quoteId = vquoteId
        Me.quoteDescription = vquoteDescription
        Me.quoteHours = vquoteHours
        Me.quoteAmount = vquoteAmount
        Me.worker = vworker
    End Sub

    Public Sub New(vquoteDescription As String, vquoteHours As Integer, vquoteAmount As Integer, vworker As String)
        'MyBase.New()
        'Me.quoteId = vquoteId
        Me.quoteDescription = vquoteDescription
        Me.quoteHours = vquoteHours
        Me.quoteAmount = vquoteAmount
        Me.worker = vworker
    End Sub

    Public Sub New(ID As Integer, worker As String)
        getQuotation(ID, worker)
    End Sub

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
    Public Function getWorker() As String
        Return worker
    End Function


    Public Sub savequoteDescription()


        Dim connection As SqlConnection = New SqlConnection(ValidationClass.CONNECTIONSTRING)
        Dim query As String = "INSERT INTO Quotation (quoteID, quoteDescription, quoteHours, quoteAmount, Worker) Values (@ID, @quoteDescription, @quoteHours, @quoteAmount, @worker)"
        connection.Open()

        Dim command As SqlCommand = New SqlCommand(query, connection)
        command.Parameters.AddWithValue("@ID", quoteId)
        command.Parameters.AddWithValue("@quoteDescription", quoteDescription)
        command.Parameters.AddWithValue("@quoteHours", quoteHours)
        command.Parameters.AddWithValue("@quoteAmount", quoteAmount)
        command.Parameters.AddWithValue("@worker", worker)


        Dim reader As SqlDataReader = command.ExecuteReader()
        connection.Close()

        'Response.Redirect("QuotationDisplay.aspx")

    End Sub
    Public Sub getQuotation(ID As Integer, worker As String)
       
        Dim connection As SqlConnection
        Dim command As SqlCommand
        Dim reader As SqlDataReader

        connection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\HandymanDatabase.mdf;Integrated Security=True")
        Dim commandstring As String = "SELECT * From Quotation WHERE QuoteId = @quoteId AND Worker = @worker"
        command = New SqlCommand(commandstring, connection)
        command.Parameters.AddWithValue("@quoteId", ID)
        command.Parameters.AddWithValue("@worker", worker)

        command.Connection.Open()
        reader = command.ExecuteReader()

        If reader.HasRows Then
            reader.Read()
            Me.quoteId = quoteId
            quoteDescription = reader("quoteDescription")
            quoteHours = reader("quoteHours")
            quoteAmount = reader("quoteAmount")
            Me.worker = reader("Worker")
        End If

    End Sub

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
End Class
