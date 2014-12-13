<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MovieMaintenance.aspx.cs" Inherits="Training.Web.MovieMaintenance" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Maintenance of the movie</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:GridView ID="MovieGridView" runat="server" AutoGenerateColumns="False"  Caption="Maintenance of the movie" >
                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
                    <asp:BoundField DataField="MovieName" HeaderText="MovieName" SortExpression="MovieName" />
                    <asp:BoundField DataField="MovieTypeId" HeaderText="MovieTypeId" SortExpression="MovieTypeId" />
                    <asp:ImageField DataImageUrlField="Image" HeaderText="Image" ReadOnly="True" NullDisplayText="No image on file." AlternateText="Movie Image" >
                        <ControlStyle Height="100px" Width="150px" BorderStyle="Groove" />
                    </asp:ImageField>
                    <asp:BoundField DataField="Actor" HeaderText="Actor" SortExpression="Actor" />
                    <asp:BoundField DataField="Description" HeaderText="Description" SortExpression="Description" />
                    <asp:BoundField DataField="UploadDate" HeaderText="UploadDate" SortExpression="UploadDate" />
                    <asp:CheckBoxField DataField="IsAudit" HeaderText="IsAudit" SortExpression="IsAudit" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
    </body>
</html>
