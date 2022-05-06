
namespace Library_System
{
    partial class Addbook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Addbook));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbaddbook = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cancel = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.pdate = new System.Windows.Forms.DateTimePicker();
            this.quantity = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.TextBox();
            this.author = new System.Windows.Forms.TextBox();
            this.bookname = new System.Windows.Forms.TextBox();
            this.bkquantity = new System.Windows.Forms.Label();
            this.bkprice = new System.Windows.Forms.Label();
            this.bkpurchdate = new System.Windows.Forms.Label();
            this.bkauthor = new System.Windows.Forms.Label();
            this.bkname = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 385);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Wheat;
            this.panel1.Controls.Add(this.lbaddbook);
            this.panel1.Location = new System.Drawing.Point(221, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(415, 80);
            this.panel1.TabIndex = 1;
            // 
            // lbaddbook
            // 
            this.lbaddbook.AutoSize = true;
            this.lbaddbook.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbaddbook.Location = new System.Drawing.Point(139, 46);
            this.lbaddbook.Name = "lbaddbook";
            this.lbaddbook.Size = new System.Drawing.Size(110, 29);
            this.lbaddbook.TabIndex = 0;
            this.lbaddbook.Text = "Add Book";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.cancel);
            this.panel2.Controls.Add(this.save);
            this.panel2.Controls.Add(this.pdate);
            this.panel2.Controls.Add(this.quantity);
            this.panel2.Controls.Add(this.price);
            this.panel2.Controls.Add(this.author);
            this.panel2.Controls.Add(this.bookname);
            this.panel2.Controls.Add(this.bkquantity);
            this.panel2.Controls.Add(this.bkprice);
            this.panel2.Controls.Add(this.bkpurchdate);
            this.panel2.Controls.Add(this.bkauthor);
            this.panel2.Controls.Add(this.bkname);
            this.panel2.Location = new System.Drawing.Point(221, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(415, 376);
            this.panel2.TabIndex = 2;
            // 
            // cancel
            // 
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cancel.Location = new System.Drawing.Point(254, 258);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 34);
            this.cancel.TabIndex = 12;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // save
            // 
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.save.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.save.Location = new System.Drawing.Point(139, 258);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 34);
            this.save.TabIndex = 11;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.button1_Click);
            // 
            // pdate
            // 
            this.pdate.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pdate.Location = new System.Drawing.Point(159, 92);
            this.pdate.Name = "pdate";
            this.pdate.Size = new System.Drawing.Size(229, 26);
            this.pdate.TabIndex = 10;
            this.pdate.ValueChanged += new System.EventHandler(this.pdate_ValueChanged);
            // 
            // quantity
            // 
            this.quantity.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.quantity.Location = new System.Drawing.Point(159, 194);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(182, 26);
            this.quantity.TabIndex = 9;
            // 
            // price
            // 
            this.price.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.price.Location = new System.Drawing.Point(159, 142);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(182, 26);
            this.price.TabIndex = 8;
            // 
            // author
            // 
            this.author.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.author.Location = new System.Drawing.Point(159, 49);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(182, 26);
            this.author.TabIndex = 6;
            // 
            // bookname
            // 
            this.bookname.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bookname.Location = new System.Drawing.Point(159, 5);
            this.bookname.Name = "bookname";
            this.bookname.Size = new System.Drawing.Size(182, 26);
            this.bookname.TabIndex = 5;
            this.bookname.TextChanged += new System.EventHandler(this.bookname_TextChanged);
            // 
            // bkquantity
            // 
            this.bkquantity.AutoSize = true;
            this.bkquantity.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bkquantity.Location = new System.Drawing.Point(10, 199);
            this.bkquantity.Name = "bkquantity";
            this.bkquantity.Size = new System.Drawing.Size(96, 18);
            this.bkquantity.TabIndex = 4;
            this.bkquantity.Text = "Book Quantity";
            // 
            // bkprice
            // 
            this.bkprice.AutoSize = true;
            this.bkprice.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bkprice.Location = new System.Drawing.Point(10, 147);
            this.bkprice.Name = "bkprice";
            this.bkprice.Size = new System.Drawing.Size(73, 18);
            this.bkprice.TabIndex = 3;
            this.bkprice.Text = "Book Price";
            // 
            // bkpurchdate
            // 
            this.bkpurchdate.AutoSize = true;
            this.bkpurchdate.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bkpurchdate.Location = new System.Drawing.Point(10, 98);
            this.bkpurchdate.Name = "bkpurchdate";
            this.bkpurchdate.Size = new System.Drawing.Size(96, 18);
            this.bkpurchdate.TabIndex = 2;
            this.bkpurchdate.Text = "Purchase Date";
            // 
            // bkauthor
            // 
            this.bkauthor.AutoSize = true;
            this.bkauthor.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bkauthor.Location = new System.Drawing.Point(10, 54);
            this.bkauthor.Name = "bkauthor";
            this.bkauthor.Size = new System.Drawing.Size(85, 18);
            this.bkauthor.TabIndex = 1;
            this.bkauthor.Text = "Book Author";
            // 
            // bkname
            // 
            this.bkname.AutoSize = true;
            this.bkname.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bkname.Location = new System.Drawing.Point(10, 11);
            this.bkname.Name = "bkname";
            this.bkname.Size = new System.Drawing.Size(79, 18);
            this.bkname.TabIndex = 0;
            this.bkname.Text = "Book Name";
            // 
            // Addbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 381);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Addbook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Addbooks";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbaddbook;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label bkquantity;
        private System.Windows.Forms.Label bkprice;
        private System.Windows.Forms.Label bkpurchdate;
        private System.Windows.Forms.Label bkauthor;
        private System.Windows.Forms.Label bkname;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.DateTimePicker pdate;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.TextBox author;
        private System.Windows.Forms.TextBox bookname;
    }
}