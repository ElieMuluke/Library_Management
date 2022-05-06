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
    public partial class ReturnBook : Form
    {
        public ReturnBook()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (libraryid.Text == "")
            {
                panel3.Visible = false;
                dataGridView1.DataSource = null;
            }
        }

        private void search_Click(object sender, EventArgs e)
        {
            string libid = libraryid.Text;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = LAZARUS-01; database = LibraryDatabase; Integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            con.Open();
            cmd.CommandText = "select * from IssueBook where LibID = '" + libid + "' and ReturnDate is NULL";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);


            if (ds.Tables[0].Rows.Count != 0)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Invalid LibID or No Book Issued", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                libraryid.Clear();
            }
        }

        private void ReturnBook_Load(object sender, EventArgs e)
        {
            panel3.Visible = false;
            libraryid.Clear();
        }
        string bname;
        string issdate;
        Int64 rowid;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panel3.Visible = true;

            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                rowid = Int64.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                bname = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                issdate = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
            bkname.Text = bname;
            issuedate.Text = issdate;
        }

        private void btnreturn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = LAZARUS-01; database = LibraryDatabase; Integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            con.Open();
            cmd.CommandText = "update IssueBook set ReturnDate = '"+returndate.Text+"' where LibID = '"+libraryid.Text+ "'";
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Book returned successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ReturnBook_Load(this,null);
           
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            libraryid.Clear();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}