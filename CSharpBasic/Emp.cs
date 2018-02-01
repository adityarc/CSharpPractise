//Demonstration of ArrayList concepts

using System;
using System.Collections;

namespace AdisNamespace
{
    public class Employees
    {
        public int EmpID { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }


        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add(new Employees { EmpID = 1, Name = "naam", Salary = 50000 });
            al.Add(new Employees { EmpID = 2, Name = "naam1", Salary = 30000 });
            al.Add("A");
            foreach (object obj in al)
            {
                if(obj is Employees)
                {
                    Employees e = (Employees)obj;
                    Console.WriteLine("\nID:\t" + e.EmpID + "\nName:\t" + e.Name + "\nSalary:\t" + e.Salary);

                }
                else
                {
                    Console.WriteLine("\n"+obj);
                }

            }

        }
    }
}
