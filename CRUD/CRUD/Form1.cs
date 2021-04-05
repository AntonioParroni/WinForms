/*Довольно долго мучался с этой домашкой и созданием более динамического и лаконичного подхода к ней.
Но кажется, что в данном случае, прийдется прописывать для каждой отдельной таблицы (которых у меня больше чем трех) 
собственную логику обработки всего, плюс индивидуальное добавление и редактирование для каждой. 
Мне просто лень, извините. Кажется принцип я понял. Но если конечно есть способ сделать все это намного проще.. 
я бы хотел это узнать.

Используем на db.МояТаблица.Find(id);
И вызываем соответсвующие CRUD методы db.МояТаблица.Remove(x);
db.SaveChanges();*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{
    public partial class Form1 : Form
    {

        public AcademyEntities db; 
        public Form1()
        {
            InitializeComponent();
            
            label1.Hide();
            listBox1.Hide();
            CreateButton.Hide();
            UpdateButton.Hide();
            DeleteButton.Hide();

            db = new AcademyEntities();
            
            /*db.Curators.Load();

            dataGridView1.DataSource = db.Curators.Local.ToBindingList();*/


            /*  var tableNames = db.MetadataWorkspace.GetItems(DataSpace.SSpace)
                          .Select(t => t.Name)
                          .ToList();
            DbSet dbSet = db.;*/


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           db = new AcademyEntities();

            listBox1.Show();
            
            var metadata = ((IObjectContextAdapter)(DbContext)db).ObjectContext.MetadataWorkspace;
            var tables = metadata.GetItemCollection(DataSpace.SSpace)
                .GetItems<EntityContainer>()
                .Single()
                .BaseEntitySets
                .OfType<EntitySet>()
                .Where(s => !s.MetadataProperties.Contains("Type")
                || s.MetadataProperties["Type"].ToString() == "Tables");

            listBox1.DataSource = tables.ToList();
            
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CreateButton.Show();
            DeleteButton.Show();
            UpdateButton.Show();
            string categoryName = listBox1.SelectedItem.ToString();

            //Type returnType;
            switch (categoryName)
            {
                case "Curators":
                    db.Curators.Load();
                    dataGridView1.DataSource = db.Curators.Local.ToBindingList();
                    break;
                case "Departments":
                    db.Departments.Load();
                    dataGridView1.DataSource = db.Departments.Local.ToBindingList();
                    break;
                case "Faculties":
                    db.Faculties.Load();
                    dataGridView1.DataSource = db.Faculties.Local.ToBindingList();
                    break;
                case "Groups":
                    db.Groups.Load();
                    dataGridView1.DataSource = db.Groups.Local.ToBindingList();
                    break;
                case "GroupsCurators":
                    db.GroupsCurators.Load();
                    dataGridView1.DataSource = db.GroupsCurators.Local.ToBindingList();
                    break;
                case "GroupsLectures":
                    db.GroupsLectures.Load();
                    dataGridView1.DataSource = db.GroupsLectures.Local.ToBindingList();
                    break;
                case "Lectures":
                    db.Lectures.Load();
                    dataGridView1.DataSource = db.Lectures.Local.ToBindingList();
                    break;
                case "Subjects":
                    db.Subjects.Load();
                    dataGridView1.DataSource = db.Subjects.Local.ToBindingList();
                    break;
                case "Teachers":
                    db.Teachers.Load();
                    dataGridView1.DataSource = db.Teachers.Local.ToBindingList();
                    break; 
            }
            /*
            db.Set(returnType);
            dataGridView1.DataSource = db.GetTableType(categoryName).Local;
            dataGridView1.DataSource = db.Curators.Local.ToBindingList();

            var dt = new DataTable();
            var conn = db.Database.Connection;
            var connectionState = conn.State;
                if (connectionState != ConnectionState.Open) 
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = $"SELECT * FROM {categoryName}";
                    using (var reader = cmd.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }
            dataGridView1.DataSource = dt;


            button2.Show();
            var dynamicTableType = Type.GetType(categoryName);
            dataGridView1.DataSource = db.Set(dynamicTableType.GetType);
            DbSet asd = new DbSet();
            db.Curators.Local.tob*/


        }

        private void button2_Click(object sender, EventArgs e)
        {
            db.SaveChanges();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}


