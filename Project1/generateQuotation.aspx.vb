Imports System.Data.SqlClient

Public Class generateQuotation
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnReg_Click(sender As Object, e As EventArgs) Handles btnSubQuote.ServerClick


        Dim quoteId As String = ""
        Dim quoteDescription As String = lblQuoteDescription.Text()
        Dim hours As Integer = lblQuoteHours.Text()
        Dim quoteAmount As Integer
        Dim worker As Worker = Session("user")

        Dim workerUsername As String = worker.getUsername() 'worker who is writting the quotation




        Dim connection As SqlConnection = New SqlConnection(ValidationClass.CONNECTIONSTRING)
        Dim query As String = "INSERT INTO Quotation (QuoteId, quoteDescription, quoteHours, quoteAmount, Worker) Values (@ID, @quoteDescription, @quoteHours, @quoteAmount, @worker)"
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

End Class