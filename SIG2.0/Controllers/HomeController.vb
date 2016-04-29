Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        Return View()
    End Function
    <AuthorizationPrivilegeFilter>
    Function About() As ActionResult
        ViewData("Message") = "Your application description page."

        Return View()
    End Function
    <AuthorizationPrivilegeFilter>
    Function Contact() As ActionResult
        ViewData("Message") = "Your contact page."

        Return View()
    End Function
    <AuthorizationPrivilegeFilter>
    Function dashboard() As ActionResult
        ViewData("Message") = "DASHBOARD"

        Return View()
    End Function
    Function Login() As ActionResult
        Return View()
    End Function
    <HttpPost>
    Function Login(ByVal usuarui As String, ByVal password As String) As ActionResult

        Return RedirectToAction("dashboard")
    End Function
End Class
