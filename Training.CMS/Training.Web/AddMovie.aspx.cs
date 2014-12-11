using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Threading.Tasks;
using Training.Domain;
using Training.Service;


namespace Training.Web
{
    public partial class AddMovie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void UploadButton_Click(object sender, EventArgs e)
        {
            var movie = new Movie()
            {
                MovieTypeId = Convert.ToInt32(MovieTypeIdBox.Text),
                MovieName = MovieNameBox.Text,
                Description = DescriptionBox.Text,
                Actor = ActorBox.Text,
                Image = ActorBox.Text,
                UploadDate = DateTime.Now,
                IsAudit = true
            };
            var movieService = new MovieService();
            movieService.AddMovie(movie);
        }
    }
}
 