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
                joindate = reader("JoinDate")

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
        'initializing variable
        For i As Integer = 1 To 7
            ReDim Preserve Weeks(i)(10)
            For j As Integer = 1 To 10
                Weeks(i)(j) = 0
            Next j
        Next i

        Dim query As String = "Select * FROM AdTable"
        Dim connection As SqlConnection = New SqlConnection(ValidationClass.CONNECTIONSTRING)


    End Function

End Class