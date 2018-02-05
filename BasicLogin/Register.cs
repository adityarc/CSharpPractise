using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginCred
{
    class Register
    {
        List<Product> ProductList = new List<Product>();
        public void register()
        {
            
            int flag = 0, chc = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("\tSelect option:\n\t 1. Employee Log In \n\t 2. Customer Log In \n\t 3. Exit");
                User Person = new User();
                chc = int.Parse(Console.ReadLine());
                switch (chc)
                {
                    case 1:
                        Person.GetDetails(1);
                        Console.ReadKey(false);
                        EmployeeActions();
                        break;
                    case 2:
                        Person.GetDetails(2);
                        Console.ReadKey(false);
                        CustomerActions();
                        break;
                    case 3:
                        flag = 1;
                        break;
                    default:
                        Console.WriteLine("Wrong option selected! Enter Again!");
                        Console.ReadKey();
                        break;
                }
                if (flag == 1)
                    break;

            } while (true);
        }
        public void EmployeeActions()
        {
            int flag = 0,chc = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("\tSelect Option:\n\t 1. Enter Product\n\t 2. View Log\n\t 3. Exit\n");
                chc = int.Parse(Console.ReadLine());
                switch (chc)
                {
                    case 1:
                        Product Pro = new Product();
                        Pro.GetProductDetails();
                        ProductList.Add(Pro);
                        break;
                    case 2:
                        LogFile ReadFile = new LogFile();
                        ReadFile.ReadFromFile();
                        Console.ReadKey(false);
                        break;
                    case 3:
                        flag = 1;
                        break;
                        
                    default:
                        Console.WriteLine("Wrong option selected! Enter Again!");
                        Console.ReadKey();
                        break;
                }
                if (flag == 1)
                    break;
            } while (true);
        }
        public void CustomerActions()
        {

            int flag = 0, chc = 0;
            do
            {
                Product Pro = new Product();
                ProductDetails PDet = new ProductDetails();
                Console.Clear();
                Console.WriteLine("\tSelect Option:\n\t 1. View Products\n\t 2. Search Product\n\t 3. Exit\n");
                chc = int.Parse(Console.ReadLine());
                switch (chc)
                {
                    case 1:

                        PDet.DisplayProductDetails(ProductList);
                        Console.ReadKey(false);
                        break;
                    case 2:
                        Console.Clear();
                        Console.Write("Enter the Product ID:\t");
                        int ID = int.Parse(Console.ReadLine());
                        PDet.SearchProduct(ID,ProductList);
                        Console.ReadKey(false);
                        break;
                    case 3:
                        flag = 1;
                        break;

                    default:
                        Console.WriteLine("Wrong option selected! Enter Again!");
                        Console.ReadKey();
                        break;
                }
                if (flag == 1)
                    break;
            } while (true);

        }
    }
}
