Imports System.Data.SqlClient
Public Class ClientProfile1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim connection As SqlConnection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Anna\Desktop\Project\Project1\Project1\App_Data\Data.mdf;Integrated Security=True")
        Dim query As String = "SELECT * FROM Comment WHERE CommentId = @com;"
        connection.Open()

        Dim command As SqlCommand = New SqlCommand(query, connection)
        command.Parameters.AddWithValue("@com", lblComment.InnerText)

        Dim reader As SqlDataReader = command.ExecuteReader()

        If reader.HasRows Then

            reader.Read()

            lblComment.Visible = True
           

            lblComment.InnerText = reader("CommentId")


        End If
    End Sub

End Class