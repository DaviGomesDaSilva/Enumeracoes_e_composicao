using Program.Entities;
using Program.Entities.Enum;
using System;
using System.Collections.Generic;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Client client = new Client(name, email, birthDate);

            Console.WriteLine();

            Console.Write("\nEnter order data:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            //WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine()); -> exemplo de como converter string p/ Enum
            DateTime moment = DateTime.Now;
            Order order = new Order(moment, status, client);

            OrderItem orderItem = new OrderItem();

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());            
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter #{(i+1)} item data:");
                Console.Write("Product name: ");
                string pName = Console.ReadLine();
                Console.Write("product price");
                double pPrice = double.Parse(Console.ReadLine());
                Console.Write("Quantity: ");
                int pQuantity = int.Parse(Console.ReadLine());
                Product product = new Product(pName, pPrice);
                orderItem.AddProduct(product);
                order.AddItem(orderItem);
            }
            
            Console.WriteLine();
                       

        }
    }
}
