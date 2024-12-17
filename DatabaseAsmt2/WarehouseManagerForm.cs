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
    public partial class WarehouseManagerForm : Form
    {
        private string authorityLevel;
        private int employeeId;
        public WarehouseManagerForm(string authorityLevel, int employeeId)
        {
            InitializeComponent();
            this.authorityLevel = authorityLevel;
            this.employeeId = employeeId;
        }

        private void WarehouseManagerForm_Load(object sender, EventArgs e)
        {

        }

        private void gbWerehousefatures_Enter(object sender, EventArgs e)
        {

        }

        private void btnManageProduct_Click(object sender, EventArgs e)
        {
            Manager_Product manageProduct = new Manager_Product(this.authorityLevel, this.employeeId);
            this.Hide();
            manageProduct.Show();
        }
    }
}
