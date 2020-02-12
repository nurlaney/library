namespace MyLibrary.Forms
{
    partial class AddAuthorForm
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
            this.txtAuthorName = new System.Windows.Forms.TextBox();
            this.lblAutorName = new System.Windows.Forms.Label();
            this.lblAuthorSurname = new System.Windows.Forms.Label();
            this.txtAuthorSurname = new System.Windows.Forms.TextBox();
            this.btnAddAuthor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAuthorName
            // 
            this.txtAuthorName.Location = new System.Drawing.Point(18, 53);
            this.txtAuthorName.Name = "txtAuthorName";
            this.txtAuthorName.Size = new System.Drawing.Size(198, 20);
            this.txtAuthorName.TabIndex = 0;
            // 
            // lblAutorName
            // 
            this.lblAutorName.AutoSize = true;
            this.lblAutorName.Location = new System.Drawing.Point(77, 28);
            this.lblAutorName.Name = "lblAutorName";
            this.lblAutorName.Size = new System.Drawing.Size(74, 13);
            this.lblAutorName.TabIndex = 1;
            this.lblAutorName.Text = "Author\'s name";
            // 
            // lblAuthorSurname
            // 
            this.lblAuthorSurname.AutoSize = true;
            this.lblAuthorSurname.Location = new System.Drawing.Point(77, 80);
            this.lblAuthorSurname.Name = "lblAuthorSurname";
            this.lblAuthorSurname.Size = new System.Drawing.Size(88, 13);
            this.lblAuthorSurname.TabIndex = 3;
            this.lblAuthorSurname.Text = "Author\'s surname";
            // 
            // txtAuthorSurname
            // 
            this.txtAuthorSurname.Location = new System.Drawing.Point(18, 105);
            this.txtAuthorSurname.Name = "txtAuthorSurname";
            this.txtAuthorSurname.Size = new System.Drawing.Size(198, 20);
            this.txtAuthorSurname.TabIndex = 2;
            // 
            // btnAddAuthor
            // 
            this.btnAddAuthor.Location = new System.Drawing.Point(65, 149);
            this.btnAddAuthor.Name = "btnAddAuthor";
            this.btnAddAuthor.Size = new System.Drawing.Size(100, 41);
            this.btnAddAuthor.TabIndex = 4;
            this.btnAddAuthor.Text = "Add";
            this.btnAddAuthor.UseVisualStyleBackColor = true;
            // 
            // AddAuthorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 213);
            this.Controls.Add(this.btnAddAuthor);
            this.Controls.Add(this.lblAuthorSurname);
            this.Controls.Add(this.txtAuthorSurname);
            this.Controls.Add(this.lblAutorName);
            this.Controls.Add(this.txtAuthorName);
            this.Name = "AddAuthorForm";
            this.Text = "AddAuthorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAuthorName;
        private System.Windows.Forms.Label lblAutorName;
        private System.Windows.Forms.Label lblAuthorSurname;
        private System.Windows.Forms.TextBox txtAuthorSurname;
        private System.Windows.Forms.Button btnAddAuthor;
    }
}