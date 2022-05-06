using Library_System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AllBooks bk = new AllBooks();
            bk.Show();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you wish to exit?","Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)== DialogResult.Yes) 
            {
                Application.Exit();
            } 
           
        }

        private void students_Click(object sender, EventArgs e)
        {
            Students form = new Students();
            form.Show();
        }

        private void borrow_Click(object sender, EventArgs e)
        {
            IssueBook form = new IssueBook();
            form.Show();
        }

        private void btnreturn_Click(object sender, EventArgs e)
        {
            ReturnBook form = new ReturnBook();
            form.Show();
        }
    }
}
