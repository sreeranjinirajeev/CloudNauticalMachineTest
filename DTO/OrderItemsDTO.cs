using CloudNauticalMachineTest.Model;
using System.Numerics;

namespace CloudNauticalMachineTest.DTO
{
    public class OrderItemsDTO
    {

             public string? PRODUCTNAME      { get; set; }
             public int QUANTITY         { get; set; }
             public decimal PriceEach { get; set; }
    }
}
