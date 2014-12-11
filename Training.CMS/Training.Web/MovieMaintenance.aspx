<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MovieMaintenance.aspx.cs" Inherits="Training.Web.MovieMaintenance" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Maintenance of the movie</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:GridView ID="MovieGridView" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="Movie">
                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
                    <asp:BoundField DataField="MovieName" HeaderText="MovieName" SortExpression="MovieName" />
                    <asp:BoundField DataField="MovieTypeId" HeaderText="MovieTypeId" SortExpression="MovieTypeId" />
                    <asp:ImageField DataImageUrlField="Image" HeaderText="Image" ReadOnly="True" NullDisplayText="No image on file." AlternateText="Movie Image" >
                        <ControlStyle Height="120px" Width="200px" BorderStyle="Groove" />
                    </asp:ImageField>
                    <asp:BoundField DataField="Actor" HeaderText="Actor" SortExpression="Actor" />
                    <asp:BoundField DataField="Description" HeaderText="Description" SortExpression="Description" />
                    <asp:BoundField DataField="UploadDate" HeaderText="UploadDate" SortExpression="UploadDate" />
                    <asp:CheckBoxField DataField="IsAudit" HeaderText="IsAudit" SortExpression="IsAudit" />
                    <asp:CommandField ShowDeleteButton="True" />
                    <asp:CommandField ShowEditButton="True" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="Movie" runat="server" ConnectionString="<%$ ConnectionStrings:Movie %>" SelectCommand="SELECT * FROM [Movie]"></asp:SqlDataSource>

        </div>
    </form>
    </body>
</html>
