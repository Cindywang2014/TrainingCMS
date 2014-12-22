<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ModifyUser.aspx.cs" Inherits="Training.Web.ModifyUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ModifyUser</title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
    </style>
</head>
<body style="height: 300px">
    <form id="form1" runat="server">
    <div class="auto-style1" style="height: 301px">
    
        <asp:Label ID="LabelUserName" runat="server" style="text-align: center" Text="用户名："></asp:Label>
        <asp:Label ID="DisplayUser" runat="server"></asp:Label>
       <br />
        <br />
        <asp:Label ID="LabelPassword" runat="server" Text="请输入新密码："></asp:Label>
        <asp:TextBox ID="TextPassword" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <asp:Label ID="WrongPassword" runat="server" Visible="False" ForeColor="Red"></asp:Label>
        <br />
        <asp:Label ID="LabelRepeatPassword" runat="server" Text="请再次输入密码："></asp:Label>
        <asp:TextBox ID="TextRepeatPassword" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <asp:Label ID="WrongRepeatPassword" runat="server" Visible="False" ForeColor="Red"></asp:Label>
        <br />
        <asp:Label ID="LabelEmail" runat="server" Text="请输入邮箱："></asp:Label>
        <asp:TextBox ID="TextEmail" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="WrongEmail" runat="server" Visible="False" ForeColor="Red"></asp:Label>
        <br />
        <asp:Label ID="LabelCountry" runat="server" Text="Country:"></asp:Label>
        <asp:DropDownList ID="CountryDropDownList" AutoPostBack="true" runat="server" OnSelectedIndexChanged="CountryDropDownList_SelectedIndexChanged">
        </asp:DropDownList>
        <br />
        <br />
        <asp:Label ID="LabelRegion" runat="server" Text="Region:"></asp:Label>
        <asp:DropDownList ID="RegionDropDownList" runat="server">
        </asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="ButtonSubmit" runat="server" Text="提交修改信息" OnClick="ButtonSubmit_Click" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="ButtonAbandon" runat="server" Text="返回Index页面" OnClick="ButtonAbandon_Click" />

        <br />
        <br />
        <br />
         <asp:LinkButton ID="ToIndex" runat="server" OnClick="ToIndex_Click">ToIndex</asp:LinkButton>
    </div>
    </form>
   
</body>
</html>
