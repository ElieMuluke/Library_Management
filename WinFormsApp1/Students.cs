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

namespace Library_System
{
    public partial class Students : Form
    {
        public Students()
        {
            InitializeComponent();
        }

        private void Students_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = LAZARUS-01; database = LibraryDatabase; Integrated Security = True";
            SqlCommand all = new SqlCommand();

            all.Connection = con;

            all.CommandText = "Select * from Students";
            SqlDataAdapter da = new SqlDataAdapter(all);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }

        int bid;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                bid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = LAZARUS-01; database = LibraryDatabase; Integrated Security = True";
                SqlCommand all = new SqlCommand();

                all.Connection = con;

                all.CommandText = "Select * from Students where FName LIKE '" + textBox1.Text + "%'";
                SqlDataAdapter da = new SqlDataAdapter(all);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = LAZARUS-01; database = LibraryDatabase; Integrated Security = True";
                SqlCommand all = new SqlCommand();

                all.Connection = con;

                all.CommandText = "Select * from Students";
                SqlDataAdapter da = new SqlDataAdapter(all);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = LAZARUS-01; database = LibraryDatabase; Integrated Security = True";
            SqlCommand all = new SqlCommand();

            all.Connection = con;

            all.CommandText = "Select * from Students";
            SqlDataAdapter da = new SqlDataAdapter(all);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
            textBox1.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnaddstdnt_Click(object sender, EventArgs e)
        {
            AddStudent form = new AddStudent();
            form.Show();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("The selected data will be Deleted", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = LAZARUS-01; database = LibraryDatabase; Integrated security = True";
                SqlCommand delete = new SqlCommand();
                delete.Connection = con;

                con.Open();
                delete.CommandText = "delete from Students where ID = "+ bid +"";
                SqlDataAdapter adapter = new SqlDataAdapter(delete);
                DataSet DS = new DataSet();
                adapter.Fill(DS);

               
            }

        }
    }
}
