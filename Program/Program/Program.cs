﻿using Program.Entities;
using System;
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
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            string txt = OrderStatus.Delivered.ToString(); //Convertendo tipo Enum para string
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered"); //Convertendo string para tipo Enum

            Console.WriteLine(os);
            Console.WriteLine(txt);


        }
    }
}
