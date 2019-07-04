using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_interface
{
    class GroceryGoods : IProduct, IGoods
    {
        DateTime prodDate;
        DateTime expDate;
        DateTime purchaseDate;
        DateTime dateOfSale;
        double purchasePrice;

        public string Title { get; set; }
        public DateTime ProdDate
        {
            get => prodDate;
            set
            {
                DateTime t5 = DateTime.Today.AddYears(-5);
                prodDate = value > t5 ?
                    t5 : value;
            }
        }
        public DateTime ExpDate
        {
            get => expDate;
            set
            {
                expDate = value < prodDate ? prodDate : value;
            }
        }
        public DateTime PurchaseDate
        {
            get => purchaseDate;
            set
            {
                purchaseDate = value < prodDate ? prodDate : value;
            }
        }
        public DateTime DateOfSale
        {
            get => dateOfSale;
            set
            {
                dateOfSale = value > expDate ? expDate : value;
            }
        }
        public double PurchasePrice
        {
            get => purchasePrice;
            set => purchasePrice = value > 0 ? value : 0.01;
        }
        public double Markup { get; set; }

        public GroceryGoods(string title, DateTime prodDate, DateTime expDate, DateTime purchaseDate, DateTime dateOfSale, double purchasePrice, double markup)
        {
            Title = title;
            ProdDate = prodDate;
            ExpDate = expDate;
            PurchaseDate = purchaseDate;
            DateOfSale = dateOfSale;
            PurchasePrice = purchasePrice;
            Markup = markup;
        }
    }
}
