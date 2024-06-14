using CloudNauticalMachineTest.Model;

namespace CloudNauticalMachineTest.DTO
{
    public class OrderDTO
    {
        public string? FIRSTNAME { get; set; }
        public string? LASTNAME { get; set; }
        public int ORDERID              { get; set; }
         public DateTime  ORDERDATE         { get; set; }
         public string? DeliveryAddress { get; set; }
        public List<OrderItemsDTO>? Items { get; set; }
        public DateTime DELIVERYEXPECTED { get; set; }

    }
}
