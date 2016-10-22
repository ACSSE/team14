Imports System.Data.SqlClient

Public Class Site1
    Inherits System.Web.UI.MasterPage

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("user") IsNot Nothing Then
            Dim cUser As User = Session("user")
            userLog.Visible = True

            If TypeOf cUser Is Client Then
                MsgBox("is client")
                userLog.InnerHtml = "<p style=""color:#FBCC33"">Welcome " & "<b style=""color:#01A185"">" & cUser.getUsername() & "</b> " & "<a style="" font-size:medium;""  href=""logout.aspx"">(logout)</a>&nbsp;&nbsp;&nbsp;" & countResponses() & "&nbsp;&nbsp;&nbsp;" & countMesseges()
            Else
                MsgBox("Not Client")
                userLog.InnerHtml = "<p style=""color:#FBCC33"">Welcome " & "<p style=""color:#FBCC33"">Welcome " & cUser.getUsername() & "</b> " & "<a  href=""logout.aspx"" style="" font-size:medium;"">(logout)</a></p>&nbsp;&nbsp;&nbsp;" & countMesseges()
            End If
        End If
    End Sub

    Private Function countResponses() As String
        Dim count As Integer = 0
        Dim htmlquery As String = countAds(count)
        MsgBox("In countResponses")
        If count > 0 Then
            count = 0
            Dim connection As SqlConnection = New SqlConnection(ValidationClass.CONNECTIONSTRING)
            Dim query As String = "SELECT * FROM Responses WHERE (" & htmlquery & ") AND Checked = @unchecked;"
            connection.Open()

            Dim command As SqlCommand = New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@name", htmlquery)
            command.Parameters.AddWithValue("@unchecked", "unchecked")

            Dim reader As SqlDataReader = command.ExecuteReader()

            If reader.HasRows Then
                While reader.Read()
                    count += 1
                End While
            End If
            MsgBox("Count in Responses is " & count)
            If Not (count = 0) Then
                Return "<small><a style="" font-size:small; color:yellow;"" href=ClientProfile.aspx>(" & count & ")</a></small>&nbsp;&nbsp;&nbsp;"
            End If
        End If
        Return ""
    End Function

    Private Function countMesseges() As String
        Dim cUser As User = Session("user")
        Dim count As Integer = 0
        Dim htmlquery As String = countAds(count)

        ' If count > 0 Then
        count = 0
        Dim connection As SqlConnection = New SqlConnection(ValidationClass.CONNECTIONSTRING)
        Dim query As String = "SELECT * FROM Messenges WHERE (" & htmlquery & ") AND Checked = @unchecked AND NOT (Sender = @sender);"

        connection.Open()
        Dim command As SqlCommand = New SqlCommand(query, connection)
        command.Parameters.AddWithValue("@unchecked", "unchecked")
        command.Parameters.AddWithValue("@sender", cUser.getUsername()) 'not the person logged in
        Dim reader As SqlDataReader = command.ExecuteReader()

        If reader.HasRows Then
            While reader.Read()
                MsgBox("Message counted = " & reader("Messenge"))
                count += 1
            End While
        End If
        MsgBox("Count in messages is " & count)
        If count > 0 Then
            Return "<small><a style="" font-size:small; color:red;"" href=ClientProfile.aspx>(" & count & ")</a></small>&nbsp;&nbsp;&nbsp;"
        End If
        'End If
        Return ""
    End Function

    Private Function countAds(ByRef size As Integer) As String 'to display ads that client has posted but have no handyman assinged to them
        Dim user As User = Session("user") 'can be handyman or client

        size = 0 'to use as a resize reference
        Dim jobs(size) As Integer 'to store all jobs


        Dim adconnection As SqlConnection = New SqlConnection(ValidationClass.CONNECTIONSTRING)
        adconnection.Open()
        Dim query As String = "Select * FROM AdTable WHERE Client = @name OR Worker = @name;" 'pulls data if user is hadynman or worker
        Dim command As SqlCommand = New SqlCommand(query, adconnection)
        command.Parameters.AddWithValue("@name", user.getUsername())

        Dim reader As SqlDataReader = command.ExecuteReader()

        Dim oldAds As String = ""
        Dim newAds As String = ""

        If reader.HasRows Then
            While reader.Read()
                'If no handyman is assigned to the job/ad
                size += 1
                ReDim Preserve jobs(size)

                jobs(size) = reader("PostAdId")

            End While
        End If
        adconnection.Close()
        Dim clientquery As String = ""

        For i As Integer = 1 To jobs.Length - 1
            clientquery &= "PostAdId =" & jobs(i)
            If Not (i = jobs.Length - 1) Then
                clientquery &= " OR "
            End If
        Next i
        MsgBox(clientquery)
        Return clientquery
    End Function
End Class