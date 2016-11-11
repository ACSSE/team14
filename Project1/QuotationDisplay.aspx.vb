Imports System.Data.SqlClient

Public Class QuotationDisplay
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim cUser As User = Session("user")

        Dim adID As Integer = Request.QueryString("ID")
        Dim workername As String = ""
        workername = Request.QueryString("worker")

        If Not (workername = "") Then
            Dim item As Quotation = New Quotation(adID, workername)
            Dim randomInvoiceNumber As Random = New Random()

            Dim invoiceNo As Integer = randomInvoiceNumber.Next(895623)

            quotation.InnerHtml &= "<h1><b>Handyman: " & item.getWorker() & "</b><h1>"
            quotation.InnerHtml &= "<h1><b>Invoice Number: " & CStr(invoiceNo) & "</b><h1>"

            quotation.InnerHtml &= "<p>Customer Name : " & findClient(adID) & "</p>"


            quotation.InnerHtml &= "</br>Description: " & CStr(item.getquoteDescription)
            quotation.InnerHtml &= "</br>Estimated Hours to Complete: " & CStr(item.getquoteHours)
            quotation.InnerHtml &= "</br>Estimated Amount: R" & CStr(item.getquoteAmount)

        End If

        If TypeOf cUser Is Client Then
            quotation.InnerHtml &= "<p><a href=Responses.aspx?ID=" & adID & "> Click here to go back to Responses</a></p>"
        Else
            quotation.InnerHtml &= "<p><a href=generateQuotation.aspx?ID=" & adID & "> Click here to go back to generate a new quotation</a></p>"
        End If





    End Sub

    Private Function findClient(adID As Integer)
        Dim client As String = ""

        'to find client for which ad belongs to
        Dim adconnection As SqlConnection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\HandymanDatabase.mdf;Integrated Security=True")
        adconnection.Open()
        Dim query As String = "Select Client FROM AdTable WHERE PostAdId = @ID;"
        Dim command As SqlCommand = New SqlCommand(query, adconnection)
        command.Parameters.AddWithValue("@ID", adID)

        Dim reader As SqlDataReader = command.ExecuteReader()

     

        If reader.HasRows Then
            reader.Read()
            client = reader("Client")
        End If

        Return client
    End Function

End Class