<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormTest.aspx.cs" Inherits="Training.Web.WebFormTest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Button ID="btnCallBack" runat="server" Text="回发并弹出confirm" OnClick="btnCallBack_Click" />
    <asp:Button ID="btnHid" runat="server" OnClick="btnHid_Click" Text ="qqq" />
    <asp:HiddenField ID="hid" runat="server" />
    </div>
    </form>
</body>
</html>
