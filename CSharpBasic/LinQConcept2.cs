using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO
{
    class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
    }
    class Order
    {
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public DateTime OrderDate { get; set; }
    }
    public class Execute
    {
        public static void Main(string[] args)
        {
            List<Product> L1 = new List<Product>();
            List<Order> L2 = new List<Order>();

            L1.Add(new Product { ProductID = 1, ProductName = "BAT", Price = 4650, Quantity = 10 });
            L1.Add(new Product { ProductID = 2, ProductName = "BALL", Price = 6050, Quantity = 20 });
            L1.Add(new Product { ProductID = 3, ProductName = "PADS", Price = 6500, Quantity = 30 });
            L1.Add(new Product { ProductID = 4, ProductName = "WICKETS", Price = 21350, Quantity = 15 });
            L1.Add(new Product { ProductID = 5, ProductName = "HAT", Price = 1250, Quantity = 45 });

            L2.Add(new Order { OrderID = 1, ProductID = 3, OrderDate = new DateTime(2018, 2, 2) });
            L2.Add(new Order { OrderID = 2, ProductID = 4, OrderDate = new DateTime(2018, 5, 2) });
            L2.Add(new Order { OrderID = 3, ProductID = 2, OrderDate = new DateTime(2018, 1, 2) });
            L2.Add(new Order { OrderID = 4, ProductID = 1, OrderDate = new DateTime(2018, 3, 2) });
            L2.Add(new Order { OrderID = 5, ProductID = 1, OrderDate = new DateTime(2018, 1, 2) });


            var Q = from pro in L1
                    join ord in L2 on pro.ProductID equals ord.ProductID
                    where pro.Price > 5000
                    select new
                    {
                        ProductName = pro.ProductName,
                        ProductID = pro.ProductID,
                        ProductPrice = pro.Price,
                        OrderID = ord.OrderID,
                        Date = ord.OrderDate
                    };

            Console.WriteLine("Product ID\tProduct Name\tProduct Price\tOrder ID\tOrder Date");
            foreach (var k in Q)
            {
                Console.WriteLine(k.ProductID + "\t\t" + k.ProductName + "\t\t" + k.ProductPrice + "\t\t" + k.OrderID + "\t\t" + k.Date);
            }

            Console.ReadKey();
            Console.Clear();
            //Demonstrating Group By 

            var Q2 = from obj in L2
                     group obj.OrderID by obj.ProductID into grp
                     select new
                     {
                         ProdID = grp.Key,
                         OrderID = grp

                     };
            foreach(var k1 in Q2)
            {
                Console.WriteLine("Product ID:\t" + k1.ProdID + "\n\n\t");
                foreach (var k2 in k1.OrderID)
                {
                    Console.WriteLine("\tOrder ID:\t" + k2);
                }
            }

        }
    }
}
