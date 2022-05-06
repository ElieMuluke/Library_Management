using Library_System;
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

namespace WinFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void psswd_TextChanged(object sender, EventArgs e)
        {

        }

        private void psswd_MouseClick(object sender, MouseEventArgs e)
        {
            if (psswd.Text == "Password")
            {
                psswd.Clear();
                psswd.PasswordChar = '*';
            }
        }

        private void usnm_MouseClick(object sender, MouseEventArgs e)
        {
            if (usnm.Text == "Username")
            {
                usnm.Clear();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://web.facebook.com/friscolibrary");
        }

        private void picboxig_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/friscolibrary/");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection mycon = new SqlConnection();
            mycon.ConnectionString = "data source = LAZARUS-01; database = LibraryDatabase; Integrated Security = True";
            SqlCommand mycmd = new SqlCommand();
            mycmd.Connection = mycon;
            mycmd.CommandText = "select * from LoginTable where Username = '"+usnm.Text+"' and pass = '"+psswd.Text+"'";
            SqlDataAdapter adapter = new SqlDataAdapter(mycmd);
            DataSet set = new DataSet();

            adapter.Fill(set);

            if (set.Tables[0].Rows.Count !=0)
            {
                this.Hide();
                Home form = new Home();
                form.Show();
            }
            else
            {
                MessageBox.Show("Wrong Username or Passwprd", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void usnm_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsignup_Click(object sender, EventArgs e)
        {
            this.SendToBack();
            Register form = new Register();
            form.Show();
        }
    }
}
