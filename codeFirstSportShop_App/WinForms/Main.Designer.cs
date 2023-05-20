namespace WinForms
{
    partial class Main
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DocButton = new System.Windows.Forms.Button();
            this.SalesButton = new System.Windows.Forms.Button();
            this.SportItemsButton = new System.Windows.Forms.Button();
            this.SportShopsButton = new System.Windows.Forms.Button();
            this.SalesBySportShopsButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SalesButton);
            this.groupBox1.Controls.Add(this.DocButton);
            this.groupBox1.Location = new System.Drawing.Point(113, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 155);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Оперативна інформація";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SportShopsButton);
            this.groupBox2.Controls.Add(this.SportItemsButton);
            this.groupBox2.Location = new System.Drawing.Point(114, 280);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(246, 143);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Довідник";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.SalesBySportShopsButton);
            this.groupBox3.Location = new System.Drawing.Point(492, 119);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(240, 303);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Аналіз";
            // 
            // DocButton
            // 
            this.DocButton.Location = new System.Drawing.Point(38, 45);
            this.DocButton.Name = "DocButton";
            this.DocButton.Size = new System.Drawing.Size(146, 30);
            this.DocButton.TabIndex = 0;
            this.DocButton.Text = "Накладні";
            this.DocButton.UseVisualStyleBackColor = true;
            this.DocButton.Click += new System.EventHandler(this.DocButton_Click);
            // 
            // SalesButton
            // 
            this.SalesButton.Location = new System.Drawing.Point(39, 105);
            this.SalesButton.Name = "SalesButton";
            this.SalesButton.Size = new System.Drawing.Size(144, 32);
            this.SalesButton.TabIndex = 1;
            this.SalesButton.Text = "Продажі";
            this.SalesButton.UseVisualStyleBackColor = true;
            this.SalesButton.Click += new System.EventHandler(this.SalesButton_Click);
            // 
            // SportItemsButton
            // 
            this.SportItemsButton.Location = new System.Drawing.Point(34, 49);
            this.SportItemsButton.Name = "SportItemsButton";
            this.SportItemsButton.Size = new System.Drawing.Size(170, 25);
            this.SportItemsButton.TabIndex = 0;
            this.SportItemsButton.Text = "Спорт товари";
            this.SportItemsButton.UseVisualStyleBackColor = true;
            this.SportItemsButton.Click += new System.EventHandler(this.SportItemsButton_Click);
            // 
            // SportShopsButton
            // 
            this.SportShopsButton.Location = new System.Drawing.Point(35, 102);
            this.SportShopsButton.Name = "SportShopsButton";
            this.SportShopsButton.Size = new System.Drawing.Size(168, 26);
            this.SportShopsButton.TabIndex = 1;
            this.SportShopsButton.Text = "Магазини";
            this.SportShopsButton.UseVisualStyleBackColor = true;
            this.SportShopsButton.Click += new System.EventHandler(this.SportShopsButton_Click);
            // 
            // SalesBySportShopsButton
            // 
            this.SalesBySportShopsButton.Location = new System.Drawing.Point(70, 44);
            this.SalesBySportShopsButton.Name = "SalesBySportShopsButton";
            this.SalesBySportShopsButton.Size = new System.Drawing.Size(130, 35);
            this.SalesBySportShopsButton.TabIndex = 0;
            this.SalesBySportShopsButton.Text = "Продажі спорт магазинів";
            this.SalesBySportShopsButton.UseVisualStyleBackColor = true;
            this.SalesBySportShopsButton.Click += new System.EventHandler(this.SalesBySportShopsButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Main";
            this.Text = "Sport Shop";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button SalesButton;
        private System.Windows.Forms.Button DocButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button SportShopsButton;
        private System.Windows.Forms.Button SportItemsButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button SalesBySportShopsButton;
    }
}

