Imports System.Data.SqlClient

Public Class cAdmin
    Inherits User

    Public Sub New(vusername As String, vpassword As String, vname As String, vsurname As String, vemail As String, vdate As Date)
        MyBase.New(vusername, vpassword, vname, vusername, vemail, "", "", vdate)

    End Sub

    Public Sub New(vusername As String, vpassword As String)

        Dim connection As SqlConnection
        Dim command As SqlCommand
        Dim reader As SqlDataReader
        'password = Secrecy.HashPassword(vpassword)
        password = vpassword

        connection = New SqlConnection(ValidationClass.CONNECTIONSTRING)
        Dim commandstring As String = "SELECT * From Administrators WHERE Username = @user AND Password = @pass"
        command = New SqlCommand(commandstring, connection)
        command.Parameters.AddWithValue("@user", vusername)
        command.Parameters.AddWithValue("@pass", vpassword)

        command.Connection.Open()
        reader = command.ExecuteReader()

        If reader.HasRows Then
            reader.Read()
            MsgBox("In the admin function")
            Me.username = vusername
            Me.password = reader("Password")
            Name = reader("Name")
            surname = reader("Surname")
            email = reader("Email")

        End If
    End Sub

    Public Overrides Function getRating() As Integer
        Return 0
    End Function

    Public Overrides Sub saveUser()

    End Sub

    Public Overrides Sub updateAverage(average As Integer)

    End Sub

    Public Overrides Sub updateUser()

    End Sub
End Class
