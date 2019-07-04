using System;

namespace WinForms_interface
{
    /*
    "Товар" со свойствами: 
    дата закупки(не раньше даты производства), 
    дата продажи(не позже конечной даты годности), 
    закупочная цена(больше 0), 
    наценка(может быть как больше единицы(с добавочной стоимостью), так и меньше единицы(со скидкой)).
    */
    interface IGoods
    {
        DateTime PurchaseDate { get; set; } // дата закупки
        DateTime DateOfSale { get; set; } // дата продажи
        double PurchasePrice { get; set; } // закупочная цена
        double Markup { get; set; } // наценка
    }
}
