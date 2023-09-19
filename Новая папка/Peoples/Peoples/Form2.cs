using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Peoples
{
    public partial class Form2 : Form
    {
        private SQLiteConnection DB;
        public Form2()
        {
            InitializeComponent();
        }
        static class DataBase // строка подключения к БД
        {
            public static string ConnectionString = @"Data Source=db.db; Integrated Security=False; MultipleActiveResultSets=True";
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            DB = new SQLiteConnection(DataBase.ConnectionString);
            await DB.OpenAsync();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter("SELECT * FROM Peoples", DB);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();

            dataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            dataAdapter.Fill(ds, "Info");
            dataGridView1.DataSource = ds.Tables[0];
            // SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter("SELECT * FROM Photo", DB);
            //DataSet ds = new DataSet();
            //DataTable dt = new DataTable();

            // dataAdapter.Fill(dt);
            //  dataGridView1.DataSource = dt;
            // dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // dataAdapter.Fill(ds, "Info");
            // dataGridView1.DataSource = ds.Tables[0];

        }
}
}
