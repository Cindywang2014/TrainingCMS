<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Training.Web.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Main</title>
    <%--<link href="https://laracasts.com/css/min.css?v=177" rel="stylesheet" />--%>
    <link href="Css/Index.css" rel="stylesheet" />
</head>
<body class="home ">

    <div class="container wrap">
        <div style="float:right"><asp:Label ID="UserName" runat="server" Text="Label"></asp:Label></div>
        <h2 class="section-heading">Master Page</h2>
        <span class="section-heading-divider"></span>
        <div class="row lesson-set lessons__row">
            <article class="col-md-4 lesson-block lesson-block-series lesson-18 ">
                <a href="MovieMaintenance.aspx">
                    <div class="full-center lesson-block-inner" 
                         style="background: -webkit-linear-gradient(top, rgba(0,0,0,0.3), rgba(0,0,0,0.3)), url(/Images/movie.jpg); 
                         background-size: cover;">
                    </div>
                </a>
                <div class="lesson-block-excerpt">
                    <p>This is Movie Maintenance.</p>
                </div>
            </article>
            <article class="col-md-4 lesson-block lesson-block-series lesson-11 ">
                <a href="AddMovieType.aspx">
                    <div class="full-center lesson-block-inner" 
                         style="background: -webkit-linear-gradient(top, rgba(0,0,0,0.3), rgba(0,0,0,0.3)), url(/Images/movietype.jpg);
                         background-size: cover;">
                    </div>
                </a>

                <div class="lesson-block-excerpt">
                    <p>This is MovieType.</p>
                </div>
            </article>
            <article class="col-md-4 lesson-block lesson-block-series lesson-16 ">
                <a href="ModifyUser.aspx">
                    <div class="full-center lesson-block-inner" 
                         style="background: -webkit-linear-gradient(top, rgba(0,0,0,0.3), rgba(0,0,0,0.3)), url(/Images/user.jpg); 
                         background-size: cover;">
                    </div>
                </a>
                <div class="lesson-block-excerpt">
                    <p>This is ModifyUser.</p>
                </div>
            </article>
        </div>
        <div class="row lesson-set lessons__row">
            <article class="col-md-4 lesson-block lesson-block-series lesson-17 ">
                <a href="AddCountry.aspx">
                    <div class="full-center lesson-block-inner" 
                         style="background: -webkit-linear-gradient(top, rgba(0,0,0,0.3), rgba(0,0,0,0.3)), url(/Images/country.jpg);
                         background-size: cover;">
                    </div>
                </a>
                <div class="lesson-block-excerpt">
                    <p>This is Country.</p>
                </div>
            </article>
            <article class="col-md-4 lesson-block lesson-block-series lesson-15 ">
                <a href="AddRegion.aspx">
                    <div class="full-center lesson-block-inner" 
                         style="background: -webkit-linear-gradient(top, rgba(0,0,0,0.3), rgba(0,0,0,0.3)), url(/Images/reg.jpg); 
                         background-size: cover;">
                    </div>
                </a>
                <div class="lesson-block-excerpt">
                    <p>This is Region.</p>
                </div>
            </article>
        </div>
    </div>

</body>
</html>
