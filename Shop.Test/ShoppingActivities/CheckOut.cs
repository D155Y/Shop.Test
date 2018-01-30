using System;
using Shop.Test.Extention;
using Shop.Test.Interface;

namespace Shop.Test.ShoppingActivities
{
    class CheckOut : ICheckOut
    {
        private readonly ICalculatePrice _calculatePrice;

        public CheckOut() : this(new CalculatePrice())
        {

        }

        public CheckOut(ICalculatePrice calculatePrice)
        {
            _calculatePrice = calculatePrice;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="shoppingCart"></param>
        /// <returns></returns>
        public Reciept CheckOutAndCalculate(IShoppingCart shoppingCart)
        {
            if (shoppingCart == null || shoppingCart.ShoppingItems.Count == 0)
            {
                throw new ArgumentException("Shopping cart is empty");
            }

            var shoppingItems = shoppingCart.GroupShoppingItems();
            return _calculatePrice.Calculate(shoppingItems);
        }
    }
}

    