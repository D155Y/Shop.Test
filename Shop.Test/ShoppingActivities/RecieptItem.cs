namespace Shop.Test.ShoppingActivities
{
    public class RecieptItem
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }

        public double TotalItemPrice
        {
            get { return Quantity * UnitPrice; }
        }
    }
}