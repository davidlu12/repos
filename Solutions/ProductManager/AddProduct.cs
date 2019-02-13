using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductManager
{
    public delegate void EventDelegate(object sender, EventArgs e);

    public partial class AddProduct : Form
    {
        public event EventDelegate ProductCreated;

        public AddProduct()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (!InputOK())
                return;

            string name = nameTextBox.Text;
            string id = idTextBox.Text;
            double price;
            int qty;

            bool success = double.TryParse(priceTextBox.Text, out price);
             success = int.TryParse(qtyTextBox.Text, out qty);

            Product tmpProduct = new Product(name, id, price, qty);
            ProductEventArgs tmpArgs = new ProductEventArgs(tmpProduct);

            ProductCreated(this, tmpArgs);

            ClearTextBoxes();
        }

        private void ClearTextBoxes()
        {
            nameTextBox.Clear();
            idTextBox.Clear();
            priceTextBox.Clear();
            qtyTextBox.Clear();
            idTextBox.Focus();
        }

        private bool InputOK()
        {
            bool inputOK = true;

            if (nameTextBox.Text == "" || idTextBox.Text == "")
            {
                MessageBox.Show("Product Name and ID are required.");
                inputOK = false;
            }

            if (priceTextBox.Text != "")
                inputOK = IsTextBoxNumeric(priceTextBox);

            if (qtyTextBox.Text != "")
                inputOK = IsTextBoxNumeric(qtyTextBox);

            if (!inputOK)
                MessageBox.Show("Price and Quantity must be valid numbers.");

            return inputOK;
        }

        private bool IsTextBoxNumeric(TextBox t)
        {
            
            double number = 0;
            bool success = false;
            success = double.TryParse(t.Text, out number);
            return success;
        }

        public void ShowProduct(Product p)
        {
            nameTextBox.Text = p.Name;
            idTextBox.Text = p.Id;
            priceTextBox.Text = p.Price.ToString();
            qtyTextBox.Text = p.Quantity.ToString();

            this.Text = "Product Details";
            addButton.Visible = false;

        }

    }
}
