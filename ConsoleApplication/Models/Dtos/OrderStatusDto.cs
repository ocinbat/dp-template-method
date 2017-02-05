namespace ConsoleApplication.Models.Dtos
{
    public class OrderStatusDto
    {
        public long OrderId { get; set; }

        public string OldStatus { get; set; }

        public string NewStatus { get; set; }
    }
}