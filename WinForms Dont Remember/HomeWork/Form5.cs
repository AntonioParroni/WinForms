using System;
using System.Drawing;
using System.Windows.Forms;

namespace HomeWork
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            btnOk.Click += OkClick;
            btnReset.Click += ResetClick;
            inputTextBox.Enter += TextBoxEnter;
        }

        private void TextBoxEnter(object sender, EventArgs e)
        {
            label5.Visible = false;
            inputTextBox.BackColor = Color.White;
        }

        private void ResetClick(object sender, EventArgs e)
        {
            inputTextBox.Clear();
            resultTextBox.Clear();
            inputTextBox.BackColor = Color.White;
            label5.Visible = false;
            dateTimePicker.Value = DateTime.Now;

        }

        private void OkClick(object sender, EventArgs e)
        {
            if (inputTextBox.Text == "")
            {
                resultTextBox.Text = dateTimePicker.Value.Date.ToString("dddd").ToUpper();
                inputTextBox.Text = dateTimePicker.Value.ToShortDateString();
            }
            else
            {
                try
                {
                    DateTime day = new DateTime();
                    day = DateTime.Parse(inputTextBox.Text);
                    resultTextBox.Text = day.ToString("dddd").ToUpper();
                    
                    dateTimePicker.Value = day;
                }
                catch (Exception)
                {
                    label5.Visible = true;
                    inputTextBox.BackColor = Color.Blue; 
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 f6 = new Form6();
            f6.ShowDialog();
        }
    }
}
