Public Class QuotationDisplay
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


        If Not Page.IsPostBack Then

            Dim item As Quotation = New Quotation("", "", "", "", "", "")
            Dim worker As Worker = Session("user")

            Dim workerUsername As String = worker.getUsername() 'worker who is writting the quotation

            Dim randomInvoiceNumber As Random = New Random()

            Dim invoiceNo As Integer = randomInvoiceNumber.Next(895623)

            quotation.InnerHtml &= "<h1><b>Handyman: " & workerUsername & "</b><h1>"
            quotation.InnerHtml &= "<h1><b>Invoice Number: " & CStr(invoiceNo) & "</b><h1>"

            quotation.InnerHtml &= "<p>Customer Name : " & Session("UserName").ToString & "</p>"

     
            quotation.InnerHtml &= "</br>Description: " & CStr(item.getquoteDescription)
            quotation.InnerHtml &= "</br>Estimated Hours to Complete: " & CStr(item.getquoteHours)
            quotation.InnerHtml &= "</br>Estimated Amount: " & CStr(item.getquoteAmount)

            quotation.InnerHtml &= "<br/>"

            quotation.InnerHtml &= "<p><a href=Responses.aspx> Click here to go back</a></p>"

        End If

    End Sub

End Class