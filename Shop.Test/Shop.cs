using System.Collections.Generic;
using Shop.Test.Interface;
using Shop.Test.ShoppingActivities;

namespace Shop.Test 
{
    public class Shop
    {
        private readonly IShoppingCart _cart;
        private readonly ICheckOut _checkout;

        public Shop(IDictionary<string, double> priceLists)
        : this(new ShoppingCart(priceLists), new CheckOut())
        {
        }

        public Shop(IShoppingCart cart, ICheckOut checkout)
        {
            _cart = cart;
            _checkout = checkout;
        }

        public void AddToShoppingCart(string itemName, int quantity)
        {
            _cart.AddItem(itemName, quantity);
        }

        public Reciept CheckOut()
        {
            return _checkout.CheckOutAndCalculate(_cart);
        }
    }
}

