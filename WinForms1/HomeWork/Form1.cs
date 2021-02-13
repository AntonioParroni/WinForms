using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork
{
    public partial class Form1 : Form
    {
        public int GuessedNumber { get; set; }
        public Form1()
        {
            InitializeComponent();
            // this.BackColor = Color.Aquamarine;
        }
        
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            //GuessedNumber = Convert.ToInt32(textBox1.Text);
        }

        private void richTextBox1_Validating(object sender, CancelEventArgs e)
        {
            /*if (Convert.ToInt32(textBox1.Text) < 0 || Convert.ToInt32(textBox1.Text) > 2000)
            {
                MessageBox.Show("Wrong Number, Try Again!");
            }
            else
                GuessedNumber = Convert.ToInt32(textBox1.Text);*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = richTextBox1.Text;
            int i = 0;
            try
            {
                i = Convert.ToInt32(str);
            }
            catch (Exception)
            {
                richTextBox1.Clear();
                richTextBox1.Focus();
                MessageBox.Show("Failed to convert");
                return;
            }
            
            if (i < 0 || i > 2000)
            {
                MessageBox.Show("Number out of range");
                richTextBox1.Clear();
                richTextBox1.Focus();
            }
            else
            {
                GuessedNumber = Convert.ToInt32(str);  
                GuessNumber(GuessedNumber);
            }
        }

        public void GuessNumber(int number)
        {
            int counter = 0;
            bool foundFlag = false;


            double searchNum = 1000;
            
            while (!foundFlag)
            {
                if (Math.Abs(searchNum - Convert.ToDouble(GuessedNumber)) < 0.2)
                {
                    MessageBox.Show("Guessed Your Number In " + counter + " iterations");
                    foundFlag = true;
                    richTextBox1.Clear();
                    richTextBox1.Focus();
                    break;
                }
                
                if (BiggerGuessIndication(searchNum))
                {
                    searchNum = searchNum + (searchNum / 2);
                }
                else
                {
                    searchNum = searchNum / 2; 
                }
                counter++;
            }
            
        }

        public bool BiggerGuessIndication(double num)
        {
            int number = Convert.ToInt32(num);
            if (GuessedNumber > number)
                return true;
            return false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }
        
        /*private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }*/
    }
}