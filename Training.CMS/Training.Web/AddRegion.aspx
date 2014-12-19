<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddRegion.aspx.cs" Inherits="Training.Web.AddRegion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Resgion</title>
    <link href="dist/css/vendor/bootstrap.min.css" rel="stylesheet" />
    <link href="dist/css/flat-ui.css" rel="stylesheet" />
    <script src="dist/js/vendor/jquery.min.js"></script>
    <script src="dist/js/flat-ui.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div style="display:table; margin:20px auto">
    <p>添加地区</p>
        选择国家：<asp:DropDownList ID="DDLCountry" AutoPostBack="true" OnSelectedIndexChanged="DDLCountry_SelectedIndexChanged" runat="server"></asp:DropDownList>
    添加地区：<asp:TextBox ID="RegionNamebox" runat="server"></asp:TextBox><asp:Button ID="BtnAddRegion" OnClick="BtnAddRegion_Click" runat="server" Text="添加" />
       
         <asp:GridView ID="GvShowRegion" AutoGenerateColumns="false"
             OnPageIndexChanging="GvShowRegion_PageIndexChanging"
             OnRowCancelingEdit="GvShowRegion_RowCancelingEdit"
             OnRowDataBound="GvShowRegion_RowDataBound"
             OnRowDeleting="GvShowRegion_RowDeleting"
             OnRowEditing="GvShowRegion_RowEditing"
             OnRowUpdating="GvShowRegion_RowUpdating" AllowPaging="true" PageSize="10" Caption="地区信息维护" runat="server">
            <PagerSettings NextPageText="下一页" PreviousPageText="前一页" />
            <Columns>
                <%--<asp:BoundField DataField="Id" HeaderText="编号" ReadOnly="true" HeaderStyle-Width="0" SortExpression="RegionId" >
                     <HeaderStyle CssClass="yangshi" />
                    <ItemStyle CssClass="yangshi" />
                    </asp:BoundField>--%>
                <asp:BoundField DataField="CountryName" HeaderText="所属国家" ReadOnly="true" SortExpression="CountryId" />
                <asp:BoundField DataField="RegionName" HeaderText="地区名称" SortExpression="RegionName" />
                <asp:CommandField HeaderText="编辑" ShowEditButton="true" />
                <asp:CommandField HeaderText="删除" ShowDeleteButton="true" />
            </Columns>
            
        </asp:GridView>
        <asp:LinkButton ID="ToIndex" runat="server" OnClick="ToIndex_Click">ToIndex</asp:LinkButton>
    </div>
    </form>
</body>
</html>
