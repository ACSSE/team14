Imports System.Data.SqlClient

Public Class generateQuotation
    Inherits System.Web.UI.Page

    Private cQuotation As Quotation

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim worker As Worker = Session("user")
        errlabel.Visible = False
        Dim ID As Integer = Request.QueryString("ID")
        Dim func As String = Request.QueryString("ifunction")

        If func = "ERROR" Then
            errlabel.Visible = True
            errlabel.Text = "Please enter integer values for hours and amount (in rands)"
        End If

        cQuotation = New Quotation(ID, worker.getUsername())

        If Not (cQuotation.getWorker() = "") Then
            prevQ.InnerHtml = "<a href=QuotationDisplay.aspx?ID=" & ID & "&worker=" & worker.getUsername() & ">View Previously made Quotation</a>"
        End If

    End Sub

    Protected Sub btnReg_Click(sender As Object, e As EventArgs) Handles btnSubQuote.ServerClick

        Dim ID As Integer = Request.QueryString("ID")

        If Not (IsNumeric(txtQuoteAmount.Text())) Or Not (IsNumeric(txtQuoteHours.Text())) Then
            Response.Redirect("generateQuotation.aspx?ID=" & ID & "&ifunction=ERROR")
        End If


        Dim description As String = txtQuoteDescription.Text()
        Dim hours As Integer = txtQuoteHours.Text()
        Dim amount As String = txtQuoteAmount.Text()
        Dim worker As Worker = Session("user")

        Dim workerUsername As String = worker.getUsername() 'worker who is writting the quotation



        Dim cQuotation As Quotation = New Quotation(ID, description, hours, amount, workerUsername) 'ID is identical to job ID
        cQuotation.savequoteDescription()
        'commiting message into the database
        Response.Redirect("WorkerProfile.aspx?ID=" & ID)


    End Sub

End Class