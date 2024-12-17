using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseAsmt2
{
    public partial class gbManageCustomer : Form
    {
        private int customerId;
        private int employeeId;
        private string authorityLevel;
        private int userId;
        public gbManageCustomer(string authorityLevel, int employee)
        {
            InitializeComponent();
            this.employeeId = employee;
            this.authorityLevel = authorityLevel;

        }


        public gbManageCustomer()
        {
            InitializeComponent();

        }

        private void gbManageCustomer_Load(object sender, EventArgs e)
        {
            LoadCustomerData();
        }
        private void ChangeButtonStatus(bool buttonStatus)
        {
            btnUpdate.Enabled = buttonStatus;
            btnDelete.Enabled = buttonStatus;
            btnClear.Enabled = buttonStatus;
            btnAdd.Enabled = buttonStatus;
        }
        private bool ValidateData(string customerCode, string customerName, string phoneNumber)
        {
            bool isValid = true;
            if (customerCode == null || customerCode == string.Empty)
            {
                MessageBox.Show(
                    "Customer Code cannot be blank",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                isValid = false;
                txtCustomerCode.Focus();
            }
            else if (customerName == null || customerName == string.Empty)
            {
                MessageBox.Show(
                    "Customer Name cannot be blank",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                isValid = false;
                txtCustomerName.Focus();
            }
        
            else if (phoneNumber == null || phoneNumber == string.Empty)
            {
                MessageBox.Show(
                    "Phonenumber cannot be blank",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                isValid = false;
                txtPhonenumber.Focus();
            }
            return isValid;
        }
        private void FlushCustomer()
        {
            this.customerId = 0;
            ChangeButtonStatus(false);
        }
        private void LoadCustomerData()
        {
            SqlConnection connection = DatabaseConnection.GetConnection();
            if (connection != null)
            {
                connection.Open();
                string query = "SELECT * FROM Customer";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dtgCustomer.DataSource = table;
                connection.Close();
            }
        }
        private bool CheckUserExistence(int customerId)
        {
            bool isExist = false;
            SqlConnection connection = DatabaseConnection.GetConnection();
            if (connection != null)
            {
                connection.Open();
                string checkCustomerQuery = "SELECT * FROM Customer WHERE CustomerId = @customerId";
                SqlCommand command = new SqlCommand(checkCustomerQuery, connection);
                command.Parameters.AddWithValue(checkCustomerQuery, customerId);
                SqlDataReader reader = command.ExecuteReader();
                isExist = reader.HasRows;
                connection.Close();
            }
            return isExist;
        }
        private void AddCustomer(string customerCode, string phoneNumber, string customerName)
        {
            SqlConnection connection = DatabaseConnection.GetConnection();
            if (connection != null)
            {
                connection.Open();
                string query = "INSERT INTO Customer (CustomerCode, Phonenumber, CustomerName) " +
                                "VALUES (@CustomerCode, @Phonenumber, @CustomerName)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("customerCode", customerCode);
                command.Parameters.AddWithValue("phoneNumber", phoneNumber);
                command.Parameters.AddWithValue("customerName", customerName);
                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show(
                        "Successfully add new customer",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                        );
                }
                else
                {
                    MessageBox.Show(
                        "An eror occur while adding customer",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );
                }
                connection.Close();
                ClearData();
                LoadCustomerData();

            }
        }

        private void ClearData()
        {
            throw new NotImplementedException();
        }

        private void updateCustomer(int customerId, string customerCode, string customerName, string phoneNumber)
        {
            SqlConnection connection = DatabaseConnection.GetConnection();
            if (connection != null)
            {
                connection.Open();
                string query = "UPDATE Customer SET " +
                    "CustomerCode = @customerCode, " +
                    "CustomerName = @CustomerName, " +
                    "phoneNumber = @phoneNumber " +
                    "WHERE CustomerId = @customerId";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("customerCode", customerCode);
                cmd.Parameters.AddWithValue("customerName", customerName);
                cmd.Parameters.AddWithValue("phoneNumber", phoneNumber);
                cmd.Parameters.AddWithValue("customerId", customerId);
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show(
                        "Successfully update customer",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                        );
                }
                else
                {
                    MessageBox.Show(
                        "An error occur while updating customer",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );
                }
                connection.Close();
                ClearData();
                LoadCustomerData();

            }
        }
        private void DeleteCustomer(int customerId)
        {
            SqlConnection connection = DatabaseConnection.GetConnection();
            if (connection != null)
            {
                connection.Open();
                string deleteOrderDetailQuery = "SELETE SaleDetail WHERE SaleDatailID IN " +
                    "(SELECT SaleID FROM Sales WHERE CustomerID = @customerId)";
                SqlCommand cmd = new SqlCommand(deleteOrderDetailQuery, connection);
                cmd.Parameters.AddWithValue("customerId", customerId);
                cmd.ExecuteNonQuery();
                string deleteOrderQuery = "DELETE Sales WHERE CustomerID = @customerId";
                cmd = new SqlCommand(deleteOrderQuery, connection);
                cmd.Parameters.AddWithValue("customerID", customerId);
                cmd.ExecuteNonQuery();
                string deleteCustomerQuery = "DELETE Customer WHERE CustomerID = @customerID";
                cmd = new SqlCommand(deleteCustomerQuery, connection);
                cmd.Parameters.AddWithValue("customerId", customerId);
                int deleteCusstomerResult = cmd.ExecuteNonQuery();
                if (deleteCusstomerResult > 0)
                {
                    MessageBox.Show(
                        "Successfully delete customer",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                        );
                }
                else
                {
                    MessageBox.Show(
                        "An eror occur while deleting customer",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                }
                connection.Close();
                ClearData();
                LoadCustomerData();

            }
        }
        private void SearchCustomer(string search)
        {
            if (string.IsNullOrEmpty(search))
            {
                LoadCustomerData();
            }
            else
            {
                SqlConnection connection = DatabaseConnection.GetConnection();
                if (connection != null)
                {
                    connection.Open();
                    string query = "SELECT * FROM Customer WHERE CustomerCode LIKE @search OR CustomerName LIKE @search OR Phonenumber LIKE @search";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("search", "%" + search + "%");
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dtgCustomer.DataSource = table;
                    connection.Close();
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string customerCode = txtCustomerCode.Text;
            string customerName = txtCustomerName.Text;
            string phoneNumber = txtPhonenumber.Text;
            bool isValid = ValidateData(customerCode, customerName, phoneNumber);
            if (isValid)
            {
                AddCustomer(customerCode, customerName, phoneNumber);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (customerId > 0)
            {
                DialogResult result = MessageBox.Show(
                    "Do you want to delete this customer with all related date?",
                    "Warning",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    bool isUserExist = CheckUserExistence(customerId);
                    if (isUserExist)
                    {
                        DeleteCustomer(customerId);

                    }
                    else
                    {
                        MessageBox.Show(
                            "No customer found",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            switch (authorityLevel)
            {
                case "Admin":
                    {
                        AdminForm adminForm = new AdminForm(this.authorityLevel, this.userId);
                        this.Hide();
                        adminForm.Show();
                        break;
                    }
                case "Warehouse Manager":
                    {
                        WarehouseManagerForm warehouseManagerForm = new WarehouseManagerForm(this.authorityLevel, this.userId);
                        this.Hide();
                        warehouseManagerForm.Show();
                        break;
                    }
                case "Sale":
                    {
                        SaleForm saleForm = new SaleForm(this.authorityLevel, this.userId);
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

        private void dtgCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dtgCustomer.CurrentCell.RowIndex;
            if (index > -1)
            {
                customerId = (int)dtgCustomer.Rows[index].Cells[0].Value;
                txtCustomerCode.Text = dtgCustomer.Rows[index].Cells[1].Value.ToString();
                txtCustomerName.Text = dtgCustomer.Rows[index].Cells[2].Value.ToString();
                txtPhonenumber.Text = dtgCustomer.Rows[index].Cells[3].Value.ToString();
                ChangeButtonStatus(true);

            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string search = txtSearch.Text;
            SearchCustomer(search);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Check customerId
            if (customerId > 8)
            {
                // Check user existence
                bool isUserExist = CheckUserExistence(customerId);
                if (isUserExist)
                {
                    // Get data from user input
                    string customerCode = txtCustomerCode.Text;
                    string customerName = txtCustomerName.Text;
                    string phoneNumber = txtPhonenumber.Text;

                    // Validate data
                    bool isValid = ValidateData(customerCode, customerName, phoneNumber);
                    if (isValid)
                    {
                        updateCustomer(customerId, customerCode, customerName, phoneNumber);
                    }
                }
                else
                {
                    // Show error message
                    MessageBox.Show("No customer found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
