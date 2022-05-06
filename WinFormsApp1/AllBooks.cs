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
    public partial class AllBooks : Form
    {
        public AllBooks()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void addbook_Click(object sender, EventArgs e)
        {
            Addbook form = new Addbook();
            form.Show();
        }

        private void AllBooks_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-QOPRS00\\SQLEXPRESS;Initial Catalog=LibraryDatabase;Integrated Security=True";
            SqlCommand all = new SqlCommand();

            all.Connection = con;

            all.CommandText = "Select * from NewBook";
            SqlDataAdapter da = new SqlDataAdapter(all);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }
        int bid;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                bid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());

            }
        }

        private void searchbx_TextChanged(object sender, EventArgs e)
        {
            if(searchbx.Text != "")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-QOPRS00\\SQLEXPRESS;Initial Catalog=LibraryDatabase;Integrated Security=True";
                SqlCommand all = new SqlCommand();

                all.Connection = con;

                all.CommandText = "Select * from NewBook where BookName LIKE '"+ searchbx.Text + "%'";
                SqlDataAdapter da = new SqlDataAdapter(all);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-QOPRS00\\SQLEXPRESS;Initial Catalog=LibraryDatabase;Integrated Security=True";
                SqlCommand all = new SqlCommand();

                all.Connection = con;

                all.CommandText = "Select * from NewBook";
                SqlDataAdapter da = new SqlDataAdapter(all);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-QOPRS00\\SQLEXPRESS;Initial Catalog=LibraryDatabase;Integrated Security=True";
            SqlCommand all = new SqlCommand();

            all.Connection = con;

            all.CommandText = "Select * from NewBook";
            SqlDataAdapter da = new SqlDataAdapter(all);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
            searchbx.Clear();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("The selected data will be Deleted", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-QOPRS00\\SQLEXPRESS;Initial Catalog=LibraryDatabase;Integrated Security=True";
                SqlCommand delete = new SqlCommand();
                delete.Connection = con;

                con.Open();
                delete.CommandText = "delete from NewBook where ID = " + bid + "";
                SqlDataAdapter adapter = new SqlDataAdapter(delete);
                DataSet DS = new DataSet();
                adapter.Fill(DS);


            }
        }
    }
}
