using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Моделювання.DataAccess;

namespace WinForms
{
    public partial class SportShopSalesForm : Form
    {
        // Спільні об'єкти
        SportShopContext context;
        BindingSource bindingПродажіВиробника = new BindingSource();
        BindingSource bindingСтруктура = new BindingSource();

        public SportShopSalesForm()
        {
            InitializeComponent();
        }

        private void SportShopSalesForm_Load(object sender, EventArgs e)
        {
            // Створюємо екземпляр класу DbContext
            context = new SportShopContext();
            // Завантажуємо дані для manufacturerBindingSource
            sportShopBindingSource.DataSource =
             context.SportShops.ToList();

            // Запит для gvПродажіВиробника
            var queryПродажіВиробника = from продаж in context.ItemDocs
                                        where продаж.SportShopId ==
                                       (int)sportShopIdComboBox.SelectedValue
                                        select new
                                        {
                                            Дата = продаж.Date,
                                            Товар = продаж.SportItem.Name,
                                            Опис = продаж.SportItem.Description,
                                            Ціна = продаж.SportItem.Price,
                                            Кількість = продаж.Count,
                                            Вартість = продаж.SportItem.Price * продаж.Count
                                        };
            // Відображаємо дані
            bindingПродажіВиробника.DataSource = queryПродажіВиробника.ToList();
            SportShopSalesDataGridView.DataSource = bindingПродажіВиробника;
            SportShopSalesDataGridView.AutoResizeColumns();

            //Сума
            decimal Сума = (decimal)queryПродажіВиробника.Sum(p => p.Вартість);
            SumTextBox.Text = Сума.ToString("0.00");
            SumTextBox.TextAlign = HorizontalAlignment.Right;

            //***********
            // Діаграма *
            //***********
            //Запит
            var queryСтруктура = from товар in queryПродажіВиробника
                                 group товар by товар.Товар into t
                                 select new
                                 {
                                     Товар = t.Key,
                                     Вартість = t.Sum(p => p.Вартість)
                                 };
            //Дані для відображення
            bindingСтруктура.DataSource = queryСтруктура.ToList();
            SportShopSalesChart.DataSource = bindingСтруктура;
            SportShopSalesChart.Series["Series1"].XValueMember = "Товар";
            SportShopSalesChart.Series["Series1"].YValueMembers = "Вартість";
            //Тип діаграми
            SportShopSalesChart.Series["Series1"].ChartType = SeriesChartType.Pie;

            //Підписи на діаграмі
            SportShopSalesChart.Series["Series1"].Label = "#PERCENT{P0}";
            //Об'ємний варіант (3D)
            this.SportShopSalesChart.ChartAreas[0].Area3DStyle.Enable3D = true;
            //Заголовок
            SportShopSalesChart.Titles.Add("Заголовок");
            SportShopSalesChart.Titles[0].Text = "Структура продажів\n щодо виробника";
            SportShopSalesChart.Titles[0].Font = new Font("Times New Roman", 12,
            FontStyle.Bold);
            SportShopSalesChart.Titles[0].ForeColor = Color.Red;
            //Легенда
            SportShopSalesChart.Series["Series1"].IsVisibleInLegend = true;
            SportShopSalesChart.Series["Series1"].LegendText = "#VALX";
        }

        private void sportShopIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.CanFocus) //Після завантаження
            {
                var queryПродажіВиробника =
                from продаж in context.ItemDocs
                where продаж.SportShopId ==
                (int)sportShopIdComboBox.SelectedValue
                select new
                {
                    Дата = продаж.Date,
                    Товар = продаж.SportItem.Name,
                    Опис = продаж.SportItem.Description,
                    Ціна = продаж.SportItem.Price,
                    Кількість = продаж.Count,
                    Вартість = продаж.SportItem.Price * продаж.Count
                };
                // Відображаємо дані
                bindingПродажіВиробника.DataSource =
                queryПродажіВиробника.ToList();
                //Сума
                decimal Сума = (decimal)queryПродажіВиробника.Sum(p =>
                p.Вартість);
                SumTextBox.Text = Сума.ToString("0.00");
                //***********
                // Діаграма *
                //***********
                //Запит
                var queryСтруктура =
                from товар in queryПродажіВиробника
                group товар by товар.Товар into t
                select new
                {
                    Товар = t.Key,
                    Вартість = t.Sum(p => p.Вартість)
                };
                //Дані для відображення
                bindingСтруктура.DataSource = queryСтруктура.ToList();
                if (queryСтруктура.Count() > 0)
                {
                    SportShopSalesChart.DataSource = bindingСтруктура;
                    SportShopSalesChart.Series["Series1"].XValueMember = "Товар";
                    SportShopSalesChart.Series["Series1"].YValueMembers = "Вартість";
                    SportShopSalesChart.Series["Series1"].ChartType = SeriesChartType.Pie;
                }
            }
        }

        private void SportShopSalesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
