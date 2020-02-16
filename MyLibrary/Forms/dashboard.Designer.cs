using System;

namespace MyLibrary.Forms
{
    partial class dashboardForm
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
            this.btnGoOrders = new System.Windows.Forms.Button();
            this.dtGrdBooks = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddBookDashb = new System.Windows.Forms.Button();
            this.btnAddCustomerDashb = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGoOrders
            // 
            this.btnGoOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoOrders.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnGoOrders.Location = new System.Drawing.Point(47, 12);
            this.btnGoOrders.Name = "btnGoOrders";
            this.btnGoOrders.Size = new System.Drawing.Size(113, 105);
            this.btnGoOrders.TabIndex = 0;
            this.btnGoOrders.Text = "Order";
            this.btnGoOrders.UseVisualStyleBackColor = true;
            this.btnGoOrders.Click += new System.EventHandler(this.btnGoOrders_Click);
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
            this.dtGrdBooks.Location = new System.Drawing.Point(2, 123);
            this.dtGrdBooks.Name = "dtGrdBooks";
            this.dtGrdBooks.Size = new System.Drawing.Size(649, 197);
            this.dtGrdBooks.TabIndex = 12;
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
            // AddBookDashb
            // 
            this.AddBookDashb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBookDashb.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.AddBookDashb.Location = new System.Drawing.Point(275, 12);
            this.AddBookDashb.Name = "AddBookDashb";
            this.AddBookDashb.Size = new System.Drawing.Size(107, 105);
            this.AddBookDashb.TabIndex = 13;
            this.AddBookDashb.Text = "Add Book";
            this.AddBookDashb.UseVisualStyleBackColor = true;
            this.AddBookDashb.Click += new System.EventHandler(this.AddBookDashb_Click);
            // 
            // btnAddCustomerDashb
            // 
            this.btnAddCustomerDashb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCustomerDashb.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnAddCustomerDashb.Location = new System.Drawing.Point(508, 12);
            this.btnAddCustomerDashb.Name = "btnAddCustomerDashb";
            this.btnAddCustomerDashb.Size = new System.Drawing.Size(118, 105);
            this.btnAddCustomerDashb.TabIndex = 14;
            this.btnAddCustomerDashb.Text = "Add Customer";
            this.btnAddCustomerDashb.UseVisualStyleBackColor = true;
            this.btnAddCustomerDashb.Click += new System.EventHandler(this.btnAddCustomerDashb_Click);
            // 
            // dashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(101)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(652, 321);
            this.Controls.Add(this.btnAddCustomerDashb);
            this.Controls.Add(this.AddBookDashb);
            this.Controls.Add(this.dtGrdBooks);
            this.Controls.Add(this.btnGoOrders);
            this.Name = "dashboardForm";
            this.Text = "dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdBooks)).EndInit();
            this.ResumeLayout(false);

        }



        #endregion

        private System.Windows.Forms.Button btnGoOrders;
        private System.Windows.Forms.DataGridView dtGrdBooks;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button AddBookDashb;
        private System.Windows.Forms.Button btnAddCustomerDashb;
    }
}