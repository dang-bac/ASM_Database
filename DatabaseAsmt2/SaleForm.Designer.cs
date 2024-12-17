namespace DatabaseAsmt2
{
    partial class SaleForm
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
            this.gbSalefeature = new System.Windows.Forms.GroupBox();
            this.btnManageorder = new System.Windows.Forms.Button();
            this.btnManageCustomer = new System.Windows.Forms.Button();
            this.gbSalefeature.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSalefeature
            // 
            this.gbSalefeature.Controls.Add(this.btnManageorder);
            this.gbSalefeature.Controls.Add(this.btnManageCustomer);
            this.gbSalefeature.Location = new System.Drawing.Point(24, 31);
            this.gbSalefeature.Name = "gbSalefeature";
            this.gbSalefeature.Size = new System.Drawing.Size(1262, 412);
            this.gbSalefeature.TabIndex = 0;
            this.gbSalefeature.TabStop = false;
            this.gbSalefeature.Text = "Sale feature";
            // 
            // btnManageorder
            // 
            this.btnManageorder.Location = new System.Drawing.Point(689, 153);
            this.btnManageorder.Name = "btnManageorder";
            this.btnManageorder.Size = new System.Drawing.Size(251, 104);
            this.btnManageorder.TabIndex = 1;
            this.btnManageorder.Text = "Manage Order";
            this.btnManageorder.UseVisualStyleBackColor = true;
            this.btnManageorder.Click += new System.EventHandler(this.btnManageorder_Click);
            // 
            // btnManageCustomer
            // 
            this.btnManageCustomer.Location = new System.Drawing.Point(84, 153);
            this.btnManageCustomer.Name = "btnManageCustomer";
            this.btnManageCustomer.Size = new System.Drawing.Size(251, 104);
            this.btnManageCustomer.TabIndex = 0;
            this.btnManageCustomer.Text = " Manage Customer";
            this.btnManageCustomer.UseVisualStyleBackColor = true;
            this.btnManageCustomer.Click += new System.EventHandler(this.btnManageCustomer_Click);
            // 
            // SaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 609);
            this.Controls.Add(this.gbSalefeature);
            this.Name = "SaleForm";
            this.Text = "SaleForm";
            this.Load += new System.EventHandler(this.SaleForm_Load);
            this.gbSalefeature.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSalefeature;
        private System.Windows.Forms.Button btnManageorder;
        private System.Windows.Forms.Button btnManageCustomer;
    }
}