using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Training.Web
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RegisterButton_Click(object sender, EventArgs e)
        {

        }

        protected void UserNameTextRegister_TextChanged(object sender, EventArgs e)
        {
            if (UserNameTextRegister.Text.Trim() == "")
            {
                Response.Write("<script>alert('请注意：用户名不能为空！');</script>");
            }
            else
            {

            }




        }

        protected void PasswordTextRegister_TextChanged(object sender, EventArgs e)
        {
            if (PasswordTextRegister.Text.Trim() == "")
            {
                Response.Write("<script>alert('请注意：密码不能为空！');</script>");
            }
            else if (PasswordTextRegister.Text.Trim().Length > 20)
            {
                Response.Write("<script>alert('请注意：密码的长度不能超过20！');</script>");
            }
            else
            {

            }
        }

        protected void EmailAddressText_TextChanged(object sender, EventArgs e)
        {
            Regex regemail = new Regex(@"^[\w-]+(\.[\w-]+)*@[\w-]+(\.[\w-]+)+$");
            if (EmailAddressText.Text.Trim() == "")
            {
                Response.Write("<script>alert('请注意：Email不能为空！');</script>");
            }
            else if (!regemail.IsMatch(EmailAddressText.Text))
            {
                Response.Write("请填写正确的Email地址!");
            }
            else
            {

            }

        }



    }
}
