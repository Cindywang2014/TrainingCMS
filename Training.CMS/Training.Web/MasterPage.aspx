<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MasterPage.aspx.cs" Inherits="Training.Web.MasterPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form runat="server">
        <header>
            <asp:DropDownList ID="ChooseMovieType" runat="server"></asp:DropDownList>
            <asp:TextBox ID="InputActor" runat="server"></asp:TextBox>
            <asp:Button ID="SubmitCondition" runat="server" Text="Search.." />
        </header>
        <section>
            <asp:ListView ID="EligibleMovies" runat="server"></asp:ListView>
        </section>
    </form>
</body>
</html>
