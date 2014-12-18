<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MovieDetails.aspx.cs" Inherits="Training.Web.MovieDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Movie Details</title>
    <style>
        body {
            margin: 0;
            padding: 0;
            background: #e9e9e9;
        }

        header {
            margin: 0 auto;
            padding: 20px;
            height: 170px;
            width: 60%;
            background: url(/Images/background.jpg);
            background-size: 100% 210px;
        }

        section {
            margin: 0 auto;
            padding: 20px;
            width: 60%;
            height: inherit;
            background-color: white;
        }
    </style>
</head>
<body>
    <form runat="server">

        <header>
        </header>

        <section>
            MovieName:&nbsp 
            <asp:Label ID="MovieName" runat="server" Text="MovieName"></asp:Label>
            <br />
            <br />
            <asp:Image ID="MovieImage" Width="280" Height="280" runat="server" />
            <br />
            <br />
            Actor:&nbsp
            <asp:Label ID="MovieActors" runat="server"></asp:Label>
            <br />
            <br />
            Description:
            <br />
            &nbsp&nbsp
            <asp:Label ID="MovieDecriptions" runat="server"></asp:Label>
        </section>
    </form>
</body>
</html>
