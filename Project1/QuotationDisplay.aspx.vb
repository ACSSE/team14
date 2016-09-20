Public Class QuotationDisplay
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


        If Not Page.IsPostBack Then

            Dim item As Quotation

            Dim randomInvoiceNumber As Random = New Random()

            Dim invoiceNo As Integer = randomInvoiceNumber.Next(895623)


            quotation.InnerHtml &= "<h1><b>Invoice Number: " & CStr(invoiceNo) & "</b><h1>"
            quotation.InnerHtml &= "<p>Customer Name : " & Session("UserName").ToString & "</p>"

     
            quotation.InnerHtml &= "</br>Description: " & CStr(item.getquoteDescription)
            quotation.InnerHtml &= "</br>Estimated Hours to Complete: " & CStr(item.getquoteHours)
            quotation.InnerHtml &= "</br>Estimated Amount: " & CStr(item.getquoteAmount)



            quotation.InnerHtml &= "<p><a href=ClientProfile.aspx> Click here to go back to the profile page</a></p>"


        End If

    End Sub

End Class