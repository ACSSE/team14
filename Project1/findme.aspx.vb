
Imports System.Data
Imports System.Data.SqlClient

Public Class findme
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim connection As SqlConnection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\HandymanDatabase.mdf;Integrated Security=True")
        connection.Open()
        Dim query As String = "INSERT INTO Location (Town, Surburb) VALUES (@town, @suburb);"
        Dim command As SqlCommand = New SqlCommand(query, connection)

        command.Parameters.AddWithValue("@town", txtTown)
        command.Parameters.AddWithValue("@suburb", txtSuburb)

        Dim reader As SqlDataReader = command.ExecuteReader()
        connection.Close()

    End Sub

End Class