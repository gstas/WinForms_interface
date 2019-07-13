using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_interface
{
    public partial class MainForm : Form
    {
        Store store;
        int selectedRow;

        Func<double, double, double> Summ = GroceryGoods.SummaryCalculate;

        public MainForm()
        {
            InitializeComponent();
            store = new Store();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            GroceryGoods bread = new GroceryGoods("Bread", new DateTime(2019, 7, 3), new DateTime(2019, 7, 6), new DateTime(2019, 7, 4), 15, 5);
            GroceryGoods sausage = new GroceryGoods("Sausage", new DateTime(2019, 7, 3), new DateTime(2019, 9, 6), new DateTime(2019, 7, 4), 90, 25);
            GroceryGoods beer = new GroceryGoods("Beer", new DateTime(2019, 7, 3), new DateTime(2020, 9, 6), new DateTime(2019, 7, 4), 50, 5);

            store.StoreGoods.Add(bread);
            store.StoreGoods.Add(sausage);
            store.StoreGoods.Add(beer);

            dataGridView1.Rows.Add(store.StoreGoods.Count);

            if (store.StoreGoods.Count > 0)
            {
                selectedRow = 0;
                FillForm();
            }

            comboBoxSortOrder.DataSource = Enum.GetValues(typeof(StoreSortMode));
        }

        private void DataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 0)
            {
                DateTime dos = ((GroceryGoods)store.StoreGoods[row]).DateOfSale;
                dataGridView1.Rows[row].Cells[0].Value = ((GroceryGoods)store.StoreGoods[row]).Title;
                dataGridView1.Rows[row].Cells[1].Value = ((GroceryGoods)store.StoreGoods[row]).ProdDate.ToShortDateString();
                dataGridView1.Rows[row].Cells[2].Value = ((GroceryGoods)store.StoreGoods[row]).ExpDate.ToShortDateString();
                dataGridView1.Rows[row].Cells[3].Value = ((GroceryGoods)store.StoreGoods[row]).PurchaseDate.ToShortDateString();
                dataGridView1.Rows[row].Cells[4].Value = dos > DateTime.MinValue ? dos.ToShortDateString() : "";
                dataGridView1.Rows[row].Cells[5].Value = ((GroceryGoods)store.StoreGoods[row]).PurchasePrice;
                dataGridView1.Rows[row].Cells[6].Value = ((GroceryGoods)store.StoreGoods[row]).Markup;

                dataGridView1.Rows[row].Cells[7].Value = Summ(((GroceryGoods)store.StoreGoods[row]).PurchasePrice, ((GroceryGoods)store.StoreGoods[row]).Markup);
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string errorText = "";
            double purchasePrice = 0;
            double markup = 0;

            try
            {
                purchasePrice = Convert.ToDouble(textBoxPurchasePrice.Text);
            }
            catch (Exception)
            {
                errorText += "Не верное значение закупочной стоимости!\n";
            }

            try
            {
                markup = Convert.ToDouble(textBoxMarkup.Text);
            }
            catch (Exception)
            {
                errorText += "Не верное значение наценки!\n";
            }

            if (errorText != "")
            {
                MessageBox.Show(errorText, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            GroceryGoods newGoods = new GroceryGoods(
                textBoxTitle.Text,
                dateTimePickerProdDate.Value,
                dateTimePickerExpDate.Value,
                dateTimePickerPurchaseDate.Value,
                checkBoxDateOfSale.Checked ? DateTime.MinValue : dateTimePickerDateOfSale.Value,
                purchasePrice,
                markup
            );

            store.StoreGoods.Add(newGoods);
            dataGridView1.Rows.Add(1);
        }

        private void CheckBoxDateOfSale_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePickerDateOfSale.Enabled = !dateTimePickerDateOfSale.Enabled;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete this item - " +
                ((GroceryGoods)store.StoreGoods[selectedRow]).Title + "?",
                                     "Confirm Delete",
                                     MessageBoxButtons.YesNo,
                                     MessageBoxIcon.Question,
                                     MessageBoxDefaultButton.Button2);
            if (confirmResult == DialogResult.Yes)
            {
                store.StoreGoods.RemoveAt(selectedRow);
                dataGridView1.Rows.RemoveAt(selectedRow);
            }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            FillForm();
        }

        private void FillForm()
        {
            textBoxTitle.Text = ((GroceryGoods)store.StoreGoods[selectedRow]).Title;
            dateTimePickerProdDate.Value = ((GroceryGoods)store.StoreGoods[selectedRow]).ProdDate;
            dateTimePickerExpDate.Value = ((GroceryGoods)store.StoreGoods[selectedRow]).ExpDate;
            dateTimePickerPurchaseDate.Value = ((GroceryGoods)store.StoreGoods[selectedRow]).PurchaseDate;

            if (((GroceryGoods)store.StoreGoods[selectedRow]).DateOfSale == DateTime.MinValue)
            {
                checkBoxDateOfSale.Checked = true;
                dateTimePickerDateOfSale.Enabled = false;
            }
            else
            {
                checkBoxDateOfSale.Checked = false;
                dateTimePickerDateOfSale.Enabled = true;
                dateTimePickerDateOfSale.Value = ((GroceryGoods)store.StoreGoods[selectedRow]).DateOfSale;
            }

            textBoxPurchasePrice.Text = ((GroceryGoods)store.StoreGoods[selectedRow]).PurchasePrice.ToString();
            textBoxMarkup.Text = ((GroceryGoods)store.StoreGoods[selectedRow]).Markup.ToString();
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            ((GroceryGoods)store.StoreGoods[selectedRow]).CalcMarkup();
            FillForm();
            dataGridView1.Update();
            dataGridView1.Refresh();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            ((GroceryGoods)store.StoreGoods[selectedRow]).Title = textBoxTitle.Text;
            ((GroceryGoods)store.StoreGoods[selectedRow]).ProdDate = dateTimePickerProdDate.Value;
            ((GroceryGoods)store.StoreGoods[selectedRow]).ExpDate = dateTimePickerExpDate.Value;
            ((GroceryGoods)store.StoreGoods[selectedRow]).PurchaseDate = dateTimePickerPurchaseDate.Value;
            ((GroceryGoods)store.StoreGoods[selectedRow]).DateOfSale = checkBoxDateOfSale.Checked ? DateTime.MinValue : dateTimePickerDateOfSale.Value;
            ((GroceryGoods)store.StoreGoods[selectedRow]).PurchasePrice = Convert.ToDouble(textBoxPurchasePrice.Text);
            ((GroceryGoods)store.StoreGoods[selectedRow]).Markup = Convert.ToDouble(textBoxMarkup.Text);
            FillForm();
            dataGridView1.Update();
            dataGridView1.Refresh();
        }

        private void BtnExpired_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < store.StoreGoods.Count; i++)
            {
                dataGridView1.Rows[i].Cells[2].Style.BackColor = Color.White;
            }

            foreach (int i in store.GetExpired())
            {
                dataGridView1.Rows[i].Cells[2].Style.BackColor = Color.LightPink;
            }
        }

        private void BtnSort_Click(object sender, EventArgs e)
        {
            store.SortByExpDate((StoreSortMode)comboBoxSortOrder.SelectedItem);
            
            dataGridView1.Update();
            dataGridView1.Refresh();
        }
    }
}
