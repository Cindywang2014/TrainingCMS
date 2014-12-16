<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MovieDetails.aspx.cs" Inherits="Training.Web.MovieDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Image ID="MovieImage" ImageUrl="~/dist/img/icons/png/Chat.png" runat="server" />
            <br />
            <asp:Label ID="MovieActors" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Label ID="MovieDecriptions" runat="server" Text="Label"></asp:Label>

        </div>
    </form>
</body>
</html>
