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
        protected void Page_Load(object sender, EventArgs e)
        {
            int index = new HomePage().GetListviewSelectedIndex();
            var rowdata = new HomePage().GetListViewSource().Rows[index];
            MovieActors.Text = rowdata.ItemArray[4].ToString();
            MovieDecriptions.Text = rowdata.ItemArray[3].ToString();
            MovieImage.ImageUrl = rowdata.ItemArray[5].ToString();
        }
    }
}