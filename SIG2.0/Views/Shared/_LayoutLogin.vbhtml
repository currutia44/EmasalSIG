@*<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>@ViewData("Title")</title>
</head>
<body>
    <div>
        @RenderBody()
    </div>
</body>
</html>*@
<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <title>@ViewBag.Title | EMASAL</title>
    <!-- Tell the browser to be responsive to screen width -->
    <meta content="width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no" name="viewport">
    <!-- Bootstrap 3.3.5 -->
    @Styles.Render("~/Content/css")
    @Scripts.Render("~/bundles/modernizr")
    @Styles.Render("~/Content/bootstrap-slider")
    @Styles.Render("~/Content/bootstrap-wysihtml5")
    @Styles.Render("~/Content/datepicker")
    @Styles.Render("~/Content/daterangepicker")
    @Styles.Render("~/Content/datatables")
    @Styles.Render("~/Content/fullcalendar")
    @Styles.Render("~/Content/iCheck")
    @Styles.Render("~/Content/select2")
    <!-- Font Awesome -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/font-awesome/4.4.0/css/font-awesome.min.css">
    <!-- Ionicons -->
    <link rel="stylesheet" href="https://code.ionicframework.com/ionicons/2.0.1/css/ionicons.min.css">
    <!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
        <script src="https://oss.maxcdn.com/html5shiv/3.7.3/html5shiv.min.js"></script>
        <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
    <![endif]-->
</head>
<body class="hold-transition login-page">
    <div class="login-box">
        <div class="login-logo">
            <a href="#"><b>Admin</b>EMASAL</a>
        </div><!-- /.login-logo -->
        <div class="login-box-body">
            @RenderBody()
        </div><!-- /.login-box-body -->
    </div><!-- /.login-box -->
    <!-- jQuery 2.1.4 -->
    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/bootstrap")
    @Scripts.Render("~/bundles/bootstrap-slider")
    @Scripts.Render("~/bundles/bootstrap-wysihtml5")
    @Scripts.Render("~/bundles/chartjs")
    @Scripts.Render("~/bundles/datepicker")
    @Scripts.Render("~/bundles/daterangepicker")
    @Scripts.Render("~/bundles/datatables")
    @Scripts.Render("~/bundles/fastclick")
    @Scripts.Render("~/bundles/flot")
    @Scripts.Render("~/bundles/fullcalendar")
    @Scripts.Render("~/bundles/iCheck")
    @Scripts.Render("~/bundles/select2")
    @RenderSection("scripts", required:=False)
    <script>
      $(function () {
        $('input').iCheck({
          checkboxClass: 'icheckbox_square-blue',
          radioClass: 'iradio_square-blue',
          increaseArea: '20%' // optional
        });
      });
    </script>
</body>
</html>
