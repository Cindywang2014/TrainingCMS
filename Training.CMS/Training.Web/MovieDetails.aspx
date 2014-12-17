<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MovieDetails.aspx.cs" Inherits="Training.Web.MovieDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="display: table; margin: 20px auto 0; max-width: 60%;">
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
        </div>
    </form>
</body>
</html>
