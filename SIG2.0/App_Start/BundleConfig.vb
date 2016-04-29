Imports System.Web.Optimization

Public Module BundleConfig
    ' Para obtener más información sobre Bundles, visite http://go.microsoft.com/fwlink/?LinkId=301862
    Public Sub RegisterBundles(ByVal bundles As BundleCollection)

        bundles.Add(New ScriptBundle("~/bundles/jquery").Include(
                    "~/Scripts/jquery-{version}.js"))

        bundles.Add(New ScriptBundle("~/bundles/jqueryval").Include(
                    "~/Scripts/jquery.validate*"))

        ' Utilice la versión de desarrollo de Modernizr para desarrollar y obtener información. De este modo, estará
        ' preparado para la producción y podrá utilizar la herramienta de compilación disponible en http://modernizr.com para seleccionar solo las pruebas que necesite.
        bundles.Add(New ScriptBundle("~/bundles/modernizr").Include(
                    "~/Scripts/modernizr-*"))

        bundles.Add(New ScriptBundle("~/bundles/bootstrap").Include(
                  "~/Scripts/bootstrap.js",
                  "~/Scripts/app.min.js",
                  "~/Scripts/respond.js"))

        bundles.Add(New StyleBundle("~/Content/css").Include(
                  "~/Content/bootstrap.css",
                  "~/Content/AdminLTE.css",
                  "~/Content/skins/skin-blue.css"))

        'JS PLUGINS
        bundles.Add(New ScriptBundle("~/bundles/bootstrap-slider").Include(
                    "~/Scripts/bootstrap-slider/bootstrap-slider.js"))

        bundles.Add(New ScriptBundle("~/bundles/bootstrap-wysihtml5").Include(
                    "~/Scripts/bootstrap-wysihtml5/bootstrap3-wysihtml5.all.js"))

        bundles.Add(New ScriptBundle("~/bundles/chartjs").Include(
                    "~/Scripts/chartjs/Chart.js"))

        bundles.Add(New ScriptBundle("~/bundles/datepicker").Include(
                    "~/Scripts/datepicker/bootstrap-datepicker.js"))

        bundles.Add(New ScriptBundle("~/bundles/daterangepicker").Include(
                    "~/Scripts/daterangepicker/moment.js",
                    "~/Scripts/daterangepicker/daterangepicker.js"))

        bundles.Add(New ScriptBundle("~/bundles/datatables").Include(
                    "~/Scripts/datatables/jquery.dataTables.js",
                    "~/Scripts/datatables/dataTables.bootstrap.js"))

        bundles.Add(New ScriptBundle("~/bundles/fastclick").Include(
                    "~/Scripts/fastclick/fastclick.js"))

        bundles.Add(New ScriptBundle("~/bundles/flot").Include(
                    "~/Scripts/flot/excanvas.js",
                    "~/Scripts/flot/jquery.colorhelpers.js",
                    "~/Scripts/flot/jquery.flot.canvas.js",
                    "~/Scripts/flot/jquery.flot.js",
                    "~/Scripts/flot/jquery.flot.categories.js",
                    "~/Scripts/flot/jquery.flot.crosshair,js",
                    "~/Scripts/flot/jquery.flot.errorbars.js",
                    "~/Scripts/flot/jquery.flot.fillbetween.js",
                    "~/Scripts/flot/jquery.flot.image.js",
                    "~/Scripts/flot/jquery.flot.navigate.js",
                    "~/Scripts/flot/jquery.flot.pie.js",
                    "~/Scripts/flot/jquery.flot.resize.js",
                    "~/Scripts/flot/jquery.flot.selection.js",
                    "~/Scripts/flot/jquery.flot.stack.js",
                    "~/Scripts/flot/jquery.flot.symbol.js",
                    "~/Scripts/flot/jquery.flot.threshold.js",
                    "~/Scripts/flot/jquery.flot.time.js"))

        bundles.Add(New ScriptBundle("~/bundles/fullcalendar").Include(
                    "~/Scripts/fullcalendar/fullcalendar.js"))

        bundles.Add(New ScriptBundle("~/bundles/iCheck").Include(
                    "~/Scripts/iCheck/icheck.js"))

        bundles.Add(New ScriptBundle("~/bundles/select2").Include(
                    "~/Scripts/select2/select2.js"))




        'CSS PLUGINS
        bundles.Add(New StyleBundle("~/Content/bootstrap-slider").Include(
                    "~/Scripts/bootstrap-slider/slider.css"))

        bundles.Add(New StyleBundle("~/Content/bootstrap-wysihtml5").Include(
                    "~/Scripts/bootstrap-wysihtml5/bootstrap3-wysihtml5.css"))

        bundles.Add(New StyleBundle("~/Content/datepicker").Include(
                    "~/Scripts/datepicker/datepicker3.css"))

        bundles.Add(New StyleBundle("~/Content/daterangepicker").Include(
                    "~/Scripts/daterangepicker/daterangepicker-bs3.css"))

        bundles.Add(New StyleBundle("~/Content/datatables").Include(
                    "~/Scripts/datatables/dataTables.bootstrap.css",
                    "~/Scripts/datatables/jquery.dataTables.css",
                    "~/Scripts/datatables/jquery.dataTables_themeroller.css"))

        bundles.Add(New StyleBundle("~/Content/fullcalendar").Include(
                    "~/Scripts/fullcalendar/fullcalendar.css",
                    "~/Scripts/fullcalendar/fullcalendar.print.css"))

        bundles.Add(New StyleBundle("~/Content/iCheck").Include(
                    "~/Scripts/iCheck/all.css"))

        bundles.Add(New StyleBundle("~/Content/select2").Include(
                    "~/Scripts/select2/select2.css"))


    End Sub
End Module

