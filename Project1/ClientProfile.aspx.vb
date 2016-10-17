




Public Class ClientProfile
    Inherits System.Web.UI.Page

    Private client As Client
    Private newRes As Boolean

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'update.InnerHtml = "<a href=""UpdateProfile.aspx?username=" & Session("UserName") & "&user=client>Update your profile</a>"
        Dim c As User = Session("user")
        client = c


        changeDB()

        Dim ifunction As String = Request.QueryString("function")
        ' MsgBox("ClientProfile:PageLoad()-ifunction = " & ifunction)
        If ifunction = "cancel" Then
            '  MsgBox("ClientProfile:PageLoad()-inside ifunction if-statement")
            Dim CancelAd As Integer = Request.QueryString("cancelID")
            Dim jobs() As Job = Session("jobs")
            Dim quote() As Quotation = Session("quote")
            '  MsgBox("ClientProfile:PageLoad()-CancelIa= " & CancelAd)
            For i As Integer = 1 To jobs.Length() - 1
                'MsgBox("ClientProfile:PageLoad()-JOBID= " & jobs(i).getID())
                If jobs(i).getID() = CancelAd Then
                    ' MsgBox("ClientProfile:PageLoad()-Inside the delete jobs if-statement")
                    changeDB(CancelAd)
                    jobs(i).deleteJob()
                End If
            Next i
        End If

        Try
            lblName.Visible = True
            lblSurname.Visible = True
            lblNumber.Visible = True
            lblAddress.Visible = True
            lblEmail.Visible = True

            lblName.InnerText = client.getName()  'reader("Name")
            lblSurname.InnerHtml = client.getSurname()  'reader("SurName")
            lblNumber.InnerText = client.getNumbers() 'reader("MobileNumber")
            lblAddress.InnerText = client.getAddress() 'reader("Address")
            lblEmail.InnerText = client.getEmail  'reader("Email")



            AdsDiv.InnerHtml = displayAds()
            quotationDiv.InnerHtml = displayQuote()
        Catch ex As Exception

        End Try
       


    End Sub


    Private Function displayAds() As String 'to display ads that client has posted but have no handyman assinged to them
        Dim size As Integer = 0 'to use as a resize reference
        Dim jobs(size) As Job 'to store all jobs


        Dim adconnection As SqlConnection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\HandymanDatabase.mdf;Integrated Security=True")
        adconnection.Open()
        Dim query As String = "Select * FROM AdTable WHERE Client = @name;"
        Dim command As SqlCommand = New SqlCommand(query, adconnection)
        command.Parameters.AddWithValue("@name", client.getUsername())

        Dim reader As SqlDataReader = command.ExecuteReader()

        Dim oldAds As String = ""
        Dim newAds As String = ""

        If reader.HasRows Then
            While reader.Read()
                'If no handyman is assigned to the job/ad
                size += 1
                ReDim Preserve jobs(size)

                'varaibles to creat a new job
                Dim client As Client = Session("user")

                Dim clientUsername As String = client.getUsername() 'client who is posting ad
                Dim ID As Integer = reader("PostAdId")
                Dim title As String = reader("AdTitle")
                Dim description As String = reader("AdDescription")
                Dim category As String = reader("Category")
                Dim oDate As Date = reader("OpenDate")

                Dim tempJob As Job 'Temporary container for job object

                If IsDBNull(reader("Status")) Then

                    If reader("Worker") Is Nothing Or IsDBNull(reader("Worker")) Then
                        tempJob = New Job(ID, category, title, description, clientUsername, "", oDate)
                        jobs(size) = tempJob 'adding job to the list

                        'building html thing language to display jobs
                        newAds &= "<div>"
                        determineNewRes(ID)
                        If newRes Then
                            newAds &= "<h4>" & tempJob.getTitle() & "</h4> <span class=""bell animated shake""> </span>"
                        Else
                            newAds &= "<h4>" & tempJob.getTitle() & "</h4>"
                        End If
                        
                        newAds &= displayResponses(tempJob.getID())
                        newAds &= "<a style=""color:white"" href=ClientProfile.aspx?function=cancel&cancelID=" & tempJob.getID() & ">Cancel</a>"
                        newAds &= "</div><br/>" & Environment.NewLine

                    Else 'if handyman has been assigned

                        Dim handyman As String = reader("Worker") 'to be used in constructor

                        tempJob = New Job(ID, category, title, description, clientUsername, handyman, oDate)
                        jobs(size) = tempJob 'adding job to the list


                        oldAds &= "<div>"
                        oldAds &= "<h4>" & reader("AdTitle") & "</h4>"
                        oldAds &= "<a style=""color:white"" href=RatingHandyMan.aspx?Handyman=" & tempJob.getHandyman() & "&adID=" & tempJob.getID() & ">Done</a> <br/>"
                        oldAds &= ValidationClass.displayMessenges(ID) & "<hr/>" 'displays all the messsenges sent for this particular job
                        oldAds &= "</div> <br/>" & Environment.NewLine
                    End If
                End If
            End While
        End If
        adconnection.Close()

        Session("jobs") = jobs


        Return newAds & Environment.NewLine & oldAds
    End Function

    Private Function displayQuote() As String 'to display ads that client has posted but have no handyman assinged to them
        Dim size As Integer = 0 'to use as a resize reference
        Dim quote(size) As Quotation 'to store all quotes


        Dim adconnection As SqlConnection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\HandymanDatabase.mdf;Integrated Security=True")
        adconnection.Open()
        Dim query As String = "Select * FROM Quotation WHERE QuoteId = @quote;"
        Dim command As SqlCommand = New SqlCommand(query, adconnection)
        command.Parameters.AddWithValue("@quote", client.getUsername())

        Dim reader As SqlDataReader = command.ExecuteReader()

        Dim oldQuote As String = ""
        Dim newQuote As String = ""

        If reader.HasRows Then
            While reader.Read()
                'If no handyman is assigned to the job/ad
                size += 1
                ReDim Preserve quote(size)

                'varaibles to creat a new job
                Dim worker As Worker = Session("user")

                Dim workerUsername As String = worker.getUsername() 'worker who is writting the quotation
                Dim quoteId As Integer = reader("QuoteId")
                Dim quoteDescription As String = reader("quoteDescription")
                Dim quoteHours As Integer = reader("quoteHours")
                Dim quoteAmount As Integer = reader("quoteAmount")

                Dim tempQuote As Quotation  'Temporary container for quotation

                If IsDBNull(reader("Status")) Then

                    If reader("Worker") Is Nothing Or IsDBNull(reader("Worker")) Then
                        tempQuote = New Quotation(quoteId, quoteDescription, quoteHours, quoteAmount, workerUsername)
                        quote(size) = tempQuote  'adding quotation to the list

                        'building html thing language to display jobs
                        newQuote &= "<div>"
                        determineNewRes(ID)
                        If newRes Then
                            newQuote &= "<h4> Quotation: " & tempQuote.getquoteId & "</h4> <span class=""bell animated shake""> </span><br/>"
                        Else
                            newQuote &= "<h4> Quotation: " & tempQuote.getquoteId & "</h4>"
                        End If

                        newQuote &= displayQuotation(tempQuote.getquoteId)
                        newQuote &= "<a style=""color:white"" href=ClientProfile.aspx?function=cancel&cancelID=" & tempQuote.getquoteId & ">Cancel</a>"
                        newQuote &= "</div><br/>" & Environment.NewLine

                    Else 'if handyman has been assigned

                        Dim handyman As String = reader("Worker") 'to be used in constructor

                        tempQuote = New Quotation(quoteId, quoteDescription, quoteHours, quoteAmount, workerUsername)
                        quote(size) = tempQuote 'adding job to the list


                        oldQuote &= "<div>"
                        oldQuote &= "<h4>" & reader("QuoteId") & "</h4>"
                        oldQuote &= "<a style=""color:white"" href=RatingHandyMan.aspx?Handyman=" & tempQuote.getWorker & "&adID=" & tempQuote.getquoteId & ">Done</a> <br/>"
                        'oldQuote &= ValidationClass.displayMessenges(ID) & "<hr/>" 'displays all the messsenges sent for this particular job
                        oldQuote &= "</div> <br/>" & Environment.NewLine
                    End If
                End If
            End While
        End If
        adconnection.Close()

        Session("quote") = quote


        Return newQuote & Environment.NewLine & oldQuote
    End Function

    Public Sub determineNewRes(adID As Integer)
        '  Dim count As Integer = 0
        newRes = False

        Dim connection As SqlConnection = New SqlConnection(ValidationClass.CONNECTIONSTRING)
        Dim query As String = "SELECT * FROM Responses WHERE AdID = @name;"
        connection.Open()

        Dim command As SqlCommand = New SqlCommand(query, connection)
        command.Parameters.AddWithValue("@name", adID)

        Dim reader As SqlDataReader = command.ExecuteReader()

        If reader.HasRows Then
            While reader.Read()
                '   count += 1
                If reader("Checked") = "unchecked" Then
                    newRes = True
                End If
            End While
        End If


    End Sub


    Private Function displayResponses(adID As String) As String
        Dim count As Integer = 0

        Dim connection As SqlConnection = New SqlConnection(ValidationClass.CONNECTIONSTRING)
        Dim query As String = "SELECT * FROM Responses WHERE AdID = @name;"
        connection.Open()

        Dim command As SqlCommand = New SqlCommand(query, connection)
        command.Parameters.AddWithValue("@name", adID)

        Dim reader As SqlDataReader = command.ExecuteReader()

        If reader.HasRows Then
            While reader.Read()
                count += 1
            End While
        End If

        Return "<a style=""color:white"" href=Responses.aspx?ID=" & adID & ">Responses(" & count & ")</a>&nbsp;&nbsp;&nbsp;"
    End Function

    Private Function displayQuotation(QuoteId As String) As String
        Dim count As Integer = 0

        Dim connection As SqlConnection = New SqlConnection(ValidationClass.CONNECTIONSTRING)
        Dim query As String = "SELECT * FROM Quotation WHERE QuoteId = @quote;"
        connection.Open()

        Dim command As SqlCommand = New SqlCommand(query, connection)
        command.Parameters.AddWithValue("@quote", QuoteId)

        Dim reader As SqlDataReader = command.ExecuteReader()

        If reader.HasRows Then
            While reader.Read()
                count += 1
            End While
        End If

        Return "<a style=""color:white"" href=QuaotationDisplay.aspx?ID=" & QuoteId & ">Quotation(" & count & ")</a>&nbsp;&nbsp;&nbsp;"
    End Function

    Private Sub changeDB() 'NOTE TO SELF when changing handyman see this function
        Dim selected As String = Request.QueryString("Selected")
        Dim adder As String = Request.QueryString("ID")

        If adder IsNot Nothing Or Not (adder = "") Then
            Dim adconnection As SqlConnection = New SqlConnection(ValidationClass.CONNECTIONSTRING)
            adconnection.Open()
            Dim query As String = "UPDATE AdTable SET Worker = @handyman WHERE PostAdId = @name"
            Dim command As SqlCommand = New SqlCommand(query, adconnection)
            command.Parameters.AddWithValue("@handyman", selected)
            command.Parameters.AddWithValue("@name", adder)

            Dim reader As SqlDataReader = command.ExecuteReader()
            changeDB(adder)

        End If
    End Sub

    Private Sub changeDB(adID As Integer)
        'delete postadid
        Dim adconnection As SqlConnection = New SqlConnection(ValidationClass.CONNECTIONSTRING)
        adconnection.Open()
        Dim query As String = "DELETE FROM Responses WHERE AdID = @name;"
        Dim command As SqlCommand = New SqlCommand(query, adconnection)
        command.Parameters.AddWithValue("@name", adID)

        Dim reader As SqlDataReader = command.ExecuteReader()
        adconnection.Close()
    End Sub
End Class