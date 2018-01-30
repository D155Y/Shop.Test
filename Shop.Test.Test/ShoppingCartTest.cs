using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Shop.Test.Extention;
using Shop.Test.Interface;
using Shop.Test.ShoppingActivities;

namespace Shop.Test.Test
{
    [TestFixture]
    public class ShoppingCartTest
    {
        private readonly IDictionary<string, double> _pricelist = new Dictionary<string, double>();

        [SetUp]
        public void SetUp()
        {
           _pricelist.Add("apple", .6 );
            _pricelist.Add("orange", .25);
        }

        [TearDown]
        public void TearDown()
        {
            // To do
        }

        [Test]
        public void When_Items_added_to_cart_are_grouped()
        {
            //arrange
            IShoppingCart shoppingCart = new ShoppingCart(_pricelist);
            shoppingCart.AddItem("apple", 2);
            shoppingCart.AddItem("apple", 1);
            shoppingCart.AddItem("orange", 2);
            shoppingCart.AddItem("orange", 2);

            //act
            var grouped = shoppingCart.GroupShoppingItems();

            //assert
            Assert.IsTrue(grouped.Count == 2);
            Assert.IsTrue(grouped.First(i => String.Compare(i.Name, "apple",StringComparison.OrdinalIgnoreCase) == 0).Quantity ==3);
            Assert.IsTrue(grouped.First(i => String.Compare(i.Name, "orange", StringComparison.OrdinalIgnoreCase) == 0).Quantity == 4);
        }
    }


  
}
