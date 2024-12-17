namespace DatabaseAsmt2
{
    partial class History_Form
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
            this.gbPurchasehistory = new System.Windows.Forms.GroupBox();
            this.dtgOrderHistory = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.gbPurchasehistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgOrderHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPurchasehistory
            // 
            this.gbPurchasehistory.Controls.Add(this.dtgOrderHistory);
            this.gbPurchasehistory.Location = new System.Drawing.Point(28, 31);
            this.gbPurchasehistory.Name = "gbPurchasehistory";
            this.gbPurchasehistory.Size = new System.Drawing.Size(1016, 602);
            this.gbPurchasehistory.TabIndex = 0;
            this.gbPurchasehistory.TabStop = false;
            this.gbPurchasehistory.Text = "Purchase History";
            // 
            // dtgOrderHistory
            // 
            this.dtgOrderHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgOrderHistory.Location = new System.Drawing.Point(17, 54);
            this.dtgOrderHistory.Name = "dtgOrderHistory";
            this.dtgOrderHistory.RowHeadersWidth = 82;
            this.dtgOrderHistory.RowTemplate.Height = 33;
            this.dtgOrderHistory.Size = new System.Drawing.Size(975, 519);
            this.dtgOrderHistory.TabIndex = 0;
            this.dtgOrderHistory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgOrderHistory_CellContentClick);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(679, 639);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(365, 91);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // History_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 760);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.gbPurchasehistory);
            this.Name = "History_Form";
            this.Text = "History_Form";
            this.Load += new System.EventHandler(this.History_Form_Load);
            this.gbPurchasehistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgOrderHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPurchasehistory;
        private System.Windows.Forms.DataGridView dtgOrderHistory;
        private System.Windows.Forms.Button btnBack;
    }
}