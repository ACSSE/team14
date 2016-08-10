Public Class Site1
    Inherits System.Web.UI.MasterPage

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("UserName") <> Nothing Then
            userLog.Visible = True
            userLog.InnerHtml = "<small style=""color:#FBCC33"">Welcome</small> " & "<small style=""color:#01A185""><b>" & Session("UserName").ToString & "</b></small> " & "<a style="" font-size:small;""  href=""index.aspx"">(logout)</a>"
        End If
    End Sub

End Class