using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication.Models;
using ConsoleApplication.Models.Dtos;

namespace ConsoleApplication
{
    class ArasCargoStatusUpdater : OrderCargoStatusUpdater
    {
        public override List<Order> GetOrders()
        {
            // Use Loki here.
            throw new NotImplementedException();
        }

        public override List<OrderStatusDto> GetOrderStatus(List<Order> orders)
        {
            throw new NotImplementedException();
        }
    }
}
