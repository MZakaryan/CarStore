namespace CarStore.Forms
{
    partial class FormClient
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
            this.lblBrands = new System.Windows.Forms.Label();
            this.comboBoxBrands = new System.Windows.Forms.ComboBox();
            this.lblModels = new System.Windows.Forms.Label();
            this.comboBoxModels = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnBuy = new System.Windows.Forms.Button();
            this.dgvCars = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCars)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBrands
            // 
            this.lblBrands.AutoSize = true;
            this.lblBrands.Location = new System.Drawing.Point(12, 9);
            this.lblBrands.Name = "lblBrands";
            this.lblBrands.Size = new System.Drawing.Size(35, 13);
            this.lblBrands.TabIndex = 0;
            this.lblBrands.Text = "Brand";
            // 
            // comboBoxBrands
            // 
            this.comboBoxBrands.FormattingEnabled = true;
            this.comboBoxBrands.Location = new System.Drawing.Point(12, 25);
            this.comboBoxBrands.Name = "comboBoxBrands";
            this.comboBoxBrands.Size = new System.Drawing.Size(156, 21);
            this.comboBoxBrands.Sorted = true;
            this.comboBoxBrands.TabIndex = 0;
            this.comboBoxBrands.SelectedIndexChanged += new System.EventHandler(this.comboBoxBrands_SelectedIndexChanged);
            // 
            // lblModels
            // 
            this.lblModels.AutoSize = true;
            this.lblModels.Location = new System.Drawing.Point(185, 9);
            this.lblModels.Name = "lblModels";
            this.lblModels.Size = new System.Drawing.Size(36, 13);
            this.lblModels.TabIndex = 1;
            this.lblModels.Text = "Model";
            // 
            // comboBoxModels
            // 
            this.comboBoxModels.FormattingEnabled = true;
            this.comboBoxModels.Location = new System.Drawing.Point(188, 25);
            this.comboBoxModels.Name = "comboBoxModels";
            this.comboBoxModels.Size = new System.Drawing.Size(149, 21);
            this.comboBoxModels.Sorted = true;
            this.comboBoxModels.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(515, 23);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(25, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnBuy
            // 
            this.btnBuy.Location = new System.Drawing.Point(465, 65);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(75, 23);
            this.btnBuy.TabIndex = 4;
            this.btnBuy.Text = "Buy";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // dgvCars
            // 
            this.dgvCars.AllowUserToAddRows = false;
            this.dgvCars.AllowUserToDeleteRows = false;
            this.dgvCars.AllowUserToResizeColumns = false;
            this.dgvCars.AllowUserToResizeRows = false;
            this.dgvCars.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCars.Location = new System.Drawing.Point(15, 65);
            this.dgvCars.MultiSelect = false;
            this.dgvCars.Name = "dgvCars";
            this.dgvCars.ReadOnly = true;
            this.dgvCars.Size = new System.Drawing.Size(444, 280);
            this.dgvCars.TabIndex = 5;
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 357);
            this.Controls.Add(this.dgvCars);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.comboBoxModels);
            this.Controls.Add(this.lblModels);
            this.Controls.Add(this.comboBoxBrands);
            this.Controls.Add(this.lblBrands);
            this.MaximizeBox = false;
            this.Name = "FormClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Car list";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormClient_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBrands;
        private System.Windows.Forms.ComboBox comboBoxBrands;
        private System.Windows.Forms.Label lblModels;
        private System.Windows.Forms.ComboBox comboBoxModels;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.DataGridView dgvCars;
    }
}