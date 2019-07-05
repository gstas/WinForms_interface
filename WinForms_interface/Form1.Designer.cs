namespace WinForms_interface
{
    partial class MainForm
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
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfSale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchasePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Markup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPurchasePrice = new System.Windows.Forms.Label();
            this.textBoxPurchasePrice = new System.Windows.Forms.TextBox();
            this.textBoxMarkup = new System.Windows.Forms.TextBox();
            this.lblMarkup = new System.Windows.Forms.Label();
            this.dateTimePickerProdDate = new System.Windows.Forms.DateTimePicker();
            this.lblProdDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerExpDate = new System.Windows.Forms.DateTimePicker();
            this.lblPurchaseDate = new System.Windows.Forms.Label();
            this.dateTimePickerPurchaseDate = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblDateOfSale = new System.Windows.Forms.Label();
            this.dateTimePickerDateOfSale = new System.Windows.Forms.DateTimePicker();
            this.checkBoxDateOfSale = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title,
            this.ProdDate,
            this.ExpDate,
            this.PurchaseDate,
            this.DateOfSale,
            this.PurchasePrice,
            this.Markup});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(827, 158);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.DataGridView1_CellPainting);
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // ProdDate
            // 
            this.ProdDate.HeaderText = "ProdDate";
            this.ProdDate.Name = "ProdDate";
            this.ProdDate.ReadOnly = true;
            // 
            // ExpDate
            // 
            this.ExpDate.HeaderText = "ExpDate";
            this.ExpDate.Name = "ExpDate";
            this.ExpDate.ReadOnly = true;
            // 
            // PurchaseDate
            // 
            this.PurchaseDate.HeaderText = "PurchaseDate";
            this.PurchaseDate.Name = "PurchaseDate";
            this.PurchaseDate.ReadOnly = true;
            // 
            // DateOfSale
            // 
            this.DateOfSale.HeaderText = "DateOfSale";
            this.DateOfSale.Name = "DateOfSale";
            this.DateOfSale.ReadOnly = true;
            // 
            // PurchasePrice
            // 
            this.PurchasePrice.HeaderText = "PurchasePrice";
            this.PurchasePrice.Name = "PurchasePrice";
            this.PurchasePrice.ReadOnly = true;
            // 
            // Markup
            // 
            this.Markup.HeaderText = "Markup";
            this.Markup.Name = "Markup";
            this.Markup.ReadOnly = true;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(175, 192);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(152, 20);
            this.textBoxTitle.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(139, 195);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(30, 13);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Title:";
            // 
            // lblPurchasePrice
            // 
            this.lblPurchasePrice.AutoSize = true;
            this.lblPurchasePrice.Location = new System.Drawing.Point(90, 325);
            this.lblPurchasePrice.Name = "lblPurchasePrice";
            this.lblPurchasePrice.Size = new System.Drawing.Size(79, 13);
            this.lblPurchasePrice.TabIndex = 4;
            this.lblPurchasePrice.Text = "PurchasePrice:";
            // 
            // textBoxPurchasePrice
            // 
            this.textBoxPurchasePrice.Location = new System.Drawing.Point(175, 322);
            this.textBoxPurchasePrice.Name = "textBoxPurchasePrice";
            this.textBoxPurchasePrice.Size = new System.Drawing.Size(56, 20);
            this.textBoxPurchasePrice.TabIndex = 3;
            // 
            // textBoxMarkup
            // 
            this.textBoxMarkup.Location = new System.Drawing.Point(175, 348);
            this.textBoxMarkup.Name = "textBoxMarkup";
            this.textBoxMarkup.Size = new System.Drawing.Size(56, 20);
            this.textBoxMarkup.TabIndex = 3;
            // 
            // lblMarkup
            // 
            this.lblMarkup.AutoSize = true;
            this.lblMarkup.Location = new System.Drawing.Point(123, 351);
            this.lblMarkup.Name = "lblMarkup";
            this.lblMarkup.Size = new System.Drawing.Size(46, 13);
            this.lblMarkup.TabIndex = 4;
            this.lblMarkup.Text = "Markup:";
            // 
            // dateTimePickerProdDate
            // 
            this.dateTimePickerProdDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerProdDate.Location = new System.Drawing.Point(175, 218);
            this.dateTimePickerProdDate.Name = "dateTimePickerProdDate";
            this.dateTimePickerProdDate.Size = new System.Drawing.Size(94, 20);
            this.dateTimePickerProdDate.TabIndex = 5;
            // 
            // lblProdDate
            // 
            this.lblProdDate.AutoSize = true;
            this.lblProdDate.Location = new System.Drawing.Point(114, 222);
            this.lblProdDate.Name = "lblProdDate";
            this.lblProdDate.Size = new System.Drawing.Size(55, 13);
            this.lblProdDate.TabIndex = 6;
            this.lblProdDate.Text = "ProdDate:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "ExpDate:";
            // 
            // dateTimePickerExpDate
            // 
            this.dateTimePickerExpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerExpDate.Location = new System.Drawing.Point(175, 244);
            this.dateTimePickerExpDate.Name = "dateTimePickerExpDate";
            this.dateTimePickerExpDate.Size = new System.Drawing.Size(94, 20);
            this.dateTimePickerExpDate.TabIndex = 7;
            // 
            // lblPurchaseDate
            // 
            this.lblPurchaseDate.AutoSize = true;
            this.lblPurchaseDate.Location = new System.Drawing.Point(91, 274);
            this.lblPurchaseDate.Name = "lblPurchaseDate";
            this.lblPurchaseDate.Size = new System.Drawing.Size(78, 13);
            this.lblPurchaseDate.TabIndex = 12;
            this.lblPurchaseDate.Text = "PurchaseDate:";
            // 
            // dateTimePickerPurchaseDate
            // 
            this.dateTimePickerPurchaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerPurchaseDate.Location = new System.Drawing.Point(175, 270);
            this.dateTimePickerPurchaseDate.Name = "dateTimePickerPurchaseDate";
            this.dateTimePickerPurchaseDate.Size = new System.Drawing.Size(94, 20);
            this.dateTimePickerPurchaseDate.TabIndex = 11;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(175, 374);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // lblDateOfSale
            // 
            this.lblDateOfSale.AutoSize = true;
            this.lblDateOfSale.Location = new System.Drawing.Point(104, 300);
            this.lblDateOfSale.Name = "lblDateOfSale";
            this.lblDateOfSale.Size = new System.Drawing.Size(65, 13);
            this.lblDateOfSale.TabIndex = 15;
            this.lblDateOfSale.Text = "DateOfSale:";
            // 
            // dateTimePickerDateOfSale
            // 
            this.dateTimePickerDateOfSale.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDateOfSale.Location = new System.Drawing.Point(175, 296);
            this.dateTimePickerDateOfSale.Name = "dateTimePickerDateOfSale";
            this.dateTimePickerDateOfSale.Size = new System.Drawing.Size(94, 20);
            this.dateTimePickerDateOfSale.TabIndex = 14;
            // 
            // checkBoxDateOfSale
            // 
            this.checkBoxDateOfSale.AutoSize = true;
            this.checkBoxDateOfSale.Checked = true;
            this.checkBoxDateOfSale.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDateOfSale.Location = new System.Drawing.Point(275, 299);
            this.checkBoxDateOfSale.Name = "checkBoxDateOfSale";
            this.checkBoxDateOfSale.Size = new System.Drawing.Size(67, 17);
            this.checkBoxDateOfSale.TabIndex = 16;
            this.checkBoxDateOfSale.Text = "Not Sold";
            this.checkBoxDateOfSale.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 461);
            this.Controls.Add(this.checkBoxDateOfSale);
            this.Controls.Add(this.lblDateOfSale);
            this.Controls.Add(this.dateTimePickerDateOfSale);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblPurchaseDate);
            this.Controls.Add(this.dateTimePickerPurchaseDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerExpDate);
            this.Controls.Add(this.lblProdDate);
            this.Controls.Add(this.dateTimePickerProdDate);
            this.Controls.Add(this.lblMarkup);
            this.Controls.Add(this.lblPurchasePrice);
            this.Controls.Add(this.textBoxMarkup);
            this.Controls.Add(this.textBoxPurchasePrice);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Interfaces";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchasePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Markup;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPurchasePrice;
        private System.Windows.Forms.TextBox textBoxPurchasePrice;
        private System.Windows.Forms.TextBox textBoxMarkup;
        private System.Windows.Forms.Label lblMarkup;
        private System.Windows.Forms.DateTimePicker dateTimePickerProdDate;
        private System.Windows.Forms.Label lblProdDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerExpDate;
        private System.Windows.Forms.Label lblPurchaseDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerPurchaseDate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblDateOfSale;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateOfSale;
        private System.Windows.Forms.CheckBox checkBoxDateOfSale;
    }
}

