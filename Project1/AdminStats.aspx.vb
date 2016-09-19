Imports System.Data.SqlClient

Public Class AdminStats1
    Inherits System.Web.UI.Page

    Private clients() As Date
    Private workers() As Worker

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim d As Integer = DateAndTime.Now.Month()

        clients = getClients()
        workers = getWorkers()


        VisiterStats.InnerHtml = getNewUsers()
        TotalUsers.InnerHtml = getTotalUsers()
        WeekStats.InnerHtml = getWeeklyJobsOpened()
    End Sub

    Private Function getClients()
        Dim size As Integer = 0
        Dim clients(size) As Date

        'temp varaibles for creation of clients
        Dim joindate As String



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
                joindate = reader("JoinDate")
                size += 1
                ReDim Preserve clients(size)
                clients(size) = joindate
            End While
        End If
        connection.Close()
        Return clients
    End Function

    Private Function getWorkers()
        Dim size As Integer
        Dim workers(size) As Worker

        'temp varaibles to initialize the varaibles
        Dim category As String
        Dim joindate As Date

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
                If Not IsDBNull(reader("JoinDate")) Then
                    joindate = reader("JoinDate")
                End If
                size += 1
                ReDim Preserve workers(size)
                workers(size) = New Worker("", "", "", "", "", "", "", "", category, Nothing, joindate)
            End While
        End If
        connection.Close()
        Return workers
    End Function

    Private Function getNewUsers() As String
        'initializing array
        Dim months(12)() As Integer
        For i As Integer = 1 To 12
            ReDim months(i)(2)
            months(i)(1) = 0
            months(i)(2) = 0
        Next i

        For i As Integer = 1 To clients.Length - 1
            Dim month As Integer = clients(i).Month
            months(month)(1) += 1
        Next i

        For i As Integer = 1 To workers.Length - 1
            Dim month As Integer = workers(i).getDate().Month
            months(month)(2) += 1
        Next i

        Dim html As String = "<table>"
        html &= "<tr>"
        html &= "<th>Month</th>"
        html &= "<th>Clients</th>"
        html &= "<th>Handymen</th>"
        html &= "</tr>"

        Dim latestmonth As Integer = Date.Now.Month

        For i As Integer = 1 To latestmonth
            Select Case i
                Case 12
                    html &= "<tr><td>December</td> <td>" & months(12)(1) & "</td><td>" & months(12)(2) & "</td></tr>"
                Case 11
                    html &= "<tr><td>November</td> <td>" & months(11)(1) & "</td><td>" & months(11)(2) & "</td></tr>"
                Case 10
                    html &= "<tr><td>October</td> <td>" & months(10)(1) & "</td><td>" & months(10)(2) & "</td></tr>"
                Case 9
                    html &= "<tr><td>September</td> <td>" & months(9)(1) & "</td><td>" & months(9)(2) & "</td></tr>"
                Case 8
                    html &= "<tr><td>August</td> <td>" & months(8)(1) & "</td><td>" & months(8)(2) & "</td></tr>"
                Case 7
                    html &= "<tr><td>July</td> <td>" & months(7)(1) & "</td><td>" & months(7)(2) & "</td></tr>"
                Case 6
                    html &= "<tr><td>June</td><td>" & months(6)(1) & "</td><td>" & months(6)(2) & "</td></tr>"
                Case 5
                    html &= "<tr><td>May</td> <td>" & months(5)(1) & "</td><td>" & months(5)(2) & "</td></tr>"
                Case 4
                    html &= "<tr><td>April</td><td>" & months(4)(1) & "</td><td>" & months(4)(2) & "</td></tr>"
                Case 3
                    html &= "<tr><td>March </td><td> " & months(3)(1) & "</td><td>" & months(3)(2) & "</td></tr>"
                Case 2
                    html &= "<tr><td>February </td><td>" & months(2)(1) & "</td><td>" & months(2)(2) & "</td></tr>"
                Case 1
                    html &= "<tr><td>January</td><td>" & months(1)(1) & "</td><td>" & months(1)(2) & "</td></tr>"

            End Select
        Next i


        html &= "</table>"
        Return html
    End Function

    Public Function getTotalUsers() As String
        Dim html As String = "<h3>Total Users </h3>"

        'getting total users for the stats
        html &= "<h4>Registered Clients: " & clients.Length - 1 & "</h4>"
        html &= "<h4>Registered Workers: " & workers.Length - 1 & "</h4>"
        html &= "<h4>Total Users:" & clients.Length - 1 + workers.Length - 1 & "</h4>"

        Return html
    End Function

    Public Function getWeeklyJobsOpened() As String
        Dim Weeks(7)() As Integer
        Dim weekSum(7) As Integer

        Dim size As Integer = 0
        Dim jobs(size) As Job

        'initializing variable
        For i As Integer = 1 To 7
            ReDim Preserve Weeks(i)(10)
            For j As Integer = 1 To 10
                Weeks(i)(j) = 0
            Next j
        Next i

        Dim query As String = "Select * FROM AdTable"
        Dim connection As SqlConnection = New SqlConnection(ValidationClass.CONNECTIONSTRING)
        connection.Open()

        Dim command As SqlCommand = New SqlCommand(query, connection)

        Dim reader As SqlDataReader = command.ExecuteReader()

        If reader.HasRows() Then
            While reader.Read()
                Dim jobDate As Date = reader("OpenDate")
                If jobDate.Year <= Date.Now.Year Then 'ensures they are in the same year... roughly
                    If jobDate.Month <= Date.Now.Month Then 'Months are roughly close
                        If jobDate.Day - Date.Now.Day < 7 Then 'ensures data is form the past 7 days
                            Dim category As String = reader("Category")
                            size += 1
                            ReDim Preserve jobs(size)
                            jobs(size) = New Job(category, "", "", "", "", jobDate)
                        End If
                    End If
                End If

            End While
        End If
        connection.Close()
        'jobs to be shown in html

        For i As Integer = 1 To jobs.Length - 1
            Dim day As Integer = jobs(i).getDate().DayOfWeek + 1
            Dim type As Integer = determineCategory(jobs(i).getCategory())
            Weeks(day)(type) += 1
        Next i


        For d As Integer = 1 To 7
            weekSum(d) = 0
            For t As Integer = 1 To 10
                weekSum(d) += Weeks(d)(t)
            Next t
        Next d

        'html code here
        Dim html As String = "<table>"

        html &= " <tr>"
        html &= " <th>Day</th>"
        html &= " <th>Total</th>"
        html &= "<th>Electrician</th>"
        html &= " <th>Paint and Decoration</th>"
        html &= " <th>Pool Specialist</th>"
        html &= " <th>Garden and Landscaping</th>"
        html &= " <th>Security, Fire and Safety</th>"
        html &= " <th>Kitchen Specialist</th>"
        html &= " <th>Geyser Specialist</th>"
        html &= " <th>Pest Control</th>"
        html &= " <th>Tilling Specialist</th>"
        html &= " <th>Roof Specialist</th>"
        html &= " </tr>"

        For i As Integer = 1 To 7
            html &= "<tr>"
            html &= "<td>" & i & "</td>"
            html &= "<td>" & weekSum(i) & "</td>"
            For j As Integer = 1 To 10
                html &= "<td>" & Weeks(i)(j) & "</td>"
            Next j
            html &= "</tr>"
        Next i

        html &= "</table>"
        Return html
    End Function

    Private Function determineCategory(category As String) As Integer
        Select Case category
            Case "Electrician"
                Return 1
            Case "Paint and Decoration"
                Return 2
            Case "Pool Specialist"
                Return 3
            Case "Garden and Landscaping"
                Return 4
            Case "Security, Fire and Safety"
                Return 5
            Case "Kitchen Specialist"
                Return 6
            Case "Geyser Specialist"
                Return 7
            Case "Pest Control"
                Return 8
            Case "Tilling Specialist"
                Return 9
            Case "Roof Specialist"
                Return 10
        End Select

    End Function

End Class