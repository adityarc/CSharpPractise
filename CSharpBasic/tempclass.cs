using System;
using System.Collections.Generic;
namespace AdisNamespace
{
    public class Employee<T>
    {
        T _val;
        public T _getval
        {
            get { return _val; }
            set { _val = value; }
        }
    }
    public class EXEC
    { 
        static void Main(string[] args)
        {
            Employee<int> o1 = new Employee<int>();
            o1._getval = 1;
            Console.WriteLine("\nvalue = " + o1._getval);
            Employee<string> o2 = new Employee<string>();
            o2._getval = "ABCD";
            Console.WriteLine("\nvalue = " + o2._getval);
        }
    }
}
