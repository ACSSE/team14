Imports System.Data.SqlClient

Public Class ViewHistory
    Inherits System.Web.UI.Page
    Private worker As Worker
    Private jobs() As JobStats
    Private Shared pagecount As Integer

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        worker = Session("user")
        getHistory() 'obtaining the values for array jobs()

        Dim page As Integer = Request.QueryString("pg")
        'doing graphing work here
        'MsgBox("length = " & jobs.Length())
        Dim size As Integer = jobs.Length() 'number of jobs

        If page = Nothing Or page = 1 Then
            If Not (size = 0) Then
                ''show the latest 5 jobs
                If size <= 5 Then 'when handyman has less than 5 jobs
                    '    Dim chartname As String
                    '    Dim seriesname As String
                    '    For i As Integer = 1 To size - 1
                    '        chartname = "job" & i
                    '        seriesname = "Job" & i
                    '        'MsgBox(jobs(i).rate)
                    '        Me.jobRatings.Series(chartname).Points.AddXY(seriesname, jobs(i).rate)
                    '        'MsgBox("chartname=" & chartname & "seriesname=" & seriesname)
                    '    Next i
                Else
                    '    Me.jobRatings.Series("job1").Points.AddXY("Job1", jobs(size - 1).rate)
                    '    Me.jobRatings.Series("job2").Points.AddXY("Job2", jobs(size - 2).rate)
                    '    Me.jobRatings.Series("job3").Points.AddXY("Job3", jobs(size - 3).rate)
                    '    Me.jobRatings.Series("job4").Points.AddXY("Job4", jobs(size - 4).rate)
                    '    Me.jobRatings.Series("job5").Points.AddXY("Job5", jobs(size - 5).rate)

                End If
                writeJobs(page)
            Else 'if the jobs array is empty

            End If

            Else 'for other pages
                'chartArea.Visible = False
                writeJobs(page)
            End If

    End Sub

    Private Sub getHistory()
        Dim size As Integer = 0
        'Dim jobs(size) As JobStats 'job ids in array


        Dim adconnection As SqlConnection = New SqlConnection(ValidationClass.CONNECTIONSTRING)
        adconnection.Open()
        Dim query As String = "Select * FROM Ratings WHERE Worker = @name AND Pending = @true;"
        Dim command As SqlCommand = New SqlCommand(query, adconnection)

        command.Parameters.AddWithValue("@name", worker.getUsername())
        command.Parameters.AddWithValue("@true", "false")

        Dim reader As SqlDataReader = command.ExecuteReader()

        Dim notifications As String = ""

        If reader.HasRows Then
            While reader.Read()
                size += 1
                Dim id As Integer = reader("JobID")
                Dim job As Job = Nothing
                getJob(id, job)
                ReDim Preserve jobs(size)
                jobs(size) = New JobStats(job, reader("Comments"), reader("JobAverage"))
            End While
        End If

        Dim html As String = ""

    End Sub

    Public Sub getJob(JobID As Integer, ByRef job As Job)

        Dim adconnection As SqlConnection = New SqlConnection(ValidationClass.CONNECTIONSTRING)
        adconnection.Open()
        Dim query As String = "Select * FROM AdTable WHERE PostAdId = @name;"
        Dim command As SqlCommand = New SqlCommand(query, adconnection)
        command.Parameters.AddWithValue("@name", JobID)

        Dim reader As SqlDataReader = command.ExecuteReader()

        If reader.HasRows Then
            reader.Read()

            job = New Job(reader("Category"), reader("AdTitle"), reader("AdDescription"), "", "", reader("OpenDate"))
        End If
    End Sub

    Private Sub writeJobs(page As Integer)

        Dim script As String = ""

        Dim size As Integer = jobs.Length()

        Dim limiter As Integer = 5 * page

        If limiter < size - 1 Then
            Dim start As Integer = limiter - 5
            For i As Integer = 1 To size - 1 'Fix later
                script &= "<a href=""WorkerProfile.aspx"">"
                script &= "<li>"
                ' script &= "<img src=""images/g4.jpg"" title="" alt=""/>"
                script &= "<section class=""list-left"">"
                script &= "<h5 class=""title"">" & jobs(i).job.getTitle() & "</h5>"
                script &= "<h4>Rating: " & ValidationClass.getRateImage(jobs(i).rate) & "<h4>"
                script &= "<h6 class=""title"">" & jobs(i).job.getCategory() & "</h6>"
                script &= "<span class=""adprice""><p> <i class=""glyphicon glyphicon-map-marker""></i><a href=""#"">Gauteng</a>, <a href=""#"">Dunvegan</a></p></span>"
                script &= "<p class=""catpath"">" & jobs(i).comments & "</p>"
                script &= "</section> <section class=""list-right""></section><div class=""clearfix""></div></li></a>"

            Next i
        Else 'when there is not 5 jobs left on this page
            limiter = limiter - 5
            If limiter <= 0 Then
                limiter = 1
            End If
            ' MsgBox("Limiter = " & limiter & "size = " & size - 1)
            While Not (limiter = size - 1)
                
                '  MsgBox("Limiter = " & limiter & "size = " & size - 1)
                script &= "<ul class=""list"">"
                script &= "<a href=""WorkerProfile.aspx"">"
                script &= "<li>"
                'script &= "<img src=""images/g4.jpg"" title="" alt=""/>"
                script &= "<section class=""list-left"">"
                script &= "<h5 class=""title"">" & jobs(limiter).job.getTitle() & "</h5>"
                script &= "<h4>Rating: " & ValidationClass.getRateImage(jobs(limiter).rate) & "<h4>"
                script &= "<h6 class=""title"">" & jobs(limiter).job.getCategory() & "</h6>"
                script &= "<span class=""adprice""><p> <i class=""glyphicon glyphicon-map-marker""></i><a href=""#"">Gauteng</a>, <a href=""#"">Dunvegan</a></p></span>"
                script &= "<p class=""catpath"">" & jobs(limiter).comments & "</p>"
                script &= "</section> <section class=""list-right""></section><div class=""clearfix""></div></li></a>"
                script &= "</ul>"
                limiter += 1 'incrementing limiter
            End While
        End If
        '  MsgBox(script)
        container.InnerHtml = script
    End Sub

End Class

Public Class JobStats 'to help with displaying the job stats
    Public job As Job 'to hold all job values
    Public comments As String
    Public rate As Integer


    Public Sub New(job As Job, comments As String, rate As Integer)
        Me.job = job
        Me.comments = comments
        Me.rate = rate
    End Sub
End Class
