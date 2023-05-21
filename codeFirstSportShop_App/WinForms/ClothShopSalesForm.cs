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
    public partial class ClothShopSalesForm : Form
    {
        // Спільні об'єкти
        ClothShopContext context;
        BindingSource bindingПродажіВиробника = new BindingSource();
        BindingSource bindingСтруктура = new BindingSource();

        public ClothShopSalesForm()
        {
            InitializeComponent();
        }

        private void ClothShopSalesForm_Load(object sender, EventArgs e)
        {
            // Створюємо екземпляр класу DbContext
            context = new ClothShopContext();
            // Завантажуємо дані для manufacturerBindingSource
            ClothShopBindingSource.DataSource =
             context.ClothShops.ToList();

            // Запит для gvПродажіВиробника
            var queryПродажіВиробника = from продаж in context.ClothDocs
                                        where продаж.ClothShopId ==
                                       (int)ClothShopIdComboBox.SelectedValue
                                        select new
                                        {
                                            Дата = продаж.Date,
                                            Товар = продаж.Cloth.Name,
                                            Опис = продаж.Cloth.Description,
                                            Ціна = продаж.Cloth.Price,
                                            Кількість = продаж.Count,
                                            Вартість = продаж.Cloth.Price * продаж.Count
                                        };
            // Відображаємо дані
            bindingПродажіВиробника.DataSource = queryПродажіВиробника.ToList();
            ClothShopSalesDataGridView.DataSource = bindingПродажіВиробника;
            ClothShopSalesDataGridView.AutoResizeColumns();

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
            ClothShopSalesChart.DataSource = bindingСтруктура;
            ClothShopSalesChart.Series["Series1"].XValueMember = "Товар";
            ClothShopSalesChart.Series["Series1"].YValueMembers = "Вартість";
            //Тип діаграми
            ClothShopSalesChart.Series["Series1"].ChartType = SeriesChartType.Pie;

            //Підписи на діаграмі
            ClothShopSalesChart.Series["Series1"].Label = "#PERCENT{P0}";
            //Об'ємний варіант (3D)
            this.ClothShopSalesChart.ChartAreas[0].Area3DStyle.Enable3D = true;
            //Заголовок
            ClothShopSalesChart.Titles.Add("Заголовок");
            ClothShopSalesChart.Titles[0].Text = "Структура продажів\n щодо виробника";
            ClothShopSalesChart.Titles[0].Font = new Font("Times New Roman", 12,
            FontStyle.Bold);
            ClothShopSalesChart.Titles[0].ForeColor = Color.Red;
            //Легенда
            ClothShopSalesChart.Series["Series1"].IsVisibleInLegend = true;
            ClothShopSalesChart.Series["Series1"].LegendText = "#VALX";
        }

        private void ClothShopIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.CanFocus) //Після завантаження
            {
                var queryПродажіВиробника =
                from продаж in context.ClothDocs
                where продаж.ClothShopId ==
                (int)ClothShopIdComboBox.SelectedValue
                select new
                {
                    Дата = продаж.Date,
                    Товар = продаж.Cloth.Name,
                    Опис = продаж.Cloth.Description,
                    Ціна = продаж.Cloth.Price,
                    Кількість = продаж.Count,
                    Вартість = продаж.Cloth.Price * продаж.Count
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
                    ClothShopSalesChart.DataSource = bindingСтруктура;
                    ClothShopSalesChart.Series["Series1"].XValueMember = "Товар";
                    ClothShopSalesChart.Series["Series1"].YValueMembers = "Вартість";
                    ClothShopSalesChart.Series["Series1"].ChartType = SeriesChartType.Pie;
                }
            }
        }

        private void ClothShopSalesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
