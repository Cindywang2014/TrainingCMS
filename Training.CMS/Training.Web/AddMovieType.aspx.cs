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
    public partial class AddMovieType : System.Web.UI.Page
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
                BindMovieType();
            }
        }

        protected void BtnAddMovieType_Click(object sender, EventArgs e)
        {
            var movieType = new MovieType();
            movieType.TypeName = MovieTypeBox.Text.ToString().Trim();

            var movieTypeService = new MovieTypeService();
            int count = movieTypeService.ExperimentalType(movieType);
            if (count == 0)
            {
                var result = movieTypeService.AddMovieType(movieType);
                if (result == 1)
                {
                    BindMovieType();
                    Response.Write("<script>alert('添加成功')</script>");
                }
                else
                {
                    Response.Write("<script>alert('添加失败！')</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('已经存在此类型')</script>");
            }
        }
        public void BindMovieType()
        {

            var movieTypeService = new MovieTypeService();
            GvShowMovieType.DataKeyNames = new string[] { "Id" };
            GvShowMovieType.DataSource = movieTypeService.GetMovieTypes();
            GvShowMovieType.DataBind();
        }
        protected void GvShowMovieType_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {

            GvShowMovieType.PageIndex = e.NewPageIndex;
            BindMovieType();
        }

        protected void GvShowMovieType_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GvShowMovieType.EditIndex = -1;
            BindMovieType();
        }

        protected void GvShowMovieType_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                
                e.Row.Attributes.Add("onmouseover", "currentcolor=this.style.backgroundColor;this.style.backgroundColor='#7f9edb',this.style.fontWeight='';");
                
                e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor=currentcolor,this.style.fontWeight='';");
            }
        }

        protected void GvShowMovieType_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string typeID = GvShowMovieType.DataKeys[e.RowIndex].Value.ToString();
            var movieType = new MovieType();
            var movie = new Movie();
            movie.MovieTypeId = Convert.ToInt32(typeID);
            var movieServcie = new MovieService();
            var count = movieServcie.ExperimentalMovieCount(movie);
            movieType.Id = Convert.ToInt32(typeID);
           
            if(count==0)
            {
            var movieTypeService = new MovieTypeService();
            var reult=movieTypeService.DeteleMovieType(movieType); 
                if(reult==1)
                {

                    ClientScript.RegisterStartupScript(this.GetType(), "", "<script>if(confirm('删除吗？')){}else{}</script>");
                BindMovieType();
                }
                else
                {
                    Response.Write("<script>alert('删除失败')</script>");
                }

            }

            else
            {
                Response.Write("<script>alert('类型内包括电影信息，不能删除类型')</script>");
            }
        }

        protected void GvShowMovieType_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GvShowMovieType.EditIndex = e.NewEditIndex;
            BindMovieType();
        }

        protected void GvShowMovieType_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

            //get edit row key value
            string typeID = GvShowMovieType.DataKeys[e.RowIndex].Value.ToString();
            string typeName = ((TextBox)(GvShowMovieType.Rows[e.RowIndex].Cells[0].Controls[0])).Text.ToString().Trim();
            var movietype = new MovieType();
            movietype.Id = Convert.ToInt32(typeID);
            movietype.TypeName = typeName;
            if (!string.IsNullOrWhiteSpace(movietype.TypeName))
            {
                var movieTypeService = new MovieTypeService();
                var result = movieTypeService.UpdateMovieType(movietype);
                if (result == 1)
                {
                    Response.Write("<script>alert('修改成功')</script>");
                    GvShowMovieType.EditIndex = -1;
                    BindMovieType();
                }
                else
                {
                    Response.Write("<script>alert('修改失败')</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('内容不能为空')</script>");
            }
        }

        protected void ToIndex_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }

        public Movie movie { get; set; }
    }
}