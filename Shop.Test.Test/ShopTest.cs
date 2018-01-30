using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Shop.Test.Test
{
    [TestFixture]
    public class ShopTest
    {
        private readonly IDictionary<string, double> _pricelist = new Dictionary<string, double>();

        [SetUp]
        public void SetUp()
        {
            _pricelist.Add("apple", .6);
            _pricelist.Add("orange", .25);
        }

        [TearDown]
        public void TearDown()
        {
            // To do
        }

        [Test]
        public void When_Adding_ItemsToCart()
        {
            //arrange
            Shop shop = new Shop(_pricelist);

            //act
            shop.AddToShoppingCart("apple",2);
            shop.AddToShoppingCart("orange", 4);
            var recipet = shop.CheckOut();

            //assert
            Assert.IsTrue(recipet.Total == 2.2);
            Assert.True(recipet.RecieptItems.Count == 2);
            Assert.True(recipet.RecieptItems.Sum(i => i.Quantity) == 6);
        }
    }
}
