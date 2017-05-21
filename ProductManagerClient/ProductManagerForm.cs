using ProductDatabase;
using ProductManagerClient.ProductServiceReference;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductManagerClient
{
    public partial class ProductManagerForm : Form
    {
        ProductServiceClient Client;
        public ProductManagerForm(ProductServiceClient client)
        {
            Client = client;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Product product = Client.GetProduct(int.Parse(textBox1.Text));
                if (product == null)
                    label2.Text = "Product with such id doesn't exist.";
                else
                    label2.Text = "Id: " + product.Id + " Name: " + product.Name + " Count: " + product.Count + " Price: " + product.Price;
            }
            catch(FormatException)
            {
                label2.Text = "Product with such id doesn't exist.\n Have you tried putting numbers as ID yet?";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool status = Client.DeleteProduct(int.Parse(textBox1.Text));
            if (status)
                label2.Text = "Product deleted.";
            else
                label2.Text = "Product not deleted.";
        }
    }
}
