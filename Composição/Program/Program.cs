using System;
using Program.Entities;
using Program.Entities.Enums;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayments
            };

            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayments.ToString(); // Convertendo Enum p/ string

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered"); // Convertendo string para Enum

            Console.WriteLine(txt);
            Console.WriteLine(os);


        }
    }
}
