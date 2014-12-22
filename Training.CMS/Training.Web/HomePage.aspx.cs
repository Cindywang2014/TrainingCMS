using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Training.Service;
using System.Data;

namespace Training.Web
{
    public partial class HomePage : System.Web.UI.Page
    {
        private readonly IMovieService MovieService = ServiceFactory.GetMovieService();
        private readonly IMovieTypeService MovieTypeService = ServiceFactory.GetMovieTypeService();
        private static string MovieType = "全部";
        private static string Actor = "";
        private static int ListviewSelectedIndex;
        protected void Page_Load(object sender, EventArgs e)
        {
            this.MaintainScrollPositionOnPostBack = true;
            if (!IsPostBack)
            {
                ChooseMovieTypeDatabound();
                ConsilientMoviesDatabound();
            }
        }

        private void ChooseMovieTypeDatabound()
        {
            ChooseMovieType.DataSource = MovieTypeService.GetMovieTypes();
            ChooseMovieType.DataTextField = "TypeName";
            ChooseMovieType.DataValueField = "Id";
            ChooseMovieType.DataBind();
        }

        private void ConsilientMoviesDatabound()
        {
            var ListViewSource = MovieService.GetMovies(MovieType, Actor);
            ConsilientMovies.DataSource = ListViewSource;
            ConsilientMovies.DataBind();
        }

        private void ShowQueryResult()
        {
            MovieType = ChooseMovieType.SelectedItem.Text;
            Actor = InputActor.Text;
            ConsilientMoviesDatabound();
        }

        protected void ChooseMovieType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ShowQueryResult();
        }

        protected void SubmitCondition_Click(object sender, EventArgs e)
        {
            ShowQueryResult();
        }

        protected void ConsilientMovies_SelectedIndexChanging(object sender, ListViewSelectEventArgs e)
        {
            ListviewSelectedIndex = e.NewSelectedIndex;
            Response.Redirect("MovieDetails.aspx?typename=" + MovieType + "&actor=" + Actor + "&index=" + ListviewSelectedIndex);
        }

        protected void ConsilientMovies_PagePropertiesChanged(object sender, EventArgs e)
        {
            ConsilientMoviesDatabound();
        }

    }
}