using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderBO;
using System.Data.SqlClient;
using System.Data;

namespace OrderDAL
{
    public class Orderdal
    {
        public int Add(Orderbo O)
        {
            SqlConnection con = new SqlConnection("server= intvmsql01; user id= pj01tms55_1718;password=tcstvm ; database=db01tms55_1718");
            con.Open();

            SqlCommand cmd = new SqlCommand("sp_insert1349205_2", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@itemname", O.Itemname);
            cmd.Parameters.AddWithValue("@qn", O.Quantityneeded);
            cmd.Parameters.AddWithValue("@tp", O.Total);
            cmd.Parameters.AddWithValue("@cname", O.Customername);
            cmd.Parameters.AddWithValue("@con", O.Contact);
            cmd.Parameters.AddWithValue("@e", O.Email);
            cmd.Parameters.AddWithValue("@od", DateTime.Now);
            cmd.Parameters.AddWithValue("@oid", 0);

            cmd.Parameters["@oid"].Direction = ParameterDirection.Output;

            int ra = cmd.ExecuteNonQuery();
            if (ra > 0)
            {
                int oid = Convert.ToInt32(cmd.Parameters["@oid"].Value);
                return oid;
            }
            else
            {
                return 0;
            }

        }

        public List<Orderbo> View()
        {
            SqlConnection con = new SqlConnection("server= intvmsql01; user id= pj01tms55_1718;password=tcstvm ; database=db01tms55_1718");
            con.Open();
            
            SqlCommand cmd = new SqlCommand("sp_view1349205", con);
            cmd.CommandType = CommandType.StoredProcedure;

            List<Orderbo> list = new List<Orderbo>();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Orderbo O = new Orderbo();
                O.Orderid = Convert.ToInt32(reader["orderid"]);
                O.Itemname = reader["ItemName"].ToString();
                O.Quantityneeded = Convert.ToInt32(reader["QuantityNeeded"]);
                O.Total = Convert.ToInt32(reader["TotalPrice"]);
                O.Customername = reader["CustomerName"].ToString();
                O.Contact = Convert.ToInt64(reader["Contact"]);
                O.Email = reader["Email"].ToString();
                O.Orderdate = Convert.ToDateTime(reader["OrderDate"]);
                O.Mandate = Convert.ToDateTime(reader["ManufacturingDate"]);

                list.Add(O);
            }
            return list;

        }

        public int delete(int oid)
        {
            SqlConnection con = new SqlConnection("server= intvmsql01; user id= pj01tms55_1718;password=tcstvm ; database=db01tms55_1718");
            con.Open();

            SqlCommand cmd = new SqlCommand("sp_delete1349205_1", con);          

            cmd.CommandType = CommandType.StoredProcedure;          
            cmd.Parameters.AddWithValue("@id1", oid);
            int r = cmd.ExecuteNonQuery();

            return r;
        }

        public Item itemDetails(string itemname)
        {
            SqlConnection con = new SqlConnection("server= intvmsql01; user id= pj01tms55_1718;password=tcstvm ; database=db01tms55_1718");
            con.Open();

            Item retItem = new Item();
            SqlCommand cmd = new SqlCommand("SELECT QuantityAvailable from tableitem1349205 where ItemName = '" + itemname + "'", con);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                retItem.Quantity = Convert.ToInt32(rdr["QuantityAvailable"]);
            }
            rdr.Close();

            cmd = new SqlCommand("SELECT Price from tableitem1349205 where itemName = '" + itemname + "'", con);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                retItem.ItemPrice = Convert.ToInt32(rdr["Price"]);
            }
            rdr.Close();
          
            return retItem;
        }
    }
}


