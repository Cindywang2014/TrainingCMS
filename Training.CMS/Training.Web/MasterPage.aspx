<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MasterPage.aspx.cs" Inherits="Training.Web.MasterPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form runat="server">
        <header>
            <asp:DropDownList ID="ChooseMovieType" runat="server"></asp:DropDownList>
            <asp:TextBox ID="InputActor" runat="server"></asp:TextBox>
            <asp:Button ID="SubmitCondition" runat="server" Text="Search.." />
        </header>
        <section>
            <asp:ListView ID="ConsilientMovies" runat="server" DataSourceID="Movie">
                <AlternatingItemTemplate>
                    <li style="">MovieName:
                        <asp:Label ID="MovieNameLabel" runat="server" Text='<%# Eval("Image") %>' />
                        <br />
                        Description:
                        <asp:Label ID="DescriptionLabel" runat="server" Text='<%# Eval("Description") %>' />
                        <br />
                        Actor:
                        <asp:Label ID="ActorLabel" runat="server" Text='<%# Eval("Actor") %>' />
                        <br />
                        Image:
                        <asp:Label ID="ImageLabel" runat="server" Text='<%# Eval("MovieName") %>' />
                        <br />
                    </li>
                </AlternatingItemTemplate>
                <EditItemTemplate>
                    <li style="">MovieName:
                        <asp:TextBox ID="MovieNameTextBox" runat="server" Text='<%# Bind("Image") %>' />
                        <br />
                        Description:
                        <asp:TextBox ID="DescriptionTextBox" runat="server" Text='<%# Bind("Description") %>' />
                        <br />
                        Actor:
                        <asp:TextBox ID="ActorTextBox" runat="server" Text='<%# Bind("Actor") %>' />
                        <br />
                        Image:
                        <asp:TextBox ID="ImageTextBox" runat="server" Text='<%# Bind("MovieName") %>' />
                        <br />
                        <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Update" />
                        <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancel" />
                    </li>
                </EditItemTemplate>
                <EmptyDataTemplate>
                    No data was returned.
                </EmptyDataTemplate>
                <InsertItemTemplate>
                    <li style="">MovieName:
                        <asp:TextBox ID="MovieNameTextBox" runat="server" Text='<%# Bind("Image") %>' />
                        <br />
                        Description:
                        <asp:TextBox ID="DescriptionTextBox" runat="server" Text='<%# Bind("Description") %>' />
                        <br />
                        Actor:
                        <asp:TextBox ID="ActorTextBox" runat="server" Text='<%# Bind("Actor") %>' />
                        <br />
                        Image:
                        <asp:TextBox ID="ImageTextBox" runat="server" Text='<%# Bind("MovieName") %>' />
                        <br />
                        <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="Insert" />
                        <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Clear" />
                    </li>
                </InsertItemTemplate>
                <ItemSeparatorTemplate>
                    <br />
                </ItemSeparatorTemplate>
                <ItemTemplate>
                    <li style="">MovieName:
                        <asp:Label ID="MovieNameLabel" runat="server" Text='<%# Eval("Image") %>' />
                        <br />
                        Description:
                        <asp:Label ID="DescriptionLabel" runat="server" Text='<%# Eval("Description") %>' />
                        <br />
                        Actor:
                        <asp:Label ID="ActorLabel" runat="server" Text='<%# Eval("Actor") %>' />
                        <br />
                        Image:
                        <asp:Label ID="ImageLabel" runat="server" Text='<%# Eval("MovieName") %>' />
                        <br />
                    </li>
                </ItemTemplate>
                <LayoutTemplate>
                    <ul id="itemPlaceholderContainer" runat="server" style="">
                        <li runat="server" id="itemPlaceholder" />
                    </ul>
                    <div style="">
                    </div>
                </LayoutTemplate>
                <SelectedItemTemplate>
                    <li style="">MovieName:
                        <asp:Label ID="MovieNameLabel" runat="server" Text='<%# Eval("Image") %>' />
                        <br />
                        Description:
                        <asp:Label ID="DescriptionLabel" runat="server" Text='<%# Eval("Description") %>' />
                        <br />
                        Actor:
                        <asp:Label ID="ActorLabel" runat="server" Text='<%# Eval("Actor") %>' />
                        <br />
                        Image:
                        <asp:Label ID="ImageLabel" runat="server" Text='<%# Eval("MovieName") %>' />
                        <br />
                    </li>
                </SelectedItemTemplate>
            </asp:ListView>
            <asp:SqlDataSource ID="Movie" runat="server" ConnectionString="Data Source=(local);Initial Catalog=Movie;User ID=sa;Password=123" ProviderName="System.Data.SqlClient" SelectCommand="SELECT [Image], [Description], [Actor], [MovieName] FROM [Movie]"></asp:SqlDataSource> 
        </section>
    </form>
</body>
</html>
