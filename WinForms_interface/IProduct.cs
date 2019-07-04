using System;

namespace WinForms_interface
{
    /*
    "Продукт" со свойствами: 
    наименование, 
    дата производства(не старше 5 лет), 
    конечная дата годности(не раньше даты производства)
    */
    interface IProduct
    {
        string Title { set; get; } // наименование
        DateTime ProdDate { set; get; } // дата производства
        DateTime ExpDate { set; get; } // конечная дата годности
    }
}
