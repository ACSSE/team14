
﻿Public Class logout
Inherits System.Web.UI.Page

Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    Session("user") = Nothing
    Session("Username") = Nothing
    Response.Redirect("LoginClient.aspx")

End Sub

End Class