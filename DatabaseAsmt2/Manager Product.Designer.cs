namespace DatabaseAsmt2
{
    partial class Manager_Product
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
            this.gbProductInformation = new System.Windows.Forms.GroupBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.txtProductQuantity = new System.Windows.Forms.TextBox();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblProductImg = new System.Windows.Forms.Label();
            this.lblProductQuantity = new System.Windows.Forms.Label();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblProductCode = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbProductData = new System.Windows.Forms.GroupBox();
            this.dtgProduct = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.cbSupplier = new System.Windows.Forms.ComboBox();
            this.gbProductInformation.SuspendLayout();
            this.gbProductData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // gbProductInformation
            // 
            this.gbProductInformation.Controls.Add(this.cbSupplier);
            this.gbProductInformation.Controls.Add(this.cbCategory);
            this.gbProductInformation.Controls.Add(this.txtProductQuantity);
            this.gbProductInformation.Controls.Add(this.txtProductPrice);
            this.gbProductInformation.Controls.Add(this.txtProductName);
            this.gbProductInformation.Controls.Add(this.txtProductCode);
            this.gbProductInformation.Controls.Add(this.lblCategory);
            this.gbProductInformation.Controls.Add(this.lblProductImg);
            this.gbProductInformation.Controls.Add(this.lblProductQuantity);
            this.gbProductInformation.Controls.Add(this.lblProductPrice);
            this.gbProductInformation.Controls.Add(this.lblProductName);
            this.gbProductInformation.Controls.Add(this.lblProductCode);
            this.gbProductInformation.Controls.Add(this.btnClear);
            this.gbProductInformation.Controls.Add(this.btnDelete);
            this.gbProductInformation.Controls.Add(this.btnUpdate);
            this.gbProductInformation.Controls.Add(this.btnAdd);
            this.gbProductInformation.Location = new System.Drawing.Point(22, 35);
            this.gbProductInformation.Name = "gbProductInformation";
            this.gbProductInformation.Size = new System.Drawing.Size(774, 744);
            this.gbProductInformation.TabIndex = 0;
            this.gbProductInformation.TabStop = false;
            this.gbProductInformation.Text = "Product Information";
            // 
            // cbCategory
            // 
            this.cbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(337, 383);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(393, 45);
            this.cbCategory.TabIndex = 14;
            // 
            // txtProductQuantity
            // 
            this.txtProductQuantity.Location = new System.Drawing.Point(337, 235);
            this.txtProductQuantity.Multiline = true;
            this.txtProductQuantity.Name = "txtProductQuantity";
            this.txtProductQuantity.Size = new System.Drawing.Size(393, 45);
            this.txtProductQuantity.TabIndex = 13;
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Location = new System.Drawing.Point(337, 162);
            this.txtProductPrice.Multiline = true;
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(393, 45);
            this.txtProductPrice.TabIndex = 12;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(337, 94);
            this.txtProductName.Multiline = true;
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(393, 45);
            this.txtProductName.TabIndex = 11;
            // 
            // txtProductCode
            // 
            this.txtProductCode.Location = new System.Drawing.Point(337, 31);
            this.txtProductCode.Multiline = true;
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(393, 45);
            this.txtProductCode.TabIndex = 10;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(24, 403);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(99, 25);
            this.lblCategory.TabIndex = 9;
            this.lblCategory.Text = "Category";
            // 
            // lblProductImg
            // 
            this.lblProductImg.AutoSize = true;
            this.lblProductImg.Location = new System.Drawing.Point(24, 314);
            this.lblProductImg.Name = "lblProductImg";
            this.lblProductImg.Size = new System.Drawing.Size(91, 25);
            this.lblProductImg.TabIndex = 8;
            this.lblProductImg.Text = "Supplier";
            // 
            // lblProductQuantity
            // 
            this.lblProductQuantity.AutoSize = true;
            this.lblProductQuantity.Location = new System.Drawing.Point(24, 255);
            this.lblProductQuantity.Name = "lblProductQuantity";
            this.lblProductQuantity.Size = new System.Drawing.Size(172, 25);
            this.lblProductQuantity.TabIndex = 7;
            this.lblProductQuantity.Text = "Product Quantity";
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.Location = new System.Drawing.Point(24, 182);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(141, 25);
            this.lblProductPrice.TabIndex = 6;
            this.lblProductPrice.Text = "Product Price";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(24, 114);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(148, 25);
            this.lblProductName.TabIndex = 5;
            this.lblProductName.Text = "Product Name";
            // 
            // lblProductCode
            // 
            this.lblProductCode.AutoSize = true;
            this.lblProductCode.Location = new System.Drawing.Point(24, 51);
            this.lblProductCode.Name = "lblProductCode";
            this.lblProductCode.Size = new System.Drawing.Size(143, 25);
            this.lblProductCode.TabIndex = 4;
            this.lblProductCode.Text = "Product Code";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(422, 612);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(236, 75);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(34, 612);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(236, 75);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(422, 497);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(236, 75);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(34, 497);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(236, 75);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gbProductData
            // 
            this.gbProductData.Controls.Add(this.dtgProduct);
            this.gbProductData.Controls.Add(this.txtSearch);
            this.gbProductData.Location = new System.Drawing.Point(829, 35);
            this.gbProductData.Name = "gbProductData";
            this.gbProductData.Size = new System.Drawing.Size(700, 744);
            this.gbProductData.TabIndex = 1;
            this.gbProductData.TabStop = false;
            this.gbProductData.Text = "Product Data";
            // 
            // dtgProduct
            // 
            this.dtgProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProduct.Location = new System.Drawing.Point(33, 124);
            this.dtgProduct.Name = "dtgProduct";
            this.dtgProduct.RowHeadersWidth = 82;
            this.dtgProduct.RowTemplate.Height = 33;
            this.dtgProduct.Size = new System.Drawing.Size(649, 605);
            this.dtgProduct.TabIndex = 16;
            this.dtgProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgProduct_CellContentClick);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(289, 48);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(393, 45);
            this.txtSearch.TabIndex = 15;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(444, 795);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(236, 75);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cbSupplier
            // 
            this.cbSupplier.FormattingEnabled = true;
            this.cbSupplier.Location = new System.Drawing.Point(337, 306);
            this.cbSupplier.Name = "cbSupplier";
            this.cbSupplier.Size = new System.Drawing.Size(393, 33);
            this.cbSupplier.TabIndex = 15;
            // 
            // Manager_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1554, 882);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.gbProductData);
            this.Controls.Add(this.gbProductInformation);
            this.Name = "Manager_Product";
            this.Text = "Manager_Product";
            this.Load += new System.EventHandler(this.Manager_Product_Load);
            this.gbProductInformation.ResumeLayout(false);
            this.gbProductInformation.PerformLayout();
            this.gbProductData.ResumeLayout(false);
            this.gbProductData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbProductInformation;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.TextBox txtProductQuantity;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblProductImg;
        private System.Windows.Forms.Label lblProductQuantity;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblProductCode;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gbProductData;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dtgProduct;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cbSupplier;
    }
}