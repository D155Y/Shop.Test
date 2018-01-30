using Shop.Test.ShoppingActivities;

namespace Shop.Test.Interface
{
    public interface ICheckOut
    {
        Reciept CheckOutAndCalculate(IShoppingCart shoppingCart);
    }
}