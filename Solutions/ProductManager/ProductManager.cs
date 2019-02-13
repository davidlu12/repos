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
    public partial class ProductManager : Form
    {
        AddProduct addForm;
        public ProductManager()
        {
            InitializeComponent();
        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addForm = new AddProduct();
            addForm.Show();
            addForm.ProductCreated += new EventDelegate(this.addForm_ProductCreated);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addForm_ProductCreated(object sender, EventArgs e)
        {
            ProductEventArgs tmpArgs = (ProductEventArgs)e;
            Product tmpProduct = tmpArgs.Product;
            productListBox.Items.Add(tmpProduct);
        }

        private void productListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product tmpProduct = (Product)productListBox.SelectedItem;
            nameTextBox.Text = tmpProduct.Name;
            idTextBox.Text = tmpProduct.Id;
            detailsButton.Enabled = true;

        }

        private void detailsButton_Click(object sender, EventArgs e)
        {
            if (productListBox.SelectedItem == null)
                return;

            Product tmpProduct = (Product)productListBox.SelectedItem;
            addForm = new AddProduct();
            addForm.ShowProduct(tmpProduct);
            addForm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
