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
    public partial class InvoicesForm : Form
    {
        private ClothShopContext context;

        public InvoicesForm()
        {
            InitializeComponent();
        }

        private void InvoicesForm_Load(object sender, EventArgs e)
        {
            // Створюємо екземпляр класу DbContext
            /*  context = new ClothShopContext();
              // Завантажуємо дані для manufacturerBindingSource
              ClothShopBindingSource.DataSource =
              context.ClothShops.ToList();
              // Завантажуємо дані для invoiceBindingSource
              context.Invoices.Load();
              InvoiceBindingSource.DataSource =
              context.Invoices.Local.ToBindingList();

              sportItemBindingSource.DataSource = context.ClothItems.Local.ToBindingList();*/


            // Створюємо екземпляр класу DbContext
            context = new ClothShopContext();
            // Завантажуємо дані для manufacturerBindingSource
            ClothShopBindingSource.DataSource =
            context.ClothShops.ToList();
            // Завантажуємо дані для productBindingSource
            sportItemBindingSource.DataSource = context.ClothItems.ToList();
            // Завантажуємо дані для invoiceBindingSource
            context.Invoices.Load();
            InvoiceBindingSource.DataSource =
            context.Invoices.Local.ToBindingList();

        }

        private void InvoiceBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            InvoiceItemBindingSource.EndEdit();
            InvoiceBindingSource.EndEdit();
            context.SaveChanges();
            // Оновлення даних на формі
            InvoiceBindingSource.MovePrevious();
            InvoiceBindingSource.MoveNext();
        }

        private void InvoiceItemDataGridView_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            //Значення за замовчуванням для стовпця Товар
            e.Row.Cells["productIDDataGridViewComboBoxColumn"].Value =
            context.ClothItems.Min(t => t.ClothId);
        }

        private void InvoiceItemDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
