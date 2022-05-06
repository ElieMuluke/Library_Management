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
using WinFormsApp1;

namespace Library_System
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void back_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("All unsaved data will be lost","Are you sure", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
                Login form = new Login();
                form.Show();
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            string conpass = conpsswd.Text;
            string pass = psswd.Text;

            if (conpass != pass)
            {
                MessageBox.Show("Passwords entered are not the same", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if(username.Text != "" && psswd.Text != "" && conpsswd.Text != "")
            {
                string uname = username.Text;
                
                

                SqlConnection con = new SqlConnection(); 
                con.ConnectionString = "Data Source=DESKTOP-QOPRS00\\SQLEXPRESS;Initial Catalog=LibraryDatabase;Integrated Security=True";
                SqlCommand save = new SqlCommand();
                save.Connection = con;

                con.Open();
                save.CommandText = "insert into LoginTable (Username, pass) values ('" + uname + "','" + pass + "')";
                save.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Sucessful data save", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);

                username.Clear();
                psswd.Clear();
                conpsswd.Clear();
            }
            else
            {
                MessageBox.Show("Empty fields not accepte", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void conpsswd_TextChanged(object sender, EventArgs e)
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

        private void conpsswd_MouseClick(object sender, MouseEventArgs e)
        {
            if (conpsswd.Text == "Confirm Password")
            {
                conpsswd.Clear();
                conpsswd.PasswordChar = '*';
            }
        }

        private void username_MouseClick(object sender, MouseEventArgs e)
        {
            if (username.Text == "Username")
            {
                username.Clear();
                
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
