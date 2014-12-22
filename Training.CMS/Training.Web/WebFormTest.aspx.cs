using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Training.Web
{
    public partial class WebFormTest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnCallBack_Click(object sender, EventArgs e)
        {
            string js = string.Format("document.getElementById('{0}').value=confirm('是否确认?');document.getElementById('{1}').click();", hid.ClientID, btnHid.ClientID);
            ClientScript.RegisterStartupScript(GetType(), "confirm", js, true);

        }

        protected void btnHid_Click(object sender, EventArgs e)
        {
            string result = hid.Value.ToLower() == "true" ? "是" : "否";
            Response.Write(string.Format("您选择的是{0}", result));
            
        }
    }
}