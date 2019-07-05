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

        public MainForm()
        {
            InitializeComponent();
            store = new Store();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            GroceryGoods bread = new GroceryGoods("Bread", new DateTime(2019, 7, 3), new DateTime(2019, 7, 6), new DateTime(2019, 7, 4), 15, 5);
            GroceryGoods sausage = new GroceryGoods("Sausage", new DateTime(2019, 7, 3), new DateTime(2019, 9, 6), new DateTime(2019, 7, 4), 50, 25);
            //MessageBox.Show(bread.ToString());

            store.StoreGoods.Add(bread);
            store.StoreGoods.Add(sausage);

            dataGridView1.Rows.Add(store.StoreGoods.Count);
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
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            GroceryGoods newGoods = new GroceryGoods(
                textBoxTitle.Text,
                dateTimePickerProdDate.Value,
                dateTimePickerExpDate.Value,
                dateTimePickerPurchaseDate.Value,
                checkBoxDateOfSale.Checked ? DateTime.MinValue : dateTimePickerDateOfSale.Value,
                Convert.ToDouble(textBoxPurchasePrice.Text),
                Convert.ToDouble(textBoxMarkup.Text)
            );

            store.StoreGoods.Add(newGoods);
            dataGridView1.Rows.Add(1);
        }

        private void CheckBoxDateOfSale_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePickerDateOfSale.Visible = !dateTimePickerDateOfSale.Visible;
        }
    }
}
