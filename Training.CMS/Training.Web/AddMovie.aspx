<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddMovie.aspx.cs" Inherits="Training.Web.AddMovie" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        电影名称<br />
        <asp:TextBox ID="MovieNameBox" runat="server"></asp:TextBox>
        <br />
        电影类别<br />
        <asp:TextBox ID="MovieTypeIdBox" runat="server"></asp:TextBox>
        <br />
        导演<br />
        <asp:TextBox ID="ActorBox" runat="server"></asp:TextBox>
        <br />
        图片<br />
        <asp:FileUpload ID="ImageUpload" runat="server" />
        <br />
        描述<br />
        <asp:TextBox ID="DescriptionBox" runat="server"></asp:TextBox>
        <br />
        上传时间<br />
        <asp:TextBox ID="UploadDateBox" runat="server"></asp:TextBox>
        <br />
        审核<br />
        <asp:RadioButton ID="Passed" runat="server" />
        <asp:RadioButton ID="Fail" runat="server" Checked="True" />
        <br />
        <asp:Button ID="UploadButton" runat="server" OnClick="UploadButton_Click" Text="提交" />
    </form>
</body>
</html>
