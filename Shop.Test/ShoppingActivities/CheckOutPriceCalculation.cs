using System.Collections.Generic;
using Shop.Test.Interface;

namespace Shop.Test.ShoppingActivities
{
    public class CheckOutPriceCalculation : ICalculatePrice
    {
        private readonly List<IRule> _rules;
        readonly CalculatePrice _calculatePrice = new CalculatePrice();

        public CheckOutPriceCalculation(List<IRule> rules)
        {
            _rules = rules;
        }
        
        public Reciept Calculate(List<ShoppingItem> shoppintItems)
        {
            var reciept = _calculatePrice.Calculate(shoppintItems);

            foreach (IRule rule in _rules)
            {
                reciept = rule.ApplyRule(reciept);
            }

            return reciept;
        }
    }
}