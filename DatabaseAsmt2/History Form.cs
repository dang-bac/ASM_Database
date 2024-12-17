using Azure;
using Azure.Core.Pipeline;
using Microsoft.Data.SqlClient;

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
    public partial class History_Form : Form
    {
        private int employeeId;
        private string authorityLevel;
        public History_Form()
        {
            InitializeComponent();
        }

        private void History_Form_Load(object sender, EventArgs e)
        {
            SqlConnection connection = DatabaseConnection.GetConnection();
            if (connection != null)
            {
                connection.Open();
                string query = "SELECT s.SaleDate, e.EmployeeId, c.CustomerId " +
                       "FROM Sale s " +
                       "INNER JOIN Employee e ON s.EmployeeId = e.EmployeeId " +
                       "INNER JOIN Customer c ON s.CustomerId = c.CustomerId " +
                       "WHERE s.EmployeeId = @employeeId ";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@employeeId", employeeId);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dtgOrderHistory.DataSource = dataTable;
            }
        }
        private void RedirectPage()
        {
            switch (this.authorityLevel)
            {
                case "Admin":
                    AdminForm adminForm = new AdminForm(authorityLevel, employeeId);
                    this.Hide();
                    adminForm.Show();
                    break;

                case "Warehouse Manager":
                    WarehouseManagerForm warehouseManagerForm = new WarehouseManagerForm(authorityLevel, employeeId);
                    this.Hide();
                    warehouseManagerForm.Show();
                    break;

                case "Sale":
                    gbManageCustomer saleForm = new gbManageCustomer(authorityLevel, employeeId);
                    this.Hide();
                    saleForm.Show();
                    break;

                default:
                    break;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            RedirectPage();
        }

        private void dtgOrderHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
