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
    public partial class MovieDetails : System.Web.UI.Page
    {
        private readonly IMovieService MovieServer = ServiceFactory.GetMovieService();
        protected void Page_Load(object sender, EventArgs e)
        {
            var index = Convert.ToInt32(Request.QueryString["index"]);
            var typename = Request.QueryString["typename"];
            var actor = Request.QueryString["actor"];
            var rowdata = MovieServer.GetMovies(typename, actor).Rows[index];

            MovieName.Text = rowdata.ItemArray[2].ToString();
            MovieDecriptions.Text = rowdata.ItemArray[3].ToString();
            MovieActors.Text = rowdata.ItemArray[4].ToString();
            MovieImage.ImageUrl = rowdata.ItemArray[5].ToString();
        }
    }
}