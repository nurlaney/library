namespace MyLibrary.Forms
{
    partial class AddCustomerForm
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
            this.txtcCustomerName = new System.Windows.Forms.TextBox();
            this.lblcAddCustomer = new System.Windows.Forms.Label();
            this.lblcCustomerSurname = new System.Windows.Forms.Label();
            this.txtcCustomerSurname = new System.Windows.Forms.TextBox();
            this.label2alblcCustomerEmail = new System.Windows.Forms.Label();
            this.txtcCustomEmail = new System.Windows.Forms.TextBox();
            this.btncCustomerAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtcCustomerName
            // 
            this.txtcCustomerName.Location = new System.Drawing.Point(23, 42);
            this.txtcCustomerName.Name = "txtcCustomerName";
            this.txtcCustomerName.Size = new System.Drawing.Size(153, 20);
            this.txtcCustomerName.TabIndex = 0;
            // 
            // lblcAddCustomer
            // 
            this.lblcAddCustomer.AutoSize = true;
            this.lblcAddCustomer.Location = new System.Drawing.Point(23, 23);
            this.lblcAddCustomer.Name = "lblcAddCustomer";
            this.lblcAddCustomer.Size = new System.Drawing.Size(35, 13);
            this.lblcAddCustomer.TabIndex = 1;
            this.lblcAddCustomer.Text = "Name";
            // 
            // lblcCustomerSurname
            // 
            this.lblcCustomerSurname.AutoSize = true;
            this.lblcCustomerSurname.Location = new System.Drawing.Point(23, 68);
            this.lblcCustomerSurname.Name = "lblcCustomerSurname";
            this.lblcCustomerSurname.Size = new System.Drawing.Size(49, 13);
            this.lblcCustomerSurname.TabIndex = 3;
            this.lblcCustomerSurname.Text = "Surname";
            // 
            // txtcCustomerSurname
            // 
            this.txtcCustomerSurname.Location = new System.Drawing.Point(23, 87);
            this.txtcCustomerSurname.Name = "txtcCustomerSurname";
            this.txtcCustomerSurname.Size = new System.Drawing.Size(153, 20);
            this.txtcCustomerSurname.TabIndex = 2;
            // 
            // label2alblcCustomerEmail
            // 
            this.label2alblcCustomerEmail.AutoSize = true;
            this.label2alblcCustomerEmail.Location = new System.Drawing.Point(23, 115);
            this.label2alblcCustomerEmail.Name = "label2alblcCustomerEmail";
            this.label2alblcCustomerEmail.Size = new System.Drawing.Size(35, 13);
            this.label2alblcCustomerEmail.TabIndex = 5;
            this.label2alblcCustomerEmail.Text = "E-mail";
            // 
            // txtcCustomEmail
            // 
            this.txtcCustomEmail.Location = new System.Drawing.Point(23, 134);
            this.txtcCustomEmail.Name = "txtcCustomEmail";
            this.txtcCustomEmail.Size = new System.Drawing.Size(153, 20);
            this.txtcCustomEmail.TabIndex = 4;
            // 
            // btncCustomerAdd
            // 
            this.btncCustomerAdd.Location = new System.Drawing.Point(44, 169);
            this.btncCustomerAdd.Name = "btncCustomerAdd";
            this.btncCustomerAdd.Size = new System.Drawing.Size(96, 35);
            this.btncCustomerAdd.TabIndex = 6;
            this.btncCustomerAdd.Text = "Add";
            this.btncCustomerAdd.UseVisualStyleBackColor = true;
            // 
            // AddCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(197, 223);
            this.Controls.Add(this.btncCustomerAdd);
            this.Controls.Add(this.label2alblcCustomerEmail);
            this.Controls.Add(this.txtcCustomEmail);
            this.Controls.Add(this.lblcCustomerSurname);
            this.Controls.Add(this.txtcCustomerSurname);
            this.Controls.Add(this.lblcAddCustomer);
            this.Controls.Add(this.txtcCustomerName);
            this.Name = "AddCustomerForm";
            this.Text = "Add Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcCustomerName;
        private System.Windows.Forms.Label lblcAddCustomer;
        private System.Windows.Forms.Label lblcCustomerSurname;
        private System.Windows.Forms.TextBox txtcCustomerSurname;
        private System.Windows.Forms.Label label2alblcCustomerEmail;
        private System.Windows.Forms.TextBox txtcCustomEmail;
        private System.Windows.Forms.Button btncCustomerAdd;
    }
}