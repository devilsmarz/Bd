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
            ClothItemsForm вікноТовари = new ClothItemsForm();
            вікноТовари.ShowDialog();
        }

        private void ClothShopsButton_Click(object sender, EventArgs e)
        {
            ClothShopsForm ClothShopsForm = new ClothShopsForm();
            ClothShopsForm.ShowDialog();
        }

        private void SalesButton_Click(object sender, EventArgs e)
        {
            SalesForm salesForm = new SalesForm();
            salesForm.ShowDialog();
        }

        private void DocButton_Click(object sender, EventArgs e)
        {
            InvoicesForm InvoicesForm = new InvoicesForm();
            InvoicesForm.ShowDialog();
        }

        private void SalesByClothShopsButton_Click(object sender, EventArgs e)
        {
            ClothShopSalesForm ClothShopSalesForm = new ClothShopSalesForm();
            ClothShopSalesForm.ShowDialog();
        }
    }
}
