using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication.Models;
using ConsoleApplication.Models.Dtos;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            List<OrderCargoStatusUpdater> cargoStatusUpdaters = GetAllOrderCargoStatusUpdaters();

            Parallel.ForEach(cargoStatusUpdaters, (cargoStatusUpdater) =>
            {
                List<Order> orders = cargoStatusUpdater.GetOrders();
                List<OrderStatusDto> newStatuses = cargoStatusUpdater.GetOrderStatus(orders);
                cargoStatusUpdater.UpdateOrderStatuses(newStatuses);
            });
        }

        private static List<OrderCargoStatusUpdater> GetAllOrderCargoStatusUpdaters()
        {
            return new List<OrderCargoStatusUpdater>();
        }
    }
}
