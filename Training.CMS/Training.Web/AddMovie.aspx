<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddMovie.aspx.cs" Inherits="Training.Web.AddMovie" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>New Movie</title>  
    <link href="dist/css/vendor/bootstrap.min.css" rel="stylesheet" />
    <link href="dist/css/flat-ui.css" rel="stylesheet" />
    <script src="dist/js/vendor/jquery.min.js"></script>
    <script src="dist/js/flat-ui.min.js"></script>
</head>
<body>
    <form id="form1" runat="server" style="display:table; margin:20px auto">
        电影名称<br />
        <asp:TextBox ID="MovieNameBox" runat="server" ></asp:TextBox>
        <br />
        电影类别<br />
        <asp:DropDownList ID="MovieTypeList" runat="server" class="btn btn-default dropdown-toggle"></asp:DropDownList>
        <br />
        主演<br />
        <asp:TextBox ID="ActorBox" runat="server"></asp:TextBox>
        <br />
        图片<br />
        <asp:Image ID="Image" runat="server" Height="100px" Width="150px"/>
        <br />
        <asp:FileUpload ID="ImageUpload" runat="server" />
        描述<br />
        <asp:TextBox ID="DescriptionBox" runat="server" Height="100px" TextMode="MultiLine" Width="300px"></asp:TextBox>
        <br />
        <asp:Button ID="UploadButton" runat="server" OnClick="UploadButton_Click" Text="提交" class="btn btn-success"/>
    </form>
</body>
</html>
