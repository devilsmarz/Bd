namespace WinForms
{
    partial class SportItemsForm
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
            this.SportItemsDataGridView = new System.Windows.Forms.DataGridView();
            this.SaveChangesButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SportItemsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SportItemsDataGridView
            // 
            this.SportItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SportItemsDataGridView.Location = new System.Drawing.Point(110, 76);
            this.SportItemsDataGridView.Name = "SportItemsDataGridView";
            this.SportItemsDataGridView.Size = new System.Drawing.Size(538, 287);
            this.SportItemsDataGridView.TabIndex = 0;
            // 
            // SaveChangesButton
            // 
            this.SaveChangesButton.Location = new System.Drawing.Point(110, 401);
            this.SaveChangesButton.Name = "SaveChangesButton";
            this.SaveChangesButton.Size = new System.Drawing.Size(115, 23);
            this.SaveChangesButton.TabIndex = 1;
            this.SaveChangesButton.Text = "Зберегти зміни";
            this.SaveChangesButton.UseVisualStyleBackColor = true;
            this.SaveChangesButton.Click += new System.EventHandler(this.SaveChangesButton_Click);
            // 
            // SportItemsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SaveChangesButton);
            this.Controls.Add(this.SportItemsDataGridView);
            this.Name = "SportItemsForm";
            this.Text = "Sport Items";
            this.Load += new System.EventHandler(this.SportItemsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SportItemsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView SportItemsDataGridView;
        private System.Windows.Forms.Button SaveChangesButton;
    }
}