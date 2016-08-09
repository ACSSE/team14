Imports System.Data.SqlClient
Public Class WorkerProfile
    Inherits System.Web.UI.Page

    Private worker As Worker

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
      

        Dim c As User = Session("user")
        worker = c

        lblRegion.Visible = True
        lblName.Visible = True
        lblSurname.Visible = True
        lblNumber.Visible = True
        lblEmail.Visible = True


        JobTitle.InnerText = worker.getCategory() 'setting the correct heading category
        lblRegion.InnerText = worker.getRegion()
        lblName.InnerText = worker.getName()
        lblSurname.InnerHtml = worker.getSurname()
        lblNumber.InnerText = worker.getNumbers()
        lblEmail.InnerText = worker.getEmail()

        myJobs.InnerHtml = displayJobs()
        JobNots.InnerHtml = displayJobs(worker.getCategory())
    End Sub

    Private Function displayJobs() As String 'display jobs that the handyman has already accepted or is working on
        Dim size As Integer
        Dim HandymanJobs(size) As Job

        Dim adconnection As SqlConnection = New SqlConnection(ValidationClass.CONNECTIONSTRING)
        adconnection.Open()
        Dim query As String = "Select * FROM AdTable WHERE Worker = @name"
        Dim command As SqlCommand = New SqlCommand(query, adconnection)

        command.Parameters.AddWithValue("@name", worker.getUsername())

        Dim reader As SqlDataReader = command.ExecuteReader()

        Dim notifications As String = "<h3>My Jobs</h3> <br/>"

        Dim tempJob As Job ' to use as holder

        If reader.HasRows Then
            Dim clientUsername As String = ""
            Dim ID As Integer = 0
            Dim title As String = ""
            Dim description As String = ""
            Dim category As String = ""
            While reader.Read() 'getting all the jobs
                size += 1
                ReDim Preserve HandymanJobs(size)

                clientUsername = reader("Client")
                ID = reader("PostAdId")
                title = reader("AdTitle")
                description = reader("AdDescription")
                category = reader("Category")

                
                tempJob = New Job(ID, category, title, description, clientUsername, "")
                HandymanJobs(size) = tempJob 'adding job to the list
                'TO DO Build messaging service here
                notifications &= "<h5>" & reader("AdTitle") & "</h5> "
                notifications &= ValidationClass.displayMessenges(ID) & "<hr/>" 'displays all the messsenges sent for this particular job

            End While
        End If
        Return notifications
    End Function

    Private Function displayJobs(categroy As String) As String
       

        Dim size As Integer = 0 'for resizing purposes
        Dim jobs(size) As Job 'array for jobs to be stored

        Dim adconnection As SqlConnection = New SqlConnection(ValidationClass.CONNECTIONSTRING)
        adconnection.Open()
        Dim query As String = "Select * FROM AdTable WHERE Category = @name AND Worker IS NULL"
        Dim command As SqlCommand = New SqlCommand(query, adconnection)

        command.Parameters.AddWithValue("@name", categroy)

        Dim reader As SqlDataReader = command.ExecuteReader()

        Dim notifications As String = "<h3>New Jobs</h3> <br/>"

        Dim tempJob As Job ' to use as holder

        If reader.HasRows Then
            Dim clientUsername As String = ""
            Dim ID As Integer = 0
            Dim title As String = ""
            Dim description As String = ""
            Dim category As String = ""

            While reader.Read() 'getting all the jobs
                size += 1
                ReDim Preserve jobs(size)

                clientUsername = reader("Client")
                ID = reader("PostAdId")
                title = reader("AdTitle")
                description = reader("AdDescription")
                category = reader("Category")

                If reader("Worker") Is Nothing Or IsDBNull(reader("Worker")) Then
                    If shouldADD(ID) Then
                        tempJob = New Job(ID, category, title, description, clientUsername, "")
                        jobs(size) = tempJob 'adding job to the list

                        notifications &= "<a href= AdDetail.aspx?ID=" & reader("PostAdID") & ">" & reader("AdTitle") & "</a> <br />"
                       End If
                End If

            End While
        End If
        Session("jobs") = jobs

        Return notifications
    End Function


    Private Function shouldADD(JobID As Integer) As Boolean
        'Jobs that the handyman has already answerede should not be displayed

        Dim adconnection As SqlConnection = New SqlConnection(ValidationClass.CONNECTIONSTRING)
        adconnection.Open()
        Dim query As String = "Select * FROM Responses WHERE AdID = @name AND Worker = @worker"
        Dim command As SqlCommand = New SqlCommand(query, adconnection)

        command.Parameters.AddWithValue("@name", JobID)
        command.Parameters.AddWithValue("@worker", worker.getUsername())

        Dim reader As SqlDataReader = command.ExecuteReader()

        If reader.HasRows Then
            ' MsgBox("WorkerProfile:shouldADD() - reader has rows, returns true")
            adconnection.Close()
            Return False 'If there is already a response than the job should not be shown
        End If


        ' MsgBox("WorkerProfile:shouldADD() - reader has no rows, returns false")
        adconnection.Close()
        Return True 'job shown if there was no response made by handyman
    End Function

   
End Class