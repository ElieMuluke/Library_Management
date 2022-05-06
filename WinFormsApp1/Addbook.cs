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
    public partial class Addbook : Form
    {
        public Addbook()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bookname.Text != "" && author.Text != "" && price.Text != "" && quantity.Text != "")
            {
                String BookName = bookname.Text;
                String bauthor = author.Text;
                String purdate = pdate.Text;
                Int64 bprice = Int64.Parse(price.Text);
                Int64 bquantity = Int64.Parse(quantity.Text);

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = LAZARUS-01; database = LibraryDatabase; Integrated security = True";
                SqlCommand save = new SqlCommand();
                save.Connection = con;

                con.Open();
                save.CommandText = "insert into NewBook (BookName,Author,PDate,Price,Quantity) values ('" + BookName + "','" + bauthor + "','" + purdate + "','" + bprice + "','" + bquantity + "')";
                save.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Data saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                bookname.Clear();
                author.Clear();
                price.Clear();
                quantity.Clear();

            }
            else
            {
                MessageBox.Show("Empty field not accepted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("All unsaved data will be erased","Are you sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)==DialogResult.OK)
            {
                this.Close();
            }
            
        }

        private void bookname_TextChanged(object sender, EventArgs e)
        {

        }

        private void pdate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
