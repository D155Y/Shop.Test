using Shop.Test.ShoppingActivities;

namespace Shop.Test.Interface
{
    public interface IRule
    {
        Reciept ApplyRule(Reciept reciept);
    }
}