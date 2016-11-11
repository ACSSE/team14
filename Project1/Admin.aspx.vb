Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient
Imports Microsoft.Reporting.WebForms
Public Class Admin
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        ReportViewer1.ProcessingMode = ProcessingMode.Local

        Dim dsReport As DataTable = GetData()
        Dim ds As ReportDataSource = New ReportDataSource("ObjectDataSource1", dsReport)

        ReportViewer1.LocalReport.ReportPath = Server.MapPath("~/Report2.rdlc")
        ReportViewer1.LocalReport.Refresh()

    End Sub
    Private Function GetData() As DataTable

        Dim connection As SqlConnection
        Dim command As SqlCommand
        ' Dim reader As SqlDataReader
        Dim dataTable As DataTable = New DataTable()

        connection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\HandymanDatabase.mdf;Integrated Security=True")
        Dim commandstring As String = "SELECT TOP 2 Name, Category, JoinDate FROM  Workers"

        command = New SqlCommand(commandstring, connection)
        command.CommandType = CommandType.Text

        Dim adp As SqlDataAdapter = New SqlDataAdapter(command)
        adp.Fill(dataTable)


        Return dataTable
    End Function

    'Private Function GetData(query As String) As HandymanDatabaseDataSet1

    '    Dim connection As SqlConnection
    '    Dim command As SqlCommand
    '    Dim adapter As SqlDataAdapter
    '    Dim handy As HandymanDatabaseDataSet

    '    command = New SqlCommand(query)
    '    connection = New SqlConnection(ValidationClass.CONNECTIONSTRING)

    '    command.Connection = connection
    '    adapter = New SqlDataAdapter()
    '    adapter.SelectCommand = command
    '    handy = New HandymanDatabaseDataSet()

    '    adapter.Fill(handy, "DataTable")
    '    Return handy


    'End Function
End Class