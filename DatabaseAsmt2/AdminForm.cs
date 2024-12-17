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
    public partial class AdminForm : Form
    {
        private string authorityLevel;
        private int employeeId;
        private string employeePosition;


        public AdminForm(string selectedRole, int employeeID)
        {
            InitializeComponent();
            this.employeeId = employeeID;
            this.authorityLevel = selectedRole;
        }

        private void btnManageEmployee_Click(object sender, EventArgs e)
        {
            MangeEmployee_Form manageEmployee = new MangeEmployee_Form(employeePosition);
            this.Hide();
            manageEmployee.Show();
        }

        private void btnManageProduct_Click(object sender, EventArgs e)
        {
            Manager_Product manageProduct = new Manager_Product();
            this.Hide();
            manageProduct.Show();
        }

        private void btnManageCategory_Click(object sender, EventArgs e)
        {

        }

        private void btnManageOrder_Click(object sender, EventArgs e)
        {

        }

        private void btnManageImport_Click(object sender, EventArgs e)
        {

        }

        private void btnViewStatistic_Click(object sender, EventArgs e)
        {

        }
    }
}
