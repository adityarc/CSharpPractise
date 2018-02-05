using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginCred
{
    class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

        internal void GetProductDetails()
        {
            Console.Clear();
            Console.Write("\n\tEnter the Product Details:\n");
            
            Console.Write("Product ID:\t");
            ProductID =int.Parse(Console.ReadLine());
            Console.Write("Product Name:\t");
            ProductName = Console.ReadLine();
            Console.Write("Quantity:\t");
            Quantity = int.Parse(Console.ReadLine());
            Console.Write("Price:\t");
            Price = double.Parse(Console.ReadLine());

            //ProductDetails PD = new ProductDetails();
            //PD.AddProductDetails(this);
        }
        internal void DisplayProduct()
        {
            Console.WriteLine("\n\tProduct ID:\t"+ProductID);
            Console.WriteLine("\n\tProduct Name:\t"+ProductName);
            Console.WriteLine("\n\tProduct Quantity:\t" + Quantity);
            Console.WriteLine("\n\tProduct Price:\t" + Price +"\n\n");
        }
    }
}
