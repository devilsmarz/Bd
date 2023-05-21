namespace WinForms
{
    partial class SalesForm
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
            System.Windows.Forms.Label itemDocIdLabel;
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label ClothShopIdLabel;
            System.Windows.Forms.Label sportItemIdLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label countLabel;
            System.Windows.Forms.Label вартістьLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesForm));
            this.itemDocBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.itemDocBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.itemDocBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.itemDocIdTextBox = new System.Windows.Forms.TextBox();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ClothShopIdComboBox = new System.Windows.Forms.ComboBox();
            this.ClothShopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sportItemIdComboBox = new System.Windows.Forms.ComboBox();
            this.sportItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.countTextBox = new System.Windows.Forms.TextBox();
            this.вартістьTextBox = new System.Windows.Forms.TextBox();
            itemDocIdLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            ClothShopIdLabel = new System.Windows.Forms.Label();
            sportItemIdLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            countLabel = new System.Windows.Forms.Label();
            вартістьLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.itemDocBindingNavigator)).BeginInit();
            this.itemDocBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemDocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClothShopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportItemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // itemDocIdLabel
            // 
            itemDocIdLabel.AutoSize = true;
            itemDocIdLabel.Location = new System.Drawing.Point(242, 88);
            itemDocIdLabel.Name = "itemDocIdLabel";
            itemDocIdLabel.Size = new System.Drawing.Size(69, 13);
            itemDocIdLabel.TabIndex = 1;
            itemDocIdLabel.Text = "Cloth Doc Id:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(242, 128);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(36, 13);
            dateLabel.TabIndex = 3;
            dateLabel.Text = "Дата:";
            // 
            // ClothShopIdLabel
            // 
            ClothShopIdLabel.AutoSize = true;
            ClothShopIdLabel.Location = new System.Drawing.Point(242, 171);
            ClothShopIdLabel.Name = "ClothShopIdLabel";
            ClothShopIdLabel.Size = new System.Drawing.Size(85, 13);
            ClothShopIdLabel.TabIndex = 5;
            ClothShopIdLabel.Text = "Магазин одягу:";
            // 
            // sportItemIdLabel
            // 
            sportItemIdLabel.AutoSize = true;
            sportItemIdLabel.Location = new System.Drawing.Point(242, 219);
            sportItemIdLabel.Name = "sportItemIdLabel";
            sportItemIdLabel.Size = new System.Drawing.Size(72, 13);
            sportItemIdLabel.TabIndex = 7;
            sportItemIdLabel.Text = "Товар одягу:";
            sportItemIdLabel.Click += new System.EventHandler(this.sportItemIdLabel_Click);
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(242, 263);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(32, 13);
            priceLabel.TabIndex = 9;
            priceLabel.Text = "Ціна:";
            // 
            // countLabel
            // 
            countLabel.AutoSize = true;
            countLabel.Location = new System.Drawing.Point(242, 312);
            countLabel.Name = "countLabel";
            countLabel.Size = new System.Drawing.Size(56, 13);
            countLabel.TabIndex = 11;
            countLabel.Text = "Кількість:";
            // 
            // вартістьLabel
            // 
            вартістьLabel.AutoSize = true;
            вартістьLabel.Location = new System.Drawing.Point(242, 357);
            вартістьLabel.Name = "вартістьLabel";
            вартістьLabel.Size = new System.Drawing.Size(53, 13);
            вартістьLabel.TabIndex = 13;
            вартістьLabel.Text = "Вартість:";
            // 
            // itemDocBindingNavigator
            // 
            this.itemDocBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.itemDocBindingNavigator.BindingSource = this.itemDocBindingSource;
            this.itemDocBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.itemDocBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.itemDocBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.itemDocBindingNavigatorSaveItem});
            this.itemDocBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.itemDocBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.itemDocBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.itemDocBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.itemDocBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.itemDocBindingNavigator.Name = "itemDocBindingNavigator";
            this.itemDocBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.itemDocBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.itemDocBindingNavigator.TabIndex = 0;
            this.itemDocBindingNavigator.Text = "bindingNavigator1";
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
            // itemDocBindingSource
            // 
            this.itemDocBindingSource.DataSource = typeof(Моделювання.Model.ClothDoc);
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
            // itemDocBindingNavigatorSaveItem
            // 
            this.itemDocBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.itemDocBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("itemDocBindingNavigatorSaveItem.Image")));
            this.itemDocBindingNavigatorSaveItem.Name = "itemDocBindingNavigatorSaveItem";
            this.itemDocBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.itemDocBindingNavigatorSaveItem.Text = "Save Data";
            this.itemDocBindingNavigatorSaveItem.Click += new System.EventHandler(this.itemDocBindingNavigatorSaveItem_Click);
            // 
            // itemDocIdTextBox
            // 
            this.itemDocIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemDocBindingSource, "ClothDocId", true));
            this.itemDocIdTextBox.Location = new System.Drawing.Point(313, 85);
            this.itemDocIdTextBox.Name = "itemDocIdTextBox";
            this.itemDocIdTextBox.Size = new System.Drawing.Size(168, 20);
            this.itemDocIdTextBox.TabIndex = 2;
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.itemDocBindingSource, "Date", true));
            this.dateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDateTimePicker.Location = new System.Drawing.Point(281, 124);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateDateTimePicker.TabIndex = 4;
            // 
            // ClothShopIdComboBox
            // 
            this.ClothShopIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.itemDocBindingSource, "ClothShopId", true));
            this.ClothShopIdComboBox.DataSource = this.ClothShopBindingSource;
            this.ClothShopIdComboBox.DisplayMember = "Name";
            this.ClothShopIdComboBox.FormattingEnabled = true;
            this.ClothShopIdComboBox.Location = new System.Drawing.Point(330, 168);
            this.ClothShopIdComboBox.Name = "ClothShopIdComboBox";
            this.ClothShopIdComboBox.Size = new System.Drawing.Size(151, 21);
            this.ClothShopIdComboBox.TabIndex = 6;
            this.ClothShopIdComboBox.ValueMember = "ClothShopId";
            // 
            // ClothShopBindingSource
            // 
            this.ClothShopBindingSource.DataSource = typeof(Моделювання.Model.ClothShop);
            // 
            // sportItemIdComboBox
            // 
            this.sportItemIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.itemDocBindingSource, "ClothId", true));
            this.sportItemIdComboBox.DataSource = this.sportItemBindingSource;
            this.sportItemIdComboBox.DisplayMember = "Name";
            this.sportItemIdComboBox.FormattingEnabled = true;
            this.sportItemIdComboBox.Location = new System.Drawing.Point(318, 216);
            this.sportItemIdComboBox.Name = "sportItemIdComboBox";
            this.sportItemIdComboBox.Size = new System.Drawing.Size(163, 21);
            this.sportItemIdComboBox.TabIndex = 8;
            this.sportItemIdComboBox.ValueMember = "ClothId";
            // 
            // sportItemBindingSource
            // 
            this.sportItemBindingSource.DataSource = typeof(Моделювання.Model.Cloth);
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemDocBindingSource, "Cloth.Price", true));
            this.priceTextBox.Location = new System.Drawing.Point(282, 260);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(199, 20);
            this.priceTextBox.TabIndex = 10;
            // 
            // countTextBox
            // 
            this.countTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemDocBindingSource, "Count", true));
            this.countTextBox.Location = new System.Drawing.Point(304, 309);
            this.countTextBox.Name = "countTextBox";
            this.countTextBox.Size = new System.Drawing.Size(177, 20);
            this.countTextBox.TabIndex = 12;
            this.countTextBox.TextChanged += new System.EventHandler(this.countTextBox_TextChanged);
            // 
            // вартістьTextBox
            // 
            this.вартістьTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemDocBindingSource, "Вартість", true));
            this.вартістьTextBox.Location = new System.Drawing.Point(313, 350);
            this.вартістьTextBox.Name = "вартістьTextBox";
            this.вартістьTextBox.Size = new System.Drawing.Size(168, 20);
            this.вартістьTextBox.TabIndex = 14;
            // 
            // SalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(вартістьLabel);
            this.Controls.Add(this.вартістьTextBox);
            this.Controls.Add(countLabel);
            this.Controls.Add(this.countTextBox);
            this.Controls.Add(priceLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(sportItemIdLabel);
            this.Controls.Add(this.sportItemIdComboBox);
            this.Controls.Add(ClothShopIdLabel);
            this.Controls.Add(this.ClothShopIdComboBox);
            this.Controls.Add(dateLabel);
            this.Controls.Add(this.dateDateTimePicker);
            this.Controls.Add(itemDocIdLabel);
            this.Controls.Add(this.itemDocIdTextBox);
            this.Controls.Add(this.itemDocBindingNavigator);
            this.Name = "SalesForm";
            this.Text = "SalesForm";
            this.Load += new System.EventHandler(this.SalesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemDocBindingNavigator)).EndInit();
            this.itemDocBindingNavigator.ResumeLayout(false);
            this.itemDocBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemDocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClothShopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportItemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource itemDocBindingSource;
        private System.Windows.Forms.BindingNavigator itemDocBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton itemDocBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox itemDocIdTextBox;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.ComboBox ClothShopIdComboBox;
        private System.Windows.Forms.BindingSource ClothShopBindingSource;
        private System.Windows.Forms.ComboBox sportItemIdComboBox;
        private System.Windows.Forms.BindingSource sportItemBindingSource;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox countTextBox;
        private System.Windows.Forms.TextBox вартістьTextBox;
    }
}