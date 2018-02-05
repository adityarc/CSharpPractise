using System;

namespace ADO
{
    public class Execute
    {
        public static void Message(string str)
        {
            Console.WriteLine("Welcome, " + str);
        }
        static void Main(string[] args)
        {
            Action<string> obj = Message;
            obj("ARC");

            Action<int, int> add = (x, y) =>
             {
                 Console.WriteLine(x + y);
             };

            add(10, 30);

            Func<int, int, int> add1 = (x, y) =>
            {
                return (x + y);
            };

            Console.WriteLine("Sum of 20 and 40 is " + add1(20, 40));
        }
    }
}
