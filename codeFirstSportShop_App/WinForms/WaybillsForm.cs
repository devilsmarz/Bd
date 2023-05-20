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
    public partial class WaybillsForm : Form
    {
        private SportShopContext context;

        public WaybillsForm()
        {
            InitializeComponent();
        }

        private void WaybillsForm_Load(object sender, EventArgs e)
        {
            // Створюємо екземпляр класу DbContext
            /*  context = new SportShopContext();
              // Завантажуємо дані для manufacturerBindingSource
              sportShopBindingSource.DataSource =
              context.SportShops.ToList();
              // Завантажуємо дані для invoiceBindingSource
              context.Waybills.Load();
              waybillBindingSource.DataSource =
              context.Waybills.Local.ToBindingList();

              sportItemBindingSource.DataSource = context.SportItems.Local.ToBindingList();*/


            // Створюємо екземпляр класу DbContext
            context = new SportShopContext();
            // Завантажуємо дані для manufacturerBindingSource
            sportShopBindingSource.DataSource =
            context.SportShops.ToList();
            // Завантажуємо дані для productBindingSource
            sportItemBindingSource.DataSource = context.SportItems.ToList();
            // Завантажуємо дані для invoiceBindingSource
            context.Waybills.Load();
            waybillBindingSource.DataSource =
            context.Waybills.Local.ToBindingList();

        }

        private void waybillBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            waybillItemBindingSource.EndEdit();
            waybillBindingSource.EndEdit();
            context.SaveChanges();
            // Оновлення даних на формі
            waybillBindingSource.MovePrevious();
            waybillBindingSource.MoveNext();
        }

        private void waybillItemDataGridView_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            //Значення за замовчуванням для стовпця Товар
            e.Row.Cells["productIDDataGridViewComboBoxColumn"].Value =
            context.SportItems.Min(t => t.SportItemId);
        }
    }
}
