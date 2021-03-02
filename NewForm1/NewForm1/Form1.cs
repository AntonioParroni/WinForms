using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewForm1
{
    public partial class Form1 : Form
    {
        public double TotalPrice { get; set; } = 0;
        List<Product> products = null;
        public Form1()
        {
            InitializeComponent();
            products = new List<Product>();
            
            
            btnAdd.Click += BtnAdd_Click;
            btnEdit.Click += BtnEdit_Click;
            productStock.SelectedIndexChanged += ProductStock_SelectedIndexChanged;
            btnAddList.Click += BtnAddList_Click;
        }

        private void BtnAddList_Click(object sender, EventArgs e)
        {
            try
            {
                ProductList.Items.Add(((Product)productStock.Items[productStock.SelectedIndex]).ToString());
                TotalPrice += ((Product)productStock.Items[productStock.SelectedIndex]).Price;
                if (ProductList.Items.Count > 0)
                {
                    allPriceProductLabel2.Visible = false;
                    allPriceProductLabel.Visible = true;
                    allPriceProduct.Visible = true;
                    labelAllPriceProduct.Visible = true;
                }
                allPriceProduct.Text = TotalPrice.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("No Goods Selection", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void ProductStock_SelectedIndexChanged(object sender, EventArgs e)
        {
            priceProduct.Text = ((Product)productStock.Items[productStock.SelectedIndex]).Price.ToString();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int tempNum = productStock.SelectedIndex;
                Product tempProduct = (Product)productStock.Items[tempNum];
                Form2 form2 = new Form2(false, tempProduct);
                form2.ShowDialog();
                productStock.Items.RemoveAt(tempNum);
                productStock.Items.Insert(tempNum, tempProduct);
                productStock.SelectedIndex = tempNum;
            }
            catch (Exception)
            {
                MessageBox.Show("No Goods Selection", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            products.Add(new Product());
            Form2 form2 = new Form2(true, products[products.Count - 1]);
            if (form2.ShowDialog() == DialogResult.OK)
            {
                productStock.Items.Add(products[products.Count - 1]);
                groupBoxProduct.Text = $"Items in Stock {productStock.Items.Count}";
            }
        }
    }
}
