namespace CloudNauticalMachineTest.Model
{
    public class Orders
    {
        public int ORDERID { get; set; }
        public string? CUSTOMERID { get; set; }
        public DateTime ORDERDATE { get; set; }
        public DateTime DELIVERYEXPECTED { get; set; }
        public bool CONTAINSGIFT { get; set; }
    }
}
