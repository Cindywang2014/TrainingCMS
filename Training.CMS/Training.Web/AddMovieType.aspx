<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddMovieType.aspx.cs" Inherits="Training.Web.AddMovieType" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
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
    </div>
    </form>
</body>
</html>
