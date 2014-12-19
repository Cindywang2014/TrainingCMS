<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="Training.Web.HomePage" %>

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
                <div class="logo">
                    <img src="/Images/Logo.png" />
                </div>
                <div style="float: left; width: 700px; line-height: 47px;">
                    <label>Choose MovieType:</label>
                    <asp:DropDownList ID="ChooseMovieType" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ChooseMovieType_SelectedIndexChanged" AppendDataBoundItems="True">
                        <asp:ListItem>全部</asp:ListItem>
                    </asp:DropDownList>
                    <asp:TextBox ID="InputActor" Text="Input the name of actor or movie.." runat="server"></asp:TextBox><asp:Button ID="SubmitCondition" runat="server" Text="Search" OnClick="SubmitCondition_Click" />
                </div>
            </div>

            <nav>
                <a href="#">Movie</a><a href="#">Teleplay</a><a href="#">Anime</a><a href="#">Sports</a><a href="#">Music</a><a href="#">Variety</a>
            </nav>

        </header>

        <section>
            <asp:ListView ID="ConsilientMovies" OnPagePropertiesChanged="ConsilientMovies_PagePropertiesChanged" OnSelectedIndexChanging="ConsilientMovies_SelectedIndexChanging" runat="server">
                <LayoutTemplate>
                    <div id="itemPlaceholderContainer" class="itemPlaceholderContainer" runat="server">
                        <div runat="server" id="itemPlaceholder"></div>
                        <div class="reset"></div>
                    </div>
                    <div class="datapagecontrol">
                        <asp:DataPager ID="DataPager" PageSize="9" runat="server">
                            <Fields>
                                <asp:NextPreviousPagerField ButtonType="Link" PreviousPageText="Prev" ButtonCssClass="datapage" ShowFirstPageButton="true" ShowNextPageButton="false" />
                                <asp:NumericPagerField ButtonCount="3"  />
                                <asp:NextPreviousPagerField ButtonType="Link" ButtonCssClass="datapage" ShowLastPageButton="true" ShowPreviousPageButton="false" />
                            </Fields>
                        </asp:DataPager>
                    </div>
                </LayoutTemplate>

                <EmptyDataTemplate>
                    <h2 class="empty">No data was found. Please select or input again.</h2>
                </EmptyDataTemplate>

                <ItemTemplate>
                    <div class="listviewitems">
                        <asp:LinkButton ID="MovieLink" ForeColor="Black" CommandName="Select" runat="server">
                            <div class="itemleft">
                                <asp:Image ID="Image" runat="server" Height="130px" Width="130px" ImageUrl='<%# Eval("Image") %>' />
                            </div>
                            <div class="itemright">
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
            </asp:ListView>
        </section>
    </form>
</body>

<script>
    $(document).ready(function () {
        if ($("#InputActor").val() != "Input the name of actor or movie..") {
            $("#InputActor").css("color", "black");
        }
        $("#InputActor").focus(function () {
            if ($(this).val() == "Input the name of actor or movie..") {
                $(this).val("");
            }
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
