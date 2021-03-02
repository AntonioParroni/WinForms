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

namespace WindowsFormsDz_3_3
{
    public partial class Form1 : Form
    {
        public string TextBox_ReadFile
        {
            get { return textBoxReadFile.Text; }
            set { textBoxReadFile.Text = value; }
        }
        public Form1()
        {
            InitializeComponent();
            btnUpload.Click += FileUpload_Click;
            btnEdit.Click += FileEdit_Click;
            TextBox_ReadFile = "";
        }
        private void FileEdit_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.Show();
        }

        private void FileUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "All Files(*.*)|*.*|Txt files(*.txt)|*.txt";
            file.FilterIndex = 2;
            if (file.ShowDialog() == DialogResult.OK)
            {
                StreamReader reader = new StreamReader(file.FileName, Encoding.Default);
                textBoxReadFile.Clear();
                textBoxReadFile.Text = reader.ReadToEnd();
                reader.Close();
                btnEdit.Enabled = true;
            }
        }
    }
}
