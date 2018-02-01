// Custom List for Customers

using System;
using System.Collections.Generic;
using System.Collections;

namespace AdisNamespace
{
    class CustomerCollect<T> : CollectionBase
    {
        public void Add(T obj)
        {
            List.Add(obj);
        }
        public void Remove(T obj)
        {
            List.Remove(obj);
        }
        public void Insert(int idx, T obj)
        {
            List.Insert(idx, obj);
        }
        
       
    }
    class Customer
    {   
            public int flag = 3;
            public int CustID { get; set; }
            public string CustName { get; set; }
            public string CustCity { get; set; }
            public string Pincode;
            public string _Pincode {
                get { return Pincode; }
                set {
                    if(value.Length != 6)
                {
                    Console.Write("Wrong Input.\n");
                }
                    else
                {
                    if(value.StartsWith("6"))
                    {
                    Pincode = value;
                    flag = 0;
                    }
                    else if (value.StartsWith("5"))
                    {
                    Pincode = value;
                    flag = 1;
                    }
                    else if (value.StartsWith("7"))
                    {
                    Pincode = value;
                    flag = 2;
                    }
                else
                {
                    Pincode = value;
                    flag = 3;
                }
            }
                    } }
        public int getDetails()
        {
            Console.Write("Enter the Customer ID:\t");
            CustID = int.Parse(Console.ReadLine());
            Console.Write("Enter the Customer Name:\t");
            CustName = Console.ReadLine();
            Console.Write("Enter the Pincode:\t");
            _Pincode = Console.ReadLine();
            Console.Write("Enter the City:\t");
            CustCity = Console.ReadLine();
            return flag;
        }
        public void putDetails()
        {
            Console.Write("Enter the Customer ID:\t{0}\n", CustID);
            
            Console.Write("Enter the Customer Name:\t{0}\n", CustName);
            
            Console.Write("Enter the Pincode:\t{0}\n", _Pincode);
            
            Console.Write("Enter the City:\t{0}\n", CustCity);
             
            
        }
    }
    class Execute
    {
        static void Main(string[] args)
        {
            int chc = 0;
            CustomerCollect<Customer> CustomerGen = new CustomerCollect<Customer>();
            //CustomerCollect<Customer> CustomerChe = new CustomerCollect<Customer>();
            //CustomerCollect<Customer> CustomerBan = new CustomerCollect<Customer>();
            //CustomerCollect<Customer> CustomerKol = new CustomerCollect<Customer>();
            CustomerCollect<Customer> CustomerChe2 = new CustomerCollect<Customer>();
            CustomerCollect<Customer> CustomerBan2 = new CustomerCollect<Customer>();
            CustomerCollect<Customer> CustomerKol2 = new CustomerCollect<Customer>();
            do
            {
                int f = 0;
                Customer C1 = new Customer();
                Console.WriteLine("Enter your choice:\t1. Insert \t2. Display\t3. Remove\t4. Segregate\t5. Exit");
                chc = int.Parse(Console.ReadLine());
                switch(chc)
                {
                    case 1:
                        int l = C1.getDetails();
                        if (l == 0)
                        {
                           // CustomerChe.Add(C1);
                            CustomerGen.Add(C1);
                        }
                        else if (l == 1)
                        {
                            //CustomerBan.Add(C1);
                            CustomerGen.Add(C1);
                        }
                        else if (l == 2)
                        {
                            //CustomerKol.Add(C1);
                            CustomerGen.Add(C1);
                        }
                        else
                            CustomerGen.Add(C1);

                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("The Customer Records are as follows.");
                        if(CustomerChe2.Count >= 0)
                        {
                            Console.WriteLine("The Customer Records for Chennai.\n");
                            foreach (Customer c in CustomerChe2)
                            {
                                
                                c.putDetails();
                                Console.WriteLine("");
                            }
                        }
                        else
                        {
                            Console.Write("No Records to Display for Chennai. \n\n");
                        }
                        if (CustomerBan2.Count >= 0)
                        {
                            Console.WriteLine("The Customer Records for Bangalore.\n");
                            foreach (Customer c in CustomerBan2)
                            {
                                
                                c.putDetails();
                                Console.WriteLine("");
                            }
                        }
                        else
                        {
                            Console.Write("No Records to Display for Bangalore. \n\n");
                        }
                        if (CustomerKol2.Count >= 0)
                        {
                            Console.WriteLine("The Customer Records for Kolkata.\n");
                            foreach (Customer c in CustomerKol2)
                            {
                                
                                c.putDetails();
                                Console.WriteLine("");
                            }
                        }
                        else
                        {
                            Console.Write("No Records to Display for Kolkata. \n\n");
                        }
                        if (CustomerGen.Count >= 0)
                        {
                            Console.WriteLine("\n\nRecords for all the Customers. \n\n");
                            foreach (Customer c in CustomerGen)
                            {
                                c.putDetails();
                                Console.WriteLine("");
                            }
                        }
                        else
                        {
                            Console.Write("No Records to Display. \n\n");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Enter the Customer ID of the Customer you want to remove.");
                        int cid = int.Parse(Console.ReadLine());
                        int fl = 0;
                        foreach (Customer c in CustomerGen)
                        {
                            if (c.CustID == cid)
                            {
                                CustomerGen.Remove(c);
                                fl = 1;
                            }
                        }
                        if (fl == 0)
                            Console.WriteLine("Record Not Found!");
                        break;
                    case 4:
                        foreach(Customer c in CustomerGen)
                        {
                            if(c._Pincode.StartsWith("6"))
                            {
                                CustomerChe2.Add(c);
                            }
                            else if (c._Pincode.StartsWith("5"))
                            {
                                CustomerBan2.Add(c);
                            }
                            else if (c._Pincode.StartsWith("7"))
                            {
                                CustomerKol2.Add(c);
                            }

                        }
                        break;
                    case 5:
                        f = 1;
                        break;
                    default:
                        Console.WriteLine("Wrong choice. Enter Again!");
                        Console.ReadKey(false);
                        break;
                }
                Console.ReadKey(false);
                Console.Clear();
                if (f == 1)
                    break;
            } while (true);
            
           
        }
    }

}
