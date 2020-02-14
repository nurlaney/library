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
            this.SuspendLayout();
            // 
            // btnGoOrders
            // 
            this.btnGoOrders.Location = new System.Drawing.Point(193, 95);
            this.btnGoOrders.Name = "btnGoOrders";
            this.btnGoOrders.Size = new System.Drawing.Size(169, 78);
            this.btnGoOrders.TabIndex = 0;
            this.btnGoOrders.Text = "Orders";
            this.btnGoOrders.UseVisualStyleBackColor = true;
            // 
            // dashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 321);
            this.Controls.Add(this.btnGoOrders);
            this.Name = "dashboardForm";
            this.Text = "dashboard";
            this.ResumeLayout(false);

        }



        #endregion

        private System.Windows.Forms.Button btnGoOrders;
    }
}