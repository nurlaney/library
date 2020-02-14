namespace MyLibrary.Forms
{
    partial class AddGenre
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
            this.txtAddGenre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddGenre = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAddGenre
            // 
            this.txtAddGenre.Location = new System.Drawing.Point(37, 75);
            this.txtAddGenre.Name = "txtAddGenre";
            this.txtAddGenre.Size = new System.Drawing.Size(194, 20);
            this.txtAddGenre.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Genre name";
            // 
            // btnAddGenre
            // 
            this.btnAddGenre.Location = new System.Drawing.Point(78, 110);
            this.btnAddGenre.Name = "btnAddGenre";
            this.btnAddGenre.Size = new System.Drawing.Size(113, 42);
            this.btnAddGenre.TabIndex = 2;
            this.btnAddGenre.Text = "Add";
            this.btnAddGenre.UseVisualStyleBackColor = true;
            this.btnAddGenre.Click += new System.EventHandler(this.btnAddGenre_Click);
            // 
            // AddGenre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 183);
            this.Controls.Add(this.btnAddGenre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAddGenre);
            this.Name = "AddGenre";
            this.Text = "AddGenre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAddGenre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddGenre;
    }
}