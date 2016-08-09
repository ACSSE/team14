Imports System.Data.SqlClient

Public Class RatingHandyMan
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnRatingSubmit_Click(sender As Object, e As EventArgs) Handles btnRatingSubmit.ServerClick
        Dim handyman As String = Request.QueryString("Handyman")
        Dim adID As Integer = Request.QueryString("adID")

        Dim timeManRate As Integer = lstTimeMan.SelectedValue
        Dim profRate As Integer = lstProffesion.SelectedValue
        Dim qualRate As Integer = lstQuality.SelectedValue
        Dim interRate As Integer = lstInterpersonal.SelectedValue
        Dim an As Integer = lstAn.SelectedValue

        Dim Average As Integer = CInt((timeManRate + profRate + qualRate + interRate + an) / 5)


        Dim connection As SqlConnection
        Dim command As SqlCommand
        Dim reader As SqlDataReader

        connection = New SqlConnection(ValidationClass.CONNECTIONSTRING)
        connection.Open()
        command = New SqlCommand("INSERT INTO Ratings (JobID, Worker, TimeManagement, Interpersonal, Quality, Profesionalism, Consistency) VALUES (@ID, @worker, @Man, @Inter, @Qual, @Prof, @Cons)", connection)

        command.Parameters.AddWithValue("@ID", adID)
        command.Parameters.AddWithValue("@worker", handyman)
        command.Parameters.AddWithValue("@Man", timeManRate)
        command.Parameters.AddWithValue("@Inter", interRate)
        command.Parameters.AddWithValue("@Qual", qualRate)
        command.Parameters.AddWithValue("@Prof", profRate)
        command.Parameters.AddWithValue("@Cons", an)

        reader = command.ExecuteReader()

        connection.Close()
        changeDB(adID)
        MsgBox("Handyman " & handyman & "Thanks you for your feedback")

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
        Dim average As Integer = 0 'to assist in calculating the average
        Dim count As Integer = 0 'denominator ut will be a maximum of 5
        Dim jobAve() As Integer 'A collectio of job averages

        Dim adconnection As SqlConnection = New SqlConnection(ValidationClass.CONNECTIONSTRING)
        adconnection.Open()
        Dim query As String = "SELECT * FROM Ratings WHERE Worker = @name;"
        Dim command As SqlCommand = New SqlCommand(query, adconnection)
        command.Parameters.AddWithValue("@name", worker)
        Dim reader As SqlDataReader = command.ExecuteReader()

        If reader.HasRows() Then
            While reader.Read()
                count += 1
                ReDim Preserve jobAve(count)

                If IsDBNull(reader("QuickRating")) Then

                End If

            End While
        End If

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