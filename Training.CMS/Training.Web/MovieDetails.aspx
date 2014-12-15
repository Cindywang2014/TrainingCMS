<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MovieDetails.aspx.cs" Inherits="Training.Web.MovieDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" Text="Button" />
            <table runat="server" id="tblCategories" 
                 cellspacing="0" cellpadding="1" width="440px">
            <tr id="itemPlaceholder" runat="server">
                <td>JJ</td><td>GGG</td>
            </tr>
          </table>
            <asp:Image ID="Image1" runat="server" />
        </div>
    </form>
</body>
</html>
