using System;
using System.Linq;
using Shop.Test.Interface;
using Shop.Test.ShoppingActivities;

namespace Shop.Test.Rule
{
    public class AppleRule : IRule
    {
        public Reciept ApplyRule(Reciept reciept)
        {
            if (reciept == null || reciept.RecieptItems.Count == 0)
            {
                throw new ArgumentException("Price list is null or empty.");
            }

            RecieptItem recieptItem = reciept.RecieptItems.FirstOrDefault(i =>
                String.Compare(i.Name, "apple", StringComparison.OrdinalIgnoreCase) == 0);

            if (recieptItem == null || recieptItem.Quantity == 0)
            {
                return reciept;
            }

            int quantitywithoffer = (int)recieptItem.Quantity / 2;
            int leftover = recieptItem.Quantity - quantitywithoffer * 2;
            recieptItem.Quantity = quantitywithoffer + leftover;

            return reciept;
        }
    }
}