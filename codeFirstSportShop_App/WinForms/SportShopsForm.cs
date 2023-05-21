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
    public partial class ClothShopsForm : Form
    {
        public ClothShopContext context;

        public ClothShopsForm()
        {
            InitializeComponent();
        }

        private void ClothShopsForm_Load(object sender, EventArgs e)
        {
            // Створюємо екземпляр класу DbContext
            context = new ClothShopContext();
            // Додаємо колекцію сутностей до контексту
            context.ClothShops.Load();
            // Прив'язуємо набір сутностей до елемента DataGridView
            dataGridView1.DataSource = context.ClothShops.Local.ToBindingList();
            //Вилучаємо властивості навігації з інтерфейсу
            dataGridView1.Columns.Remove("ClothDocs");
        }

        private void SabeChangesButton_Click(object sender, EventArgs e)
        {
            context.SaveChanges();
            dataGridView1.Refresh();
        }
    }
}
