Imports System.Data
Imports System.Data.SqlClient
Public Class PostAdClient
    Inherits System.Web.UI.Page

    Private worker As Worker
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' If Page.IsPostBack Then
        Dim type As String = Request.QueryString("adType")

        If type = "" Or type = Nothing Then
            categoriesList.Focus()
            worker = New Worker("", "", "", "", "", "", "", Nothing, "", "", Nothing)

        Else
            worker = New Worker(type)
            ' bindCategories()
        End If



        'End If
    End Sub

    Protected Sub btnReg_Click(sender As Object, e As EventArgs) Handles btnSubmit.ServerClick

        Dim client As Client = Session("user")

        Dim clientUsername As String = client.getUsername() 'client who is posting ad
        Dim title As String = ""
        Dim description As String = ""
        Dim category As String = ""



        ValidationClass.equateText(category, categoriesList.SelectedValue())
        ValidationClass.equateText(title, txtTitle.Text())
        ValidationClass.equateText(description, txtDescription.Text())

        If worker.getUsername() = "" Then


            'Handyman is null upon creation of job
            Dim job As Job = New Job(category, title, description, clientUsername, "", Date.Now)
            job.saveJob(False) 'save job in the database
            'redirect to client page where new job should e displayed
            Response.Redirect("ClientProfile.aspx")
        Else
            'Handyman is null upon creation of job
            Dim job As Job = New Job(category, title, description, clientUsername, worker.getUsername(), Date.Now)
            job.saveJob(True) 'save job in the database
            'redirect to client page where new job should e displayed
            Response.Redirect("ClientProfile.aspx")
        End If
    End Sub

    Private Sub bindCategories()
        If Not (worker.getUsername() = "") Then
            categoriesList.Items.Clear() 'removing all the items
            Dim splitchar As Char = "&"
            Dim category() As String = worker.getCategory().Split("&")

            For i As Integer = 0 To category.Length
                categoriesList.Items.Add(category(i))
            Next i

        End If
    End Sub
End Class