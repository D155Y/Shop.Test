using System.Collections.Generic;
using System.Linq;

namespace Shop.Test.ShoppingActivities
{
    public class Reciept
    {
        public List<RecieptItem> RecieptItems { get; private set; }

        public  Reciept(List<RecieptItem> recieptItems)
        {
            RecieptItems = recieptItems;
        }

        public double Total
        {
            get { return RecieptItems.Sum(i => i.TotalItemPrice); }
        }
    }
}