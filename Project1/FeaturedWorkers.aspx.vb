Imports System.Data.SqlClient

Public Class FeaturedWorkers
    Inherits System.Web.UI.Page

    Private workers() As Worker
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        workers = getWorkers() 'C:\Users\Karabo\Desktop\HandyMan\HandyMan\team14\Project1\ClientProfile2.aspx

        divElectrician.InnerHtml = getProfiles("Electrician")
        PaintnDecoration.InnerHtml = getProfiles("Paint and Decoration")
        PoolSpel.InnerHtml = getProfiles("Pool Specialist")
        Security.InnerHtml = getProfiles("Security, Fire and Safety")
        KitchenSpec.InnerHtml = getProfiles("Kitchen Specialist")
        GardennLandscaping.InnerHtml = getProfiles("Garden and Landscaping")
    End Sub


    Private Function getWorkers()
        Dim size As Integer
        Dim workers(size) As Worker

        'temp varaibles to initialize the varaibles
        Dim username As String
        Dim name As String
        Dim surname As String
        Dim numbers As String
        Dim rate As Integer
        Dim category As String
        Dim joindate As Date
        Dim email As String
        Dim description As String
        Dim connection As SqlConnection
        Dim command As SqlCommand
        Dim reader As SqlDataReader

        connection = New SqlConnection(ValidationClass.CONNECTIONSTRING)
        Dim commandstring As String = "SELECT * From Workers"
        command = New SqlCommand(commandstring, connection)

        command.Connection.Open()
        reader = command.ExecuteReader()

        If reader.HasRows Then
            While reader.Read()

                category = reader("Category")
                joindate = reader("JoinDate")
                username = reader("Username")
                name = reader("Name")
                surname = reader("Surname")
                numbers = reader("MobileNumber")
                email = reader("Email")
                description = reader("Description")

                size += 1
                ReDim Preserve workers(size)
                workers(size) = New Worker(username, "", name, surname, email, numbers, "", description, category, Nothing, joindate)
            End While
        End If
        connection.Close()
        Return workers
    End Function

    Private Function getProfiles(categories As string) As String
        Dim html As String = "<ul class=""list"">"
        Dim pagesize As Integer = 0

        For i As Integer = 1 To workers.Length - 1
            If workers(i).getCategory().Contains(categories) And pagesize <= 5 Then
                pagesize += 1
                If Session("viewer") = "client" Then
                    html &= "  <a href=""WorkerProfile.aspx?type=client&username=" & workers(i).getUsername() & """ > "
                Else
                    html &= "  <a href=""WorkerProfile.aspx?type=client&username=" & workers(i).getUsername() & """ > "
                End If
                html &= "<li>"
                html &= "<img src=""images/p1.png"" title="""" alt="""" />"
                html &= "<section class=""list-left"">"
                html &= "<h5 class=""title"">" & workers(i).getName() & " " & workers(i).getSurname() & "</h5>"
                html &= "<h5 class=""title"">" & categories & "</h5>"
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