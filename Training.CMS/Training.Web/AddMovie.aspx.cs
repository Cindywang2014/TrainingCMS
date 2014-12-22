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
            if (Session["UserName"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                UserName.Text = Session["UserName"].ToString();
            }
            if (!IsPostBack)
            {
                var source = new MovieTypeService().GetMovieTypes();
                MovieTypeList.DataSource = source;
                MovieTypeList.DataTextField = "TypeName";
                MovieTypeList.DataValueField = "Id";
                MovieTypeList.DataBind();
            }
        }

        protected void UploadButton_Click(object sender, EventArgs e)
        {
            if (EmptyCheck())
            {
                string name = ImageUpload.FileName;
                string ipath = Server.MapPath(@"~\Images\") + name;
                ImageUpload.SaveAs(ipath);
                var movie = new Movie()
                {
                    MovieTypeId = Convert.ToInt32(MovieTypeList.SelectedValue),
                    MovieName = MovieNameBox.Text,
                    Description = DescriptionBox.Text,
                    Actor = ActorBox.Text,
                    Image = @"~\Images\" + name,
                    UploadDate = DateTime.Now,
                    IsAudit = false
                };
                var movieService = new MovieService();
                var result = movieService.AddMovie(movie);
                if (result == 1)
                { 
                    Response.Redirect("MovieMaintenance.aspx"); 
                }
                else
                {
                    Response.Write("<script>alert('添加失败')</script>");
                }
            }
        }
        protected bool EmptyCheck()
        {
            bool result = false;
            if (String.IsNullOrWhiteSpace(MovieNameBox.Text))
            {
                Response.Write("<script>alert('请输入名字')</script>");
                return result;
            }
            else if (String.IsNullOrWhiteSpace(ActorBox.Text))
            {
                Response.Write("<script>alert('请输入主演')</script>");
                return result;
            }
            else if (String.IsNullOrWhiteSpace(ImageUpload.FileName))
            {
                Response.Write("<script>alert('请输入图片')</script>");
                return result;
            }
            else if (String.IsNullOrWhiteSpace(DescriptionBox.Text))
            {
                Response.Write("<script>alert('请输入详细信息')</script>");
                return result;
            }
            return result = true;
        }


    }
}
