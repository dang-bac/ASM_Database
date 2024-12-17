namespace DatabaseAsmt2
{
    partial class AdminForm
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
            this.gbAdminFeature = new System.Windows.Forms.GroupBox();
            this.btnViewStatistic = new System.Windows.Forms.Button();
            this.btnManageOrder = new System.Windows.Forms.Button();
            this.btnManageProduct = new System.Windows.Forms.Button();
            this.btnManageImport = new System.Windows.Forms.Button();
            this.btnManageCategory = new System.Windows.Forms.Button();
            this.btnManageEmployee = new System.Windows.Forms.Button();
            this.gbAdminFeature.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAdminFeature
            // 
            this.gbAdminFeature.Controls.Add(this.btnViewStatistic);
            this.gbAdminFeature.Controls.Add(this.btnManageOrder);
            this.gbAdminFeature.Controls.Add(this.btnManageProduct);
            this.gbAdminFeature.Controls.Add(this.btnManageImport);
            this.gbAdminFeature.Controls.Add(this.btnManageCategory);
            this.gbAdminFeature.Controls.Add(this.btnManageEmployee);
            this.gbAdminFeature.Location = new System.Drawing.Point(31, 32);
            this.gbAdminFeature.Name = "gbAdminFeature";
            this.gbAdminFeature.Size = new System.Drawing.Size(1259, 661);
            this.gbAdminFeature.TabIndex = 0;
            this.gbAdminFeature.TabStop = false;
            this.gbAdminFeature.Text = "Admin Feature";
            // 
            // btnViewStatistic
            // 
            this.btnViewStatistic.Location = new System.Drawing.Point(266, 532);
            this.btnViewStatistic.Name = "btnViewStatistic";
            this.btnViewStatistic.Size = new System.Drawing.Size(728, 102);
            this.btnViewStatistic.TabIndex = 5;
            this.btnViewStatistic.Text = "View Statistic";
            this.btnViewStatistic.UseVisualStyleBackColor = true;
            this.btnViewStatistic.Click += new System.EventHandler(this.btnViewStatistic_Click);
            // 
            // btnManageOrder
            // 
            this.btnManageOrder.Location = new System.Drawing.Point(844, 212);
            this.btnManageOrder.Name = "btnManageOrder";
            this.btnManageOrder.Size = new System.Drawing.Size(262, 102);
            this.btnManageOrder.TabIndex = 4;
            this.btnManageOrder.Text = "Manage Order";
            this.btnManageOrder.UseVisualStyleBackColor = true;
            this.btnManageOrder.Click += new System.EventHandler(this.btnManageOrder_Click);
            // 
            // btnManageProduct
            // 
            this.btnManageProduct.Location = new System.Drawing.Point(844, 58);
            this.btnManageProduct.Name = "btnManageProduct";
            this.btnManageProduct.Size = new System.Drawing.Size(262, 102);
            this.btnManageProduct.TabIndex = 3;
            this.btnManageProduct.Text = "Manage Product";
            this.btnManageProduct.UseVisualStyleBackColor = true;
            this.btnManageProduct.Click += new System.EventHandler(this.btnManageProduct_Click);
            // 
            // btnManageImport
            // 
            this.btnManageImport.Location = new System.Drawing.Point(79, 382);
            this.btnManageImport.Name = "btnManageImport";
            this.btnManageImport.Size = new System.Drawing.Size(262, 102);
            this.btnManageImport.TabIndex = 2;
            this.btnManageImport.Text = "Manage Import";
            this.btnManageImport.UseVisualStyleBackColor = true;
            this.btnManageImport.Click += new System.EventHandler(this.btnManageImport_Click);
            // 
            // btnManageCategory
            // 
            this.btnManageCategory.Location = new System.Drawing.Point(79, 212);
            this.btnManageCategory.Name = "btnManageCategory";
            this.btnManageCategory.Size = new System.Drawing.Size(262, 102);
            this.btnManageCategory.TabIndex = 1;
            this.btnManageCategory.Text = "Manage Category";
            this.btnManageCategory.UseVisualStyleBackColor = true;
            this.btnManageCategory.Click += new System.EventHandler(this.btnManageCategory_Click);
            // 
            // btnManageEmployee
            // 
            this.btnManageEmployee.Location = new System.Drawing.Point(79, 58);
            this.btnManageEmployee.Name = "btnManageEmployee";
            this.btnManageEmployee.Size = new System.Drawing.Size(262, 102);
            this.btnManageEmployee.TabIndex = 0;
            this.btnManageEmployee.Text = "Manage Employee";
            this.btnManageEmployee.UseVisualStyleBackColor = true;
            this.btnManageEmployee.Click += new System.EventHandler(this.btnManageEmployee_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 724);
            this.Controls.Add(this.gbAdminFeature);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.gbAdminFeature.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAdminFeature;
        private System.Windows.Forms.Button btnViewStatistic;
        private System.Windows.Forms.Button btnManageOrder;
        private System.Windows.Forms.Button btnManageProduct;
        private System.Windows.Forms.Button btnManageImport;
        private System.Windows.Forms.Button btnManageCategory;
        private System.Windows.Forms.Button btnManageEmployee;
    }
}