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
    public partial class AddCountry : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Bind();
            }

        }
        public void Bind()
        {
            var countryService = new CountryService();
            GvShowCountry.DataKeyNames = new string[] { "Id" };//讲数据库中的逐渐字段放入GridView控件的DataKeyNames属性中
            GvShowCountry.DataSource = countryService.GetCountries();
            GvShowCountry.DataBind();

        }
        protected void BtnAddCountry_Click(object sender, EventArgs e)
        {

            var country = new Country();
            country.CountryName = CountryNamebox.Text.ToString().Trim();
            var countryService = new CountryService();
            int count = countryService.ExperimentalCountry(country);
            if (String.IsNullOrWhiteSpace(country.CountryName))            
            {
                Response.Write("<script>alert('还啥都没写呢')</script>");

            }
            else if (count <= 0)
            {
                countryService.AddCountry(country);
                Bind();

            }
            else
            {
                Response.Write("<script>alert('已经存在此名字，换一个再试')</script>");
            }
        }

        protected void GvShowCountry_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GvShowCountry.PageIndex = e.NewPageIndex;
            Bind();
        }

        protected void GvShowCountry_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GvShowCountry.EditIndex = -1;
            Bind();
        }

        protected void GvShowCountry_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)//判定当前的行是否属于datarow类型的行
            {
                //当鼠标放上去的时候 先保存当前行的背景颜色 并给附一颜色
                e.Row.Attributes.Add("onmouseover", "currentcolor=this.style.backgroundColor;this.style.backgroundColor='#7f9edb',this.style.fontWeight='';");
                //当鼠标离开的时候 将背景颜色还原的以前的颜色
                e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor=currentcolor,this.style.fontWeight='';");
            }
        }

        protected void GvShowCountry_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {



            string countryID = GvShowCountry.DataKeys[e.RowIndex].Value.ToString();

            var region = new Region();
            region.CountryId = Convert.ToInt32(countryID);
            var regionService = new RegionService();
            int count = regionService.ExperimentalRegionCount(region);
            if (count <= 0)
            {
                var country = new Country();
                country.Id = Convert.ToInt32(countryID);

                var countryService = new CountryService();
                countryService.DeleteCountry(country);
                
                Response.Write("<script>alert('删除成功')</script>");
            }
            else
            {
                Response.Write("<script>alert('此国家里面包括地区，不能删除')</script>");
            }
            //GvShowCountry.EditIndex = -1;//return to original state
            Bind();
        }

        protected void GvShowCountry_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GvShowCountry.EditIndex = e.NewEditIndex;
            Bind();
        }

        protected void GvShowCountry_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

            //get edit row key value
            string countryID = GvShowCountry.DataKeys[e.RowIndex].Value.ToString();
            //取得文本框中输入的内容
            string countryName = ((TextBox)(GvShowCountry.Rows[e.RowIndex].Cells[1].Controls[0])).Text.ToString().Trim();

            var country = new Country()
            {
                Id = Convert.ToInt32(countryID),
                CountryName = countryName

            };

            var countryService = new CountryService();

            countryService.UpdateCountry(country);
            GvShowCountry.EditIndex = -1;//return to original state
            Bind();
        }
        protected void ToIndex_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }
    }
}