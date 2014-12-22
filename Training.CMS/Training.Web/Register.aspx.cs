using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Training.Domain;
using Training.Service;

namespace Training.Web
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
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
            Regex regexUser = new Regex("^([a-zA-Z])([a-zA-Z0-9_]){2,9}$");
            if (!regexUser.IsMatch(UserNameTextRegister.Text))
            {
                UserWrong.Visible = true;
                UserWrong.Text = "请注意：用户名格式不正确！";
                satisfyThree = false;
            }
            else
            {
                UserWrong.Visible = false;
            }

            Regex regexPassword = new Regex(@"^(\w){6,20}$");
            if (!regexPassword.IsMatch(PasswordTextRegister.Text))
            {
                FirstPasswordWrong.Visible = true;
                FirstPasswordWrong.Text = "请注意：密码格式不正确！";
                satisfyThree = false;
            }
            else
            {
                FirstPasswordWrong.Visible = false;
            }

            if (!PasswordTextRegister.Text.Equals(PasswordRepeatText.Text))
            {
                PasswordWrong.Visible = true;
                PasswordWrong.Text = "请注意：两次密码不一致！";
                satisfyThree = false;
            }
            else
            {
                PasswordWrong.Visible = false;
            }

            Regex regemail = new Regex(@"^[\w-]+(\.[\w-]+)*@[\w-]+(\.[\w-]+)+$");
            if (!regemail.IsMatch(EmailAddressText.Text))
            {
                EmailWrong.Visible = true;
                EmailWrong.Text = "请注意：请填写正确的Email地址！";
                satisfyThree = false;
            }
            else
            {
                EmailWrong.Visible = false;
            }
            return satisfyThree;
        }

        protected void RegisterButton_Click(object sender, EventArgs e)
        {
            if (CheckTextbox())
            {
                var userService = new UserService();
                var user = new User
                {
                    UserName = UserNameTextRegister.Text,
                    Password = PasswordTextRegister.Text,
                    EmailAddress = EmailAddressText.Text,
                    Country = CountryDropDownList.SelectedItem.Text,
                    Region = RegionDropDownList.SelectedItem.Text,
                };
                var resultName = userService.CheckRegisterUser(user.UserName);
                bool exist = resultName.HasRows;
                resultName.Close();
                if (exist)
                {
                    Response.Write("<script>alert('该用户已注册，请使用其他用户名！');</script>");
                }
                else
                {
                    var perform = userService.AddUser(user);
                    if (perform == 1)
                    {
                        Response.Redirect("Login.aspx");
                    }
                    else
                    {
                        Response.Write("<script>alert('注册失败！');</script>");
                    }
                }
            }
        }

        protected void PasswordRepeatText_TextChanged(object sender, EventArgs e)
        {

        }

        protected void PasswordTextRegister_TextChanged(object sender, EventArgs e)
        {

        }

        protected void EmailAddressText_TextChanged(object sender, EventArgs e)
        {

        }

        protected void UserNameTextRegister_TextChanged(object sender, EventArgs e)
        {

        }

        protected void CountryDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var countryId = Convert.ToInt32(CountryDropDownList.SelectedValue);
            var countryService = new CountryService();
            RegionDropDownList.DataSource = countryService.GetSelectRegion(countryId).DataSet;
            RegionDropDownList.DataTextField = "RegionName";
            RegionDropDownList.DataValueField = "Id";
            RegionDropDownList.DataBind();
            this.PasswordTextRegister.Attributes["value"] = PasswordTextRegister.Text.Trim();
            this.PasswordRepeatText.Attributes["value"] = PasswordRepeatText.Text.Trim();



        }

        protected void ToIndex_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }
    }
}
