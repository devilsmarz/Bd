namespace WinForms
{
    partial class ClothShopSalesForm
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
            System.Windows.Forms.Label ClothShopIdLabel;
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ClothShopIdComboBox = new System.Windows.Forms.ComboBox();
            this.ClothShopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ClothShopSalesDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.SumTextBox = new System.Windows.Forms.TextBox();
            this.ClothShopSalesChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ClothShopIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ClothShopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClothShopSalesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClothShopSalesChart)).BeginInit();
            this.SuspendLayout();
            // 
            // ClothShopIdLabel
            // 
            ClothShopIdLabel.AutoSize = true;
            ClothShopIdLabel.Location = new System.Drawing.Point(22, 33);
            ClothShopIdLabel.Name = "ClothShopIdLabel";
            ClothShopIdLabel.Size = new System.Drawing.Size(88, 13);
            ClothShopIdLabel.TabIndex = 1;
            ClothShopIdLabel.Text = "Магазин одягу: ";
            // 
            // ClothShopIdComboBox
            // 
            this.ClothShopIdComboBox.DataSource = this.ClothShopBindingSource;
            this.ClothShopIdComboBox.DisplayMember = "Name";
            this.ClothShopIdComboBox.FormattingEnabled = true;
            this.ClothShopIdComboBox.Location = new System.Drawing.Point(116, 30);
            this.ClothShopIdComboBox.Name = "ClothShopIdComboBox";
            this.ClothShopIdComboBox.Size = new System.Drawing.Size(121, 21);
            this.ClothShopIdComboBox.TabIndex = 2;
            this.ClothShopIdComboBox.ValueMember = "ClothShopId";
            this.ClothShopIdComboBox.SelectedIndexChanged += new System.EventHandler(this.ClothShopIdComboBox_SelectedIndexChanged);
            // 
            // ClothShopBindingSource
            // 
            this.ClothShopBindingSource.DataSource = typeof(Моделювання.Model.ClothShop);
            // 
            // ClothShopSalesDataGridView
            // 
            this.ClothShopSalesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClothShopSalesDataGridView.Location = new System.Drawing.Point(25, 135);
            this.ClothShopSalesDataGridView.Name = "ClothShopSalesDataGridView";
            this.ClothShopSalesDataGridView.Size = new System.Drawing.Size(591, 150);
            this.ClothShopSalesDataGridView.TabIndex = 3;
            this.ClothShopSalesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClothShopSalesDataGridView_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 381);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Сума";
            // 
            // SumTextBox
            // 
            this.SumTextBox.Location = new System.Drawing.Point(71, 381);
            this.SumTextBox.Name = "SumTextBox";
            this.SumTextBox.Size = new System.Drawing.Size(100, 20);
            this.SumTextBox.TabIndex = 5;
            // 
            // ClothShopSalesChart
            // 
            chartArea2.Name = "ChartArea1";
            this.ClothShopSalesChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.ClothShopSalesChart.Legends.Add(legend2);
            this.ClothShopSalesChart.Location = new System.Drawing.Point(773, 73);
            this.ClothShopSalesChart.Name = "ClothShopSalesChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.ClothShopSalesChart.Series.Add(series2);
            this.ClothShopSalesChart.Size = new System.Drawing.Size(363, 256);
            this.ClothShopSalesChart.TabIndex = 6;
            this.ClothShopSalesChart.Text = "chart1";
            // 
            // ClothShopSalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 450);
            this.Controls.Add(this.ClothShopSalesChart);
            this.Controls.Add(this.SumTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClothShopSalesDataGridView);
            this.Controls.Add(ClothShopIdLabel);
            this.Controls.Add(this.ClothShopIdComboBox);
            this.Name = "ClothShopSalesForm";
            this.Text = "Продажі магазину одягу";
            this.Load += new System.EventHandler(this.ClothShopSalesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClothShopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClothShopSalesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClothShopSalesChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource ClothShopBindingSource;
        private System.Windows.Forms.ComboBox ClothShopIdComboBox;
        private System.Windows.Forms.DataGridView ClothShopSalesDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SumTextBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart ClothShopSalesChart;
    }
}