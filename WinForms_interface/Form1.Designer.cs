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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfSale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchasePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Markup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Summary = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnExpired = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.groupBoxSortByDate = new System.Windows.Forms.GroupBox();
            this.comboBoxSortOrder = new System.Windows.Forms.ComboBox();
            this.lblSort = new System.Windows.Forms.Label();
            this.storeSortModeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBoxSortByDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.storeSortModeBindingSource)).BeginInit();
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
            this.Markup,
            this.Summary});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(865, 158);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
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
            this.PurchasePrice.HeaderText = "PurchasePrice, $";
            this.PurchasePrice.Name = "PurchasePrice";
            this.PurchasePrice.ReadOnly = true;
            // 
            // Markup
            // 
            this.Markup.HeaderText = "Markup, $";
            this.Markup.Name = "Markup";
            this.Markup.ReadOnly = true;
            // 
            // Summary
            // 
            this.Summary.HeaderText = "Summary, $";
            this.Summary.Name = "Summary";
            this.Summary.ReadOnly = true;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(96, 12);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(152, 20);
            this.textBoxTitle.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(60, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(30, 13);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Title:";
            // 
            // lblPurchasePrice
            // 
            this.lblPurchasePrice.AutoSize = true;
            this.lblPurchasePrice.Location = new System.Drawing.Point(11, 145);
            this.lblPurchasePrice.Name = "lblPurchasePrice";
            this.lblPurchasePrice.Size = new System.Drawing.Size(79, 13);
            this.lblPurchasePrice.TabIndex = 4;
            this.lblPurchasePrice.Text = "PurchasePrice:";
            // 
            // textBoxPurchasePrice
            // 
            this.textBoxPurchasePrice.Location = new System.Drawing.Point(96, 142);
            this.textBoxPurchasePrice.Name = "textBoxPurchasePrice";
            this.textBoxPurchasePrice.Size = new System.Drawing.Size(56, 20);
            this.textBoxPurchasePrice.TabIndex = 3;
            // 
            // textBoxMarkup
            // 
            this.textBoxMarkup.Location = new System.Drawing.Point(96, 168);
            this.textBoxMarkup.Name = "textBoxMarkup";
            this.textBoxMarkup.Size = new System.Drawing.Size(56, 20);
            this.textBoxMarkup.TabIndex = 3;
            // 
            // lblMarkup
            // 
            this.lblMarkup.AutoSize = true;
            this.lblMarkup.Location = new System.Drawing.Point(44, 171);
            this.lblMarkup.Name = "lblMarkup";
            this.lblMarkup.Size = new System.Drawing.Size(46, 13);
            this.lblMarkup.TabIndex = 4;
            this.lblMarkup.Text = "Markup:";
            // 
            // dateTimePickerProdDate
            // 
            this.dateTimePickerProdDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerProdDate.Location = new System.Drawing.Point(96, 38);
            this.dateTimePickerProdDate.Name = "dateTimePickerProdDate";
            this.dateTimePickerProdDate.Size = new System.Drawing.Size(94, 20);
            this.dateTimePickerProdDate.TabIndex = 5;
            // 
            // lblProdDate
            // 
            this.lblProdDate.AutoSize = true;
            this.lblProdDate.Location = new System.Drawing.Point(35, 42);
            this.lblProdDate.Name = "lblProdDate";
            this.lblProdDate.Size = new System.Drawing.Size(55, 13);
            this.lblProdDate.TabIndex = 6;
            this.lblProdDate.Text = "ProdDate:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "ExpDate:";
            // 
            // dateTimePickerExpDate
            // 
            this.dateTimePickerExpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerExpDate.Location = new System.Drawing.Point(96, 64);
            this.dateTimePickerExpDate.Name = "dateTimePickerExpDate";
            this.dateTimePickerExpDate.Size = new System.Drawing.Size(94, 20);
            this.dateTimePickerExpDate.TabIndex = 7;
            // 
            // lblPurchaseDate
            // 
            this.lblPurchaseDate.AutoSize = true;
            this.lblPurchaseDate.Location = new System.Drawing.Point(12, 94);
            this.lblPurchaseDate.Name = "lblPurchaseDate";
            this.lblPurchaseDate.Size = new System.Drawing.Size(78, 13);
            this.lblPurchaseDate.TabIndex = 12;
            this.lblPurchaseDate.Text = "PurchaseDate:";
            // 
            // dateTimePickerPurchaseDate
            // 
            this.dateTimePickerPurchaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerPurchaseDate.Location = new System.Drawing.Point(96, 90);
            this.dateTimePickerPurchaseDate.Name = "dateTimePickerPurchaseDate";
            this.dateTimePickerPurchaseDate.Size = new System.Drawing.Size(94, 20);
            this.dateTimePickerPurchaseDate.TabIndex = 11;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(408, 164);
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
            this.lblDateOfSale.Location = new System.Drawing.Point(25, 120);
            this.lblDateOfSale.Name = "lblDateOfSale";
            this.lblDateOfSale.Size = new System.Drawing.Size(65, 13);
            this.lblDateOfSale.TabIndex = 15;
            this.lblDateOfSale.Text = "DateOfSale:";
            // 
            // dateTimePickerDateOfSale
            // 
            this.dateTimePickerDateOfSale.Enabled = false;
            this.dateTimePickerDateOfSale.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDateOfSale.Location = new System.Drawing.Point(96, 116);
            this.dateTimePickerDateOfSale.Name = "dateTimePickerDateOfSale";
            this.dateTimePickerDateOfSale.Size = new System.Drawing.Size(94, 20);
            this.dateTimePickerDateOfSale.TabIndex = 14;
            // 
            // checkBoxDateOfSale
            // 
            this.checkBoxDateOfSale.AutoSize = true;
            this.checkBoxDateOfSale.Checked = true;
            this.checkBoxDateOfSale.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDateOfSale.Location = new System.Drawing.Point(196, 118);
            this.checkBoxDateOfSale.Name = "checkBoxDateOfSale";
            this.checkBoxDateOfSale.Size = new System.Drawing.Size(67, 17);
            this.checkBoxDateOfSale.TabIndex = 16;
            this.checkBoxDateOfSale.Text = "Not Sold";
            this.checkBoxDateOfSale.UseVisualStyleBackColor = true;
            this.checkBoxDateOfSale.CheckedChanged += new System.EventHandler(this.CheckBoxDateOfSale_CheckedChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(408, 222);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnCalc);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.textBoxTitle);
            this.panel1.Controls.Add(this.checkBoxDateOfSale);
            this.panel1.Controls.Add(this.textBoxPurchasePrice);
            this.panel1.Controls.Add(this.lblDateOfSale);
            this.panel1.Controls.Add(this.textBoxMarkup);
            this.panel1.Controls.Add(this.dateTimePickerDateOfSale);
            this.panel1.Controls.Add(this.lblPurchasePrice);
            this.panel1.Controls.Add(this.lblMarkup);
            this.panel1.Controls.Add(this.lblPurchaseDate);
            this.panel1.Controls.Add(this.dateTimePickerProdDate);
            this.panel1.Controls.Add(this.dateTimePickerPurchaseDate);
            this.panel1.Controls.Add(this.lblProdDate);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dateTimePickerExpDate);
            this.panel1.Location = new System.Drawing.Point(125, 164);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(277, 202);
            this.panel1.TabIndex = 18;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(173, 165);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 17;
            this.btnCalc.Text = "Calc";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.BtnCalc_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(408, 193);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 19;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // btnExpired
            // 
            this.btnExpired.Location = new System.Drawing.Point(408, 282);
            this.btnExpired.Name = "btnExpired";
            this.btnExpired.Size = new System.Drawing.Size(99, 23);
            this.btnExpired.TabIndex = 20;
            this.btnExpired.Text = "Show expired";
            this.btnExpired.UseVisualStyleBackColor = true;
            this.btnExpired.Click += new System.EventHandler(this.BtnExpired_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(33, 52);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(98, 23);
            this.btnSort.TabIndex = 21;
            this.btnSort.Text = "Sort by ExpDate";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.BtnSort_Click);
            // 
            // groupBoxSortByDate
            // 
            this.groupBoxSortByDate.Controls.Add(this.comboBoxSortOrder);
            this.groupBoxSortByDate.Controls.Add(this.lblSort);
            this.groupBoxSortByDate.Controls.Add(this.btnSort);
            this.groupBoxSortByDate.Location = new System.Drawing.Point(553, 164);
            this.groupBoxSortByDate.Name = "groupBoxSortByDate";
            this.groupBoxSortByDate.Size = new System.Drawing.Size(165, 81);
            this.groupBoxSortByDate.TabIndex = 22;
            this.groupBoxSortByDate.TabStop = false;
            this.groupBoxSortByDate.Text = "Sort by ExpDate";
            // 
            // comboBoxSortOrder
            // 
            this.comboBoxSortOrder.FormattingEnabled = true;
            this.comboBoxSortOrder.Location = new System.Drawing.Point(69, 19);
            this.comboBoxSortOrder.Name = "comboBoxSortOrder";
            this.comboBoxSortOrder.Size = new System.Drawing.Size(84, 21);
            this.comboBoxSortOrder.TabIndex = 23;
            // 
            // lblSort
            // 
            this.lblSort.AutoSize = true;
            this.lblSort.Location = new System.Drawing.Point(7, 22);
            this.lblSort.Name = "lblSort";
            this.lblSort.Size = new System.Drawing.Size(56, 13);
            this.lblSort.TabIndex = 22;
            this.lblSort.Text = "Sort order:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 377);
            this.Controls.Add(this.groupBoxSortByDate);
            this.Controls.Add(this.btnExpired);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Interfaces";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBoxSortByDate.ResumeLayout(false);
            this.groupBoxSortByDate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.storeSortModeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
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
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnExpired;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchasePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Markup;
        private System.Windows.Forms.DataGridViewTextBoxColumn Summary;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.GroupBox groupBoxSortByDate;
        private System.Windows.Forms.ComboBox comboBoxSortOrder;
        private System.Windows.Forms.BindingSource storeSortModeBindingSource;
        private System.Windows.Forms.Label lblSort;
    }
}

