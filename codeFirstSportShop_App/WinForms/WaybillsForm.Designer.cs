namespace WinForms
{
    partial class WaybillsForm
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
            System.Windows.Forms.Label waybillIdLabel;
            System.Windows.Forms.Label numberLabel;
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label sportShopIdLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WaybillsForm));
            this.waybillBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.waybillBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.waybillBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.waybillIdTextBox = new System.Windows.Forms.TextBox();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.sportShopIdComboBox = new System.Windows.Forms.ComboBox();
            this.sportShopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.waybillItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.waybillItemDataGridView = new System.Windows.Forms.DataGridView();
            this.sportItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIDDataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            waybillIdLabel = new System.Windows.Forms.Label();
            numberLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            sportShopIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.waybillBindingNavigator)).BeginInit();
            this.waybillBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.waybillBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportShopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waybillItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waybillItemDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportItemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // waybillIdLabel
            // 
            waybillIdLabel.AutoSize = true;
            waybillIdLabel.Location = new System.Drawing.Point(272, 84);
            waybillIdLabel.Name = "waybillIdLabel";
            waybillIdLabel.Size = new System.Drawing.Size(56, 13);
            waybillIdLabel.TabIndex = 1;
            waybillIdLabel.Text = "Waybill Id:";
            // 
            // numberLabel
            // 
            numberLabel.AutoSize = true;
            numberLabel.Location = new System.Drawing.Point(272, 130);
            numberLabel.Name = "numberLabel";
            numberLabel.Size = new System.Drawing.Size(44, 13);
            numberLabel.TabIndex = 3;
            numberLabel.Text = "Номер:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(272, 175);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(36, 13);
            dateLabel.TabIndex = 5;
            dateLabel.Text = "Дата:";
            // 
            // sportShopIdLabel
            // 
            sportShopIdLabel.AutoSize = true;
            sportShopIdLabel.Location = new System.Drawing.Point(272, 226);
            sportShopIdLabel.Name = "sportShopIdLabel";
            sportShopIdLabel.Size = new System.Drawing.Size(87, 13);
            sportShopIdLabel.TabIndex = 7;
            sportShopIdLabel.Text = "Спорт Магазин:";
            // 
            // waybillBindingNavigator
            // 
            this.waybillBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.waybillBindingNavigator.BindingSource = this.waybillBindingSource;
            this.waybillBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.waybillBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.waybillBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.waybillBindingNavigatorSaveItem});
            this.waybillBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.waybillBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.waybillBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.waybillBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.waybillBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.waybillBindingNavigator.Name = "waybillBindingNavigator";
            this.waybillBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.waybillBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.waybillBindingNavigator.TabIndex = 0;
            this.waybillBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // waybillBindingSource
            // 
            this.waybillBindingSource.DataSource = typeof(Моделювання.Model.Waybill);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // waybillBindingNavigatorSaveItem
            // 
            this.waybillBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.waybillBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("waybillBindingNavigatorSaveItem.Image")));
            this.waybillBindingNavigatorSaveItem.Name = "waybillBindingNavigatorSaveItem";
            this.waybillBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.waybillBindingNavigatorSaveItem.Text = "Save Data";
            this.waybillBindingNavigatorSaveItem.Click += new System.EventHandler(this.waybillBindingNavigatorSaveItem_Click);
            // 
            // waybillIdTextBox
            // 
            this.waybillIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.waybillBindingSource, "WaybillId", true));
            this.waybillIdTextBox.Location = new System.Drawing.Point(334, 81);
            this.waybillIdTextBox.Name = "waybillIdTextBox";
            this.waybillIdTextBox.Size = new System.Drawing.Size(200, 20);
            this.waybillIdTextBox.TabIndex = 2;
            // 
            // numberTextBox
            // 
            this.numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.waybillBindingSource, "Number", true));
            this.numberTextBox.Location = new System.Drawing.Point(325, 127);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(209, 20);
            this.numberTextBox.TabIndex = 4;
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.waybillBindingSource, "Date", true));
            this.dateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDateTimePicker.Location = new System.Drawing.Point(334, 169);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateDateTimePicker.TabIndex = 6;
            // 
            // sportShopIdComboBox
            // 
            this.sportShopIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.waybillBindingSource, "SportShopId", true));
            this.sportShopIdComboBox.DataSource = this.sportShopBindingSource;
            this.sportShopIdComboBox.DisplayMember = "Name";
            this.sportShopIdComboBox.FormattingEnabled = true;
            this.sportShopIdComboBox.Location = new System.Drawing.Point(381, 218);
            this.sportShopIdComboBox.Name = "sportShopIdComboBox";
            this.sportShopIdComboBox.Size = new System.Drawing.Size(153, 21);
            this.sportShopIdComboBox.TabIndex = 8;
            this.sportShopIdComboBox.ValueMember = "SportShopId";
            // 
            // sportShopBindingSource
            // 
            this.sportShopBindingSource.DataSource = typeof(Моделювання.Model.SportShop);
            // 
            // waybillItemBindingSource
            // 
            this.waybillItemBindingSource.DataSource = typeof(Моделювання.Model.WaybillItem);
            // 
            // waybillItemDataGridView
            // 
            this.waybillItemDataGridView.AutoGenerateColumns = false;
            this.waybillItemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.waybillItemDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.productIDDataGridViewComboBoxColumn,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn7});
            this.waybillItemDataGridView.DataSource = this.waybillItemBindingSource;
            this.waybillItemDataGridView.Location = new System.Drawing.Point(12, 346);
            this.waybillItemDataGridView.Name = "waybillItemDataGridView";
            this.waybillItemDataGridView.Size = new System.Drawing.Size(753, 220);
            this.waybillItemDataGridView.TabIndex = 9;
            this.waybillItemDataGridView.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.waybillItemDataGridView_DefaultValuesNeeded);
            // 
            // sportItemBindingSource
            // 
            this.sportItemBindingSource.DataSource = typeof(Моделювання.Model.SportItem);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "WaybillItemId";
            this.dataGridViewTextBoxColumn1.HeaderText = "WaybillItemId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "WaybillId";
            this.dataGridViewTextBoxColumn2.HeaderText = "WaybillId";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // productIDDataGridViewComboBoxColumn
            // 
            this.productIDDataGridViewComboBoxColumn.DataPropertyName = "SportItemId";
            this.productIDDataGridViewComboBoxColumn.DataSource = this.sportItemBindingSource;
            this.productIDDataGridViewComboBoxColumn.DisplayMember = "Name";
            this.productIDDataGridViewComboBoxColumn.HeaderText = "Спорт Товар";
            this.productIDDataGridViewComboBoxColumn.Name = "productIDDataGridViewComboBoxColumn";
            this.productIDDataGridViewComboBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.productIDDataGridViewComboBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.productIDDataGridViewComboBoxColumn.ValueMember = "SportItemId";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Count";
            this.dataGridViewTextBoxColumn4.HeaderText = "Count";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Вартість";
            this.dataGridViewTextBoxColumn7.HeaderText = "Вартість";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // WaybillsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 586);
            this.Controls.Add(this.waybillItemDataGridView);
            this.Controls.Add(sportShopIdLabel);
            this.Controls.Add(this.sportShopIdComboBox);
            this.Controls.Add(dateLabel);
            this.Controls.Add(this.dateDateTimePicker);
            this.Controls.Add(numberLabel);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(waybillIdLabel);
            this.Controls.Add(this.waybillIdTextBox);
            this.Controls.Add(this.waybillBindingNavigator);
            this.Name = "WaybillsForm";
            this.Text = "Накладні";
            this.Load += new System.EventHandler(this.WaybillsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.waybillBindingNavigator)).EndInit();
            this.waybillBindingNavigator.ResumeLayout(false);
            this.waybillBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.waybillBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportShopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waybillItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waybillItemDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportItemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource waybillBindingSource;
        private System.Windows.Forms.BindingNavigator waybillBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton waybillBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox waybillIdTextBox;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.ComboBox sportShopIdComboBox;
        private System.Windows.Forms.BindingSource sportShopBindingSource;
        private System.Windows.Forms.BindingSource waybillItemBindingSource;
        private System.Windows.Forms.DataGridView waybillItemDataGridView;
        private System.Windows.Forms.BindingSource sportItemBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn productIDDataGridViewComboBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}