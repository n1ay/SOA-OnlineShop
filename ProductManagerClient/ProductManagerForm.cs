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
using static ProductManagerClient.AttributeFilter;

namespace ProductManagerClient
{
    public enum AttributeFilter {
        ID,
        NAME,
        COUNT,
        PRICE
    }

    public partial class ProductManagerForm : Form
    {
        int Filter;
        ProductServiceClient Client;
        public ProductManagerForm(ProductServiceClient client)
        {
            Client = client;
            InitializeComponent();
            Filter = (int)ID;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var panels = new List<Panel> { panelAdd, panelDelete, panelUpdate };
            var buttons = new List<Button> { buttonAdd, buttonDelete, buttonUpdate };

            foreach (Panel p in panels)
            {
                p.Top = panelGet.Top;
                p.Left = panelGet.Left;
            }

            foreach (Button b in buttons)
            {
                b.Top = buttonGet.Top;
                b.Left = buttonGet.Left;
            }

        }

        private void buttonGet_Click(object sender, EventArgs e)
        {
            try
            {
                List<Product> products = Client.GetAllProducts().ToList();
                switch (Filter)
                {
                    case (int)ID:
                        products = products.FindAll(x => x.Id == int.Parse(textBoxAttribute.Text));
                        break;
                    case (int)NAME:
                        products = products.FindAll(x => x.Name.Contains(textBoxAttribute.Text));
                        break;
                    case (int)COUNT:
                        products = products.FindAll(x => x.Count == int.Parse(textBoxAttribute.Text));
                        break;
                    case (int)PRICE:
                        products = products.FindAll(x => x.Price == float.Parse(textBoxAttribute.Text));
                        break;
                    default:
                        break;
                }

                if (products.Count < 1)
                {
                    labelInfo.Text = "Product with such attributes doesn't exist.";
                    productBindingSource.Clear();
                }
                else
                {
                    labelInfo.Text = products.Count + " product(s) found";
                    productBindingSource.Clear();
                    foreach (Product p in products)
                        productBindingSource.Add(p);
                }
            }
            catch(FormatException)
            {
                labelInfo.Text = "Product with such attributes doesn't exist / Wrong input format";
                productBindingSource.Clear();
            }
        }

        private void buttonGetAll_Click(object sender, EventArgs e)
        {
            List<Product> products = Client.GetAllProducts().ToList();
            if (products.Count <= 0)
                labelInfo.Text = "0 products found";
            else
            {
                labelInfo.Text = products.Count + " product(s) found";
                productBindingSource.Clear();
                foreach (Product p in products)
                    productBindingSource.Add(p);
            }
        }

        private void comboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            string attribute = (string)comboBox.SelectedItem;
            switch(attribute)
            {
                case "Id":
                    Filter = (int)ID;
                    break;
                case "Name":
                    Filter = (int)NAME;
                    break;
                case "Count":
                    Filter = (int)COUNT;
                    break;
                case "Price":
                    Filter = (int)PRICE;
                    break;
                default:
                    break;
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            productBindingSource.Clear();
            labelInfo.Text = "";
        }

        private void buttonMenuGet_Click(object sender, EventArgs e)
        {
            panelGet.Visible = true;
            panelAdd.Visible = false;
            panelUpdate.Visible = false;
            panelDelete.Visible = false;
        }

        private void buttonMenuAdd_Click(object sender, EventArgs e)
        {
            panelAdd.Visible = true;
            panelGet.Visible = false;
            panelUpdate.Visible = false;
            panelDelete.Visible = false;
        }

        private void buttonMenuUpdate_Click(object sender, EventArgs e)
        {
            panelUpdate.Visible = true;
            panelAdd.Visible = false;
            panelGet.Visible = false;
            panelDelete.Visible = false;
        }

        private void buttonMenuDelete_Click(object sender, EventArgs e)
        {
            panelDelete.Visible = true;
            panelAdd.Visible = false;
            panelUpdate.Visible = false;
            panelGet.Visible = false;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int deleted = 0;
            foreach(Product p in getDataFromBindingsSource())
            {
                if (Client.DeleteProduct(p.Id))
                    deleted++;
            }
            labelInfo.Text = "Deleted " + deleted + " product(s)";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int added = 0;
            foreach (Product p in getDataFromBindingsSource())
            {
                if (Client.AddProduct(p) > 0)
                    added++;
            }
            labelInfo.Text = "Added " + added + " product(s)";
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            int updated = 0;
            foreach (Product p in getDataFromBindingsSource())
            {
                if(Client.UpdateProduct(p) != null)
                {
                    updated++;
                }
            }
            labelInfo.Text = "Updated " + updated + " product(s)";
        }

        private List<Product> getDataFromBindingsSource()
        {
            List<Product> products = new List<Product>(productBindingSource.Count);
            foreach (object o in productBindingSource)
            {
                products.Add((Product)o);
            }
            return products;
        }

        private void dataGridViewWrongFormat(object sender, EventArgs e)
        {
            labelInfo.Text = "";
            MessageBox.Show("Wrong Format!", "Input data error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
