<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddMovieType.aspx.cs" Inherits="Training.Web.AddMovieType" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Movietype</title>
    <link href="dist/css/vendor/bootstrap.min.css" rel="stylesheet" />
    <link href="dist/css/flat-ui.css" rel="stylesheet" />
    <script src="dist/js/vendor/jquery.min.js"></script>
    <script src="dist/js/flat-ui.min.js"></script>
</head>
<body>
    <div style="float:right"><asp:Label ID="UserName" runat="server" Text="Label"></asp:Label></div>
    <form id="form1" runat="server">
    <div style="display:table; margin:20px auto">
    输入电影类型：<asp:TextBox ID="MovieTypeBox" runat="server"></asp:TextBox>
        <asp:Button ID="BtnAddMovieType" runat="server" OnClick="BtnAddMovieType_Click" Text="添加" />
        <asp:GridView ID="GvShowMovieType" AutoGenerateColumns="false"
             OnPageIndexChanging="GvShowMovieType_PageIndexChanging"
             OnRowCancelingEdit="GvShowMovieType_RowCancelingEdit"
             OnRowDataBound="GvShowMovieType_RowDataBound"
             OnRowDeleting="GvShowMovieType_RowDeleting"
             OnRowEditing="GvShowMovieType_RowEditing"
             OnRowUpdating="GvShowMovieType_RowUpdating" AllowPaging="true" PageSize="10" Caption="电影类型信息维护" runat="server">
            <PagerSettings NextPageText="下一页" PreviousPageText="前一页" />
            <Columns>
                <%--<asp:BoundField DataField="Id" HeaderText="编号" ReadOnly="true" HeaderStyle-Width="0" SortExpression="MovieTypeId" >
                     <HeaderStyle CssClass="yangshi" />
                    <ItemStyle CssClass="yangshi" />
                    </asp:BoundField>--%>
                <asp:BoundField DataField="TypeName" HeaderText="类型名称" SortExpression="TypeName" />
                <asp:CommandField HeaderText="编辑" ShowEditButton="true" />
                <asp:CommandField HeaderText="删除"  ShowDeleteButton="true" />
            </Columns>
            
        </asp:GridView>
        <asp:LinkButton ID="ToIndex" runat="server" OnClick="ToIndex_Click">ToIndex</asp:LinkButton>
    </div>
    </form>
</body>
</html>
