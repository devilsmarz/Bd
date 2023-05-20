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
    public partial class SportShopsForm : Form
    {
        public SportShopContext context;

        public SportShopsForm()
        {
            InitializeComponent();
        }

        private void SportShopsForm_Load(object sender, EventArgs e)
        {
            // Створюємо екземпляр класу DbContext
            context = new SportShopContext();
            // Додаємо колекцію сутностей до контексту
            context.SportShops.Load();
            // Прив'язуємо набір сутностей до елемента DataGridView
            dataGridView1.DataSource = context.SportShops.Local.ToBindingList();
            //Вилучаємо властивості навігації з інтерфейсу
            dataGridView1.Columns.Remove("ItemDocs");
        }

        private void SabeChangesButton_Click(object sender, EventArgs e)
        {
            context.SaveChanges();
            dataGridView1.Refresh();
        }
    }
}
