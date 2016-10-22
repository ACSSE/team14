Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Public Class Site
    Inherits System.Web.UI.MasterPage

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not Page.IsPostBack Then
            Dim connection As SqlConnection
            Dim command As SqlCommand
            Dim connectString As String

            'Dim reader As SqlDataReader
            Try

                connectString = ConfigurationManager.ConnectionStrings("Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Data.mdf;Integrated Security=True").ConnectionString
                connection = New SqlConnection(connectString)
                command = New SqlCommand("SELECT Id, DISTINCT[City] FROM Area ")

                command.CommandType = CommandType.Text
                command.Connection = connection
                command.Connection.Open()

                

                'command.ExecuteNonQuery()
                'reader = command.ExecuteReader(CommandBehavior.CloseConnection)
                command.Connection.Close()



            Catch ex As Exception

            End Try
            

        End If

    End Sub

End Class