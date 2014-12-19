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
using System.Data;
namespace Training.Web
{
    public partial class AddRegion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindCountry();
            }

        }
        public void BindCountry()
        {
            var countryService = new CountryService();
            DataTable dtCountry = countryService.GetCountries();
            DDLCountry.DataSource = dtCountry;
            DDLCountry.DataTextField = "CountryName";
            DDLCountry.DataValueField = "Id";
            DDLCountry.DataBind();
            DDLCountry.Items.Insert(0, new ListItem("-请选择-"));
            var regionService = new RegionService();
            GvShowRegion.DataKeyNames = new string[] { "Id" };//讲数据库中的逐渐字段放入GridView控件的DataKeyNames属性中
            GvShowRegion.DataSource = regionService.GetRegions();
            GvShowRegion.DataBind();
        }

        protected void DDLCountry_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void BtnAddRegion_Click(object sender, EventArgs e)
        {

            var region = new Region();
            region.RegionName = RegionNamebox.Text.ToString().Trim();
            var regionService = new RegionService();
            int count = regionService.ExperimentalRegion(region);
            // if(DDLCountry.Text=="")
            if (DDLCountry.Text == "-请选择-")
            {
                Response.Write("<script>alert('请选择国家')</script>");
            }
            else if (count <= 0)
            {
                region.CountryId = Convert.ToInt32(DDLCountry.SelectedValue);//get Id value
                if (!string.IsNullOrWhiteSpace(region.RegionName))
                {
                    var result = regionService.AddRegion(region);
                    if (result == 1)
                    {
                        BindCountry();
                        Response.Write("<script>alert('添加成功')</script>");
                    }
                    else
                    {
                        Response.Write("<script>alert('添加失败')</script>");
                    }

                }
                else
                {
                    Response.Write("<script>alert('请填写地区')</script>");
                }

            }
            else
            {
                Response.Write("<script>alert('已经存在，换一个试试')</script>");
            }

        }
        protected void GvShowRegion_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GvShowRegion.PageIndex = e.NewPageIndex;
            BindCountry();
        }

        protected void GvShowRegion_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GvShowRegion.EditIndex = -1;
            BindCountry();
        }

        protected void GvShowRegion_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)//判定当前的行是否属于datarow类型的行
            {
                //当鼠标放上去的时候 先保存当前行的背景颜色 并给附一颜色
                e.Row.Attributes.Add("onmouseover", "currentcolor=this.style.backgroundColor;this.style.backgroundColor='#7f9edb',this.style.fontWeight='';");
                //当鼠标离开的时候 将背景颜色还原的以前的颜色
                e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor=currentcolor,this.style.fontWeight='';");
            }
        }

        protected void GvShowRegion_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string regionID = GvShowRegion.DataKeys[e.RowIndex].Value.ToString();
            var region = new Region()
            {

                Id = Convert.ToInt32(regionID)
            };
            var regionService = new RegionService();
            regionService.DeleteRegion(region);
            //var countryService = new CountryService();
            //countryService.DeleteCountry(region);
            Response.Write("<script>alert('删除成功')</script>");
            BindCountry();
        }

        protected void GvShowRegion_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GvShowRegion.EditIndex = e.NewEditIndex;
            BindCountry();
        }

        protected void GvShowRegion_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

            string regionID = GvShowRegion.DataKeys[e.RowIndex].Value.ToString();

            //get input text
            string regionName = ((TextBox)(GvShowRegion.Rows[e.RowIndex].Cells[1].Controls[0])).Text.ToString().Trim();

            var region = new Region();
            region.Id = Convert.ToInt32(regionID);
            region.RegionName = regionName;




            if (!string.IsNullOrWhiteSpace(regionName))
            {

                var regionService = new RegionService();
                var result = regionService.UpdateRegion(region);
                if (result == 1)
                {
                    Response.Write("<script>alert('修改成功')</script>");
                    GvShowRegion.EditIndex = -1;
                    BindCountry();
                }
                else
                {
                    Response.Write("<script>alert('修改失败')</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('地区不能为空')</script>");
            }
        }


        protected void ToIndex_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }
    }
}

