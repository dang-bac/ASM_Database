using System;

namespace DatabaseAsmt2
{
    partial class gbManageCustomer
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
            this.gbCustomerManager = new System.Windows.Forms.GroupBox();
            this.lblCustomerlist = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.dtgCustomer = new System.Windows.Forms.DataGridView();
            this.gbCustomerInformation = new System.Windows.Forms.GroupBox();
            this.txtPhonenumber = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtCustomerCode = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblPhonenumber = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblCustomerCode = new System.Windows.Forms.Label();
            this.gbCustomerManager.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCustomer)).BeginInit();
            this.gbCustomerInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCustomerManager
            // 
            this.gbCustomerManager.Controls.Add(this.lblCustomerlist);
            this.gbCustomerManager.Controls.Add(this.txtSearch);
            this.gbCustomerManager.Controls.Add(this.btnBack);
            this.gbCustomerManager.Controls.Add(this.dtgCustomer);
            this.gbCustomerManager.Controls.Add(this.gbCustomerInformation);
            this.gbCustomerManager.Location = new System.Drawing.Point(12, 12);
            this.gbCustomerManager.Name = "gbCustomerManager";
            this.gbCustomerManager.Size = new System.Drawing.Size(1392, 753);
            this.gbCustomerManager.TabIndex = 0;
            this.gbCustomerManager.TabStop = false;
            this.gbCustomerManager.Text = "Customer Manager";
            // 
            // lblCustomerlist
            // 
            this.lblCustomerlist.AutoSize = true;
            this.lblCustomerlist.Location = new System.Drawing.Point(922, 66);
            this.lblCustomerlist.Name = "lblCustomerlist";
            this.lblCustomerlist.Size = new System.Drawing.Size(144, 25);
            this.lblCustomerlist.TabIndex = 4;
            this.lblCustomerlist.Text = "Customer List";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(1094, 40);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(283, 51);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(501, 653);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(208, 86);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dtgCustomer
            // 
            this.dtgCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCustomer.Location = new System.Drawing.Point(878, 149);
            this.dtgCustomer.Name = "dtgCustomer";
            this.dtgCustomer.RowHeadersWidth = 82;
            this.dtgCustomer.RowTemplate.Height = 33;
            this.dtgCustomer.Size = new System.Drawing.Size(499, 498);
            this.dtgCustomer.TabIndex = 1;
            this.dtgCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCustomer_CellContentClick);
            // 
            // gbCustomerInformation
            // 
            this.gbCustomerInformation.Controls.Add(this.txtPhonenumber);
            this.gbCustomerInformation.Controls.Add(this.txtCustomerName);
            this.gbCustomerInformation.Controls.Add(this.txtCustomerCode);
            this.gbCustomerInformation.Controls.Add(this.btnClear);
            this.gbCustomerInformation.Controls.Add(this.btnDelete);
            this.gbCustomerInformation.Controls.Add(this.btnUpdate);
            this.gbCustomerInformation.Controls.Add(this.btnAdd);
            this.gbCustomerInformation.Controls.Add(this.lblPhonenumber);
            this.gbCustomerInformation.Controls.Add(this.lblCustomerName);
            this.gbCustomerInformation.Controls.Add(this.lblCustomerCode);
            this.gbCustomerInformation.Location = new System.Drawing.Point(22, 45);
            this.gbCustomerInformation.Name = "gbCustomerInformation";
            this.gbCustomerInformation.Size = new System.Drawing.Size(830, 602);
            this.gbCustomerInformation.TabIndex = 0;
            this.gbCustomerInformation.TabStop = false;
            this.gbCustomerInformation.Text = "Customer Information";
            // 
            // txtPhonenumber
            // 
            this.txtPhonenumber.Location = new System.Drawing.Point(381, 155);
            this.txtPhonenumber.Multiline = true;
            this.txtPhonenumber.Name = "txtPhonenumber";
            this.txtPhonenumber.Size = new System.Drawing.Size(368, 44);
            this.txtPhonenumber.TabIndex = 10;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(381, 93);
            this.txtCustomerName.Multiline = true;
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(368, 46);
            this.txtCustomerName.TabIndex = 9;
            // 
            // txtCustomerCode
            // 
            this.txtCustomerCode.Location = new System.Drawing.Point(381, 38);
            this.txtCustomerCode.Multiline = true;
            this.txtCustomerCode.Name = "txtCustomerCode";
            this.txtCustomerCode.Size = new System.Drawing.Size(368, 49);
            this.txtCustomerCode.TabIndex = 8;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(479, 510);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(208, 86);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(54, 510);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(208, 86);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(479, 405);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(208, 86);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(54, 405);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(208, 86);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblPhonenumber
            // 
            this.lblPhonenumber.AutoSize = true;
            this.lblPhonenumber.Location = new System.Drawing.Point(28, 174);
            this.lblPhonenumber.Name = "lblPhonenumber";
            this.lblPhonenumber.Size = new System.Drawing.Size(152, 25);
            this.lblPhonenumber.TabIndex = 2;
            this.lblPhonenumber.Text = "Phone number";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(28, 114);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(166, 25);
            this.lblCustomerName.TabIndex = 1;
            this.lblCustomerName.Text = "Customer Name";
            // 
            // lblCustomerCode
            // 
            this.lblCustomerCode.AutoSize = true;
            this.lblCustomerCode.Location = new System.Drawing.Point(28, 62);
            this.lblCustomerCode.Name = "lblCustomerCode";
            this.lblCustomerCode.Size = new System.Drawing.Size(161, 25);
            this.lblCustomerCode.TabIndex = 0;
            this.lblCustomerCode.Text = "Customer Code";
            // 
            // gbManageCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1425, 805);
            this.Controls.Add(this.gbCustomerManager);
            this.Name = "gbManageCustomer";
            this.Text = "ManageCustomer";
            this.Load += new System.EventHandler(this.gbManageCustomer_Load);
            this.gbCustomerManager.ResumeLayout(false);
            this.gbCustomerManager.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCustomer)).EndInit();
            this.gbCustomerInformation.ResumeLayout(false);
            this.gbCustomerInformation.PerformLayout();
            this.ResumeLayout(false);

        }

  

        #endregion

        private System.Windows.Forms.GroupBox gbCustomerManager;
        private System.Windows.Forms.DataGridView dtgCustomer;
        private System.Windows.Forms.GroupBox gbCustomerInformation;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtPhonenumber;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtCustomerCode;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblPhonenumber;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblCustomerCode;
        private System.Windows.Forms.Label lblCustomerlist;
    }
}