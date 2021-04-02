using System;
using System.Threading;
using System.Windows.Forms;

namespace HomeWork
{
    public partial class Form2 : Form
    {
        public Form2()
            {
                InitializeComponent();
                this.MouseMove += MyMouseMove;
                this.MouseClick += MyMouseClick;
            }
            private void MyMouseClick(object sender, MouseEventArgs e)
            {
                string text = "";
                if (e.Button == MouseButtons.Left)
                {
                    if (ModifierKeys == Keys.Control)
                    {
                        Close();
                    }

                    if ((e.X < 10 || e.X > ClientSize.Width - 10) || (e.Y < 10 || e.Y > ClientSize.Height - 10))
                    {
                        text = "Клик снаружи";
                    }
                    else if ((e.X == 10 || e.X == ClientSize.Width - 10) || (e.Y == 10 || e.Y == ClientSize.Height - 10))
                    {
                        text = "Клик на границе";
                    }
                    else
                    {
                        text = "Клик внутри";
                    }
                    MessageBox.Show(text, "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (e.Button == MouseButtons.Right)
                {
                    Text = $"Размер области окна. Ширина = {ClientSize.Width}, Высота = {ClientSize.Height}";
                    Thread.Sleep(2000);
                }
            }
            private void MyMouseMove(object sender, MouseEventArgs e)
            {
                Text = $"X {e.X} - Y {e.Y}";  
            }

            private void button1_Click(object sender, EventArgs e)
            {
                this.Hide();
                Form3 f3 = new Form3();
                f3.ShowDialog();
            }
    }
}