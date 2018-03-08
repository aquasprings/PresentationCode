using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderBO
{
    public class Orderbo
    {
        int orderid;
        string itemname;
        int quantityneeded;
        string customername;
        long contact;
        string email;
        DateTime mandate;
        int qa;

        DateTime orderdate;
        int total;

        public int Orderid
        {
            get
            {
                return orderid;
            }

            set
            {
                orderid = value;
            }
        }

        public string Itemname
        {
            get
            {
                return itemname;
            }

            set
            {
                itemname = value;
            }
        }

        public int Quantityneeded
        {
            get
            {
                return quantityneeded;
            }

            set
            {
                quantityneeded = value;
            }
        }

        public string Customername
        {
            get
            {
                return customername;
            }

            set
            {
                customername = value;
            }
        }

        public long Contact
        {
            get
            {
                return contact;
            }

            set
            {
                contact = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public DateTime Orderdate
        {
            get
            {
                return orderdate;
            }

            set
            {
                orderdate = value;
            }
        }

        public int Total
        {
            get
            {
                return total;
            }

            set
            {
                total = value;
            }
        }

        public DateTime Mandate
        {
            get
            {
                return mandate;
            }

            set
            {
                mandate = value;
            }
        }

        public int Qa
        {
            get
            {
                return qa;
            }

            set
            {
                qa = value;
            }
        }

        public Orderbo(string itemname, int quantityneeded, string customername, long contact, string email)
        {
           
            this.Itemname = itemname;
            this.Quantityneeded = quantityneeded;
            this.Customername = customername;
            this.Contact = contact;
            this.Email = email;
        }

        
        public Orderbo(string itemname, int quantityneeded, string customername, long contact, string email, int total)
        {
            this.itemname = itemname;
            this.quantityneeded = quantityneeded;
            this.customername = customername;
            this.contact = contact;
            this.email = email;            
            this.total = total;
        }
        public Orderbo()
        { }
    }
    public class Item
    {
        int itemID;
        string itemName;
        double itemPrice;
        DateTime manufacturingDate;
        int quantity;

        public Item()
        {
        }

        public int ItemID
        {
            get
            {
                return itemID;
            }

            set
            {
                itemID = value;
            }
        }

        public string ItemName
        {
            get
            {
                return itemName;
            }

            set
            {
                itemName = value;
            }
        }

        public double ItemPrice
        {
            get
            {
                return itemPrice;
            }

            set
            {
                itemPrice = value;
            }
        }

        public DateTime ManufacturingDate
        {
            get
            {
                return manufacturingDate;
            }

            set
            {
                manufacturingDate = value;
            }
        }

        public int Quantity
        {
            get
            {
                return quantity;
            }

            set
            {
                quantity = value;
            }
        }
    }

}
