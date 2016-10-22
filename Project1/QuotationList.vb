
Imports System.Data.SqlClient

Public Class QuotationList

    Private quotation() As Quotation
    Private size As Integer = 0

    Public Sub New(quoteId As Integer)
        Dim connection As SqlConnection = New SqlConnection(ValidationClass.CONNECTIONSTRING)
        Dim query As String = "SELECT * FROM Quotation WHERE QuoteId = @id;"
        connection.Open()

        Dim command As SqlCommand = New SqlCommand(query, connection)
        command.Parameters.AddWithValue("@id", quoteId)

        Dim reader As SqlDataReader = command.ExecuteReader()

        If reader.HasRows Then
            Dim user As String
            Dim description As String
            Dim hours As Integer
            Dim amount As Integer
            While reader.Read()
                'reading in values
                user = reader("QuoteUser")
                description = reader("QuoteDescription")
                hours = reader("QuoteHours")
                amount = reader("QuoteAmount")

                'entering values into the list
                size += 1
                ReDim Preserve quotation(size)
                quotation(size) = New Quotation(quoteId, user, description, hours, amount)
            End While
        End If
    End Sub

    Public Function getQuotation(index As Integer) As Quotation
        Return quotation(index)
    End Function

    Public Function getSize() As Integer
        Return size
    End Function

End Class
