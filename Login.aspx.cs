using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace OrderUI
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string uname = TextBox1.Text;
            string pass = TextBox1.Text;

            if (FormsAuthentication.Authenticate(uname,pass))
            {
                FormsAuthentication.RedirectFromLoginPage(uname,cb.Checked);
            }
            else
            {
                Response.Write("<script>alert('Invalid Login Credentials')</script>");
            }
        }
    }
}
