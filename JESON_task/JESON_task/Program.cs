using JESON_task.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace JESON_task
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Serialize
            //Product kitab = new Product { Id = 1, Name = "Cinayet ve ceza", Price = 11 };
            //Product defter = new Product { Id = 2, Name = "Ofisait", Price = 1 };
            //Product qelem = new Product { Id = 3, Name = "Oyal", Price = 0.70 };
            //OrderItem item1 = new OrderItem { Id = 1, Product = kitab, Count = 1};
            //item1.TotalPrice = kitab.Price * item1.Count;
            //OrderItem item2 = new OrderItem { Id = 2, Product = qelem, Count = 5};
            //item2.TotalPrice = qelem.Price * item2.Count;
            //OrderItem item3 = new OrderItem { Id = 3, Product = defter, Count = 7};
            //item3.TotalPrice = defter.Price * item3.Count;
            //OrderItem item4 = new OrderItem { Id = 4, Product = kitab, Count = 2};
            //item4.TotalPrice = kitab.Price * item4.Count;
            //List<OrderItem> orderItems1 = new List<OrderItem>();
            //orderItems1.Add(item1);
            //orderItems1.Add(item3);
            //List<OrderItem> orderItems2 = new List<OrderItem>();
            //orderItems2.Add(item2);
            //orderItems2.Add(item4);
            //Order order1 = new Order { Id = 1, OrderItems = orderItems1 };
            //Order order2 = new Order { Id = 2, OrderItems = orderItems2 };
            //var jsonObj = JsonConvert.SerializeObject(order1);
            //Console.WriteLine(jsonObj);
            //using (StreamWriter sw = new StreamWriter(@"C:\Users\AysuMemmedova\source\repos\JESON_task\JESON_task\Files\jsconfig1.json"))
            //{
            //    sw.WriteLine(jsonObj);
            //}
            #endregion
            #region Deserialize
            string result;
            using (StreamReader sr = new StreamReader(@"C:\Users\AysuMemmedova\source\repos\JESON_task\JESON_task\Files\json1.json"))
            {
                result = sr.ReadToEnd();
            }
            Order o1 = JsonConvert.DeserializeObject<Order>(result);
            foreach (var item in o1.OrderItems)
            {
                Console.WriteLine($"ID->{item.Product.Id} Name->{item.Product.Name} Count->{item.Count} ");
            }
            #endregion;
        }
    }
}
