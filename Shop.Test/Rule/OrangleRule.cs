using System;
using System.Linq;
using Shop.Test.Interface;
using Shop.Test.ShoppingActivities;

namespace Shop.Test.Rule
{
    public class OrangleRule : IRule
    {
        public Reciept ApplyRule(Reciept reciept)
        {
            if (reciept == null || reciept.RecieptItems.Count == 0)
            {
                throw new ArgumentException("Price list is null or empty.");
            }

            RecieptItem recieptItem = reciept.RecieptItems.FirstOrDefault(i =>
                String.Compare(i.Name, "orange", StringComparison.OrdinalIgnoreCase) == 0);

            if (recieptItem == null || recieptItem.Quantity == 0)
            {
                return reciept;
            }

            int quantitywithoffer = (int)recieptItem.Quantity / 3;
            int leftover = recieptItem.Quantity - quantitywithoffer * 3;
            recieptItem.Quantity = quantitywithoffer*2 + leftover;
            return reciept;
        }
    }
}