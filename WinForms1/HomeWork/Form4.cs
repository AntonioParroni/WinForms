using System;
using System.Drawing;
using System.Windows.Forms;

namespace HomeWork
{
    public partial class Form4 : Form
    {
         Label label;
        public Form4()
        {
            InitializeComponent();
            Text = "«Убегающий статик»";
            label = new Label();
            this.Load += FormLoad;
            this.MouseMove += FormMouseMove;
        }
        private void FormLoad(object sender, EventArgs e)
        {
            label.BorderStyle = BorderStyle.Fixed3D;
            label.Size = new Size(100, 70);
            label.Text = $"Static Box ;)";
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.AutoSize = false;
            label.ForeColor = Color.Black;
            label.BackColor = Color.Chartreuse;
            Controls.Add(label);
            LableCenter(label);
        }
        private void FormMouseMove(object sender, MouseEventArgs e)
        {
            if ((e.X > label.Location.X - 20 && e.X < label.Location.X + label.Width + 20) && (e.Y > label.Location.Y - 20 && e.Y < label.Location.Y + label.Height + 20))
            {
                if (e.X > label.Location.X - 20 && e.X < label.Location.X)
                {
                    label.Left += 10;
                }
                else if (e.X < label.Location.X + label.Width + 20 && e.X > label.Location.X + label.Width)
                {
                    label.Left -= 10;
                }
                else if (e.Y > label.Location.Y - 20 && e.Y < label.Location.Y)
                {
                    label.Top += 10;
                }
                else if (e.Y < label.Location.Y + label.Height + 20 && e.Y > label.Location.Y + label.Height)
                {
                    label.Top -= 10;
                }
                
                if ((label.Location.X < 0 || label.Location.X > ClientSize.Width - label.Width) || (label.Location.Y < 0 || label.Location.Y > ClientSize.Height - label.Height))
                {
                    LableCenter(label);
                }
            }
        }
        void LableCenter(Label lable) 
        {
            label.Left = (ClientSize.Width - label.Size.Width) / 2;
            label.Top = (ClientSize.Height - label.Size.Height) / 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f5 = new Form5();
            f5.ShowDialog();
        }
    }
}
