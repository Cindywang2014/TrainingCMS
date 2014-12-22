<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateMovie.aspx.cs" Inherits="Training.Web.UpdateMovie" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>UpdateMovie</title>
    <link href="dist/css/vendor/bootstrap.min.css" rel="stylesheet" />
    <link href="dist/css/flat-ui.css" rel="stylesheet" />
    <script src="dist/js/vendor/jquery.min.js"></script>
    <script src="dist/js/flat-ui.min.js"></script>
</head>
<body>
    <div style="float:right"><asp:Label ID="UserName" runat="server" Text="Label"></asp:Label></div>
    <form id="form1" runat="server" style="display:table; margin:20px auto">
        <div> 
            电影名称<br />
            <asp:TextBox ID="MovieNameBox" runat="server"></asp:TextBox>
            <br />
            电影类别<br />
            <asp:DropDownList ID="MovieTypeList" runat="server" class="btn btn-default dropdown-toggle" ></asp:DropDownList>
            <br />
            主演<br />
            <asp:TextBox ID="ActorBox" runat="server"></asp:TextBox>
            <br />
            图片<br />
            <asp:Image ID="Image" runat="server" Height="100px" Width="150px" />
            <br />
            <asp:FileUpload ID="ImageUpload" runat="server" Width="219px" />
            描述<br />
            <asp:TextBox ID="DescriptionBox" runat="server"  Height="100px" TextMode="MultiLine" Width="300px"></asp:TextBox>
            <br />
            审核<br />
            <asp:RadioButton ID="PassedButten" runat="server" Font-Names="Arial Black" ForeColor="#33CC33" GroupName="IsAudit" Text="Passed" />
            <asp:RadioButton ID="FailButton" runat="server" Font-Names="Arial Black" ForeColor="Red" GroupName="IsAudit" Text="Fail" />
            <br />
            <asp:Button ID="UpdateButton" runat="server" OnClick="UpdateButton_Click" Text="修改" />
            <br />
        </div>
    </form>
</body>
</html>
