using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Training.Domain;
using Training.Service;

namespace Training.Web
{
    public partial class ModifyUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserName"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                DisplayUser.Text = Session["UserName"].ToString();
            }
            if (!IsPostBack)
            {
                BindCountryAndRegion();
            }
        }
        public void BindCountryAndRegion()
        {
            var countryService = new CountryService();
            DataTable resultCountry = countryService.GetCountries();
            CountryDropDownList.DataSource = resultCountry;
            CountryDropDownList.DataTextField = "CountryName";
            CountryDropDownList.DataValueField = "Id";
            CountryDropDownList.DataBind();

            var countryId = Convert.ToInt32(CountryDropDownList.SelectedValue);
            RegionDropDownList.DataSource = countryService.GetSelectRegion(countryId).DataSet;
            RegionDropDownList.DataTextField = "RegionName";
            RegionDropDownList.DataValueField = "Id";
            RegionDropDownList.DataBind();
        }

        public bool CheckTextbox()
        {
            bool satisfyThree = true;
            Regex regexPassword = new Regex(@"^(\w){6,20}$");
            if (!regexPassword.IsMatch(TextPassword.Text))
            {
                WrongPassword.Visible = true;
                WrongPassword.Text = "请注意：密码格式不正确！";
                satisfyThree = false;
            }
            else
            {
                WrongPassword.Visible = false;
            }

            if (!TextRepeatPassword.Text.Equals(TextPassword.Text))
            {
                WrongRepeatPassword.Visible = true;
                WrongRepeatPassword.Text = "请注意：两次密码不一致！";
                satisfyThree = false;
            }
            else
            {
                WrongRepeatPassword.Visible = false;
            }

            Regex regemail = new Regex(@"^[\w-]+(\.[\w-]+)*@[\w-]+(\.[\w-]+)+$");
            if (!regemail.IsMatch(TextEmail.Text))
            {
                WrongEmail.Visible = true;
                WrongEmail.Text = "请注意：请填写正确的Email地址！";
                satisfyThree = false;
            }
            else
            {
                WrongEmail.Visible = false;
            }
            return satisfyThree;
        }

        protected void ButtonSubmit_Click(object sender, EventArgs e)
        {
            if (CheckTextbox())
            {
                var userName = Request.QueryString["UserName"];
                var user = new User
                {
                    UserName = DisplayUser.Text,
                    Password = TextPassword.Text,
                    EmailAddress = TextEmail.Text,
                    Country = CountryDropDownList.SelectedItem.Text,
                    Region = RegionDropDownList.SelectedItem.Text,
                };
                var userService = new UserService();
                var perform = userService.UpdateUser(user);
                if (perform == 1)
                {
                    Response.Write("<script>alert('修改成功！');</script>");
                }
                else
                {
                    Response.Write("<script>alert('修改失败！');</script>");
                }
            }
        }

        protected void ButtonAbandon_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }

        protected void CountryDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var countryId = Convert.ToInt32(CountryDropDownList.SelectedValue);
            var countryService = new CountryService();
            RegionDropDownList.DataSource = countryService.GetSelectRegion(countryId).DataSet;
            RegionDropDownList.DataTextField = "RegionName";
            RegionDropDownList.DataValueField = "Id";
            RegionDropDownList.DataBind();
            this.TextPassword.Attributes["value"] = TextPassword.Text.Trim();
            this.TextRepeatPassword.Attributes["value"] = TextRepeatPassword.Text.Trim();
        }

        protected void ToIndex_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }
    }
}
