using CloudNauticalMachineTest.Model;
using CloudNauticalMachineTest.Repository;
using Microsoft.AspNetCore.Mvc;

namespace CloudNauticalMachineTest.Controllers
{
    [Route("Order/GetOrdersByCustomerID")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly OrderRepository _orderRepository;

        public OrderController(OrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        [HttpGet]
        public async Task<ActionResult> GetOrdersByCustomerID(int customerID)
        {
            var products =await  _orderRepository.GetOrdersByCustomerID(customerID);
            return Ok(products);
        }
    }
}

