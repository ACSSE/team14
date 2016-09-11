Imports System.Data.SqlClient

Public Class Messenge

    Private jobID As Integer
    Private messenge As String
    Private sender As String
    Private mdate As Date

    Public Sub New(jobID As Integer, messenge As String, sender As String, mdate As Date)
        Me.jobID = jobID
        Me.messenge = messenge
        Me.sender = sender
        Me.mdate = mdate
    End Sub

    Public Function getJobID() As Integer
        Return jobID
    End Function

    Public Function getMessenge() As String
        Return messenge
    End Function

    Public Function getSender() As String
        Return sender
    End Function

    Public Function getDate()
        Return mdate
    End Function

    Public Sub saveMessenge()
        If isIdentical(jobID) = False Then

            Dim connection As SqlConnection = New SqlConnection(ValidationClass.CONNECTIONSTRING)
            Dim query As String = "INSERT INTO Messenges (PostAdId, Messenge, Sender, Date) Values (@ID, @messenge, @sender, @date)"
            connection.Open()

            Dim command As SqlCommand = New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@ID", jobID)
            command.Parameters.AddWithValue("@messenge", messenge)
            command.Parameters.AddWithValue("@sender", sender)
            command.Parameters.AddWithValue("@date", mdate)

            Dim reader As SqlDataReader = command.ExecuteReader()
            connection.Close()
        End If
    End Sub

    Public Function getMessageInfo() As String
        Dim info As String = ""
        info &= "Sender: <strong>" & sender & "</strong>        Date: " & mdate & "<br/>"
        info &= messenge
        Return info
    End Function

    'To fix problems of two messenges being sent.
    Public Function isIdentical(ID As Integer) As Boolean
        Dim messenges As MessengeList = New MessengeList(ID)

        For i As Integer = 1 To messenges.getSize()
            If messenges.getMessage(i).getDate() = mdate And messenges.getMessage(i).getMessenge() = messenge And messenges.getMessage(i).sender = sender Then
                Return True
            End If

        Next i
        Return False
    End Function
End Class
