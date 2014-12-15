using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Training.Service;

namespace Training.Web
{
    public partial class UpdateMovie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private void DataSourceBand()
        {
            //var movieService = new MovieService();
            //MovieGridView.DataSource = movieService.GetMovies();
            //MovieGridView.DataKeyNames = new string[] { "Id" };
            //MovieGridView.DataBind();
        }
    }
}