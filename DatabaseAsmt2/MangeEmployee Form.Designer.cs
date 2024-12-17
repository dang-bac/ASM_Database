namespace DatabaseAsmt2
{
    partial class MangeEmployee_Form
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
            this.gbManageEmployee = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblEmployeeList = new System.Windows.Forms.Label();
            this.dtgEmployee = new System.Windows.Forms.DataGridView();
            this.gbEmployeeInformation = new System.Windows.Forms.GroupBox();
            this.cbAuthorityLevel = new System.Windows.Forms.ComboBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtEmployeePosition = new System.Windows.Forms.TextBox();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.txtEmployeeCode = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblAuthorityLevel = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.lblEmployeeCode = new System.Windows.Forms.Label();
            this.gbManageEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmployee)).BeginInit();
            this.gbEmployeeInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbManageEmployee
            // 
            this.gbManageEmployee.Controls.Add(this.txtSearch);
            this.gbManageEmployee.Controls.Add(this.btnBack);
            this.gbManageEmployee.Controls.Add(this.lblEmployeeList);
            this.gbManageEmployee.Controls.Add(this.dtgEmployee);
            this.gbManageEmployee.Controls.Add(this.gbEmployeeInformation);
            this.gbManageEmployee.Location = new System.Drawing.Point(26, 32);
            this.gbManageEmployee.Name = "gbManageEmployee";
            this.gbManageEmployee.Size = new System.Drawing.Size(1441, 867);
            this.gbManageEmployee.TabIndex = 0;
            this.gbManageEmployee.TabStop = false;
            this.gbManageEmployee.Text = "Manage Employee";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(1021, 49);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(372, 51);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(451, 763);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(270, 92);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.button5_Click);
            // 
            // lblEmployeeList
            // 
            this.lblEmployeeList.AutoSize = true;
            this.lblEmployeeList.Location = new System.Drawing.Point(858, 75);
            this.lblEmployeeList.Name = "lblEmployeeList";
            this.lblEmployeeList.Size = new System.Drawing.Size(141, 25);
            this.lblEmployeeList.TabIndex = 2;
            this.lblEmployeeList.Text = "EmployeeList";
            // 
            // dtgEmployee
            // 
            this.dtgEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgEmployee.Location = new System.Drawing.Point(815, 139);
            this.dtgEmployee.Name = "dtgEmployee";
            this.dtgEmployee.RowHeadersWidth = 82;
            this.dtgEmployee.RowTemplate.Height = 33;
            this.dtgEmployee.Size = new System.Drawing.Size(588, 538);
            this.dtgEmployee.TabIndex = 1;
            this.dtgEmployee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgEmployee_CellContentClick);
            // 
            // gbEmployeeInformation
            // 
            this.gbEmployeeInformation.Controls.Add(this.cbAuthorityLevel);
            this.gbEmployeeInformation.Controls.Add(this.txtPassword);
            this.gbEmployeeInformation.Controls.Add(this.txtUsername);
            this.gbEmployeeInformation.Controls.Add(this.txtEmployeePosition);
            this.gbEmployeeInformation.Controls.Add(this.txtEmployeeName);
            this.gbEmployeeInformation.Controls.Add(this.txtEmployeeCode);
            this.gbEmployeeInformation.Controls.Add(this.btnClear);
            this.gbEmployeeInformation.Controls.Add(this.btnDelete);
            this.gbEmployeeInformation.Controls.Add(this.btnUpdate);
            this.gbEmployeeInformation.Controls.Add(this.btnAdd);
            this.gbEmployeeInformation.Controls.Add(this.lblPassword);
            this.gbEmployeeInformation.Controls.Add(this.lblUsername);
            this.gbEmployeeInformation.Controls.Add(this.lblAuthorityLevel);
            this.gbEmployeeInformation.Controls.Add(this.lblPosition);
            this.gbEmployeeInformation.Controls.Add(this.lblEmployeeName);
            this.gbEmployeeInformation.Controls.Add(this.lblEmployeeCode);
            this.gbEmployeeInformation.Location = new System.Drawing.Point(17, 52);
            this.gbEmployeeInformation.Name = "gbEmployeeInformation";
            this.gbEmployeeInformation.Size = new System.Drawing.Size(778, 705);
            this.gbEmployeeInformation.TabIndex = 0;
            this.gbEmployeeInformation.TabStop = false;
            this.gbEmployeeInformation.Text = "EmployeeInformation";
            // 
            // cbAuthorityLevel
            // 
            this.cbAuthorityLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAuthorityLevel.FormattingEnabled = true;
            this.cbAuthorityLevel.Location = new System.Drawing.Point(319, 200);
            this.cbAuthorityLevel.Name = "cbAuthorityLevel";
            this.cbAuthorityLevel.Size = new System.Drawing.Size(409, 45);
            this.cbAuthorityLevel.TabIndex = 15;
            this.cbAuthorityLevel.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(319, 331);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(409, 46);
            this.txtPassword.TabIndex = 14;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(319, 265);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(409, 48);
            this.txtUsername.TabIndex = 13;
            // 
            // txtEmployeePosition
            // 
            this.txtEmployeePosition.Location = new System.Drawing.Point(319, 140);
            this.txtEmployeePosition.Multiline = true;
            this.txtEmployeePosition.Name = "txtEmployeePosition";
            this.txtEmployeePosition.Size = new System.Drawing.Size(409, 45);
            this.txtEmployeePosition.TabIndex = 12;
            this.txtEmployeePosition.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(319, 87);
            this.txtEmployeeName.Multiline = true;
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(409, 45);
            this.txtEmployeeName.TabIndex = 11;
            // 
            // txtEmployeeCode
            // 
            this.txtEmployeeCode.Location = new System.Drawing.Point(319, 33);
            this.txtEmployeeCode.Multiline = true;
            this.txtEmployeeCode.Name = "txtEmployeeCode";
            this.txtEmployeeCode.Size = new System.Drawing.Size(409, 45);
            this.txtEmployeeCode.TabIndex = 10;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(434, 544);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(270, 92);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(38, 544);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(270, 92);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(434, 446);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(270, 92);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(38, 446);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(270, 92);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(23, 352);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(117, 25);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Pass Word";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(23, 288);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(119, 25);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "User Name";
            // 
            // lblAuthorityLevel
            // 
            this.lblAuthorityLevel.AutoSize = true;
            this.lblAuthorityLevel.Location = new System.Drawing.Point(23, 220);
            this.lblAuthorityLevel.Name = "lblAuthorityLevel";
            this.lblAuthorityLevel.Size = new System.Drawing.Size(56, 25);
            this.lblAuthorityLevel.TabIndex = 3;
            this.lblAuthorityLevel.Text = "Role";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(23, 160);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(89, 25);
            this.lblPosition.TabIndex = 2;
            this.lblPosition.Text = "Position";
            this.lblPosition.Click += new System.EventHandler(this.lblPosition_Click);
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Location = new System.Drawing.Point(23, 107);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(68, 25);
            this.lblEmployeeName.TabIndex = 1;
            this.lblEmployeeName.Text = "Name";
            // 
            // lblEmployeeCode
            // 
            this.lblEmployeeCode.AutoSize = true;
            this.lblEmployeeCode.Location = new System.Drawing.Point(23, 53);
            this.lblEmployeeCode.Name = "lblEmployeeCode";
            this.lblEmployeeCode.Size = new System.Drawing.Size(63, 25);
            this.lblEmployeeCode.TabIndex = 0;
            this.lblEmployeeCode.Text = "Code";
            // 
            // MangeEmployee_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1479, 925);
            this.Controls.Add(this.gbManageEmployee);
            this.Name = "MangeEmployee_Form";
            this.Text = "MangeEmployee_Form";
            this.Load += new System.EventHandler(this.MangeEmployee_Form_Load);
            this.gbManageEmployee.ResumeLayout(false);
            this.gbManageEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmployee)).EndInit();
            this.gbEmployeeInformation.ResumeLayout(false);
            this.gbEmployeeInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbManageEmployee;
        private System.Windows.Forms.DataGridView dtgEmployee;
        private System.Windows.Forms.GroupBox gbEmployeeInformation;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblEmployeeList;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblAuthorityLevel;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Label lblEmployeeCode;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cbAuthorityLevel;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtEmployeePosition;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.TextBox txtEmployeeCode;
    }
}