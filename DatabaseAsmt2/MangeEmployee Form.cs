using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseAsmt2
{
    public partial class MangeEmployee_Form : Form
    {
        int employeeID;
        string employeePosition;
        public MangeEmployee_Form(string employeePosition)
        {
            employeeID = 0;
            InitializeComponent();
            this.employeePosition = employeePosition;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            switch (employeePosition)
            {
                case "Admin":
                    {
                        AdminForm adminForm = new AdminForm(employeePosition, employeeID);
                        this.Hide();
                        adminForm.Show();
                        break;
                    }
                case "Warehouse Manager":
                    {
                        WarehouseManagerForm warehouseManagerForm = new WarehouseManagerForm(employeePosition, employeeID);
                        this.Hide();
                        warehouseManagerForm.Show();
                        break;
                    }
                case "Sale":
                    {
                        SaleForm saleForm = new SaleForm(employeePosition, employeeID);
                        this.Hide();
                        saleForm.Show();
                        break;
                    }
                default:
                    {
                        break;
                    }
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        public void InitializeCombobox()
        {
            cbAuthorityLevel.Items.Add("Admin");
            cbAuthorityLevel.Items.Add("Werehouse Manage");
            cbAuthorityLevel.Items.Add("Sale");

            cbAuthorityLevel.SelectedIndex = 0;
        }

        private void MangeEmployee_Form_Load(object sender, EventArgs e)
        {
            LoadEmployeeData();
            ChangeButtonStatus(false);
            InitializeCombobox();

        }

      
        private bool ValidataData(string employeeCode, string employeeName, string employeePosition, string authorityLevel, string username, string password)
        {
            bool isValid = true;
            if (employeeCode == null || employeeCode == string.Empty)
            {
                MessageBox.Show(
                    "Employee Code cannot be blank",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtEmployeeCode.Focus();
                isValid = false;
            }
            else if (employeeName == null || employeeName == string.Empty)
            {
                MessageBox.Show(
                     "EmployeeName cannot be blank",
                     "Error",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
                txtEmployeeName.Focus();
                isValid = false;
            }
            else if (employeePosition == null || employeePosition == string.Empty)
            {
                MessageBox.Show(
                    "employeePosition cannot be blank",
                     "Error",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
                txtEmployeePosition.Focus();
                isValid = false;
            }
            else if (authorityLevel == null || authorityLevel == string.Empty)
            {
                MessageBox.Show(
                     "Employee Code cannot be blank",
                     "Error",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
                cbAuthorityLevel.Focus();
                isValid = false;
            }
            else if (username == null || username == string.Empty)
            {
                MessageBox.Show(
                    "username cannot be blank",
                     "Error",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
                txtUsername.Focus();
                isValid = false;
            }
            else if (password == null || password == string.Empty)
            {
                MessageBox.Show(
                     "Password cannot be blank",
                     "Error",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
                txtPassword.Focus();
                isValid = false;
            }
            return isValid;
        }
        private void ChangeButtonStatus(bool buttonStatus)
        {
            // when employee is selected, button add will be disables
            // button Update, delete & Clear will be enabled and vice versa
            //btnUpdate.Enabled = buttonStatus;
            //btnDelete.Enabled = buttonStatus;
            //btnClear.Enabled = buttonStatus;
            //btnAdd.Enabled = buttonStatus;
        }
        private void FlushEmployeeID()
        {
            // Flush employee value to check button and setuo status for butoons
            this.employeeID = 0;
            ChangeButtonStatus(false);
        }
        private void LoadEmployeeData()
        {
            SqlConnection connection = DatabaseConnection.GetConnection();
            if (connection != null)
            {
                connection.Open();
                string sql = "SELECT * FROM Employee";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dtgEmployee.DataSource = table;
                connection.Close();
            }
        }
        private void ClearData()
        {
            FlushEmployeeID();
            txtEmployeeCode.Text = string.Empty;
            txtEmployeeName.Text = string.Empty;
            txtEmployeePosition.Text = string.Empty;
            cbAuthorityLevel.SelectedIndex = 0;
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtEmployeeCode.Focus();
        }
        private void cbAuthorityLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            // setup for combobox
            cbAuthorityLevel.Items.Add("Admin");
            cbAuthorityLevel.Items.Add("Warehouse Manager");
            cbAuthorityLevel.Items.Add("Sale");
            // set the selected index to the first item of the aray ( admin )
            cbAuthorityLevel.SelectedIndex = 0;
        }

        private bool CheckUserExistence(int employeeId)
        {
            bool isExist = false;
            SqlConnection connection = DatabaseConnection.GetConnection();

            if (connection != null)
            {
                connection.Open();
                string checkCustomerQuery = "SELECT * FROM Employee WHERE EmployeeID = @employeeId";

                // Declare SqlCommand variable to add parameters to query and execute it
                SqlCommand command = new SqlCommand(checkCustomerQuery, connection);

                // Add parameters
                command.Parameters.AddWithValue("@employeeId", employeeId);

                // Declare SqlDataReader variable to read retrieved data
                SqlDataReader reader = command.ExecuteReader();

                // Check if reader has row (query success and return one row show user information)
                isExist = reader.HasRows;

                // Close the connection
                connection.Close();
            }

            return isExist;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string search = txtSearch.Text;
            SearchUser(search);
        }
        private void AddUser(string employeeCode,
                             string employeeName,
                             string employeePosition,
                             string authorityLevel,
                             string username,
                             string password)
        {
            SqlConnection connection = DatabaseConnection.GetConnection();
            if (connection == null)
            {
                connection.Open();
                string sql = "INSET INTO Employee VALUES (@employeeCode, " +
                    "@employeeName, @employeePosition, " +
                    "@authorityLevel, @username, @password, 0)";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("employeeCode", employeeCode);
                command.Parameters.AddWithValue("employeeName", employeeName);
                command.Parameters.AddWithValue("employeePosition", employeePosition);
                command.Parameters.AddWithValue("authorityLevel", authorityLevel);
                command.Parameters.AddWithValue("username", username);
                command.Parameters.AddWithValue("password", password);

                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show(
                        "Successfully add new user",
                        "Information",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    ClearData();
                    LoadEmployeeData();
                }
                else
                {
                    MessageBox.Show(
                        "Cannot add new user",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                }
                connection.Close();
            }
        }
        private void UpdateUser(int employeID, 
                             string employeeCode,
                             string employeeName,
                             string employeePosition,
                             string authorityLevel,
                             string username,
                             string password)
        {
            SqlConnection connection = DatabaseConnection.GetConnection();
            if (connection != null)
            {
                connection.Open();
                string sql = "UPDATE Employee SET EmployeeCode = @employeeCode," + "EmployeeName = @employeeName," + 
                    "Position = @employeePosition," + "AjthorityLevel = @authorityLevel," + 
                    "Username = @username," + "Password = @passowrd" + "WHERE EmployeeID = @employeeID";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("employeeCode", employeeCode);
                command.Parameters.AddWithValue("employeeName", employeeName);
                command.Parameters.AddWithValue("employeePosition", employeePosition);
                command.Parameters.AddWithValue("authorityLevel", authorityLevel);
                command.Parameters.AddWithValue("username", username);
                command.Parameters.AddWithValue("password", password);
                command.Parameters.AddWithValue("employeeID", employeID);
                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show(
                        "Successfully update user",
                        "Information",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    ClearData();
                    LoadEmployeeData();
                }
                else
                {
                    MessageBox.Show(
                        "Cannot update user",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                connection.Close();

            }

        }
        private void DeleteUser(int employeeID)
        {
            SqlConnection connection = DatabaseConnection.GetConnection();
            if (connection == null)
            {
                connection.Open();
                string sql = "DELETE Employee WHERE EmployeeID = @employeeID";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("employee", employeeID);
                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show(
                        "Successfully delete user",
                        "Information",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    ClearData();
                    LoadEmployeeData();
                }
                else
                {
                    MessageBox.Show(
                        "Cannot delete user",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                connection.Close();
            }
        }
        private void SearchUser(string search)
        {
            if (string.IsNullOrEmpty(search))
            {
                LoadEmployeeData();
            }
            else
            {
                SqlConnection connection = DatabaseConnection.GetConnection();
                if (connection == null)
                {
                    connection.Open();
                    string query = "SELECT * FROM Employee WHERE EmployeeCode LIKE @search" +
                        "OR EmployeeName LIKE @search" +
                        "OR Position LIKE @search" +
                        "OR AujthorityLevel LIKE @search" +
                        "OR Username LIKE @search" +
                        "OR Password LIKE @search";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("search", "%" + search + "%");
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dtgEmployee.DataSource = table;
                    connection.Close();
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string employeeCode = txtEmployeeCode.Text;
            string employeeName = txtEmployeeName.Text;
            string employeePosition = txtEmployeePosition.Text;
            string authorityLevel = cbAuthorityLevel.SelectedItem.ToString();
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            bool isValid = ValidataData(employeeCode, employeeName, employeePosition, authorityLevel, username, password);
            if (isValid)
            {
                AddUser(employeeCode, employeeName, employeePosition, authorityLevel, username, password);
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string employeeCode = txtEmployeeCode.Text;
            string employeeName = txtEmployeeName.Text;
            string employeePosition = txtEmployeePosition.Text;
            string authorityLevel = cbAuthorityLevel.SelectedItem.ToString();
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            bool isValid = ValidataData(employeeCode, employeeName, employeePosition, authorityLevel, username, password);
            if (isValid)
            {
                UpdateUser (employeeID, employeeCode, employeeName, employeePosition, authorityLevel, username, password);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Do you want to delete this user",
                "Warrning",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DeleteUser(employeeID);
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void dtgEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dtgEmployee.CurrentCell.RowIndex;
            if (index == -1)
            {
                employeeID = Convert.ToInt32(dtgEmployee.Rows[index].Cells[0].Value);
                ChangeButtonStatus(true);
                txtEmployeeCode.Text = dtgEmployee.Rows[index].Cells[1].Value.ToString();
                txtEmployeeCode.Text = dtgEmployee.Rows[index].Cells[2].Value.ToString();
                txtEmployeePosition.Text = dtgEmployee.Rows[index].Cells[3].Value.ToString();
                string authorityLevel = dtgEmployee.Rows[index].Cells[4].Value.ToString();
                if (authorityLevel == "Admin")
                {
                    cbAuthorityLevel.SelectedIndex = 0;
                }
                else if (authorityLevel == "Werehouse Maneger")
                {
                    cbAuthorityLevel.SelectedIndex = 1;
                }
                else if (authorityLevel == "Sale")
                {
                    cbAuthorityLevel.SelectedIndex = 2;
                }
                txtUsername.Text = dtgEmployee.Rows[index].Cells[5].Value.ToString();
                txtPassword.Text = dtgEmployee.Rows[index].Cells[6].Value.ToString();
            }

        }

        private void lblPosition_Click(object sender, EventArgs e)
        {

        }
    }
}
