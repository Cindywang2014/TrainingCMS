<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="Training.Web.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="/dist/css/MasterPage.css" rel="stylesheet" />
    <title>MoviesServer</title>
</head>
<body>
    <form runat="server">
        <header>
            <asp:DropDownList ID="ChooseMovieType" runat="server" AppendDataBoundItems="True">
                <asp:ListItem>全部</asp:ListItem>
            </asp:DropDownList>
            <asp:TextBox ID="InputActor" runat="server"></asp:TextBox>
            <asp:Button ID="SubmitCondition" runat="server" Text="Search.." OnClick="SubmitCondition_Click" />
        </header>
        <section>
            <asp:ListView ID="ConsilientMovies" runat="server">
                <%--<AlternatingItemTemplate>
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
                </AlternatingItemTemplate>--%>
                <%--<EditItemTemplate>
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
                </EditItemTemplate>--%>
                <%--<EmptyDataTemplate>
                    No data was returned.
                </EmptyDataTemplate>--%>
                <%--<InsertItemTemplate>
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
                </InsertItemTemplate>--%>
                <%-- <ItemSeparatorTemplate>
                    <br />
                </ItemSeparatorTemplate>--%>
                <ItemTemplate>
                    <li style="display: table; margin-top: 10px;">
                        <div style="float: left;">
                            <asp:Image ID="Image" runat="server" Height="100px" Width="100px" src='<%# Eval("Image") %>' />
                        </div>
                        <div style="margin-left: 20px; padding-top: 20px; float: left; font-size: 13px;">
                            <asp:Label ID="MovieNameLabel" runat="server" Text='<%# Eval("MovieName") %>' />
                            <br />
                            Actor:
                        <asp:Label ID="ActorLabel" runat="server" Text='<%# Eval("Actor") %>' />
                            <br />
                            Description:
                            <br />
                            &nbsp;&nbsp;
                            <asp:Label ID="DescriptionLabel" runat="server" Text='<%# Eval("Description") %>' />
                        </div>
                        <div style="clear: both;"></div>
                    </li>
                </ItemTemplate>
                <LayoutTemplate>
                    <ul id="itemPlaceholderContainer" runat="server" style="">
                        <li runat="server" id="itemPlaceholder" />
                    </ul>
                    <div style="">
                    </div>
                </LayoutTemplate>
                <%--<SelectedItemTemplate>
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
                </SelectedItemTemplate>--%>
            </asp:ListView>
        </section>
    </form>
</body>
</html>
