using System.Collections.Generic;
using Shop.Test.ShoppingActivities;

namespace Shop.Test.Interface
{
    public interface IShoppingCart
    {
        void AddItem(string itemName, int quantity);
        List<ShoppingItem> ShoppingItems { get; set; }
    }
}