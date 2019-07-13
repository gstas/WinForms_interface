using System;
using System.Windows.Forms;

namespace WinForms_interface
{
    class GroceryGoods : IProduct, IGoods
    {
        DateTime prodDate;
        DateTime expDate;
        DateTime purchaseDate;
        DateTime dateOfSale;
        double purchasePrice;

        delegate void DelMarkup(double procent);

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

        public GroceryGoods(string title, DateTime prodDate, DateTime expDate,
            DateTime purchaseDate, double purchasePrice, double markup)
        {
            Title = title;
            ProdDate = prodDate;
            ExpDate = expDate;
            PurchaseDate = purchaseDate;
            PurchasePrice = purchasePrice;
            Markup = markup;
        }

        public GroceryGoods(string title, DateTime prodDate, DateTime expDate,
            DateTime purchaseDate, DateTime dateOfSale, double purchasePrice, double markup)
            : this(title, prodDate, expDate, purchaseDate, purchasePrice, markup)
        {
            DateOfSale = dateOfSale;
        }

        public void CalcMarkup()
        {
            /*
            если до конца срока годности осталось до 20 % от общего срока годности, 
            то скидка от закупочной цены должна составлять 10 %,
            
            если до конца срока годности осталось до 10 % от общего срока годности, 
            то скидка от закупочной цены должна составлять 25 %,
            
            в последний день срока годности скидка от закупочной цены должна составлять 50 %
            */

            double summaryExpDays = (ExpDate - ProdDate).TotalDays;
            double restOfExp = (ExpDate - DateTime.Today).TotalDays;

            double proc = restOfExp * 100 / summaryExpDays;
            
            DelMarkup del = MarkupCalculate;

            if (restOfExp <= 1)
                del(0.5);
            else if (proc < 10)
                del(0.25);
            else if (proc < 20)
                del(0.1);
        }

        private void MarkupCalculate(double procent) {
            Markup = PurchasePrice * procent * -1;
        }
       
        public static double SummaryCalculate(double pruchasePrice, double markup)
        {
            return pruchasePrice + markup;
        }

        public override string ToString()
        {
            return $"{Title}, ProdDate: {ProdDate.ToShortDateString()}, ExpDate:{ExpDate.ToShortDateString()}\n"+
                $"PurchDate: {PurchaseDate.ToShortDateString()}, PurchasePrice: {PurchasePrice}, Markup: {Markup}";
        }
    }
}
