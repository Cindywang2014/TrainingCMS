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

        public void AddUser()
        {
            var user = new User
            {
                UserName = UserNameTextRegister.Text,
                Password = PasswordTextRegister.Text,
                EmailAddress = EmailAddressText.Text,
                Country = CountryDropDownList.SelectedItem.Text,
                //Region = RegionDropDownList.SelectedItem.Text,
                Region = TextBox1.Text,
            };

            var userService = new UserService();

            var result = userService.AddUser(user);
        }
        protected void RegisterButton_Click(object sender, EventArgs e)
        {

            AddUser();
            Response.Write("<script>alert('注册成功！');</script>");
            //Response.Write("<script>alert('注册失败！');</script>");
        }

        protected void UserNameTextRegister_TextChanged(object sender, EventArgs e)
        {
            //var userService = new UserService();

            //var result = userService.CheckRegisterUser();
            //result.
            //    reader.Read();  

            if (UserNameTextRegister.Text.Trim().Length == 0)
            {
                Response.Write("<script>alert('请注意：用户名不能为空！');</script>");
              
            }
            //else if (reader.HasRows)
            //{
            //    Response.Write("<script>alert('该用户已注册，请使用其他用户名！');</script>");
            //}
            
            
        }

        protected void PasswordTextRegister_TextChanged(object sender, EventArgs e)
        {
            if (PasswordTextRegister.Text.Trim().Length == 0)
            {
                Response.Write("<script>alert('请注意：密码不能为空！');</script>");
               
            }
            else if (PasswordTextRegister.Text.Trim().Length > 20)
            {
                Response.Write("<script>alert('请注意：密码的长度不能超过20！');</script>");
                
            }

        }

        protected void EmailAddressText_TextChanged(object sender, EventArgs e)
        {

            Regex regemail = new Regex(@"^[\w-]+(\.[\w-]+)*@[\w-]+(\.[\w-]+)+$");
            if (EmailAddressText.Text.Trim().Length == 0)
            {
                Response.Write("<script>alert('请注意：Email不能为空！');</script>");
               
            }
            else if (!regemail.IsMatch(EmailAddressText.Text))
            {
                Response.Write("<script>alert('请注意：请填写正确的Email地址！');</script>");
               

            }
        }

       
    }
}
