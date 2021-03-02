using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewForm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            btnSearchF2.Click += Button1_Click;
        }
        
        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxF2.Text == "")
                {
                    MessageBox.Show("Insert mask", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                FolderBrowserDialog folder = new FolderBrowserDialog();
                if (folder.ShowDialog()==DialogResult.OK)
                {
                    string[] list = Directory.GetFiles(folder.SelectedPath, textBoxF2.Text, SearchOption.AllDirectories);
                    listBox.Items.Clear();
                    if (list.Length != 0)
                    {
                        foreach (var item in list)
                        {
                            listBox.Items.Add(item);
                        }
                    }
                    else MessageBox.Show($"No File Found", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error!" , "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /*private void listBox_Resize(object sender, EventArgs e)
        {
            MessageBox.Show("ASD!" , "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }*/
    }
}