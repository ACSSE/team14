Imports System.Data.SqlClient

Public Class FeaturedClients
    Inherits System.Web.UI.Page

    Private clients() As Client

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        clients = getClients()

        divBlocked.InnerHtml = displayClosed()
        divNonBlocked.InnerHtml = displayOpen()


    End Sub

    Private Function getClients()
        Dim size As Integer
        Dim tclients(size) As Client

        'temp varaibles to initialize the varaibles
        Dim username As String
        Dim name As String
        Dim surname As String
        Dim numbers As String
        Dim joindate As Date
        Dim email As String
        Dim status As String
        Dim region As String
        Dim address As String
        Dim suburb As String

        Dim connection As SqlConnection
        Dim command As SqlCommand
        Dim reader As SqlDataReader

        connection = New SqlConnection(ValidationClass.CONNECTIONSTRING)
        Dim commandstring As String = "SELECT * From Clients"
        command = New SqlCommand(commandstring, connection)

        command.Connection.Open()
        reader = command.ExecuteReader()

        If reader.HasRows Then
            While reader.Read()

                username = reader("Username")
                name = reader("Name")
                surname = reader("Surname")
                numbers = reader("MobileNumber")
                email = reader("Email")
                joindate = reader("JoinDate")
                address = reader("Address")
                suburb = reader("Suburb")
                region = reader("Region")
                status = reader("Status")
                size += 1
                ReDim Preserve tclients(size)
                tclients(size) = New Client(username, "", name, surname, email, numbers, address, region, suburb, joindate, status)
            End While
        End If
        connection.Close()
        Return tclients
    End Function

    Private Function displayOpen() 'to display clients wo still have access
        Dim html As String = "<ul class=""list"">"
        Dim pagesize As Integer = 0

        For i As Integer = 1 To clients.Length - 1 'to run through every client
            If clients(i).getStatus() = "OPEN" Then
                pagesize += 1

                html &= "  <a href=""ClientProfile.aspx?type=admin&username=" & clients(i).getUsername() & """ > "
                html &= "<li>"
                html &= "<img src=""images/p1.png"" title="""" alt="""" />"
                html &= "<section class=""list-left"">"
                html &= "<h5 class=""title"">" & clients(i).getName() & " " & clients(i).getSurname() & "</h5>"
                html &= "<h5 class=""title"">" & "categories" & "</h5>"
                html &= "<span class=""adprice""><p> <i class=""glyphicon glyphicon-map-marker""></i><a href=""#"">Gauteng</a>, <a href=""#"">Dowerglen</a></p></span>"
                html &= "<p class=""catpath"">Visit Profile</p>"
                html &= "</section>"
                html &= "<section class=""list-right"">"
                html &= "</section>"
                html &= "<div class=""clearfix""></div>"
                html &= "</li> "
                html &= "</a>"
            End If
        Next i
        html &= "</ul>"
        Return html
    End Function

    Private Function displayClosed() 'to display clients who no longer have access
        Dim html As String = "<ul class=""list"">"
        Dim pagesize As Integer = 0

        For i As Integer = 1 To clients.Length - 1 'to run through every client
            If clients(i).getStatus() = "BLOCKED" Then
                pagesize += 1

                html &= "  <a href=""ClientProfile.aspx?type=admin&username=" & clients(i).getUsername() & """ > "
                html &= "<li>"
                html &= "<img src=""images/p1.png"" title="""" alt="""" />"
                html &= "<section class=""list-left"">"
                html &= "<h5 class=""title"">" & clients(i).getName() & " " & clients(i).getSurname() & "</h5>"
                'html &= "<h5 class=""title"">" & categories & "</h5>"
                'html &= "<span class=""adprice""><p> <i class=""glyphicon glyphicon-map-marker""></i><a href=""#"">Gauteng</a>, <a href=""#"">Dowerglen</a></p></span>"
                html &= "<p class=""catpath"">Visit Profile</p>"
                html &= "</section>"
                html &= "<section class=""list-right"">"
                html &= "</section>"
                html &= "<div class=""clearfix""></div>"
                html &= "</li> "
                html &= "</a>"
            End If
        Next i
        html &= "</ul>"
        Return html
    End Function


End Class