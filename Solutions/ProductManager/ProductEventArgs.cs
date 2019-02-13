using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManager
{
    public class ProductEventArgs : EventArgs
    {
        private Product product;

        public ProductEventArgs(Product product)
        {
            this.product = product;
        }

        public Product Product
        {
            get
            {
                return product;
            }

            set
            {
                product = value;
            }
        }
    }
}
