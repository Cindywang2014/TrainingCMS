using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Training.Web
{
    public partial class Login : System.Web.UI.Page
    {
        protected void UserNameTextLogin_TextChanged(object sender, EventArgs e)
        {
            if (UserNameTextLogin.Text.Trim() == "")
            {
                Response.Write("<script>alert('请注意：用户名不能为空！');</script>");
            }
        }

        protected void PasswordTextLogin_TextChanged(object sender, EventArgs e)
        {
            if (PasswordTextLogin.Text.Trim() == "")
            {
                Response.Write("<script>alert('请注意：密码不能为空！');</script>");
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void RegisterButtonLogin_Click(object sender, EventArgs e)
        {

        }

        
    }
}