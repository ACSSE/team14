Public Class ValidationClass

    Public Const CONNECTIONSTRING As String = "Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\HandymanDatabase.mdf;Integrated Security=True providerName= System.Data.SqlClient"

    Public Shared Function equateText(ByRef original As String, nuValue As String) As Boolean
        If nuValue = "" Then
            Return False
        End If
        original = nuValue
        Return True
    End Function

    Public Shared Function equateText(ByRef original As Integer, nuValue As String) As Boolean
        If nuValue = "" Then
            Return False
        End If
        original = nuValue
        Return True
    End Function


    Public Shared Function equateText(ByRef original As Double, nuValue As String) As Boolean
        If nuValue = "" Then
            Return False
        End If
        original = nuValue
        Return True
    End Function

    Public Shared Function displayMessenges(jobID As Integer) As String
        Dim Htmlmessenges As String = ""
        Dim messenges As MessengeList = New MessengeList(jobID)
        Dim size As Integer = messenges.getSize()
        Htmlmessenges &= "<asp:DropDownList ID=messengeList>"
        Htmlmessenges &= "<asp:ListItem Text=""Messenges""></asp:ListItem>"
        'displaying the 3 latest messeges
        If size <= 3 And Not size = 0 Then 'to display all the messenges

            For i As Integer = 1 To size
                Htmlmessenges &= "<asp:ListItem Text=" & messenges.getMessage(i).getMessenge() & "></asp:ListItem>"
            Next i
        ElseIf Not size = 0 Then 'display the last three messenges
            Htmlmessenges &= "<asp:ListItem Text=Messenges></asp:ListItem>"
            Htmlmessenges &= "<asp:ListItem Text=" & messenges.getMessage(size - 2).getMessenge() & "></asp:ListItem>"
            Htmlmessenges &= "<asp:ListItem Text=" & messenges.getMessage(size - 1).getMessenge() & "></asp:ListItem>"
            Htmlmessenges &= "<asp:ListItem Text=" & messenges.getMessage(size).getMessenge() & "></asp:ListItem>"
        Else
            Htmlmessenges &= "<asp:ListItem Text= Empty></asp:ListItem>"
        End If

        Htmlmessenges &= "<asp:ListItem><a href=MessengesDetail.aspx?ID=" & jobID & ">View All/Send Messenge</a></asp;ListItem>"
        Htmlmessenges &= "</asp:DropDownList></td>"
        Return Htmlmessenges
    End Function

    Public Shared Function getRateImage(rate As Integer) As String
        Select Case rate
            Case 1
                Return "<i><img src=""images/star1.png"" alt="" "" style=""max-width:25%; height:auto"" /></i>"
            Case 2
                Return "<i><img src=""images/star2.png"" alt="" "" style=""max-width:25%; height:auto"" /></i>"
            Case 3
                Return "<i><img src=""images/star3.png"" alt="" "" style=""max-width:25%; height:auto"" /></i>"
            Case 4
                Return "<i><img src=""images/star4.png"" alt="" "" style=""max-width:25%; height:auto"" /></i>"
            Case 5
                Return "<i><img src=""images/star5.png"" alt="" "" style=""max-width:25%; height:auto"" /></i>"
        End Select
        Return "<h4><i><img src=""images/star1.png"" alt="" "" /></i></h4>"
    End Function

End Class