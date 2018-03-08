using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OrderDAL;
using OrderUI;

namespace OrderUI
{
    public partial class OrderView : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Orderdal d = new Orderdal();
                GridView1.DataSource = d.View();
                GridView1.DataBind();
            }
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName.Equals("can"))
            {
               int i= Convert.ToInt32( e.CommandArgument);
                Orderdal O = new Orderdal();
                int r= O.delete(i);
                if (r > 0)
                {
                    GridView1.DataSource = O.View();
                    GridView1.DataBind();
                                                           
                }
                else
                {
                    Response.Write("<script>alert('Error')</script>");
                }
            }
        }
    }
}
