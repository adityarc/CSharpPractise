using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdisNamespace
{
    public class Product
    {
        public string PID { get; set; }
        public string Name { get; set; }
        public int price { get; set; }
    }
    public class PDetails
    {
        List<Product> list1 = new List<Product>();

        public void addP()
        {
            list1.Add(new Product { PID = "1", Name = "Watch", price = 3500 });
            list1.Add(new Product { PID = "2", Name = "Ball", price = 350 });
            list1.Add(new Product { PID = "3", Name = "Wat", price = 500 });
            list1.Add(new Product { PID = "4", Name = "Wtch", price = 300 });
            list1.Add(new Product { PID = "5", Name = "Wath", price = 4500 });
        }
        public Product searchp(int price)
        {
            foreach (Product l in list1)
            {
                if(l.price == price)
                {
                    Console.WriteLine(price + "\t found");
                    return l;

                }
                
            }
            return null;
        }
        public Product searchp(string n)
        {
            foreach (Product l in list1)
            {
                if (l.Name == n)
                {
                    Console.WriteLine(n + "\t found");
                    return l;

                }

            }
            return null;
        }
        public Product this [int p]
        {
            get
            {

                foreach (Product l in list1)
                {
                    if (l.price == p)
                    {
                        Console.WriteLine(p + "\t found");
                        return l;

                    }

                }
                return null;
            }
        }
        public Product this[string name]
        {
            get
            {
                foreach (Product l in list1)
                {
                    if (l.Name == name)
                    {
                        Console.WriteLine(name + "\t found");
                        return l;

                    }

                }
                return null;
            }
        }

    }
    class Execute
    {
        static void Main(string[] args)
        {

            PDetails P1 = new PDetails();
            Product prd = new Product();
            P1.addP();
            prd = P1.searchp(350);
            prd = P1.searchp("Watch");
            prd = P1[350];
            prd = P1["Watch"];
            Console.ReadKey(false);

        }
        
        
    }
}
