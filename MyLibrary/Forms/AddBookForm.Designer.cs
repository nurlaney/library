namespace MyLibrary.Forms
{
    partial class AddBookForm
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
            this.txtcBookName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblcGenre = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lblcAuthor = new System.Windows.Forms.Label();
            this.btncAddGenre = new System.Windows.Forms.Button();
            this.btncAddAuthor = new System.Windows.Forms.Button();
            this.btncAddBook = new System.Windows.Forms.Button();
            this.nmrcPrice = new System.Windows.Forms.NumericUpDown();
            this.lblcPrice = new System.Windows.Forms.Label();
            this.dtGrdBooks = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // txtcBookName
            // 
            this.txtcBookName.Location = new System.Drawing.Point(12, 28);
            this.txtcBookName.Name = "txtcBookName";
            this.txtcBookName.Size = new System.Drawing.Size(196, 20);
            this.txtcBookName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Book Name";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(13, 75);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(195, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // lblcGenre
            // 
            this.lblcGenre.AutoSize = true;
            this.lblcGenre.Location = new System.Drawing.Point(12, 59);
            this.lblcGenre.Name = "lblcGenre";
            this.lblcGenre.Size = new System.Drawing.Size(36, 13);
            this.lblcGenre.TabIndex = 3;
            this.lblcGenre.Text = "Genre";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "AAA BBB"});
            this.comboBox2.Location = new System.Drawing.Point(13, 126);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(195, 21);
            this.comboBox2.TabIndex = 4;
            // 
            // lblcAuthor
            // 
            this.lblcAuthor.AutoSize = true;
            this.lblcAuthor.Location = new System.Drawing.Point(13, 107);
            this.lblcAuthor.Name = "lblcAuthor";
            this.lblcAuthor.Size = new System.Drawing.Size(38, 13);
            this.lblcAuthor.TabIndex = 5;
            this.lblcAuthor.Text = "Author";
            // 
            // btncAddGenre
            // 
            this.btncAddGenre.Location = new System.Drawing.Point(214, 75);
            this.btncAddGenre.Name = "btncAddGenre";
            this.btncAddGenre.Size = new System.Drawing.Size(47, 23);
            this.btncAddGenre.TabIndex = 6;
            this.btncAddGenre.Text = "Add G";
            this.btncAddGenre.UseVisualStyleBackColor = true;
            this.btncAddGenre.Click += new System.EventHandler(this.btncAddGenre_Click);
            // 
            // btncAddAuthor
            // 
            this.btncAddAuthor.Location = new System.Drawing.Point(214, 124);
            this.btncAddAuthor.Name = "btncAddAuthor";
            this.btncAddAuthor.Size = new System.Drawing.Size(47, 23);
            this.btncAddAuthor.TabIndex = 7;
            this.btncAddAuthor.Text = "Add A";
            this.btncAddAuthor.UseVisualStyleBackColor = true;
            this.btncAddAuthor.Click += new System.EventHandler(this.btncAddAuthor_Click);
            // 
            // btncAddBook
            // 
            this.btncAddBook.Location = new System.Drawing.Point(168, 163);
            this.btncAddBook.Name = "btncAddBook";
            this.btncAddBook.Size = new System.Drawing.Size(93, 45);
            this.btncAddBook.TabIndex = 8;
            this.btncAddBook.Text = "Add Book";
            this.btncAddBook.UseVisualStyleBackColor = true;
            this.btncAddBook.Click += new System.EventHandler(this.btncAddBook_Click);
            // 
            // nmrcPrice
            // 
            this.nmrcPrice.Location = new System.Drawing.Point(12, 179);
            this.nmrcPrice.Name = "nmrcPrice";
            this.nmrcPrice.Size = new System.Drawing.Size(120, 20);
            this.nmrcPrice.TabIndex = 9;
            // 
            // lblcPrice
            // 
            this.lblcPrice.AutoSize = true;
            this.lblcPrice.Location = new System.Drawing.Point(12, 163);
            this.lblcPrice.Name = "lblcPrice";
            this.lblcPrice.Size = new System.Drawing.Size(13, 13);
            this.lblcPrice.TabIndex = 10;
            this.lblcPrice.Text = "$";
            // 
            // dtGrdBooks
            // 
            this.dtGrdBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGrdBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dtGrdBooks.Location = new System.Drawing.Point(267, 12);
            this.dtGrdBooks.Name = "dtGrdBooks";
            this.dtGrdBooks.Size = new System.Drawing.Size(328, 197);
            this.dtGrdBooks.TabIndex = 11;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Book Name";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Genre";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Author";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Price";
            this.Column4.Name = "Column4";
            // 
            // AddBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 212);
            this.Controls.Add(this.dtGrdBooks);
            this.Controls.Add(this.lblcPrice);
            this.Controls.Add(this.nmrcPrice);
            this.Controls.Add(this.btncAddBook);
            this.Controls.Add(this.btncAddAuthor);
            this.Controls.Add(this.btncAddGenre);
            this.Controls.Add(this.lblcAuthor);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.lblcGenre);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcBookName);
            this.Name = "AddBookForm";
            this.Text = "Add Book";
            ((System.ComponentModel.ISupportInitialize)(this.nmrcPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcBookName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblcGenre;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lblcAuthor;
        private System.Windows.Forms.Button btncAddGenre;
        private System.Windows.Forms.Button btncAddAuthor;
        private System.Windows.Forms.Button btncAddBook;
        private System.Windows.Forms.NumericUpDown nmrcPrice;
        private System.Windows.Forms.Label lblcPrice;
        private System.Windows.Forms.DataGridView dtGrdBooks;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}