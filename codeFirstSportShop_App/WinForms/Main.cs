using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void SportItemsButton_Click(object sender, EventArgs e)
        {
            SportItemsForm вікноТовари = new SportItemsForm();
            вікноТовари.ShowDialog();
        }

        private void SportShopsButton_Click(object sender, EventArgs e)
        {
            SportShopsForm sportShopsForm = new SportShopsForm();
            sportShopsForm.ShowDialog();
        }

        private void SalesButton_Click(object sender, EventArgs e)
        {
            SalesForm salesForm = new SalesForm();
            salesForm.ShowDialog();
        }

        private void DocButton_Click(object sender, EventArgs e)
        {
            WaybillsForm waybillsForm = new WaybillsForm();
            waybillsForm.ShowDialog();
        }

        private void SalesBySportShopsButton_Click(object sender, EventArgs e)
        {
            SportShopSalesForm sportShopSalesForm = new SportShopSalesForm();
            sportShopSalesForm.ShowDialog();
        }
    }
}
