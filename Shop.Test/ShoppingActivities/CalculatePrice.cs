using System.Collections.Generic;
using System.Linq;
using Shop.Test.Interface;

namespace Shop.Test.ShoppingActivities
{
    public class CalculatePrice : ICalculatePrice
    {
        public Reciept Calculate(List<ShoppingItem> shoppintItems)
        {
            List<RecieptItem> recieptItems = shoppintItems.Select(shoppintItem => new RecieptItem()
                {
                    Name = shoppintItem.Name,
                    Quantity = shoppintItem.Quantity,
                    UnitPrice = shoppintItem.UnitPrice
                }).ToList();


            return new Reciept(recieptItems);
        }
    }
}