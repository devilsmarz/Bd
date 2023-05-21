namespace WinForms
{
    partial class InvoicesForm
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
            System.Windows.Forms.Label InvoiceIdLabel;
            System.Windows.Forms.Label numberLabel;
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label ClothShopIdLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoicesForm));
            this.InvoiceBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.InvoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.InvoiceBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.InvoiceIdTextBox = new System.Windows.Forms.TextBox();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ClothShopIdComboBox = new System.Windows.Forms.ComboBox();
            this.ClothShopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.InvoiceItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.InvoiceItemDataGridView = new System.Windows.Forms.DataGridView();
            this.sportItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIDDataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            InvoiceIdLabel = new System.Windows.Forms.Label();
            numberLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            ClothShopIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceBindingNavigator)).BeginInit();
            this.InvoiceBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClothShopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceItemDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportItemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // InvoiceIdLabel
            // 
            InvoiceIdLabel.AutoSize = true;
            InvoiceIdLabel.Location = new System.Drawing.Point(272, 84);
            InvoiceIdLabel.Name = "InvoiceIdLabel";
            InvoiceIdLabel.Size = new System.Drawing.Size(57, 13);
            InvoiceIdLabel.TabIndex = 1;
            InvoiceIdLabel.Text = "Invoice Id:";
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
            // ClothShopIdLabel
            // 
            ClothShopIdLabel.AutoSize = true;
            ClothShopIdLabel.Location = new System.Drawing.Point(272, 226);
            ClothShopIdLabel.Name = "ClothShopIdLabel";
            ClothShopIdLabel.Size = new System.Drawing.Size(85, 13);
            ClothShopIdLabel.TabIndex = 7;
            ClothShopIdLabel.Text = "Магазин одягу:";
            // 
            // InvoiceBindingNavigator
            // 
            this.InvoiceBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.InvoiceBindingNavigator.BindingSource = this.InvoiceBindingSource;
            this.InvoiceBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.InvoiceBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.InvoiceBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.InvoiceBindingNavigatorSaveItem});
            this.InvoiceBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.InvoiceBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.InvoiceBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.InvoiceBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.InvoiceBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.InvoiceBindingNavigator.Name = "InvoiceBindingNavigator";
            this.InvoiceBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.InvoiceBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.InvoiceBindingNavigator.TabIndex = 0;
            this.InvoiceBindingNavigator.Text = "bindingNavigator1";
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
            // InvoiceBindingSource
            // 
            this.InvoiceBindingSource.DataSource = typeof(Моделювання.Model.Invoice);
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
            // InvoiceBindingNavigatorSaveItem
            // 
            this.InvoiceBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.InvoiceBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("InvoiceBindingNavigatorSaveItem.Image")));
            this.InvoiceBindingNavigatorSaveItem.Name = "InvoiceBindingNavigatorSaveItem";
            this.InvoiceBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.InvoiceBindingNavigatorSaveItem.Text = "Save Data";
            this.InvoiceBindingNavigatorSaveItem.Click += new System.EventHandler(this.InvoiceBindingNavigatorSaveItem_Click);
            // 
            // InvoiceIdTextBox
            // 
            this.InvoiceIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.InvoiceBindingSource, "InvoiceId", true));
            this.InvoiceIdTextBox.Location = new System.Drawing.Point(334, 81);
            this.InvoiceIdTextBox.Name = "InvoiceIdTextBox";
            this.InvoiceIdTextBox.Size = new System.Drawing.Size(200, 20);
            this.InvoiceIdTextBox.TabIndex = 2;
            // 
            // numberTextBox
            // 
            this.numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.InvoiceBindingSource, "Number", true));
            this.numberTextBox.Location = new System.Drawing.Point(325, 127);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(209, 20);
            this.numberTextBox.TabIndex = 4;
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.InvoiceBindingSource, "Date", true));
            this.dateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDateTimePicker.Location = new System.Drawing.Point(334, 169);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateDateTimePicker.TabIndex = 6;
            // 
            // ClothShopIdComboBox
            // 
            this.ClothShopIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.InvoiceBindingSource, "ClothShopId", true));
            this.ClothShopIdComboBox.DataSource = this.ClothShopBindingSource;
            this.ClothShopIdComboBox.DisplayMember = "Name";
            this.ClothShopIdComboBox.FormattingEnabled = true;
            this.ClothShopIdComboBox.Location = new System.Drawing.Point(381, 218);
            this.ClothShopIdComboBox.Name = "ClothShopIdComboBox";
            this.ClothShopIdComboBox.Size = new System.Drawing.Size(153, 21);
            this.ClothShopIdComboBox.TabIndex = 8;
            this.ClothShopIdComboBox.ValueMember = "ClothShopId";
            // 
            // ClothShopBindingSource
            // 
            this.ClothShopBindingSource.DataSource = typeof(Моделювання.Model.ClothShop);
            // 
            // InvoiceItemBindingSource
            // 
            this.InvoiceItemBindingSource.DataSource = typeof(Моделювання.Model.InvoiceItem);
            // 
            // InvoiceItemDataGridView
            // 
            this.InvoiceItemDataGridView.AutoGenerateColumns = false;
            this.InvoiceItemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InvoiceItemDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.productIDDataGridViewComboBoxColumn,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn7});
            this.InvoiceItemDataGridView.DataSource = this.InvoiceItemBindingSource;
            this.InvoiceItemDataGridView.Location = new System.Drawing.Point(12, 346);
            this.InvoiceItemDataGridView.Name = "InvoiceItemDataGridView";
            this.InvoiceItemDataGridView.Size = new System.Drawing.Size(753, 220);
            this.InvoiceItemDataGridView.TabIndex = 9;
            this.InvoiceItemDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.InvoiceItemDataGridView_CellContentClick);
            this.InvoiceItemDataGridView.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.InvoiceItemDataGridView_DefaultValuesNeeded);
            // 
            // sportItemBindingSource
            // 
            this.sportItemBindingSource.DataSource = typeof(Моделювання.Model.Cloth);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "InvoiceItemId";
            this.dataGridViewTextBoxColumn1.HeaderText = "InvoiceItemId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "InvoiceId";
            this.dataGridViewTextBoxColumn2.HeaderText = "InvoiceId";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // productIDDataGridViewComboBoxColumn
            // 
            this.productIDDataGridViewComboBoxColumn.DataPropertyName = "ClothId";
            this.productIDDataGridViewComboBoxColumn.DataSource = this.sportItemBindingSource;
            this.productIDDataGridViewComboBoxColumn.DisplayMember = "Name";
            this.productIDDataGridViewComboBoxColumn.HeaderText = "Товар одягу";
            this.productIDDataGridViewComboBoxColumn.Name = "productIDDataGridViewComboBoxColumn";
            this.productIDDataGridViewComboBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.productIDDataGridViewComboBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.productIDDataGridViewComboBoxColumn.ValueMember = "ClothId";
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
            // InvoicesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 586);
            this.Controls.Add(this.InvoiceItemDataGridView);
            this.Controls.Add(ClothShopIdLabel);
            this.Controls.Add(this.ClothShopIdComboBox);
            this.Controls.Add(dateLabel);
            this.Controls.Add(this.dateDateTimePicker);
            this.Controls.Add(numberLabel);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(InvoiceIdLabel);
            this.Controls.Add(this.InvoiceIdTextBox);
            this.Controls.Add(this.InvoiceBindingNavigator);
            this.Name = "InvoicesForm";
            this.Text = "Накладні";
            this.Load += new System.EventHandler(this.InvoicesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceBindingNavigator)).EndInit();
            this.InvoiceBindingNavigator.ResumeLayout(false);
            this.InvoiceBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClothShopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceItemDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportItemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource InvoiceBindingSource;
        private System.Windows.Forms.BindingNavigator InvoiceBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton InvoiceBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox InvoiceIdTextBox;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.ComboBox ClothShopIdComboBox;
        private System.Windows.Forms.BindingSource ClothShopBindingSource;
        private System.Windows.Forms.BindingSource InvoiceItemBindingSource;
        private System.Windows.Forms.DataGridView InvoiceItemDataGridView;
        private System.Windows.Forms.BindingSource sportItemBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn productIDDataGridViewComboBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}