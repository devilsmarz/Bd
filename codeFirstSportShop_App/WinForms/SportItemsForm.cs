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
    public partial class SportItemsForm : Form
    {
        public SportShopContext context;

        public SportItemsForm()
        {
            InitializeComponent();
        }

        private void SportItemsForm_Load(object sender, EventArgs e)
        {
            // Створюємо екземпляр класу DbContext
            context = new SportShopContext();
            // Додаємо колекцію сутностей до контексту
            context.SportItems.Load();
            // Прив'язуємо набір сутностей до елемента DataGridView
            SportItemsDataGridView.DataSource = context.SportItems.Local.ToBindingList();
            //Вилучаємо властивості навігації з інтерфейсу
            SportItemsDataGridView.Columns.Remove("WaybillItems");
            SportItemsDataGridView.Columns.Remove("ItemDocs");
        }

        private void SaveChangesButton_Click(object sender, EventArgs e)
        {
            context.SaveChanges();
            SportItemsDataGridView.Refresh();
        }
    }
}
