<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Training.Web.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Register</title>
    <link href="dist/css/vendor/bootstrap.min.css" rel="stylesheet" />
    <link href="dist/css/flat-ui.css" rel="stylesheet" />
    <script src="dist/js/vendor/jquery.min.js"></script>
    <script src="dist/js/flat-ui.min.js"></script>
</head>
<body style="height: 313px">
    <form id="form1" runat="server">
    <div style="text-align:center">
    <asp:Label ID="UserNameRegister" runat="server" Text="用户名："></asp:Label>
        <asp:TextBox ID="UserNameTextRegister" runat="server" OnTextChanged="UserNameTextRegister_TextChanged"></asp:TextBox>
        <br />
        <asp:Label ID="UserWrong" runat="server" ForeColor="Red" Visible="False"></asp:Label>
        <br />
        <asp:Label ID="PasswordRegister" runat="server" Text="请输入密码："></asp:Label>
        <asp:TextBox ID="PasswordTextRegister" runat="server" OnTextChanged="PasswordTextRegister_TextChanged" TextMode="Password"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="PasswordRepeat" runat="server" Text="请确认密码："></asp:Label>
        <asp:TextBox ID="PasswordRepeatText" runat="server" MaxLength="20" OnTextChanged="PasswordRepeatText_TextChanged" TextMode="Password"></asp:TextBox>
        <br />
        <asp:Label ID="PasswordWrong" runat="server" ForeColor="Red" Visible="False"></asp:Label>
        <br />
        <asp:Label ID="EmailAddress" runat="server" Text="Email："></asp:Label>
        <asp:TextBox ID="EmailAddressText" runat="server" OnTextChanged="EmailAddressText_TextChanged"></asp:TextBox>
        <br />
        <asp:Label ID="EmailWrong" runat="server" ForeColor="Red" Visible="False"></asp:Label>
        <br />
        <asp:Label ID="Country" runat="server" Text="Country:"></asp:Label>
        <asp:DropDownList ID="CountryDropDownList" AutoPostBack="true"  OnSelectedIndexChanged="CountryDropDownList_SelectedIndexChanged" runat="server" >
        </asp:DropDownList>
        <br />
        <br />
        <asp:Label ID="Region" runat="server" Text="Region:"></asp:Label>
        <asp:DropDownList ID="RegionDropDownList" runat="server"  >
        </asp:DropDownList>
       
        <br />
        <br />
        <asp:Button ID="RegisterButton" runat="server" OnClick="RegisterButton_Click" Text="提交注册信息" />
        <br />
        <br />
        <asp:LinkButton ID="ToIndex" runat="server" OnClick="ToIndex_Click">ToIndex</asp:LinkButton>
    </div>
        
    </form>
</body>
</html>
