namespace DatabaseAsmt2
{
    partial class WarehouseManagerForm
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
            this.gbWerehousefatures = new System.Windows.Forms.GroupBox();
            this.btnManageProduct = new System.Windows.Forms.Button();
            this.gbWerehousefatures.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbWerehousefatures
            // 
            this.gbWerehousefatures.Controls.Add(this.btnManageProduct);
            this.gbWerehousefatures.Location = new System.Drawing.Point(13, 13);
            this.gbWerehousefatures.Name = "gbWerehousefatures";
            this.gbWerehousefatures.Size = new System.Drawing.Size(704, 502);
            this.gbWerehousefatures.TabIndex = 0;
            this.gbWerehousefatures.TabStop = false;
            this.gbWerehousefatures.Text = "Were House Fatures";
            this.gbWerehousefatures.Enter += new System.EventHandler(this.gbWerehousefatures_Enter);
            // 
            // btnManageProduct
            // 
            this.btnManageProduct.Location = new System.Drawing.Point(7, 65);
            this.btnManageProduct.Name = "btnManageProduct";
            this.btnManageProduct.Size = new System.Drawing.Size(332, 155);
            this.btnManageProduct.TabIndex = 0;
            this.btnManageProduct.Text = "Manage Product";
            this.btnManageProduct.UseVisualStyleBackColor = true;
            this.btnManageProduct.Click += new System.EventHandler(this.btnManageProduct_Click);
            // 
            // WarehouseManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 592);
            this.Controls.Add(this.gbWerehousefatures);
            this.Name = "WarehouseManagerForm";
            this.Text = "WarehouseManagerForm";
            this.Load += new System.EventHandler(this.WarehouseManagerForm_Load);
            this.gbWerehousefatures.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbWerehousefatures;
        private System.Windows.Forms.Button btnManageProduct;
    }
}