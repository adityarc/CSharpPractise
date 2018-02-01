using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdisNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderDetails OrderObj = new OrderDetails();
            OrderObj.AcceptOrderDetails();
            OrderObj.DisplayOrderDetails();
            do
            {
                Console.WriteLine("Do you want to buy the product?");
                char choice = Convert.ToChar(Console.ReadLine());
                if (choice == 'y')
                {
                    OrderObj.UserAccept();
                }
                else
                {
                    break;
                }
            } while (true);
        }
    }
}
