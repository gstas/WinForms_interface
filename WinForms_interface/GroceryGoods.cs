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
            set {
                expDate = value > prodDate ? prodDate : value;
            }
        }
        public DateTime PurchaseDate { get; set; }
        public DateTime DateOfSale { get; set; }
        public double PurchasePrice { get; set; }
        public double Markup { get; set; }
    }
}
