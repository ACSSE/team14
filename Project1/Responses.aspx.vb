
Imports System.Data.SqlClient
Public Class Responses
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim adID As Integer = Request.QueryString("ID")
        Dim html As String = ""
        Dim handyman As Worker
        Dim connection As SqlConnection = New SqlConnection(ValidationClass.CONNECTIONSTRING)
        Dim query As String = "SELECT * FROM Responses WHERE PostAdId = @name;"
        connection.Open()

        Dim command As SqlCommand = New SqlCommand(query, connection)
        command.Parameters.AddWithValue("@name", adID)

        Dim reader As SqlDataReader = command.ExecuteReader()

        If reader.HasRows Then
            While reader.Read()
                handyman = New Worker(reader("Worker"))
                'html code ofr div tag
                html &= displayWorker(handyman.getUsername())
                ' html &= "<ul>"
                html &= "<div class=""itemtype"">"
                html &= "<p class=""p-price"">" & reader("Comment") & "</p>"
                html &= "<a href=ResponseDetails.aspx?ID=" & adID & "&worker=" & handyman.getUsername() & ">Send/Read Messeges</a>"
                html &= "     <a href=ClientProfile.aspx?Selected=" & handyman.getUsername() & "&ID=" & adID & "> Confirm </a>"
                html &= "</div>"
                html &= "<hr/>"

            End While
        End If
        ' MsgBox("Resposes:Page_Load()-html values = " & html)
        HandyMen.InnerHtml = html
        changeCheckedClient(adID)
    End Sub

    Private Function displayWorker(workerID As String)
        Dim info As String = ""

        Dim connection As SqlConnection = New SqlConnection(ValidationClass.CONNECTIONSTRING)
        Dim query As String = "SELECT * FROM Workers WHERE Username = @name;"
        connection.Open()

        Dim command As SqlCommand = New SqlCommand(query, connection)
        command.Parameters.AddWithValue("@name", workerID)

        Dim reader As SqlDataReader = command.ExecuteReader()

        If reader.HasRows Then
            ' MsgBox("Resposes:displayWorker()-Reading woker values from database")
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

    Private Sub changeCheckedClient(id As Integer)
        '  MsgBox("Inside changecheckedclient")
        ' MsgBox("ID = " & id)
        Dim connection As SqlConnection = New SqlConnection(ValidationClass.CONNECTIONSTRING)
        Dim query As String = "UPDATE Responses SET Checked = @value WHERE PostAdId = @name;"
        connection.Open()

        Dim command As SqlCommand = New SqlCommand(query, connection)
        command.Parameters.AddWithValue("@name", id)
        command.Parameters.AddWithValue("@value", "checked")

        Dim reader As SqlDataReader = command.ExecuteReader()

        connection.Close()
    End Sub
End Class