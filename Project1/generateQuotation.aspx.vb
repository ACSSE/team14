Public Class generateQuotation
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnReg.ServerClick

        Dim description As String = txtQuoteDescription.Text()
        Dim hours As Integer = txtQuoteHours.Text()
        Dim amount As String = txtQuoteAmount.Text()

        Dim cUser As User = Session("user") 'to obtain sender username
        Dim ID As Integer = Request.QueryString("ID")

        Dim cQuotation As Quotation = New Quotation(ID, cUser.getUsername(), description, hours, amount)
        cQuotation.saveQuotation() 'commiting message into the database
        Response.Redirect("displayQuotation.aspx?ID=" & ID)
    End Sub

End Class