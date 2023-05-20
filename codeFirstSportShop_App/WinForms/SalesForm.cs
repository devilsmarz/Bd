using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Моделювання.DataAccess;

namespace WinForms
{
    public partial class SalesForm : Form
    {
        private SportShopContext context;
        public SalesForm()
        {
            InitializeComponent();
        }

        private void countTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SalesForm_Load(object sender, EventArgs e)
        {
            // Створюємо екземпляр класу DbContext
            context = new SportShopContext();
            // Завантажуємо дані для productBindingSource
            // та manufacturerBindingSource
            sportItemBindingSource.DataSource = context.SportItems.ToList();
            sportShopBindingSource.DataSource =
            context.SportShops.ToList();
            // Завантажуємо дані для saleBindingSource
            context.ItemDocs.Load();
            itemDocBindingSource.DataSource =
            context.ItemDocs.Local.ToBindingList();
        }

        private void itemDocBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            itemDocBindingSource.EndEdit();
            context.SaveChanges();
        }
    }
}
