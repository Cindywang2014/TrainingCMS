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
                var countryService = new CountryService();
                var resultCountry = countryService.GetCountries();
                CountryDropDownList.DataSource = resultCountry;
                CountryDropDownList.DataTextField = "CountryName";
                CountryDropDownList.DataValueField = "Id";
                CountryDropDownList.DataBind();

                //var regionService = new RegionService();
                //var resultRegion = regionService.GetRegions();
                //CountryDropDownList.DataSource = resultRegion;
                //RegionDropDownList.DataTextField = "RegionName";
                //RegionDropDownList.DataValueField = "Id";
                //RegionDropDownList.DataBind();
            }
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
                    //Region = RegionDropDownList.SelectedItem.Text,
                    Region = TextBox1.Text,
                };
                var resultName = userService.CheckRegisterUser(user.UserName);
                resultName.Read();
                bool exist = resultName.HasRows;
                resultName.Close();

                if (exist)
                {
                    Response.Write("<script>alert('该用户已注册，请使用其他用户名！');</script>");
                }
                else
                {
                    userService.AddUser(user);
                    Response.Write("<script>alert('注册成功！');</script>");
                }
            }
        }

        public bool CheckTextbox()
        {
            bool satisfyThree = false;
            Regex regemail = new Regex(@"^[\w-]+(\.[\w-]+)*@[\w-]+(\.[\w-]+)+$");
            if (string.IsNullOrWhiteSpace(UserNameTextRegister.Text.Trim()) || string.IsNullOrWhiteSpace(PasswordTextRegister.Text.Trim()))
            {
                UserWrong.Visible = true;
                UserWrong.Text = "请注意：密码或用户名不能为空！";
                return satisfyThree;
            }

            if (!PasswordTextRegister.Text.Equals(PasswordRepeatText.Text))
            {
                PasswordWrong.Visible = true;
                PasswordWrong.Text = "请注意：两次密码不一致！";
                return satisfyThree;
            }
            if (!regemail.IsMatch(EmailAddressText.Text))
            {
                EmailWrong.Visible = true;
                EmailWrong.Text = "请注意：请填写正确的Email地址！";
                return satisfyThree;
            }
            return satisfyThree=true;
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
    }
}
