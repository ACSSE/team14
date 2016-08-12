Imports System.Data.SqlClient

Public Class RatingHandyMan
    Inherits System.Web.UI.Page

    Private cUser As User
    Private adID As Integer

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cUser = Session("user")
        adID = Request.QueryString("adID")
        If TypeOf cUser Is Worker Then
            handymanRating.Visible = False
        Else
            clientRating.Visible = False
        End If


    End Sub

    Protected Sub btnRatingSubmit_Click(sender As Object, e As EventArgs) Handles btnRatingSubmit.ServerClick

        If TypeOf cUser Is Worker Then
            rateClient() 'worker rating client
        Else
            rateHandyman() 'client rating worker
        End If

    End Sub

    Private Sub rateClient()

        Dim client As String = Request.QueryString("Client")

        Dim cClient As Client = New Client(client)

        Dim Handymanrating As Integer = clientRate.SelectedValue()

        If cClient.getRating() = 0 Then
            cClient.updateAverage(Handymanrating) 'first rating
        Else
            Dim overallRating As Integer = (Handymanrating + cClient.getRating()) / 2 'average of previous and new rating
            cClient.updateAverage(overallRating)
        End If


        Dim adconnection As SqlConnection = New SqlConnection(ValidationClass.CONNECTIONSTRING)
        adconnection.Open()
        Dim query As String = "UPDATE Ratings SET Pending = @false WHERE JobID = @name"
        Dim command As SqlCommand = New SqlCommand(query, adconnection)
        command.Parameters.AddWithValue("@false", "false")
        command.Parameters.AddWithValue("@name", adID)
        'command.Parameters.AddWithValue("@worker", cUser.getUsername())
        Dim reader As SqlDataReader = command.ExecuteReader()
        adconnection.Close()


        Response.Redirect("WorkerProfile.aspx")

    End Sub

    Private Sub rateHandyman()
        Dim handyman As String = Request.QueryString("Handyman")


        Dim timeManRate As Integer = lstTimeMan.SelectedValue
        Dim profRate As Integer = lstProffesion.SelectedValue
        Dim qualRate As Integer = lstQuality.SelectedValue
        Dim interRate As Integer = lstInterpersonal.SelectedValue
        Dim an As Integer = lstAn.SelectedValue
        Dim comments As String = txtComments.Value()

        Dim Average As Integer = CInt((timeManRate + profRate + qualRate + interRate + an) / 5)


        Dim connection As SqlConnection
        Dim command As SqlCommand
        Dim reader As SqlDataReader

        connection = New SqlConnection(ValidationClass.CONNECTIONSTRING)
        connection.Open()
        command = New SqlCommand("INSERT INTO Ratings (JobID, Worker, TimeManagement, Interpersonal, Quality, Profesionalism, Consistency, Comments, Pending) VALUES (@ID, @worker, @Man, @Inter, @Qual, @Prof, @Cons, @comments, @pending)", connection)

        command.Parameters.AddWithValue("@ID", adID)
        command.Parameters.AddWithValue("@worker", handyman)
        command.Parameters.AddWithValue("@Man", timeManRate)
        command.Parameters.AddWithValue("@Inter", interRate)
        command.Parameters.AddWithValue("@Qual", qualRate)
        command.Parameters.AddWithValue("@Prof", profRate)
        command.Parameters.AddWithValue("@Cons", an)
        command.Parameters.AddWithValue("@comments", comments)
        command.Parameters.AddWithValue("@pending", "true")
        reader = command.ExecuteReader()

        connection.Close()
        changeDB(adID)
        MsgBox("Handyman " & handyman & "Thanks you for your feedback")
        calculateAve(handyman)
        Response.Redirect("ClientProfile.aspx")
    End Sub

    Private Sub changeDB(adID As Integer)
        'delete postadid
        Dim adconnection As SqlConnection = New SqlConnection(ValidationClass.CONNECTIONSTRING)
        adconnection.Open()
        Dim query As String = "UPDATE AdTable SET Status = @complete WHERE PostAdId = @name;"
        Dim command As SqlCommand = New SqlCommand(query, adconnection)
        command.Parameters.AddWithValue("@name", adID)
        command.Parameters.AddWithValue("@complete", "Complete")
        Dim reader As SqlDataReader = command.ExecuteReader()
        adconnection.Close()
    End Sub

    Private Sub calculateAve(worker As String) 'to calculate average rating of worker
        ' MsgBox("RatingHandyMan:calculateAve()")
        Dim average As Integer = 0 'to assist in calculating the average
        Dim count As Integer = 0 'denominator ut will be a maximum of 5
        Dim jobAve() As Integer = Nothing  'A collectio of job averages

        Dim adconnection As SqlConnection = New SqlConnection(ValidationClass.CONNECTIONSTRING)
        adconnection.Open()
        Dim query As String = "SELECT * FROM Ratings WHERE Worker = @name;"
        Dim command As SqlCommand = New SqlCommand(query, adconnection)
        command.Parameters.AddWithValue("@name", worker)
        Dim reader As SqlDataReader = command.ExecuteReader()

        If reader.HasRows() Then

            ' MsgBox("WorkerProfile:calculateAve()-Reader has rows")

            While reader.Read()
                count += 1
                ReDim Preserve jobAve(count)

                If IsDBNull(reader("QuickRating")) Or reader("QuickRating") = 0 Then 'if quick rating is 0 then full rating was done
                    Dim timeMan As Integer = reader("TimeManagement")
                    Dim person As Integer = reader("Interpersonal")
                    Dim quality As Integer = reader("Quality")
                    Dim prof As Integer = reader("Profesionalism")
                    Dim constin As Integer = reader("Consistency")
                    jobAve(count) = (timeMan + person + quality + prof + constin) / 5

                    'MsgBox("WorkerProfile:calculateAve()-Average " & count & ":" & jobAve(count))

                Else
                    jobAve(count) = reader("QuickRating")
                End If

            End While
        End If

        'Calculating overall average
        If jobAve IsNot Nothing Then
            If count <= 5 Then
                Dim total As Integer = 0
                For i As Integer = 1 To count 'getting all current values
                    total += jobAve(i)
                Next i
                'MsgBox("RatingHandyMan:calculateAve()-total = " & total)
                average = total / count
            Else
                average = (jobAve(count) + jobAve(count - 1) + jobAve(count - 2) + jobAve(count - 3) + jobAve(count - 4)) / 5 'taking the latest 5
            End If
        End If
        'MsgBox("RatingHandyMan:calculateAve()-Overall Average = " & average)
        Dim cUser As User = New Worker(worker)
        cUser.updateAverage(average) 'updating average 
    End Sub


    Public Sub saveHandymanAve(average As Integer, worker As String)
        'update average rating
        Dim adconnection As SqlConnection = New SqlConnection(ValidationClass.CONNECTIONSTRING)
        adconnection.Open()
        Dim query As String = "UPDATE AverageWorkerRating SET AverageRating = @average WHERE Worker = @worker;"
        Dim command As SqlCommand = New SqlCommand(query, adconnection)
        command.Parameters.AddWithValue("@average", average)
        command.Parameters.AddWithValue("@worker", worker)
        Dim reader As SqlDataReader = command.ExecuteReader()
        adconnection.Close()
    End Sub

    Private Sub deleteMessenges(adID As Integer)
        'delete messenges
        Dim adconnection As SqlConnection = New SqlConnection(ValidationClass.CONNECTIONSTRING)
        adconnection.Open()
        Dim query As String = "DELETE FROM Messenges WHERE PostAdId = @name;"
        Dim command As SqlCommand = New SqlCommand(query, adconnection)
        command.Parameters.AddWithValue("@name", adID)

        Dim reader As SqlDataReader = command.ExecuteReader()
        adconnection.Close()
    End Sub
End Class