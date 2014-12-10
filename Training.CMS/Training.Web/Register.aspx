<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Training.Web.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 186px">
    <form id="form1" runat="server">
    <div style="text-align:center">
    <asp:Label ID="UserNameRegister" runat="server" Text="用户名："></asp:Label>
        <asp:TextBox ID="UserNameTextRegister" runat="server" OnTextChanged="UserNameTextRegister_TextChanged"></asp:TextBox>
        <br />
        <asp:Label ID="PasswordRegister" runat="server" Text="密码："></asp:Label>
        <asp:TextBox ID="PasswordTextRegister" runat="server" OnTextChanged="PasswordTextRegister_TextChanged"></asp:TextBox>
        <br />
        <asp:Label ID="EmailAddress" runat="server" Text="Email："></asp:Label>
        <asp:TextBox ID="EmailAddressText" runat="server" OnTextChanged="EmailAddressText_TextChanged"></asp:TextBox>
        <br />
        <asp:Label ID="Country" runat="server" Text="Country:"></asp:Label>
        <asp:DropDownList ID="CountryDropDownList" runat="server">
        </asp:DropDownList>
        <br />
        <asp:Label ID="Region" runat="server" Text="Region:"></asp:Label>
        <asp:DropDownList ID="RegionDropDownList" runat="server">
        </asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="RegisterButton" runat="server" OnClick="RegisterButton_Click" Text="提交注册信息" />
    </div>
        
    </form>
</body>
</html>
