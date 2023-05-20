namespace WinForms
{
    partial class SportShopSalesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label sportShopIdLabel;
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.sportShopIdComboBox = new System.Windows.Forms.ComboBox();
            this.sportShopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SportShopSalesDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.SumTextBox = new System.Windows.Forms.TextBox();
            this.SportShopSalesChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            sportShopIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sportShopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SportShopSalesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SportShopSalesChart)).BeginInit();
            this.SuspendLayout();
            // 
            // sportShopIdLabel
            // 
            sportShopIdLabel.AutoSize = true;
            sportShopIdLabel.Location = new System.Drawing.Point(272, 76);
            sportShopIdLabel.Name = "sportShopIdLabel";
            sportShopIdLabel.Size = new System.Drawing.Size(90, 13);
            sportShopIdLabel.TabIndex = 1;
            sportShopIdLabel.Text = "Спорт Магазин: ";
            // 
            // sportShopIdComboBox
            // 
            this.sportShopIdComboBox.DataSource = this.sportShopBindingSource;
            this.sportShopIdComboBox.DisplayMember = "Name";
            this.sportShopIdComboBox.FormattingEnabled = true;
            this.sportShopIdComboBox.Location = new System.Drawing.Point(368, 73);
            this.sportShopIdComboBox.Name = "sportShopIdComboBox";
            this.sportShopIdComboBox.Size = new System.Drawing.Size(121, 21);
            this.sportShopIdComboBox.TabIndex = 2;
            this.sportShopIdComboBox.ValueMember = "SportShopId";
            this.sportShopIdComboBox.SelectedIndexChanged += new System.EventHandler(this.sportShopIdComboBox_SelectedIndexChanged);
            // 
            // sportShopBindingSource
            // 
            this.sportShopBindingSource.DataSource = typeof(Моделювання.Model.SportShop);
            // 
            // SportShopSalesDataGridView
            // 
            this.SportShopSalesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SportShopSalesDataGridView.Location = new System.Drawing.Point(98, 180);
            this.SportShopSalesDataGridView.Name = "SportShopSalesDataGridView";
            this.SportShopSalesDataGridView.Size = new System.Drawing.Size(591, 150);
            this.SportShopSalesDataGridView.TabIndex = 3;
            this.SportShopSalesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SportShopSalesDataGridView_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 381);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Сума";
            // 
            // SumTextBox
            // 
            this.SumTextBox.Location = new System.Drawing.Point(223, 381);
            this.SumTextBox.Name = "SumTextBox";
            this.SumTextBox.Size = new System.Drawing.Size(100, 20);
            this.SumTextBox.TabIndex = 5;
            // 
            // SportShopSalesChart
            // 
            chartArea1.Name = "ChartArea1";
            this.SportShopSalesChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.SportShopSalesChart.Legends.Add(legend1);
            this.SportShopSalesChart.Location = new System.Drawing.Point(877, 121);
            this.SportShopSalesChart.Name = "SportShopSalesChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.SportShopSalesChart.Series.Add(series1);
            this.SportShopSalesChart.Size = new System.Drawing.Size(363, 256);
            this.SportShopSalesChart.TabIndex = 6;
            this.SportShopSalesChart.Text = "chart1";
            // 
            // SportShopSalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 450);
            this.Controls.Add(this.SportShopSalesChart);
            this.Controls.Add(this.SumTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SportShopSalesDataGridView);
            this.Controls.Add(sportShopIdLabel);
            this.Controls.Add(this.sportShopIdComboBox);
            this.Name = "SportShopSalesForm";
            this.Text = "Продажі спорт магазина";
            this.Load += new System.EventHandler(this.SportShopSalesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sportShopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SportShopSalesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SportShopSalesChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource sportShopBindingSource;
        private System.Windows.Forms.ComboBox sportShopIdComboBox;
        private System.Windows.Forms.DataGridView SportShopSalesDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SumTextBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart SportShopSalesChart;
    }
}