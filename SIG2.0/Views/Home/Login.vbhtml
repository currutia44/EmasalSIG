@Code
    ViewData("Title") = "Login"
    Layout = "~/Views/Shared/_LayoutLogin.vbhtml"
End Code
<p class="login-box-msg">Sign in to start your session</p>
<form action="@Url.Content("~/Home/Login")" method="post">
    <div class="form-group has-feedback">
        <input type="email" id="usuarui" name="usuarui" class="form-control" placeholder="Email">
        <span class="glyphicon glyphicon-envelope form-control-feedback"></span>
    </div>
    <div class="form-group has-feedback">
        <input type="password" id="password" name="password" class="form-control" placeholder="Password">
        <span class="glyphicon glyphicon-lock form-control-feedback"></span>
    </div>
    <div class="row">
        <div class="col-xs-8">
            <div class="checkbox icheck">
                <label>
                    <input type="checkbox"> Remember Me
                </label>
            </div>
        </div><!-- /.col -->
        <div class="col-xs-4">
            <button type="submit" class="btn btn-primary btn-block btn-flat">Sign In</button>
        </div><!-- /.col -->
    </div>
</form>
<button class="btn btn-default pull-right" id="daterange-btn">
    <i class="fa fa-calendar"></i> Date range picker
    <i class="fa fa-caret-down"></i>
</button>
<div class="social-auth-links text-center">
    <p>- OR -</p>
    <a href="#" class="btn btn-block btn-social btn-facebook btn-flat"><i class="fa fa-facebook"></i> Sign in using Facebook</a>
    <a href="#" class="btn btn-block btn-social btn-google btn-flat"><i class="fa fa-google-plus"></i> Sign in using Google+</a>
</div><!-- /.social-auth-links -->
<a href="#">I forgot my password</a><br>
<a href="register.html" class="text-center">Register a new membership</a>

@section Scripts
    <script>
        $('#daterange-btn').daterangepicker(
    {
        ranges: {
            'Today': [moment(), moment()],
            'Yesterday': [moment().subtract(1, 'days'), moment().subtract(1, 'days')],
            'Last 7 Days': [moment().subtract(6, 'days'), moment()],
            'Last 30 Days': [moment().subtract(29, 'days'), moment()],
            'This Month': [moment().startOf('month'), moment().endOf('month')],
            'Last Month': [moment().subtract(1, 'month').startOf('month'), moment().subtract(1, 'month').endOf('month')]
        },
        startDate: moment().subtract(29, 'days'),
        endDate: moment()
    },
function (start, end) {
    $('#reportrange span').html(start.format('MMMM D, YYYY') + ' - ' + end.format('MMMM D, YYYY'));
}
);
    </script>
End Section
