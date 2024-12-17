using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseAsmt2
{
    public partial class SaleForm : Form
    {
        private string authorityLevel;
        private int employeeId;
        public SaleForm(string authorityLevel, int employeeId)
        {
            InitializeComponent();
            this.authorityLevel = authorityLevel;
            this.employeeId = employeeId;
        }

        private void SaleForm_Load(object sender, EventArgs e)
        {

        }

        private void btnManageCustomer_Click(object sender, EventArgs e)
        {
            gbManageCustomer manageCustomer = new gbManageCustomer(authorityLevel, employeeId);
            this.Hide();
            manageCustomer.Show();
        }

        private void btnManageorder_Click(object sender, EventArgs e)
        {
            History_Form orderHistory = new History_Form();
            this.Hide();
            orderHistory.Show();
        }
    }
}
