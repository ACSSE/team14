Public MustInherit Class User


    'varaibles belonging to general users - handyman and client
    Protected username As String = ""
    Protected password As String
    Protected name As String
    Protected surname As String
    Protected email As String
    Protected numbers As String
    Protected region As String
    Protected rating As Integer

    'constructor for the class
    Public Sub New(vusername As String, vpassword As String, vname As String, vsurname As String, vemail As String, mnumbers As String, vregion As String)

        username = vusername
        password = Secrecy.HashPassword(vpassword)
        numbers = mnumbers
        name = vname
        surname = vsurname
        email = vemail
        region = vregion
    End Sub

    Public Sub New() 'basic constructor
        username = ""
        ' password = ""
    End Sub

    'Getters
    Public Function getUsername() As String
        Return username
    End Function

    Public Function getName() As String
        Return name
    End Function

    Public Function getSurname() As String
        Return surname
    End Function

    Public Function getEmail() As String
        Return email
    End Function

    Public Function getNumbers() As String
        Return numbers
    End Function

    Public Function getRegion() As String
        Return region
    End Function

    'Setters
    Public Sub updateUsername(vusername As String)
        username = vusername
    End Sub

    Public Sub updatePassword(vpassword As String)
        password = Secrecy.HashPassword(vpassword)
    End Sub

    Public Sub updateName(cname As String)
        MsgBox("In User-updateName(): name = " & name)
        name = cname
    End Sub

    Public Sub updateSurname(vsurname As String)
        surname = vsurname
    End Sub

    Public Sub updateEmail(vemail As String)
        email = vemail
    End Sub

    Public Sub updateNumbers(mnumbers As String)
        numbers = mnumbers
    End Sub

    Public Sub updateRegion(vregion As String)
        region = vregion
    End Sub

    Public MustOverride Sub saveUser()

    Public MustOverride Sub updateUser()

    Public MustOverride Function getRating() As Integer

    Public MustOverride Sub updateAverage(average As Integer)

End Class
