using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManager
{
    public class Product
    {
        string name;
        string id;
        double price;
        int quantity;

        public Product()
        {
            this.name = "";
            this.id = "";
            this.price = 0;
            this.quantity = 0;
        }


        public Product(string name, string id, double price, int quantity)
        {
            this.name = name;
            this.id = id;
            this.price = price;
            this.quantity = quantity;
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public double Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
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

        public override string ToString()
        {
            return name;
        }
    }
}
