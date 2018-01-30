using System.Collections.Generic;
using Shop.Test.ShoppingActivities;

namespace Shop.Test.Interface
{
    public interface ICalculatePrice
    {
        Reciept Calculate(List<ShoppingItem> shoppintItems);
    }
}