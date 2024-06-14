using CloudNauticalMachineTest.DTO;
using CloudNauticalMachineTest.Model;
using Microsoft.Data.SqlClient;
using System.Data;

namespace CloudNauticalMachineTest.Repository
{
    public class OrderRepository
    {
        private readonly string? _connectionString;
        public OrderRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public async Task<OrderDTO> GetOrdersByCustomerID( int CustomerId)
        {
            OrderDTO orderDTO = new OrderDTO();

            using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    using (SqlCommand command = new SqlCommand("GetOrdersByCustomerId", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Add  parameters
                         command.Parameters.AddWithValue("@CustomerId", CustomerId);

                        connection.Open();

                        // Execute  command
                        SqlDataReader reader =await command.ExecuteReaderAsync();
                    List<OrderItemsDTO > Orderitems = new List<OrderItemsDTO>();
                        // Retrieve the results
                        while (reader.Read())
                        {
                        orderDTO.FIRSTNAME = reader.GetString(0);
                        orderDTO.LASTNAME = reader.GetString(1);
                        orderDTO.ORDERDATE = reader.GetDateTime(3);
                        orderDTO.ORDERID = reader.GetInt32(2);
                        orderDTO.DeliveryAddress = reader.GetString(4);
                        orderDTO.DELIVERYEXPECTED = reader.GetDateTime(8);
                        OrderItemsDTO orderItemsDTO = new OrderItemsDTO();
                        orderItemsDTO.PRODUCTNAME = reader.GetString(5);
                        orderItemsDTO.QUANTITY = reader.GetInt32(6);
                        orderItemsDTO.PriceEach = reader.GetDecimal(7);
                        Orderitems.Add(orderItemsDTO);
                        orderDTO.Items = Orderitems;
                    }

                    // Close the reader and connection
                    reader.Close();
                        connection.Close();
                    }
                }
            
            return orderDTO;
        }

        
    }
}
       

