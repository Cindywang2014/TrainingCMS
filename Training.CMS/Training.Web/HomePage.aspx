<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="Training.Web.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="/dist/css/HomePage.css" rel="stylesheet" />
    <title>MoviesServer</title>
    <script src="dist/js/vendor/jquery.min.js"></script>
    <script>

    </script>
</head>

<body>
    <form runat="server">
        <header>
            Choose MovieType:
            <asp:DropDownList ID="ChooseMovieType" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ChooseMovieType_SelectedIndexChanged" AppendDataBoundItems="True">
                <asp:ListItem>全部</asp:ListItem>
            </asp:DropDownList>
            Input actor or moviename:
            <asp:TextBox ID="InputActor" AutoPostBack="true" runat="server"></asp:TextBox>
            <asp:Button ID="SubmitCondition" runat="server" Text="Search.." OnClick="SubmitCondition_Click" />
        </header>
        <section>
            <asp:ListView ID="ConsilientMovies" OnSelectedIndexChanging="ConsilientMovies_SelectedIndexChanging" runat="server">

                <LayoutTemplate>
                    <div id="itemPlaceholderContainer" class="itemPlaceholderContainer" runat="server">
                        <div runat="server" id="itemPlaceholder"></div>
                        <div style="clear: both;"></div>
                    </div>
                </LayoutTemplate>

                <EmptyDataTemplate>
                    <br />
                    <label style="margin-left: 30px;">No data was found. Please select or input again.</label>
                </EmptyDataTemplate>

                <ItemTemplate>
                    <div style="display: table; float: left; margin: 10px;">
                        <asp:LinkButton ID="MovieLink" CommandName="Select" runat="server">
                            <div style="float: left;">
                                <asp:Image ID="Image" runat="server" Height="130px" Width="130px" ImageUrl='<%# Eval("Image") %>' />
                            </div>
                            <div style="margin-left: 20px; padding-top: 5px; float: left; font-size: 13px;">
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
            </asp:ListView>
        </section>
    </form>
</body>
</html>
