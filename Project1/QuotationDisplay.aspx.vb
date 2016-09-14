Public Class QuotationDisplay
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


        If Not Page.IsPostBack Then


            Dim randomInvoiceNumber As Random = New Random()

            Dim invoiceNo As Integer = randomInvoiceNumber.Next(895623)


            quotation.InnerHtml &= "<h1><b>Invoice Number: " & CStr(invoiceNo) & "</b><h1>"
            quotation.InnerHtml &= "<p>Customer Name : " & Session("UserName").ToString & "</p>"

     
            quotation.InnerHtml &= "</br>Description: " & CStr(quotation.)
            Invoice.InnerHtml &= "</br>DvD Title: " & CStr(Items.Title)
                Invoice.InnerHtml &= "</br>DvD Price: R" & CStr(items.price) & "</hr>"

                Command.Parameters.AddWithValue("@InvId", invoiceNo)
                Command.Parameters.AddWithValue("@Tot", total)
                Command.Parameters.AddWithValue("@User", Session("UserName"))
                Dim currentDate As Date = New Date()
                Command.Parameters.AddWithValue("@Date", CStr(currentDate.Day + "/" + currentDate.Month + "/" + currentDate.Year))
                Command.Connection = connection
                connection.Open()
                Command.ExecuteNonQuery()
                Command.Connection.Close()  '' Closing the connection and disposing the command
                Command.Dispose()
                connection.Dispose()

            AddToCart.cartItems = Nothing
            AddToCart.counter = 0
            Invoice.InnerHtml &= "<p>Vat: 14%</p>"
            Invoice.InnerHtml &= "<p>total : R" + CStr(total + (total * 0.14)) + "</p>"


            Invoice.InnerHtml &= "<p><a href=products.aspx> Click here to go back to the Product page</a></p>"


        End If

    End Sub

End Class