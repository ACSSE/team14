Imports System.Data.SqlClient

Public Class Quotation

    Private quoteId As Integer
    Private quoteDescription As String
    Private quoteHours As Integer
    Private quoteAmount As Integer



    Public Sub New(vquoteId As Integer, vquoteDescription As String, vquoteHours As Integer, vquoteAmount As Integer)
        MyBase.New()
        Me.quoteId = quoteId
        Me.quoteDescription = quoteDescription
        Me.quoteHours = quoteHours
        Me.quoteAmount = quoteAmount
    End Sub

    Public Sub New(ID As Integer)
        MyBase.New()
        getQuotation(quoteId)
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



    Public Sub savequoteDescription()


        Dim connection As SqlConnection = New SqlConnection(ValidationClass.CONNECTIONSTRING)
        Dim query As String = "INSERT INTO Quotation (QuoteId, quoteDescription, quoteHours, quoteAmount) Values (@ID, @quoteDescription, @quoteHours, @quoteAmount)"
        connection.Open()

        Dim command As SqlCommand = New SqlCommand(query, connection)
        command.Parameters.AddWithValue("@ID", quoteId)
        command.Parameters.AddWithValue("@quoteDescription", quoteDescription)
        command.Parameters.AddWithValue("@quoteHours", quoteHours)
        command.Parameters.AddWithValue("@quoteAmount", quoteAmount)

        Dim reader As SqlDataReader = command.ExecuteReader()
        connection.Close()

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

        End If

        Return getQuotation(quoteId)
    End Function

    Public Function getMessageInfo() As String
        Dim info As String = ""

        info &= "Invoice Number: <strong>" & quoteId & "</strong>"
        'info &= "<p>User : " &  & Session("UserName").ToString & "</p>"
        info &= "</br>Description: " & quoteDescription
        info &= "</br>Estimated Hours to Complete: " & quoteHours
        info &= "</br>Estimated Amount: " & quoteAmount

        Return info
    End Function
End Class
