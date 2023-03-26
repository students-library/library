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

namespace library
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_library_kckcDataSet.Book' table. You can move, or remove it, as needed.
            this.bookTableAdapter.Fill(this._library_kckcDataSet.Book);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=library-kckc.mssql.somee.com;Initial Catalog=library-kckc;User ID=kacprodyl_SQLLogin_1;Password=ybqwxa2m4h;";
            string tableName = "Book";
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var adapter = new SqlDataAdapter($"SELECT * FROM {tableName}", connection);
                var builder = new SqlCommandBuilder(adapter);
                DataTable table = new DataTable();
                adapter.Fill(table);

                var newRow = table.NewRow();
                newRow["name"] = "Czary mary9";
                newRow["id_genre"] = 1;
                newRow["publisher"] = "Hokus Pokus9";
                table.Rows.Add(newRow);

                adapter.Update(table);
            }

        }
    }
}
