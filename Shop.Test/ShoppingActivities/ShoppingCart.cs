using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Shop.Test.Interface;

namespace Shop.Test.ShoppingActivities
{
    public class ShoppingCart : IShoppingCart
    {
        private readonly IDictionary<string, double> _pricelist;

        public ShoppingCart(IDictionary<string, double> pricelist)
        {
            if (pricelist == null || pricelist.Count == 0)
            {
                throw new ArgumentException("Price list is null or empty.");
            }

            _pricelist = pricelist;
            ShoppingItems = new List<ShoppingItem>();
        }
        public void AddItem(string itemName, int quantity)
        {

            if (string.IsNullOrEmpty(itemName) || quantity == 0)
            {
                return;
            }

            double unitPrice = 0;

            if (_pricelist.ContainsKey(itemName.ToLower()))
            {
                unitPrice = _pricelist[itemName.ToLower()];
            }



            ShoppingItems.Add(new ShoppingItem()
            {
                Name = itemName,
                Quantity = quantity,
                UnitPrice = unitPrice
            });
        }

        public List<ShoppingItem> ShoppingItems { get; set; }
    }
}