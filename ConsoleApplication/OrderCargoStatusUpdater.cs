using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication.Models;
using ConsoleApplication.Models.Dtos;

namespace ConsoleApplication
{
    public abstract class OrderCargoStatusUpdater
    {
        public abstract List<Order> GetOrders();

        public abstract List<OrderStatusDto> GetOrderStatus(List<Order> orders);

        public void UpdateOrderStatuses(List<OrderStatusDto> newStatuses)
        {
            // Update db hhere.....
        }
    }
}
