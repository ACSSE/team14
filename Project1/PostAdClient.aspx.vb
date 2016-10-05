Imports System.Data
Imports System.Data.SqlClient
Public Class PostAdClient
    Inherits System.Web.UI.Page

   
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Page.IsPostBack Then
            categoriesList.Focus()
        End If
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

        'Handyman is null upon creation of job
        Dim job As Job = New Job(category, title, description, clientUsername, "", Date.Now)
        job.saveJob() 'save job in the database
        'redirect to client page where new job should e displayed
        Response.Redirect("ClientProfile.aspx")

    End Sub
End Class