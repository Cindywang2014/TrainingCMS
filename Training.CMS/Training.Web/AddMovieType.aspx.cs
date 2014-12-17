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
            if(!IsPostBack)
            {
                BindMovieType();
            }
        }

        protected void BtnAddMovieType_Click(object sender, EventArgs e)
        {
            var movieType = new MovieType();
            movieType.TypeName = MovieTypeBox.Text;

            var movieTypeService = new MovieTypeService();
            int count = movieTypeService.ExperimentalType(movieType);
            if(count<=0)
            {
                movieTypeService.AddMovieType(movieType);
                BindMovieType();
            }
            else
            {
                Response.Write("<script>alert('已经存在此类型')</script>");
            }
        }
        public void BindMovieType()
        {
          
            var movieTypeService = new MovieTypeService();
            GvShowMovieType.DataKeyNames = new string[] { "Id" };//讲数据库中的逐渐字段放入GridView控件的DataKeyNames属性中
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
            if (e.Row.RowType == DataControlRowType.DataRow)//判定当前的行是否属于datarow类型的行
            {
                //当鼠标放上去的时候 先保存当前行的背景颜色 并给附一颜色
                e.Row.Attributes.Add("onmouseover", "currentcolor=this.style.backgroundColor;this.style.backgroundColor='#7f9edb',this.style.fontWeight='';");
                //当鼠标离开的时候 将背景颜色还原的以前的颜色
                e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor=currentcolor,this.style.fontWeight='';");
            }
        }

        protected void GvShowMovieType_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string typeID = GvShowMovieType.DataKeys[e.RowIndex].Value.ToString();
            var movieType = new MovieType();
            movieType.Id = Convert.ToInt32(typeID);

            var movieTypeService = new MovieTypeService();
            movieTypeService.DeteleMovieType(movieType);
            BindMovieType();
           
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
            //取得文本框中输入的内容
            string typeName=((TextBox)(GvShowMovieType.Rows[e.RowIndex].Cells[0].Controls[0])).Text.ToString().Trim();
           

            var movietype = new MovieType();
            
                movietype.Id = Convert.ToInt32(typeID);
                movietype.TypeName = typeName;

            var movieTypeService = new MovieTypeService();
            movieTypeService.UpdateMovieType(movietype);
            GvShowMovieType.EditIndex = -1;
            BindMovieType();

           

        }
    }
}