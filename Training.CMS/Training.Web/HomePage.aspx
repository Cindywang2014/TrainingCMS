<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="Training.Web.HomePage" %>

<%--<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>--%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Css/HomePage.css" rel="stylesheet" />
    <title>MoviesServer</title>
    <script src="dist/js/vendor/jquery.min.js"></script>
</head>

<body>
    <form runat="server">
        <header>
            <div class="headertop">
                <label>Choose MovieType:</label>
                <asp:DropDownList ID="ChooseMovieType" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ChooseMovieType_SelectedIndexChanged" AppendDataBoundItems="True">
                    <asp:ListItem>全部</asp:ListItem>
                </asp:DropDownList>
                <asp:TextBox ID="InputActor" Text="Input the name of actor or movie.." runat="server"></asp:TextBox>
                <asp:Button ID="SubmitCondition" runat="server" Text="Search" OnClick="SubmitCondition_Click" />
            </div>

            <nav>
                <a href="#">Movie</a>
                <a href="#">Teleplay</a>
                <a href="#">Anime</a>
                <a href="#">Sports</a>
                <a href="#">Music</a>
                <a href="#">Variety</a>
            </nav>
        </header>
        <section>
            <asp:ListView ID="ConsilientMovies" OnSelectedIndexChanging="ConsilientMovies_SelectedIndexChanging" runat="server">

                <LayoutTemplate>
                    <div id="itemPlaceholderContainer" class="itemPlaceholderContainer" runat="server">
                        <div runat="server" id="itemPlaceholder"></div>
                        <div class="reset"></div>
                    </div>
                </LayoutTemplate>

                <EmptyDataTemplate>
                    <h2 class="empty">No data was found. Please select or input again.</h2>
                </EmptyDataTemplate>

                <ItemTemplate>
                    <div style="display: table; float: left; margin: 10px;">
                        <asp:LinkButton ID="MovieLink" CommandName="Select" runat="server">
                            <div style="float: left;">
                                <asp:Image ID="Image" runat="server" Height="130px" Width="130px" ImageUrl='<%# Eval("Image") %>' />
                            </div>
                            <div style="margin-left: 20px; padding-top: 5px; max-width: 195px; float: left; font-size: 13px;">
                                <asp:Label ID="MovieNameLabel" runat="server" Text='<%# Eval("MovieName") %>' />
                                <br />
                                Actor:
                                <asp:Label ID="ActorLabel" runat="server" Text='<%# Eval("Actor") %>' />
                                <br />
                                UploadDate:
                                <asp:Label ID="UploadDateLabel" runat="server" Text='<%# Eval("UploadDate") %>' />
                            </div>
                            <div class="reset"></div>
                        </asp:LinkButton>
                    </div>
                </ItemTemplate>

                <%--                <webdiyer:AspNetPager ID="AspNetPagerAskAnswer" runat="server"
                    AlwaysShow="True" FirstPageText="首页" LastPageText="尾页" NextPageText="下一页"
                    onpagechanged="AspNetPagerAskAnswer_PageChanged" PrevPageText="上一页"
                    PageSize="15">
                </webdiyer:AspNetPager>--%>
            </asp:ListView>



        </section>
    </form>
</body>
<script>
    $(document).ready(function () {
        $("#InputActor").focus(function () {
            if ($(this).val() == "Input the name of actor or movie..")
                $(this).val("");
            $(this).css("color", "black");
        });

        $("#InputActor").blur(function () {
            if ($(this).val().trim() == "") {
                $(this).val("Input the name of actor or movie..");
                $(this).css("color", "#acb7bf");
            }
        });
    });
</script>
</html>
