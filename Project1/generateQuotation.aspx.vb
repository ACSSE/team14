Public Class generateQuotation
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnReg_Click(sender As Object, e As EventArgs) Handles btnSubQuote.ServerClick


        Dim quoteId As String = ""
        Dim quoteDescription As String = ""
        Dim hours As Integer = ""
        Dim quoteAmount As Integer = ""

        quoteDescription = txtQuoteDescription.Text()
        hours = txtQuoteHours.Text()
        quoteAmount = txtQuoteAmount.Text




        Dim quotation As Quotation = New Quotation(quoteId, quoteDescription, hours, quoteAmount)
        quotation.savequoteDescription()

        Response.Redirect("QuotationDisplay.aspx")



    End Sub

End Class