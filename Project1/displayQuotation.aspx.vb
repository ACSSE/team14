Public Class displayQuotation
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim ID As Integer = Request.QueryString("ID")
        Dim quotations As QuotationList = New QuotationList(ID)

        Dim user As User = Session("user") 'to access user's name

        Dim html As String = "" 'HTML string to be put in div tag
        If Not (quotations.getSize() = 0) Then 'If there are messenges
            For i As Integer = 1 To quotations.getSize()
                'to do didsplay messenges in div tag on the page  
                Dim quotation As Quotation = quotations.getQuotation(i)

                If quotation.getQuoteUser() = user.getUsername() Then 'should appear in different colours
                    html &= "<p> " & quotation.getQuotationInfo() & "</p><br />"
                End If
            Next i
        End If
        quotation.InnerHtml = html

    End Sub

End Class