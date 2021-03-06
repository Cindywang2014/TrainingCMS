﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddCountry.aspx.cs" Inherits="Training.Web.AddCountry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>country</title>
    <link href="dist/css/vendor/bootstrap.min.css" rel="stylesheet" />
    <link href="dist/css/flat-ui.css" rel="stylesheet" />
    <script src="dist/js/vendor/jquery.min.js"></script>
    <script src="dist/js/flat-ui.min.js"></script>
</head>
<body>
    <div style="float:right"><asp:Label ID="UserName" runat="server" Text="Label"></asp:Label></div>
    <form id="form1" runat="server">
        <style  type="text/css">
        .yangshi
        {
            display:none ;
            }
    </style>
   <div style="display:table; margin:20px auto">
    输入国家名：<asp:TextBox ID="CountryNamebox" runat="server"></asp:TextBox>      
        <asp:Button ID="BtnAddCountry" OnClick="BtnAddCountry_Click" runat="server" Text="添加" />
        <asp:GridView ID="GvShowCountry" AutoGenerateColumns="false"
             OnPageIndexChanging="GvShowCountry_PageIndexChanging"
             OnRowCancelingEdit="GvShowCountry_RowCancelingEdit"
             OnRowDataBound="GvShowCountry_RowDataBound"
             OnRowDeleting="GvShowCountry_RowDeleting"
             OnRowEditing="GvShowCountry_RowEditing"
             OnRowUpdating="GvShowCountry_RowUpdating" AllowPaging="true" PageSize="10" Caption="国家信息维护" runat="server">
            <PagerSettings NextPageText="下一页" PreviousPageText="前一页" />
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="编号" ReadOnly="true" HeaderStyle-Width="0" SortExpression="CountryId" >
                     <HeaderStyle CssClass="yangshi" />
                    <ItemStyle CssClass="yangshi" />
                    </asp:BoundField>
                <asp:BoundField DataField="CountryName" HeaderText="国家名称" SortExpression="CountryName" />
                <asp:CommandField HeaderText="编辑" ShowEditButton="true" />
                <asp:CommandField HeaderText="删除"  ShowDeleteButton="true" />
            </Columns>
            
        </asp:GridView>
       <asp:LinkButton ID="ToIndex" runat="server" OnClick="ToIndex_Click">ToIndex</asp:LinkButton>
    </div>
    </form>
</body>
</html>
