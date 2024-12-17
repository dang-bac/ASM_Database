using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseAsmt2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeCombobox();
        }

        private void InitializeCombobox()
        {
            // Setup for combobox
            cbRole.Items.Add("Admin");
            cbRole.Items.Add("Warehouse Manager");
            cbRole.Items.Add("Sale");
            // Set the selected index to the first item of the array (Admin)
            cbRole.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string role = cbRole.SelectedItem.ToString();
            bool isValid = ValidateData(username, password, role);
            if (isValid)
            {
                SqlConnection connection = DatabaseConnection.GetConnection();
                if (connection != null)
                {
                    string query = "SELECT EmployeeID,PasswordChanged FROM Employee WHERE Username = @username AND Password = @password AND AuthorityLevel = @role";

                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("username", username);
                    command.Parameters.AddWithValue("password", password);
                    command.Parameters.AddWithValue("role", role);

                    SqlDataReader reader = command.ExecuteReader();
                    int employeeID = 0;
                    bool passwordChanged = false;
                    while (reader.Read())
                    {
                        employeeID = reader.GetInt32(reader.GetOrdinal("EmployeeID"));
                        passwordChanged = reader.GetBoolean(reader.GetOrdinal("Passwordchanged"));
                    }
                    if (employeeID > 0)
                    {
                        MessageBox.Show(
                            "Login success",
                            "Information",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        RedirectPage(role, employeeID, passwordChanged);

                    }
                    else
                    {
                        MessageBox.Show(
                            "Invalid login credential",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        ClearData();
                    }
                    reader.Close();
                    connection.Close();
                }
            }

        }

        private void ClearData()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            cbRole.SelectedIndex = 0;
            txtUsername.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearData();
        }
        private bool ValidateData(string username, string password, string role)
        {
            bool isValid = true;
            if (username == null || username == string.Empty)
            {
                MessageBox.Show(
                    "Username cannot be blank",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                isValid = false;
                txtUsername.Focus();

            }
            else if (password == null || password == string.Empty)
            {
                MessageBox.Show(
                    "Password connot be blank",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
            else if (role == null || role == string.Empty)
            {
                MessageBox.Show(
                    "No role selected",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                isValid = false;
                cbRole.Focus();
            }
            return isValid;
        }
        private void RedirectPage(string selectedRole, int employeeID, bool isChangePassword)
        {
            if (isChangePassword)
            {
                if (selectedRole != null)
                {
                    if (selectedRole == "Admin")
                    {
                        AdminForm adminForm = new AdminForm(selectedRole, employeeID);
                        this.Hide();
                        adminForm.Show();
                    }
                    else if (selectedRole == "Warehouse Manager")
                    {
                        WarehouseManagerForm warehouseManagerForm = new WarehouseManagerForm(selectedRole, employeeID);
                        this.Hide();
                        warehouseManagerForm.Show();
                    }
                    else if (selectedRole == "Sale")
                    {
                        SaleForm saleForm = new SaleForm(selectedRole, employeeID);
                        this.Hide();
                        saleForm.Show();
                    }
                }
            }

        }
    }
}
