using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Training.Service;

namespace Training.Web
{
    public partial class MovieDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int a = new HomePage().GetListviewSelectedIndex();
            //Image1.ImageUrl = ServiceFactory.GetMovieService().GetMovies("全部", "").
        }
    }
}