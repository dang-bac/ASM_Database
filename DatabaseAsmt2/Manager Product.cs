using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseAsmt2
{
    public partial class Manager_Product : Form
    {
        private int productId;
        private string authorityLevel;
        private int userId;
        public Manager_Product(string authorityLevel, int userId)
        {
            this.authorityLevel = authorityLevel;
            this.userId = userId;
            productId = 0;
            InitializeComponent();
        }
        public Manager_Product()
        {
            InitializeComponent();
        }

        private void Manager_Product_Load(object sender, EventArgs e)
        {
            LoadProductData();
            LoadSupplierCombobox();
            LoadCategoryCombobox();
            ChangeButtonStatus(false);
        }
        private void LoadCategoryCombobox()
        {
            SqlConnection connection = DatabaseConnection.GetConnection();
            if (connection != null)
            {
                connection.Open();
                string query = "SELECT CategoryID, CategoryName FROM category";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                cbCategory.DataSource = dataTable;
                cbCategory.DisplayMember = "CategoryName";
                cbCategory.ValueMember = "CategoryID";

            }
        }

        private void LoadSupplierCombobox()
        {
            SqlConnection connection = DatabaseConnection.GetConnection();
            if (connection != null)
            {
                connection.Open();
                string query = "SELECT SupplierID, SupplierName FROM Supplier";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                cbSupplier.DataSource = dataTable;
                cbSupplier.DisplayMember = "SupplierName";
                cbSupplier.ValueMember = "SupplierID";

            }
        }

        private bool ValidateData(string productCode, string productName, string productprice, string productQuantity)
        {
            double temp;
            int temp2;
            if (String.IsNullOrEmpty(productName)) { return false; }
            if (String.IsNullOrEmpty(productprice)) { return false; }
            if (!double.TryParse(productprice, out temp)) { return false; }
            if (String.IsNullOrEmpty(productQuantity)) { return false; }
            return int.TryParse(productQuantity, out temp2);
        }
        //private void UploadFile(String filter, String path)
        //{
        //    OpenFileDialog openFileDialog = new OpenFileDialog();
        //    openFileDialog.Filter = filter;
        //    openFileDialog.Title = "Select a file to up load";
        //    if (openFileDialog.ShowDialog() == DialogResult.OK)
        //    {
        //        string sourceFilePath = openFileDialog.FileName;
        //        string targetDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Uploads");
        //        string targetFilePath = Path.Combine(targetDirectory, Path.GetFileName(sourceFilePath));

        //        try
        //        {
        //            if (!Directory.Exists(targetDirectory))
        //            {
        //                Directory.CreateDirectory(targetDirectory);

        //            }
        //            File.Copy(sourceFilePath, targetFilePath, overwrite: true);
        //            txtProductImg.Text = targetFilePath;
        //            MessageBox.Show("File uploaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Eror uploading file:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        //        }
        //    }
        //}
        private void LoadProductData()
        {
            SqlConnection connection = DatabaseConnection.GetConnection();
            if (connection != null)
            {
                connection.Open();
                string query = "SELECT p.DiamondID, p.DiamondName, c.CategoryName, p.Price, p.ProductCode, s.SupplierName, p.InventoryQuantity " +
                                "FROM Diamond p " +
                                "INNER JOIN Category c ON p.CategoryID = c.CategoryID " +
                                "INNER JOIN Supplier s ON p.SupplierID = s.SupplierID";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                //adapter.Fill(dataTable);
                dtgProduct.DataSource = dataTable;
                connection.Close();
            }
        }
        private void ClearData()
        {
            FlushProductId();
            txtProductCode.Text = string.Empty;
            txtProductName.Text = string.Empty;
            txtProductQuantity.Text = string.Empty;
            txtSearch.Text = string.Empty;
        }
        private void ChangeButtonStatus(bool buttonStatus)
        {
            btnUpdate.Enabled = buttonStatus;
            btnDelete.Enabled = buttonStatus;
            btnClear.Enabled = buttonStatus;
            btnAdd.Enabled = !buttonStatus;
        }
        private void FlushProductId()
        {
            this.productId = 0;
            ChangeButtonStatus(false);
        }
        private void AddProduct()
        {
            SqlConnection connection = DatabaseConnection.GetConnection();
            if (connection != null)
            {
                connection.Open();
                string productCode = txtProductCode.Text;
                string productName = txtProductName.Text;
                int supplierId = Convert.ToInt32(cbSupplier.SelectedValue);
                string price = txtProductPrice.Text;
                string quantity = txtProductQuantity.Text;
                int categoryId = Convert.ToInt32(cbCategory.SelectedValue);
                if (ValidateData(productCode, productName, price, quantity))
                {
                    string sql = "INSERT INTO Diamond VALUES (@productName, @categoryId, @productPrice, @productCode, @supplierId, @productQuantity)";
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("productCode", productCode);
                    command.Parameters.AddWithValue("productName", productName);
                    command.Parameters.AddWithValue("productPrice", Convert.ToDouble(price));
                    command.Parameters.AddWithValue("productQuantity", Convert.ToInt32(quantity));
                    command.Parameters.AddWithValue("supplierId", supplierId);
                    command.Parameters.AddWithValue("categoryId", categoryId);
                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show(
                            "Successfully add new product",
                            "Ìnormation",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        ClearData();
                        LoadProductData();
                    }
                    else
                    {
                        MessageBox.Show(
                            "Cannot add new product",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }

                }
                connection.Close();
            }
        }
        private void UpdateProdcut()
        {
            SqlConnection connection = DatabaseConnection.GetConnection();
            if (connection != null)
            {
                connection.Open();
                string productCode = txtProductCode.Text;
                string productName = txtProductName.Text;
                int supplierId = Convert.ToInt32(cbSupplier.SelectedValue);
                string price = txtProductPrice.Text;
                string quantity = txtProductQuantity.Text;
                int categoryId = Convert.ToInt32(cbCategory.SelectedValue);
                if (ValidateData(productCode, productName, price, quantity))
                {
                    string sql = "UPDATE Diamond SET DiamondName = @productName, ProductCode = @productCode, " +
                     "SupplierID = @supplierId, Price = @productPrice, " +
                     "InventoryQuantity = @productQuantity, CategoryID = @categoryId " +
                     "WHERE ProductID = @productId";
                    SqlCommand command = new SqlCommand(sql, connection);

                    // Add parameters
                    command.Parameters.AddWithValue("@productCode", productCode);
                    command.Parameters.AddWithValue("@productName", productName);
                    command.Parameters.AddWithValue("@productPrice", Convert.ToDouble(price));
                    command.Parameters.AddWithValue("@productQuantity", Convert.ToInt32(quantity));
                    command.Parameters.AddWithValue("@categoryId", categoryId);
                    command.Parameters.AddWithValue("@productId", this.productId);

                    // Execute query and get the result
                    int result = command.ExecuteNonQuery();

                    // Check the result
                    if (result > 0)
                    {
                        MessageBox.Show("Successfully update product", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearData();
                        LoadProductData();
                    }
                    else
                    {
                        MessageBox.Show("Cannot update product", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                // Close the connection
                connection.Close();
            }
        }
        private void UpdateProduct()
        {
            // Open connection by call the GetConnection function in DatabaseConnection class
            SqlConnection connection = DatabaseConnection.GetConnection();

            // Check connection
            if (connection != null)
            {
                connection.Open();
                string productCode = txtProductCode.Text;
                string productName = txtProductName.Text;
                int supplierId = Convert.ToInt32(cbSupplier.SelectedValue);
                string price = txtProductPrice.Text;
                string quantity = txtProductQuantity.Text;
                int categoryId = Convert.ToInt32(cbCategory.SelectedValue);
                if (ValidateData(productCode, productName, price, quantity))
                {
                    string sql = "UPDATE Diamond SET DiamondName = @productName, ProductCode = @productCode, " +
                     "SupplierID = @supplierId, Price = @productPrice, " +
                     "InventoryQuantity = @productQuantity, CategoryID = @categoryId " +
                     "WHERE ProductID = @productId";
                    SqlCommand command = new SqlCommand(sql, connection);

                    // Add parameters
                    command.Parameters.AddWithValue("@productCode", productCode);
                    command.Parameters.AddWithValue("@productName", productName);
                    command.Parameters.AddWithValue("@productPrice", Convert.ToDouble(price));
                    command.Parameters.AddWithValue("@productQuantity", Convert.ToInt32(quantity));
                    command.Parameters.AddWithValue("@categoryId", categoryId);
                    command.Parameters.AddWithValue("@productId", this.productId);

                    // Execute query and get the result
                    int result = command.ExecuteNonQuery();

                    // Check the result
                    if (result > 0)
                    {
                        MessageBox.Show("Successfully update product", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearData();
                        LoadProductData();
                    }
                    else
                    {
                        MessageBox.Show("Cannot update product", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                // Close the connection
                connection.Close();
            }
        }
        private void DeleteProduct()
        {
            // Ask for confirmation
            DialogResult dialogResult = MessageBox.Show("Do you want to delete the product?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                // Check if product in any order
                // If it save, deny this action because this can cause exception while running
                if (IsProductInOrder(this.productId))
                {
                    MessageBox.Show("Product is in another order\nCannot delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // Open connection by call the GetConnection function in DatabaseConnection class
                    SqlConnection connection = DatabaseConnection.GetConnection();

                    // Check connection
                    if (connection != null)
                    {
                        // Open the connection
                        connection.Open();

                        // declare query
                        string sql = "DELETE FROM Product WHERE ProductID = @productId";

                        // declare sqlcommand variable to manipulate query
                        SqlCommand command = new SqlCommand(sql, connection);

                        // add params
                        command.Parameters.AddWithValue("@productId", this.productId);

                        // execute query and get the result
                        int result = command.ExecuteNonQuery();

                        // check result
                        if (result > 0)
                        {
                            MessageBox.Show("Successfully delete product", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearData();
                            LoadProductData();
                        }
                        else
                        {
                            MessageBox.Show("Cannot delete product", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        // close the connection
                        connection.Close();
                    }
                }
            }
        }
        private bool IsProductInOrder(int productId)
        {
            // Open connection by call the GetConnection function in DatabaseConnection class
            SqlConnection connection = DatabaseConnection.GetConnection();

            // Check connection
            if (connection != null)
            {
                // Open the connection
                connection.Open();

                // declare query to get number of record have productId equal productId
                string sql = "SELECT COUNT(*) FROM OrderDetail WHERE ProductID = @productId";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@productId", productId);

                // execute query and get the result
                int result = (int)command.ExecuteScalar();
                connection.Close();

                return result > 0;
            }

            return false;
        }

        private void SearchProduct(string search)
        {
            // If the search string is empty, load all products
            if (string.IsNullOrEmpty(search))
            {
                LoadProductData();
            }
            else
            {
                // Open connection by call the GetConnection function in DatabaseConnection class
                SqlConnection connection = DatabaseConnection.GetConnection();

                // Check connection
                if (connection != null)
                {
                    // Open the connection
                    connection.Open();

                    // Declare query to get the product, product code, category name, price, 
                    // inventory quantity, product image, category name
                    string sql = "SELECT p.DiamondID, p.DiamondName, c.CategoryName, p.Price, p.ProductCode, s.SupplierName, p.InventoryQuantity " +
                                "FROM Diamond p " +
                                "INNER JOIN Category c ON p.CategoryID = c.CategoryID " +
                                "INNER JOIN Supplier s ON p.SupplierID = s.SupplierID " +
                                "WHERE p.ProductCode LIKE @search " +
                                "OR p.DiamondName LIKE @search " +
                                "OR c.CategoryName LIKE @search " +
                                "OR s.SupplierName LIKE @search";

                    // Initialize SqlDataAdapter to translate query result to a data table
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);

                    // Add params to query
                    adapter.SelectCommand.Parameters.AddWithValue("@search", "%" + search + "%");

                    // Initialize data table
                    DataTable data = new DataTable();

                    // Fill the data table with data queried from database
                    adapter.Fill(data);

                    // Set the data source for data table
                    dtgProduct.DataSource = data;

                    // Close the connection
                    connection.Close();
                }
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            switch (authorityLevel)
            {
                case "Admin":
                    AdminForm adminForm = new AdminForm(this.authorityLevel, this.userId);
                    this.Hide();
                    adminForm.Show();
                    break;

                case "Warehouse Manager":
                    WarehouseManagerForm warehouseManagerForm = new WarehouseManagerForm(this.authorityLevel, this.userId);
                    this.Hide();
                    warehouseManagerForm.Show();
                    break;

                case "Sale":
                    SaleForm saleForm = new SaleForm(this.authorityLevel, this.userId);
                    this.Hide();
                    saleForm.Show();
                    break;

                default:
                    break;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateProduct();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteProduct();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearData();

        }

        //private void btnUpload_Click(object sender, EventArgs e)
        //{
        //    UploadFile("Image Files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png", @"C:\Uploads");

        //}

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddProduct();
        }

        private void dtgProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            
            // Set row index based on current cell clicked
            int rowIndex = dtgProduct.CurrentCell.RowIndex;

            // Check index >= 0 && currentRow.IsNewRow
            if (rowIndex >= 0 && !dtgProduct.Rows[rowIndex].IsNewRow)
            {
                // Get value of each cell based on row index 
                // (use this query to execute in SSMS to imagine the datagridview:
                //SELECT ProductID, ProductName, CategoryID, Price, ProductCode, SupplierID FROM Product);

                // Change button status to true (update, delete, clear is enable when productId is assigned with value > 0)
                ChangeButtonStatus(true);

                // Get the Product Code (index is 1)
                txtProductCode.Text = dtgProduct.Rows[rowIndex].Cells[4].Value.ToString();

                // Get the Product Name (index is 2)
                txtProductName.Text = dtgProduct.Rows[rowIndex].Cells[1].Value.ToString();

                // Get the Product Price (index is 3)
                txtProductPrice.Text = dtgProduct.Rows[rowIndex].Cells[3].Value.ToString();

                // Get the Product Quantity (index is 4)
                txtProductQuantity.Text = dtgProduct.Rows[rowIndex].Cells[6].Value.ToString();

                // Get the Img URL (index is 5)
                string supplierName = dtgProduct.Rows[rowIndex].Cells[5].Value.ToString();
                for (int i = 0; i < cbSupplier.Items.Count; i++)
                {
                    DataRowView row = (DataRowView)cbSupplier.Items[i];
                    if (row["SupplierName"].ToString() == supplierName)
                    {
                        cbSupplier.SelectedIndex = i;
                        break;
                    }
                }

                // Get the CategoryName (index is 6) and check in combobox to select the equal value
                string categoryName = dtgProduct.Rows[rowIndex].Cells[2].Value.ToString();
                for (int i = 0; i < cbCategory.Items.Count; i++)
                {
                    DataRowView row = (DataRowView)cbCategory.Items[i];
                    if (row["CategoryName"].ToString() == categoryName)
                    {
                        cbCategory.SelectedIndex = i;
                        break;
                    }
                }
                this.productId = Convert.ToInt32(dtgProduct.Rows[rowIndex].Cells[0].Value);
            }

        }
    }
}
