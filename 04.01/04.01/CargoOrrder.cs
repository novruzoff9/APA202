using _04._01.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._01
{
    internal class CargoOrrder
    {
        private static int _id;
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int CourierId { get; set; }
        public decimal Price { get; set; }

        public DateTime CreatedAt { get; set; }

        public OrderStatus Status { get; set; }
        public CargoOrrder()
        {
            _id++;
            Id = _id;
            CreatedAt = DateTime.Now;
            Status = OrderStatus.Created;
        }
        public void UpdateStatus(OrderStatus newStatus)
        {
            if (Status==OrderStatus.Delivered || Status==OrderStatus.Cancalled)
            {
                Console.WriteLine("Statusu deyismek olmasin");

            }
            Status = newStatus;
        }





    }
}
