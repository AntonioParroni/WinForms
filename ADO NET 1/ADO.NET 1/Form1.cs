using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO.NET_1
{
    public partial class Form1 : Form
    {
        public string DBName { get; set; }
        public string ConnectionString { get; set; }
        
        public Form1()
        {
            InitializeComponent();
            comboBox1.Hide();
            textBox2.Hide();
            ConnectedTrueBox.Hide();
            ConnectedFalseBox.Hide();
            dataGridView1.Hide();
            statusBar1.Hide();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            try
            {
                connection.Open();
                ConnectedTrueBox.Show();
                
                SqlCommand cmd = new SqlCommand("SELECT * FROM INFORMATION_SCHEMA.TABLES" , connection);
                SqlDataReader reader = cmd.ExecuteReader();

                var dt = new DataTable();
                dt.Load(reader);
                List<DataRow> dr = dt.AsEnumerable().ToList();
                
                foreach (var row in dr)
                {
                    comboBox1.Items.Add(row["TABLE_NAME"]);
                }
                
                comboBox1.Show();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                ConnectedFalseBox.Show();
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DBName = richTextBox1.Text;
                ConnectionString = "Server=localhost;Database=";
                ConnectionString += DBName;
                ConnectionString += ";Trusted_Connection=True;";
            }
            catch (Exception)
            {
                MessageBox.Show("Error Parsing Connection String!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedTableName = comboBox1.SelectedItem.ToString();

            SqlConnection connection = new SqlConnection(ConnectionString);
            try
            {
                connection.Open();
                ConnectedTrueBox.Show();
                
                SqlCommand cmd = new SqlCommand($"SELECT * FROM {selectedTableName}" , connection);
                SqlDataReader reader = cmd.ExecuteReader();

                var dt = new DataTable();
                dt.Load(reader);

                dataGridView1.DataSource = dt;

                statusBar1.Text = "This Table Contains " + dt.Rows.Count + " Rows";
                dataGridView1.Show();
                statusBar1.Show();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                ConnectedFalseBox.Show();
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
    }
}