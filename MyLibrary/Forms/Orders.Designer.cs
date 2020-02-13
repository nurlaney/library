namespace MyLibrary.Forms
{
    partial class Orders
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
            this.grpBxSrchCustomer = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSrchCustomer = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSrchName = new System.Windows.Forms.TextBox();
            this.txtSrchSurname = new System.Windows.Forms.TextBox();
            this.grbBxSrchBook = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpBxReport = new System.Windows.Forms.GroupBox();
            this.lblCountNumb = new System.Windows.Forms.Label();
            this.lblPriceNumb = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblReturnDate = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblBook = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.grpBxChekout = new System.Windows.Forms.GroupBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSrchBook = new System.Windows.Forms.TextBox();
            this.btnSendtoCard = new System.Windows.Forms.Button();
            this.btnSendOrder = new System.Windows.Forms.Button();
            this.grpBxSrchCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grbBxSrchBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.grpBxReport.SuspendLayout();
            this.grpBxChekout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBxSrchCustomer
            // 
            this.grpBxSrchCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(101)))), ((int)(((byte)(100)))));
            this.grpBxSrchCustomer.Controls.Add(this.label1);
            this.grpBxSrchCustomer.Controls.Add(this.label2);
            this.grpBxSrchCustomer.Controls.Add(this.btnSrchCustomer);
            this.grpBxSrchCustomer.Controls.Add(this.dataGridView1);
            this.grpBxSrchCustomer.Controls.Add(this.txtSrchName);
            this.grpBxSrchCustomer.Controls.Add(this.txtSrchSurname);
            this.grpBxSrchCustomer.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.grpBxSrchCustomer.Location = new System.Drawing.Point(1, 6);
            this.grpBxSrchCustomer.Name = "grpBxSrchCustomer";
            this.grpBxSrchCustomer.Size = new System.Drawing.Size(365, 262);
            this.grpBxSrchCustomer.TabIndex = 11;
            this.grpBxSrchCustomer.TabStop = false;
            this.grpBxSrchCustomer.Text = "Search Customer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(134, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Surname";
            // 
            // btnSrchCustomer
            // 
            this.btnSrchCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSrchCustomer.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnSrchCustomer.Location = new System.Drawing.Point(274, 57);
            this.btnSrchCustomer.Name = "btnSrchCustomer";
            this.btnSrchCustomer.Size = new System.Drawing.Size(75, 26);
            this.btnSrchCustomer.TabIndex = 10;
            this.btnSrchCustomer.Text = "Search";
            this.btnSrchCustomer.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(101)))), ((int)(((byte)(100)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.Location = new System.Drawing.Point(6, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(350, 149);
            this.dataGridView1.TabIndex = 6;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Name";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Surname";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Mail";
            this.Column3.Name = "Column3";
            // 
            // txtSrchName
            // 
            this.txtSrchName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtSrchName.Location = new System.Drawing.Point(6, 61);
            this.txtSrchName.Name = "txtSrchName";
            this.txtSrchName.Size = new System.Drawing.Size(125, 20);
            this.txtSrchName.TabIndex = 5;
            // 
            // txtSrchSurname
            // 
            this.txtSrchSurname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtSrchSurname.Location = new System.Drawing.Point(137, 61);
            this.txtSrchSurname.Name = "txtSrchSurname";
            this.txtSrchSurname.Size = new System.Drawing.Size(131, 20);
            this.txtSrchSurname.TabIndex = 7;
            // 
            // grbBxSrchBook
            // 
            this.grbBxSrchBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(101)))), ((int)(((byte)(100)))));
            this.grbBxSrchBook.Controls.Add(this.txtSrchBook);
            this.grbBxSrchBook.Controls.Add(this.comboBox1);
            this.grbBxSrchBook.Controls.Add(this.button1);
            this.grbBxSrchBook.Controls.Add(this.dataGridView2);
            this.grbBxSrchBook.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.grbBxSrchBook.Location = new System.Drawing.Point(1, 274);
            this.grbBxSrchBook.Name = "grbBxSrchBook";
            this.grbBxSrchBook.Size = new System.Drawing.Size(365, 266);
            this.grbBxSrchBook.TabIndex = 12;
            this.grbBxSrchBook.TabStop = false;
            this.grbBxSrchBook.Text = "Search Book";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Book Name",
            "Author",
            "Genre"});
            this.comboBox1.Location = new System.Drawing.Point(137, 43);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(138, 21);
            this.comboBox1.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(284, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 26);
            this.button1.TabIndex = 16;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(101)))), ((int)(((byte)(100)))));
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridView2.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.Location = new System.Drawing.Point(9, 71);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(350, 157);
            this.dataGridView2.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Book Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Author";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Genre";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // grpBxReport
            // 
            this.grpBxReport.Controls.Add(this.btnSendtoCard);
            this.grpBxReport.Controls.Add(this.lblCountNumb);
            this.grpBxReport.Controls.Add(this.lblPriceNumb);
            this.grpBxReport.Controls.Add(this.dateTimePicker1);
            this.grpBxReport.Controls.Add(this.lblReturnDate);
            this.grpBxReport.Controls.Add(this.lblCount);
            this.grpBxReport.Controls.Add(this.lblPrice);
            this.grpBxReport.Controls.Add(this.lblBook);
            this.grpBxReport.Controls.Add(this.lblCustomer);
            this.grpBxReport.Location = new System.Drawing.Point(372, 6);
            this.grpBxReport.Name = "grpBxReport";
            this.grpBxReport.Size = new System.Drawing.Size(200, 262);
            this.grpBxReport.TabIndex = 13;
            this.grpBxReport.TabStop = false;
            this.grpBxReport.Text = "Report";
            // 
            // lblCountNumb
            // 
            this.lblCountNumb.AutoSize = true;
            this.lblCountNumb.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblCountNumb.Location = new System.Drawing.Point(55, 133);
            this.lblCountNumb.Name = "lblCountNumb";
            this.lblCountNumb.Size = new System.Drawing.Size(13, 13);
            this.lblCountNumb.TabIndex = 8;
            this.lblCountNumb.Text = "3";
            // 
            // lblPriceNumb
            // 
            this.lblPriceNumb.AutoSize = true;
            this.lblPriceNumb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblPriceNumb.Location = new System.Drawing.Point(52, 98);
            this.lblPriceNumb.Name = "lblPriceNumb";
            this.lblPriceNumb.Size = new System.Drawing.Size(25, 13);
            this.lblPriceNumb.TabIndex = 7;
            this.lblPriceNumb.Text = "13$";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(85, 161);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(110, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // lblReturnDate
            // 
            this.lblReturnDate.AutoSize = true;
            this.lblReturnDate.Location = new System.Drawing.Point(8, 167);
            this.lblReturnDate.Name = "lblReturnDate";
            this.lblReturnDate.Size = new System.Drawing.Size(71, 13);
            this.lblReturnDate.TabIndex = 4;
            this.lblReturnDate.Text = "Return Date :";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(8, 133);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(41, 13);
            this.lblCount.TabIndex = 3;
            this.lblCount.Text = "Count :";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(7, 98);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(37, 13);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "Price :";
            // 
            // lblBook
            // 
            this.lblBook.AutoSize = true;
            this.lblBook.Location = new System.Drawing.Point(7, 70);
            this.lblBook.Name = "lblBook";
            this.lblBook.Size = new System.Drawing.Size(38, 13);
            this.lblBook.TabIndex = 1;
            this.lblBook.Text = "Book :";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(7, 42);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(57, 13);
            this.lblCustomer.TabIndex = 0;
            this.lblCustomer.Text = "Customer :";
            // 
            // grpBxChekout
            // 
            this.grpBxChekout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(101)))), ((int)(((byte)(100)))));
            this.grpBxChekout.Controls.Add(this.dataGridView3);
            this.grpBxChekout.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.grpBxChekout.Location = new System.Drawing.Point(372, 274);
            this.grpBxChekout.Name = "grpBxChekout";
            this.grpBxChekout.Size = new System.Drawing.Size(200, 228);
            this.grpBxChekout.TabIndex = 14;
            this.grpBxChekout.TabStop = false;
            this.grpBxChekout.Text = "Cart";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(101)))), ((int)(((byte)(100)))));
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView3.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView3.Location = new System.Drawing.Point(0, 19);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(194, 209);
            this.dataGridView3.TabIndex = 0;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Books";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Counts";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Total";
            this.Column6.Name = "Column6";
            // 
            // txtSrchBook
            // 
            this.txtSrchBook.Location = new System.Drawing.Point(12, 43);
            this.txtSrchBook.Name = "txtSrchBook";
            this.txtSrchBook.Size = new System.Drawing.Size(119, 20);
            this.txtSrchBook.TabIndex = 18;
            // 
            // btnSendtoCard
            // 
            this.btnSendtoCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSendtoCard.Location = new System.Drawing.Point(85, 216);
            this.btnSendtoCard.Name = "btnSendtoCard";
            this.btnSendtoCard.Size = new System.Drawing.Size(91, 30);
            this.btnSendtoCard.TabIndex = 9;
            this.btnSendtoCard.Text = "Send";
            this.btnSendtoCard.UseVisualStyleBackColor = false;
            // 
            // btnSendOrder
            // 
            this.btnSendOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSendOrder.Location = new System.Drawing.Point(372, 507);
            this.btnSendOrder.Name = "btnSendOrder";
            this.btnSendOrder.Size = new System.Drawing.Size(195, 33);
            this.btnSendOrder.TabIndex = 10;
            this.btnSendOrder.Text = "Order";
            this.btnSendOrder.UseVisualStyleBackColor = false;
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 542);
            this.Controls.Add(this.btnSendOrder);
            this.Controls.Add(this.grpBxChekout);
            this.Controls.Add(this.grpBxReport);
            this.Controls.Add(this.grbBxSrchBook);
            this.Controls.Add(this.grpBxSrchCustomer);
            this.Name = "Orders";
            this.Text = "Orders";
            this.grpBxSrchCustomer.ResumeLayout(false);
            this.grpBxSrchCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grbBxSrchBook.ResumeLayout(false);
            this.grbBxSrchBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.grpBxReport.ResumeLayout(false);
            this.grpBxReport.PerformLayout();
            this.grpBxChekout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBxSrchCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSrchCustomer;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.TextBox txtSrchName;
        private System.Windows.Forms.TextBox txtSrchSurname;
        private System.Windows.Forms.GroupBox grbBxSrchBook;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.GroupBox grpBxReport;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblBook;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblReturnDate;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblCountNumb;
        private System.Windows.Forms.Label lblPriceNumb;
        private System.Windows.Forms.GroupBox grpBxChekout;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.TextBox txtSrchBook;
        private System.Windows.Forms.Button btnSendtoCard;
        private System.Windows.Forms.Button btnSendOrder;
    }
}