using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Training.Domain;
using Training.Service;

namespace Training.Web
{
    public partial class UpdateMovie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var source = new MovieTypeService().GetMovieTypes();
                MovieTypeList.DataSource = source;
                MovieTypeList.DataTextField = "TypeName";
                MovieTypeList.DataValueField = "Id";
                MovieTypeList.DataBind();
                ShowData();

            }
        }
        protected void ShowData()
        {
            var MovieId = Request.QueryString["MovieId"];
            var movie = new Movie()
            {
                Id = Convert.ToInt32(MovieId),
            };
            var movieService = new MovieService();
            var infoTable = movieService.ShowMovie(movie.Id).Rows[0];
            MovieNameBox.Text=infoTable.ItemArray[2].ToString();
            ActorBox.Text=infoTable.ItemArray[4].ToString();
            Image.ImageUrl = infoTable.ItemArray[5].ToString();
            DescriptionBox.Text = infoTable.ItemArray[3].ToString();
            PassedButten.Checked = Convert.ToBoolean(infoTable.ItemArray[7]);
            FailButton.Checked = !Convert.ToBoolean(infoTable.ItemArray[7]);
            MovieTypeList.SelectedValue = infoTable.ItemArray[1].ToString();
        }
        protected void UpdateButton_Click(object sender, EventArgs e)
        {
            string name = ImageUpload.FileName;
            string ipath = Server.MapPath(@"~\Images\") + name;
            ImageUpload.SaveAs(ipath);
            var MovieId = Request.QueryString["MovieId"];
            var movie = new Movie()
            {
                Id = Convert.ToInt32(MovieId),
                MovieTypeId = Convert.ToInt32(MovieTypeList.SelectedValue),
                MovieName = MovieNameBox.Text,
                Description = DescriptionBox.Text,
                Actor = ActorBox.Text,
                Image = @"~\Images\" + name,
                UploadDate = DateTime.Now,
                IsAudit = PassedButten.Checked,
            };
            var movieService = new MovieService();

            movieService.UpdateMovie(movie);
        }
    }
}