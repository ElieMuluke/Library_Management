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
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void fname_TextChanged(object sender, EventArgs e)
        {

        }

        private void cancle_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("All unsaved data will be erased", "Are you sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (fname.Text != "" && lname.Text != "" && libid.Text != "" && pnumber.Text != "")
            {
                String firstname = fname.Text;
                String lastname = lname.Text;
                Int64 LibID = Int64.Parse(libid.Text);
                Int64 phone = Int64.Parse(pnumber.Text);

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = LAZARUS-01; database = LibraryDatabase; Integrated security = True";
                SqlCommand save = new SqlCommand();
                save.Connection = con;

                con.Open();
                save.CommandText = "insert into Students (FName,Lname,LibId,PhoneNO) values ('" + firstname + "','" + lastname + "','" + LibID + "','" + phone + "')";
                save.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Data saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                fname.Clear();
                lname.Clear();
                libid.Clear();
                pnumber.Clear();

            }
            else
            {
                MessageBox.Show("Empty field not accepted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {

        }

        private void libid_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lname_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pnumber_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
