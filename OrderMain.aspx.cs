using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OrderBO;
using OrderDAL;

namespace OrderUI
{
    public partial class Ordermain : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            this.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string itemname = TextBox1.Text;
            int qn = Convert.ToInt32(TextBox2.Text);
            string custname = TextBox3.Text;
            long mobno = Convert.ToInt64(TextBox4.Text);
            string email = TextBox5.Text;
            int total=0;            

            Orderdal d = new Orderdal();
            
            Item iobj = d.itemDetails(itemname);
            Response.Write("<script>alert('Item Price is" + iobj.ItemPrice + "')</script>");
            total = (Convert.ToInt32(iobj.ItemPrice) * qn);


            if (iobj.Quantity < qn)
            {
                Response.Write("<script>alert('This quantity is not available for this item. Max available is " + iobj.Quantity + "')</script>");
            }
            else
            {
                
                tp.Text = "" + total;
                Orderbo o = new Orderbo(itemname, qn, custname, mobno, email, total);           
               
                int o_id = d.Add(o);
                if (o_id > 0)
                {
                    oid.Text = "" + o_id;
                    
                }                
            }      
           
        }
       
    }
}
