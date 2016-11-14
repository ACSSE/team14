Imports System.Data.SqlClient

Public Class mComplaint
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnReg_Click(sender As Object, e As EventArgs) Handles btnSubmit.ServerClick
        Dim cUser As User = Session("user") 'User that made complaint

            Dim adconnection As SqlConnection = New SqlConnection(ValidationClass.CONNECTIONSTRING)
            adconnection.Open()
            Dim query As String = "INSERT INTO Responses (PostAdId, Worker, Comment, Checked) VALUES (@ID, @Handyman, @comment, @check);"
            Dim command As SqlCommand = New SqlCommand(query, adconnection)
            command.Parameters.AddWithValue("@ID", 17)
            command.Parameters.AddWithValue("@Handyman", cUser.getUsername())
            command.Parameters.AddWithValue("@comment", txtDescription.Text & "&&" & txtTitle.Text)
            command.Parameters.AddWithValue("@check", "unchecked")

            Dim reader As SqlDataReader = command.ExecuteReader()
            adconnection.Close()
    End Sub

End Class