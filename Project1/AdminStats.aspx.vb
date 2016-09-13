Imports System.Data.SqlClient

Public Class AdminStats1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim d As Integer = DateAndTime.Now.Month()

        Dim clients() As Date = getClients()
        Dim workers() As Worker = getWorkers()

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
            months(month)(1) += 1
        Next i

        Dim html As String = ""

        Dim latestmonth As Integer = Date.Now.Month

        For i As Integer = 1 To latestmonth
            Select Case i
                Case 12

                Case 11

                Case 10
                    html &= "<p>October &nbps&nbps&nbps&nbps&nbps&nbps&nbps " & months(10)(1) & "&nbps&nbps&nbps&nbps&nbps&nbps&nbps" & months(10)(2)
                Case 9
                    html &= "September &nbps&nbps&nbps&nbps&nbps&nbps&nbps " & months(9)(1) & "&nbps&nbps&nbps&nbps&nbps&nbps&nbps" & months(9)(2) & "<p></p>"
                Case 8
                    html &= "<p>August &nbps&nbps&nbps&nbps&nbps&nbps&nbps " & months(8)(1) & "&nbps&nbps&nbps&nbps&nbps&nbps&nbps" & months(8)(2)
                Case 7
                    html &= "July &nbps&nbps&nbps&nbps&nbps&nbps&nbps " & months(7)(1) & "&nbps&nbps&nbps&nbps&nbps&nbps&nbps" & months(7)(2)
                Case 6
                    html &= "June &nbps&nbps&nbps&nbps&nbps&nbps&nbps " & months(6)(1) & "&nbps&nbps&nbps&nbps&nbps&nbps&nbps" & months(6)(2)
                Case 5
                    html &= "May &nbps&nbps&nbps&nbps&nbps&nbps&nbps " & months(5)(1) & "&nbps&nbps&nbps&nbps&nbps&nbps&nbps" & months(5)(2)
                Case 4
                    html &= "April &nbps&nbps&nbps&nbps&nbps&nbps&nbps " & months(4)(1) & "&nbps&nbps&nbps&nbps&nbps&nbps&nbps" & months(4)(2)
                Case 3
                    html &= "March &nbps&nbps&nbps&nbps&nbps&nbps&nbps " & months(3)(1) & "&nbps&nbps&nbps&nbps&nbps&nbps&nbps" & months(3)(2)
                Case 2
                    html &= "February &nbps&nbps&nbps&nbps&nbps&nbps&nbps " & months(2)(1) & "&nbps&nbps&nbps&nbps&nbps&nbps&nbps" & months(2)(2)
                Case 1
                    html &= "January &nbps&nbps&nbps&nbps&nbps&nbps&nbps " & months(1)(1) & "&nbps&nbps&nbps&nbps&nbps&nbps&nbps" & months(1)(2)

            End Select
        Next i


       

        VisiterStats.InnerHtml = html

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

End Class