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
            Choose MovieType:
            <asp:DropDownList ID="ChooseMovieType" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ChooseMovieType_SelectedIndexChanged" AppendDataBoundItems="True">
                <asp:ListItem>全部</asp:ListItem>
            </asp:DropDownList>

            <asp:TextBox ID="InputActor" runat="server"></asp:TextBox>
            <asp:Button ID="SubmitCondition" runat="server" Text="Search.." OnClick="SubmitCondition_Click" />
        </header>
        <section>
            <asp:ListView ID="ConsilientMovies" OnSelectedIndexChanging="ConsilientMovies_SelectedIndexChanging" runat="server">
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
                <EmptyDataTemplate>
                    <br />
                    <label style="margin-left: 30px;">No data was found. Please select or input again.</label>
                </EmptyDataTemplate>
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
                    <div>
                        <asp:LinkButton ID="MovieLink" CommandName="Select" runat="server">
                            <div style="float: left;">
                                <asp:Image ID="Image" runat="server" Height="130px" Width="130px" src='<%# Eval("Image") %>' />
                            </div>
                            <div style="margin-left: 20px; padding-top: 20px; float: left; font-size: 13px;">
                                <asp:Label ID="MovieNameLabel" runat="server" Text='<%# Eval("MovieName") %>' />
                                <br />
                                Actor:
                                <asp:Label ID="ActorLabel" runat="server" Text='<%# Eval("Actor") %>' />
                                <br />
                                UploadDate:
                                <asp:Label ID="UploadDateLabel" runat="server" Text='<%# Eval("UploadDate") %>' />
                            </div>
                            <div style="clear: both;"></div>
                        </asp:LinkButton>
                    </div>
                </ItemTemplate>

                <LayoutTemplate>
                    <div id="itemPlaceholderContainer" runat="server" style="margin-left: 20px;">
                        <div runat="server" itemid='<%# Eval("Id") %>' id="itemPlaceholder"></div>
                    </div>
                </LayoutTemplate>

                <%--<SelectedItemTemplate>
                    <div>
                        <asp:LinkButton ID="MovieLink" OnClick="MovieLink_Click" runat="server">
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
                        </asp:LinkButton>
                    </div>
                </SelectedItemTemplate>--%>
            </asp:ListView>
        </section>
    </form>
</body>
</html>
