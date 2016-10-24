Imports System.Data.SqlClient

Public Class Responses
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim adID As Integer = Request.QueryString("ID")
        Dim html As String = ""
        Dim handyman As Worker
        Dim worker As Quotation
        Dim connection As SqlConnection = New SqlConnection(ValidationClass.CONNECTIONSTRING)
        Dim query As String = "SELECT * FROM Responses WHERE PostAdId = @name;"
        connection.Open()

        Dim command As SqlCommand = New SqlCommand(query, connection)
        command.Parameters.AddWithValue("@name", adID)

        Dim reader As SqlDataReader = command.ExecuteReader()

        If reader.HasRows Then
            While reader.Read()
                handyman = New Worker(reader("Worker"))
                worker = New Quotation(reader("Worker"))
                'html code ofr div tag
                html &= "<div class=""itemtype"">"
                html &= displayWorker(handyman.getUsername())
                html &= "</div>"

                html &= "<div class=""itemtype"">"
                html &= "<p class=""p-price"">" & reader("Comment") & "</p>"
                html &= "     <a href=ClientProfile.aspx?Selected=" & handyman.getUsername() & "&ID=" & adID & "> Confirm </a>"
                html &= "</div>"
                html &= "<div class=""itemtype"">"
                html &= "<p class=""p-price"">" & displayQuotation(worker.getWorker) & "</p>"
                html &= "</div>"
                html &= "<hr/>"

            End While
        End If
        HandyMen.InnerHtml = html
        changeCheckedClient(adID)
        changeCheckedQuotation(adID)
    End Sub

    'displays worker information
    Private Function displayWorker(workerID As String)
        Dim info As String = ""

        Dim connection As SqlConnection = New SqlConnection(ValidationClass.CONNECTIONSTRING)
        Dim query As String = "SELECT * FROM Workers WHERE Username = @name;"
        connection.Open()

        Dim command As SqlCommand = New SqlCommand(query, connection)
        command.Parameters.AddWithValue("@name", workerID)

        Dim reader As SqlDataReader = command.ExecuteReader()

        If reader.HasRows Then 'building html string for website
            reader.Read()
            info &= "<h4>" & reader("Name") & " " & reader("Surname") & "</h4> <br />"
            info &= "<div class=""itemtype"">"
            info &= "<p class=""p-price"">Rating</p>"
            info &= "	<h4><i><img src=""images/rate1.png"" alt="" "" /></i></h4>"
            info &= "<div class=""clearfix""></div>"
            info &= "</div>"
        End If
        Return info
    End Function

    Private Function displayQuotation(WorkerId As String) As String
        Dim quote As String = ""
        Dim handyman As Worker
        Dim adID As Integer = Request.QueryString("ID")

        Dim connection As SqlConnection = New SqlConnection(ValidationClass.CONNECTIONSTRING)
        Dim query As String = "SELECT * FROM Quotation WHERE Worker = @worker;"
        connection.Open()

        Dim command As SqlCommand = New SqlCommand(query, connection)
        command.Parameters.AddWithValue("@worker", WorkerId)

        Dim reader As SqlDataReader = command.ExecuteReader()

        If reader.HasRows Then
            reader.Read()
            handyman = New Worker(reader("Worker"))

            quote &= "<p class=""p-price"">Quotation</p>"
            quote &= "<a href=QuotationDisplay.aspx?Selected=" & handyman.getUsername & "> View </a>"
            quote &= "<div class=""clearfix""></div>"
            quote &= "</div>"

        End If

        Return quote
    End Function

    Private Sub changeCheckedClient(id As Integer)
        Dim connection As SqlConnection = New SqlConnection(ValidationClass.CONNECTIONSTRING)
        Dim query As String = "UPDATE Responses SET Checked = @value WHERE PostAdId = @name;"
        connection.Open()

        Dim command As SqlCommand = New SqlCommand(query, connection)
        command.Parameters.AddWithValue("@name", id)
        command.Parameters.AddWithValue("@value", "checked")

        Dim reader As SqlDataReader = command.ExecuteReader()

        connection.Close()
    End Sub

    Private Sub changeCheckedQuotation(id As Integer)
        Dim connection As SqlConnection = New SqlConnection(ValidationClass.CONNECTIONSTRING)
        Dim query As String = "UPDATE Quotation SET Checked = @value WHERE QuoteId = @name;"
        connection.Open()

        Dim command As SqlCommand = New SqlCommand(query, connection)
        command.Parameters.AddWithValue("@name", id)
        command.Parameters.AddWithValue("@value", "checked")

        Dim reader As SqlDataReader = command.ExecuteReader()

        connection.Close()
    End Sub
End Class