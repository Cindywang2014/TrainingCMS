using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Training.Domain;
using Training.Service;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Training.Web
{
    public partial class Login : System.Web.UI.Page
    {
       
        protected void RegisterButtonLogin_Click(object sender, EventArgs e)
        {
           
            
        }

        public bool CheckLogin() 
        {
            bool satisfyTwo = false;
            if ((UserNameTextLogin.Text.Trim().Length == 0) || (PasswordTextLogin.Text.Trim().Length==0)) 
            {
                UserWrong.Visible = true;
                UserWrong.Text = "请注意：密码和用户名不能为空！";
                return satisfyTwo;
            }
          return   satisfyTwo = true;
        }
        protected void LoginButton_Click(object sender, EventArgs e)
        {
            if (CheckLogin())
            {
                var user = new User
                {
                    UserName = UserNameTextLogin.Text,
                    Password = PasswordTextLogin.Text,
                };
                var userService = new UserService();
                var result = userService.CheckLogin(user.UserName, user.Password);
                bool exist = result.HasRows;
                result.Close();
                if (exist)
                {
                    Response.Write("<script>alert('登录成功！');</script>");
                }
                else
                {
                    Response.Write("<script>alert('用户名或者密码错误！');</script>");
                }
            }
        }

        protected void UserNameTextLogin_TextChanged(object sender, EventArgs e)
        {

        }

        protected void PasswordTextLogin_TextChanged(object sender, EventArgs e)
        {


        }

       

    }
}