Imports System.Data.SqlClient

Public Class MessengeList
    Private messages() As Messenge
    Private size As Integer = 0

    Public Sub New(JobID As Integer)
        Dim connection As SqlConnection = New SqlConnection(ValidationClass.CONNECTIONSTRING)
        Dim query As String = "SELECT * FROM Messenges WHERE PostAdId  = @name;"
        connection.Open()

        Dim command As SqlCommand = New SqlCommand(query, connection)
        command.Parameters.AddWithValue("@name", JobID)

        Dim reader As SqlDataReader = command.ExecuteReader()

        If reader.HasRows Then
            Dim words As String
            Dim sender As String
            Dim mdate As Date = DateAndTime.Today()
            While reader.Read()
                'reading in values
                words = reader("Messenge")
                sender = reader("Sender")
                mdate = reader("Date")
                'entering values into the list
                size += 1
                ReDim Preserve messages(size)
                messages(size) = New Messenge(jobID, words, sender, mdate)
            End While
        End If
    End Sub

    Public Function getMessage(index As Integer) As Messenge
        Return messages(index)
    End Function

    Public Function getSize() As Integer
        Return size
    End Function

End Class
