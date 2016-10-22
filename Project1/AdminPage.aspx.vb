Public Class AdminPage
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim d As cAdmin = Session("user")

        lblName.InnerText = d.getName()
        lblSurname.InnerText = d.getSurname()
        lblNumber.InnerText = d.getNumbers()
        lblEmail.InnerText = d.getEmail()
    End Sub

End Class