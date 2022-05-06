
namespace WinFormsApp1
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.books = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnreturn = new System.Windows.Forms.Button();
            this.borrow = new System.Windows.Forms.Button();
            this.students = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // books
            // 
            this.books.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.books.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.books.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.books.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.books.Image = ((System.Drawing.Image)(resources.GetObject("books.Image")));
            this.books.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.books.Location = new System.Drawing.Point(44, 46);
            this.books.Name = "books";
            this.books.Size = new System.Drawing.Size(111, 58);
            this.books.TabIndex = 0;
            this.books.Text = "Books";
            this.books.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.books.UseVisualStyleBackColor = false;
            this.books.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnexit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnexit.Image = ((System.Drawing.Image)(resources.GetObject("btnexit.Image")));
            this.btnexit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnexit.Location = new System.Drawing.Point(635, 45);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(96, 58);
            this.btnexit.TabIndex = 1;
            this.btnexit.Text = "Exit";
            this.btnexit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnreturn
            // 
            this.btnreturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnreturn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnreturn.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnreturn.Image = ((System.Drawing.Image)(resources.GetObject("btnreturn.Image")));
            this.btnreturn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnreturn.Location = new System.Drawing.Point(479, 46);
            this.btnreturn.Name = "btnreturn";
            this.btnreturn.Size = new System.Drawing.Size(111, 58);
            this.btnreturn.TabIndex = 2;
            this.btnreturn.Text = "Reaturn";
            this.btnreturn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnreturn.UseVisualStyleBackColor = false;
            this.btnreturn.Click += new System.EventHandler(this.btnreturn_Click);
            // 
            // borrow
            // 
            this.borrow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.borrow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.borrow.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.borrow.Image = ((System.Drawing.Image)(resources.GetObject("borrow.Image")));
            this.borrow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.borrow.Location = new System.Drawing.Point(329, 46);
            this.borrow.Name = "borrow";
            this.borrow.Size = new System.Drawing.Size(111, 58);
            this.borrow.TabIndex = 3;
            this.borrow.Text = "Borrow";
            this.borrow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.borrow.UseVisualStyleBackColor = false;
            this.borrow.Click += new System.EventHandler(this.borrow_Click);
            // 
            // students
            // 
            this.students.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.students.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.students.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.students.Image = ((System.Drawing.Image)(resources.GetObject("students.Image")));
            this.students.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.students.Location = new System.Drawing.Point(177, 45);
            this.students.Name = "students";
            this.students.Size = new System.Drawing.Size(127, 58);
            this.students.TabIndex = 4;
            this.students.Text = "Students";
            this.students.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.students.UseVisualStyleBackColor = false;
            this.students.Click += new System.EventHandler(this.students_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1269, 681);
            this.Controls.Add(this.students);
            this.Controls.Add(this.borrow);
            this.Controls.Add(this.btnreturn);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.books);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button books;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnreturn;
        private System.Windows.Forms.Button borrow;
        private System.Windows.Forms.Button students;
    }
}