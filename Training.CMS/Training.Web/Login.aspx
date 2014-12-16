<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Training.Web.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align:center; height: 126px;">
        <asp:Label ID="UserNameLogin" runat="server" Text="用户名："></asp:Label>
        <asp:TextBox ID="UserNameTextLogin" runat="server" OnTextChanged="UserNameTextLogin_TextChanged"></asp:TextBox>
        <br />
        <asp:Label ID="UserWrong" runat="server" ForeColor="Red" Visible="False"></asp:Label>
        <br />
        <asp:Label ID="PasswordLogin" runat="server" Text="密码："></asp:Label>
        <asp:TextBox ID="PasswordTextLogin" runat="server" OnTextChanged="PasswordTextLogin_TextChanged" TextMode="Password"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button ID="LoginButton" runat="server" Text="登录" OnClick="LoginButton_Click" />
        &nbsp; &nbsp;
        <asp:Button ID="RegisterButtonLogin" runat="server" Text="注册" OnClick="RegisterButtonLogin_Click" />
    </div>
    </form>
</body>
</html>
