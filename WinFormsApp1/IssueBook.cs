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
    public partial class IssueBook : Form
    {
        
        public IssueBook()
        {
            InitializeComponent();
        }

        private void IssueBook_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = LAZARUS-01; database = LibraryDatabase; Integrated security = True";
            SqlCommand issue = new SqlCommand();
            issue.Connection = con;

            con.Open();
            issue =new SqlCommand("select BookName from NewBook",con);
            SqlDataReader reader = issue.ExecuteReader();

            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    bookname.Items.Add(reader.GetString(i));
                }
            }
            reader.Close();
            con.Close();
        }

        int count;
        private void autofill_Click(object sender, EventArgs e)
        {
            if (studentid.Text != "")
            {
                string id = studentid.Text;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = LAZARUS-01; database = LibraryDatabase; Integrated security = True";
                SqlCommand search = new SqlCommand();
                search.Connection = con;

                con.Open();
                search.CommandText = "select * from Students where LibId = '"+id+"'";
                SqlDataAdapter adapter = new SqlDataAdapter(search);
                DataSet set = new DataSet();
                adapter.Fill(set);
                con.Close();

                con.Open();
                search.CommandText = "select count(LibID) from IssueBook where LibID = '" + id + "' and ReturnDate is null";
                SqlDataAdapter adapt = new SqlDataAdapter(search);
                DataSet set1 = new DataSet();
                adapt.Fill(set1);
                

                count = int.Parse(set1.Tables[0].Rows[0][0].ToString());


                if (set.Tables[0].Rows.Count != 0)
                {
                    stname.Text = set.Tables[0].Rows[0][1].ToString();
                    libID.Text = set.Tables[0].Rows[0][3].ToString();
                    pnumber.Text = set.Tables[0].Rows[0][4].ToString();
                }
                else
                {
                    stname.Clear();
                    libID.Clear();
                    pnumber.Clear();

                    MessageBox.Show("Invalid ID entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void fname_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (studentid.Text != "")
            {
                if(bookname.SelectedIndex != -1 && count <= 2)
                {
                    string sname = stname.Text;
                    Int64 libid = Int64.Parse(libID.Text);
                    Int64 phone = Int64.Parse(pnumber.Text);
                    string bkname = bookname.Text;
                    string issuedt = dateTimePicker1.Text;

                    String id = studentid.Text;
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "data source = LAZARUS-01; database = LibraryDatabase; Integrated security = True";
                    SqlCommand search = new SqlCommand();
                    search.Connection = con;

                    con.Open();
                    search.CommandText = "insert into IssueBook (StudentName,LibID,PhoneNo,BkName,IssueDate) values ('"+sname+"','"+libid+"','"+phone+"','"+bkname+"','"+issuedt+"')";
                    search.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Book issued successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Either no book selected or maximum number has been reached","No Book selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Enter a valid ID number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            studentid.Clear();
            stname.Clear();
            libID.Clear();
            pnumber.Clear();
           
            
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bookname_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void stname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
