Imports System.Web.Routing


Public Class AuthorizationPrivilegeFilter
    Inherits ActionFilterAttribute

    Public Overrides Sub OnActionExecuting(ByVal filterContext As ActionExecutingContext)



        filterContext.Result = New RedirectToRouteResult(New RouteValueDictionary(
                                                         New With {.controller = "Home", .action = "Login"}))

    End Sub


End Class
