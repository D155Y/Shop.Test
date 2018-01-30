using System;
using System.Collections.Generic;
using System.Linq;
using Shop.Test.Interface;
using Shop.Test.ShoppingActivities;

namespace Shop.Test.Extention
{
    public static class ShoppingCartExt
    {
        public static List<ShoppingItem> GroupShoppingItems(this IShoppingCart shoppingCart)
        {
            if (shoppingCart == null || shoppingCart.ShoppingItems.Count == 0)
            {
                throw new InvalidOperationException("Can't group shopping item as cart is empty.");
            }

            var shoppingItems = shoppingCart.ShoppingItems;

            return (shoppingItems
                .GroupBy(item => new { Name = item.Name.ToLower(), UnitPrice = item.UnitPrice })
                .Select(g =>
                    new ShoppingItem
                    {
                        Name = g.Key.Name,
                        Quantity = g.Sum(i => i.Quantity),
                        UnitPrice = g.Key.UnitPrice
                    })).ToList();
        }
    }
}