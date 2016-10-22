Imports System.Data.SqlClient

Public Class generateQuotation
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnReg_Click(sender As Object, e As EventArgs) Handles btnSubQuote.ServerClick


        Dim description As String = txtQuoteDescription.Text()
        Dim hours As Integer = txtQuoteHours.Text()
        Dim amount As String = txtQuoteAmount.Text()
        Dim worker As Worker = Session("user")

        Dim workerUsername As String = worker.getUsername() 'worker who is writting the quotation

        Dim cUser As User = Session("user") 'to obtain sender username
        Dim ID As Integer = Request.QueryString("ID")

        Dim cQuotation As Quotation = New Quotation(ID, description, hours, amount, workerUsername) 'ID is identical to job ID
        cQuotation.savequoteDescription()
        'commiting message into the database
        Response.Redirect("WorkerProfile.aspx?ID=" & ID)


    End Sub

End Class