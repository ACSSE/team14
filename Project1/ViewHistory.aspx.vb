Imports System.Data.SqlClient

Public Class ViewHistory
    Inherits System.Web.UI.Page
    Private worker As Worker

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        worker = Session("Worker")
        
    End Sub

    Private Sub getHistory()
        Dim size As Integer = 0
        Dim IDs(size) As Integer 'job ids in array
        Dim comments(size) As String


        Dim adconnection As SqlConnection = New SqlConnection(ValidationClass.CONNECTIONSTRING)
        adconnection.Open()
        Dim query As String = "Select * FROM Ratings WHERE Worker = @name AND Pending = @true;"
        Dim command As SqlCommand = New SqlCommand(query, adconnection)

        command.Parameters.AddWithValue("@name", worker.getUsername())
        command.Parameters.AddWithValue("@true", "false")

        Dim reader As SqlDataReader = command.ExecuteReader()

        Dim notifications As String = ""

        If reader.HasRows Then
            reader.Read()
            size += 1
            ReDim Preserve IDs(size)
            ReDim Preserve comments(size)
            IDs(size) = reader("JobID") 'GET ALL THE JOB IDs    
            comments(size) = reader("Comments")
        End If

        Dim client1 As Client = Nothing
        Dim client2 As Client = Nothing

        'Binding values to the clients
        If size <= 1 Then
            client1 = getHistoryClientFromJobsInfo(IDs(size))
        Else
            client1 = getHistoryClientFromJobsInfo(IDs(size))
            client2 = getHistoryClientFromJobsInfo(IDs(size - 1))
        End If



        Dim html As String = ""

        If size > 1 Then
            'first client history and comments
            html &= "<div class=""col-md-6 happy-clients-grid wow bounceIn"" data-wow-delay=""0.4s"">"
            html &= "<div class=""client"">"
            html &= "<img src=""images/client_1.jpg"" alt="""" />"
            html &= "</div>"
            html &= "<div class=""client-info"">"
            html &= "<p>" & comments(size) & "</p>"
            html &= "<h4><a href=""#"">" & client1.getName() & " " & client1.getSurname() & "</a><p> <i class=""glyphicon glyphicon-map-marker""></i><a href=""#"">Gauteng</a>, <a href=""#"">Edenvale</a></p></h4>"
            html &= "</div>"
            html &= "<div class=""clearfix""></div>"
            html &= "</div>"

            'second client history and comments
            html &= "<div class=""client"">"
            html &= "<img src=""images/client_1.jpg"" alt="""" />"
            html &= "</div>"
            html &= "<div class=""client-info"">"
            html &= "<p>" & comments(size - 1) & "</p>"
            html &= "<h4><a href=""#"">" & client2.getName() & " " & client2.getSurname() & "</a><p> <i class=""glyphicon glyphicon-map-marker""></i><a href=""#"">Gauteng</a>, <a href=""#"">Edenvale</a></p></h4>"
            html &= "</div>"
            html &= "<div class=""clearfix""></div>"
            html &= "</div>"

        ElseIf size = 1 Then
            html &= "<div class=""col-md-6 happy-clients-grid wow bounceIn"" data-wow-delay=""0.4s"">"
            html &= "<div class=""client"">"
            html &= "<img src=""images/client_1.jpg"" alt="""" />"
            html &= "</div>"
            html &= "<div class=""client-info"">"
            html &= "<p>" & comments(size) & "</p>"
            html &= "<h4><a href=""#"">" & client1.getName() & " " & client1.getSurname() & "</a><p> <i class=""glyphicon glyphicon-map-marker""></i><a href=""#"">Gauteng</a>, <a href=""#"">Edenvale</a></p></h4>"
            html &= "</div>"
            html &= "<div class=""clearfix""></div>"
            html &= "</div>"
        Else
            html &= ""
        End If

        divHistory.InnerHtml = html
    End Sub

    Public Function getHistoryClientFromJobsInfo(JobID As Integer) As Client

        Dim adconnection As SqlConnection = New SqlConnection(ValidationClass.CONNECTIONSTRING)
        adconnection.Open()
        Dim query As String = "Select * FROM AdTable WHERE PostAdId = @name;"
        Dim command As SqlCommand = New SqlCommand(query, adconnection)
        command.Parameters.AddWithValue("@name", JobID)

        Dim reader As SqlDataReader = command.ExecuteReader()

        Dim client As Client = Nothing

        If reader.HasRows Then
            reader.Read()
            Dim username As String = reader("Client")
            client = New Client(username)
        End If

        Return client

    End Function

End Class