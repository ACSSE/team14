Public Class ValidationClass

    Public Const CONNECTIONSTRING As String = "Data Source=SQL5023.Smarterasp.net;Initial Catalog=DB_A0AFBC_HandymanDatabase;User Id=DB_A0AFBC_HandymanDatabase_admin;Password=anna98542210;"


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
        Return "<i><img src=""images/star1.png"" alt="" "" style=""max-width:25%; height:auto"" /></i>"
    End Function
    'Taking a string representation of category and turning it into Enum Category
    'Public Shared Function enumCategory(category As String) As Category
    '    Dim toR As Category
    '    MsgBox("ValidationClass:enumCategory- Category = " & category)
    '    Select Case category
    '        Case "Electrician"
    '            toR = Project1.Category.Electrician
    '            Return toR
    '        Case "Gardnen and Landscaping"
    '            toR = Project1.Category.GardnerNLandscaper
    '            Return toR
    '        Case "Kitchen Specialist"
    '            Return Project1.Category.KitchenSpecialist
    '        Case "Paint & Decoration"
    '            Return Project1.Category.PaintNDecoration
    '        Case "Security, Fire and Safety"
    '            Return Project1.Category.SecurityFireNSafety
    '        Case "Pest Control"
    '            Return Project1.Category.PestControl
    '        Case "Tilling Specialist"
    '            Return Project1.Category.TillingSpecialist
    '        Case "Roof Specialist"
    '            Return Project1.Category.RoofSpecialist
    '        Case "Geyser Specialist"
    '            Return Project1.Category.GeyserSpecialist
    '        Case Else
    '            Return Nothing
    '    End Select
    'End Function

    ''Taking the enum Category and turning it into a string category
    'Public Shared Function stringCategory(category As Category) As String
    '    MsgBox("ValdiationClass:stringCategory - straight msgbox =" & category.ToString())
    '    Select Case category
    '        Case Project1.Category.GeyserSpecialist
    '            MsgBox("ValidationClass:stringCategory - result Geyser Specialist")
    '            Return "Geyser Specialist"
    '        Case Project1.Category.KitchenSpecialist
    '            Return "Kitchen Specialist"
    '        Case Project1.Category.GardnerNLandscaper
    '            MsgBox("ValidationClass:stringCategory - result Gardner and Landscaping")
    '            Return "Garden and Landscaping"
    '        Case Project1.Category.PaintNDecoration
    '            Return "Paint & Decoration"
    '        Case Project1.Category.PestControl
    '            Return "Pest Control"
    '        Case Project1.Category.RoofSpecialist
    '            Return "Roof Specialist"
    '        Case Project1.Category.SecurityFireNSafety
    '            Return "Security, Fire & Safety"
    '        Case Project1.Category.TillingSpecialist
    '            Return "Tilling Specialist"
    '        Case Project1.Category.Electrician
    '            MsgBox("ValidationClass:stringCategory - result Electrician")
    '            Return "Electrician"
    '        Case Else
    '            Return ""
    '    End Select
    'End Function


End Class

'Public Enum Category 'category of handyman and job 
'    Electrician
'    GardnerNLandscaper
'    PaintNDecoration
'    PoolSpecialist
'    KitchenSpecialist
'    SecurityFireNSafety
'    PestControl
'    TillingSpecialist
'    RoofSpecialist
'    GeyserSpecialist
'End Enum
