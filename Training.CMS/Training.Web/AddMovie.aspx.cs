﻿using System;
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
            if (!IsPostBack)
            {
                UploadDateBox.Text = DateTime.Now.ToString();
                var source = new MovieTypeService().GetMovieTypes();
                MovieTypeList.DataSource = source;
                MovieTypeList.DataTextField = "TypeName";
                MovieTypeList.DataValueField = "Id";
                MovieTypeList.DataBind();
            }
        }

        protected void UploadButton_Click(object sender, EventArgs e)
        {
            string name = ImageUpload.FileName;
            string ipath = Server.MapPath(@"~\App_Data\Images\") + name;
            ImageUpload.SaveAs(ipath);
            var movie = new Movie()
            {
                MovieTypeId = Convert.ToInt32(MovieTypeList.SelectedValue),
                MovieName = MovieNameBox.Text,
                Description = DescriptionBox.Text,
                Actor = ActorBox.Text,
                Image = @"\App_Data\Images\" + name,
                UploadDate = DateTime.Now,
                IsAudit = PassedButten.Checked
            };
            var movieService = new MovieService();
            movieService.AddMovie(movie);
        }

    }
}
//tbStartTime.Value = DateTime.Now.ToString("yyyy-MM-dd");