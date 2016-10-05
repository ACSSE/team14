
Imports System.Data.SqlClient

Public Class Quotation

    Private QuoteId As Integer
    Private QuoteUser As String
    Private QuoteDescription As String
    Private QuoteHours As Integer
    Private QuoteAmount As Integer

    Public Sub New(QuoteId As Integer, QuoteUser As String, QuoteDescription As String, QuoteHours As Integer, QuoteAmount As Integer)
        Me.QuoteId = QuoteId
        Me.QuoteUser = QuoteUser
        Me.QuoteDescription = QuoteDescription
        Me.QuoteHours = QuoteHours
        Me.QuoteAmount = QuoteAmount
    End Sub

    Public Function getQuoteId() As Integer
        Return QuoteId
    End Function

    Public Function getQuoteUser() As String
        Return QuoteUser
    End Function

    Public Function getQuoteDescription() As String
        Return QuoteDescription
    End Function

    Public Function getQuoteHours() As Integer
        Return QuoteHours
    End Function

    Public Function getQuoteAmount() As Integer
        Return QuoteAmount
    End Function

    Public Sub saveQuotation()


        Dim connection As SqlConnection = New SqlConnection(ValidationClass.CONNECTIONSTRING)
        Dim query As String = "INSERT INTO Quotation (QuoteId, QuoteUser, QuoteDescription, QuoteHours, QuoteAmount) Values (@quoteId, @quoteUser, @quoteDescription, @quoteHours, @quoteAmount)"
        connection.Open()

        Dim command As SqlCommand = New SqlCommand(query, connection)
        command.Parameters.AddWithValue("@quoteId", QuoteId)
        command.Parameters.AddWithValue("@quoteUser", QuoteUser)
        command.Parameters.AddWithValue("@quoteDescription", QuoteDescription)
        command.Parameters.AddWithValue("@quoteHours", QuoteHours)
        command.Parameters.AddWithValue("@quoteAmount", QuoteAmount)

        Dim reader As SqlDataReader = command.ExecuteReader()
        connection.Close()

    End Sub

    Public Function getQuotationInfo() As String
        Dim quoteInfo As String = ""
        quoteInfo &= "<strong>Customer: </strong>" & QuoteUser & "<br/><br/>"
        quoteInfo &= "<strong>Description: </strong>" & QuoteDescription & "<br/>"
        quoteInfo &= "<strong>Hours: </strong>" & QuoteHours & "<br/>"
        quoteInfo &= "<strong>Description: </strong>" & QuoteDescription & "<br/>"
        Return quoteInfo
    End Function

    'To fix problems of two messenges being sent.
    'Public Function isIdentical(ID As Integer) As Boolean
    'Dim messenges As MessengeList = New MessengeList(ID)

    'For i As Integer = 1 To messenges.getSize()
    'If messenges.getMessage(i).getDate() = mdate And messenges.getMessage(i).getMessenge() = messenge And messenges.getMessage(i).sender = sender Then
    'Return True
    'End If

    'Next i
    'Return False
    'End Function

End Class
