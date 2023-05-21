namespace WinForms
{
    partial class ClothShopsForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SabeChangesButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(132, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(489, 252);
            this.dataGridView1.TabIndex = 0;
            // 
            // SabeChangesButton
            // 
            this.SabeChangesButton.Location = new System.Drawing.Point(132, 379);
            this.SabeChangesButton.Name = "SabeChangesButton";
            this.SabeChangesButton.Size = new System.Drawing.Size(75, 23);
            this.SabeChangesButton.TabIndex = 1;
            this.SabeChangesButton.Text = "Зберегти Зміни";
            this.SabeChangesButton.UseVisualStyleBackColor = true;
            this.SabeChangesButton.Click += new System.EventHandler(this.SabeChangesButton_Click);
            // 
            // ClothShopsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SabeChangesButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ClothShopsForm";
            this.Text = "ClothShopsForm";
            this.Load += new System.EventHandler(this.ClothShopsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button SabeChangesButton;
    }
}