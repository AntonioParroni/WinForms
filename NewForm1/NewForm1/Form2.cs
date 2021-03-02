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
        public partial class Form2 : Form
        {
            Product product;
            bool addnew = true;
            public Form2(bool addnew, Product product)
            {
                InitializeComponent();
                this.product = product;
                this.addnew = addnew;
                btnEditAddF2.Click += BtnEditAddF2_Click;
                btnCancelF2.Click += BtnCancelF2_Click;
                this.Load += Form2_Load;
            }

            private void Form2_Load(object sender, EventArgs e)
            {
                if (!addnew)
                {
                    Text = "Edit Goods";
                    nameTextBox.Text = product.Name;
                    specificationTextBox.Text = product.Specification;
                    descriptionTextBox.Text = product.Description;
                    priceTextBox.Text = product.Price.ToString();
                    addnew = true;
                }
            }

            private void BtnCancelF2_Click(object sender, EventArgs e)
            {
                Close();
            }

            private void BtnEditAddF2_Click(object sender, EventArgs e)
            {
                if (addnew)
                {
                    if (nameTextBox.Text == "" || specificationTextBox.Text == "" || descriptionTextBox.Text == "" || priceTextBox.Text == "")
                    {
                        MessageBox.Show("Fill all the fields", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    product.Name = nameTextBox.Text;
                    product.Specification = specificationTextBox.Text;
                    product.Description = descriptionTextBox.Text;
                    try
                    {
                        if (double.Parse(priceTextBox.Text) < 0)
                        {
                            MessageBox.Show("Price is below 0$", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        product.Price = double.Parse(priceTextBox.Text);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Inccorect Price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                this.DialogResult = DialogResult.OK;
            }
        }
    }
