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
    public partial class ClothItemsForm : Form
    {
        public ClothShopContext context;

        public ClothItemsForm()
        {
            InitializeComponent();
        }

        private void SportItemsForm_Load(object sender, EventArgs e)
        {
            // Створюємо екземпляр класу DbContext
            context = new ClothShopContext();
            // Додаємо колекцію сутностей до контексту
            context.ClothItems.Load();
            // Прив'язуємо набір сутностей до елемента DataGridView
            SportItemsDataGridView.DataSource = context.ClothItems.Local.ToBindingList();
            //Вилучаємо властивості навігації з інтерфейсу
            SportItemsDataGridView.Columns.Remove("InvoicesItems");
            SportItemsDataGridView.Columns.Remove("ClothDocs");
        }

        private void SaveChangesButton_Click(object sender, EventArgs e)
        {
            context.SaveChanges();
            SportItemsDataGridView.Refresh();
        }

        private void SportItemsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
