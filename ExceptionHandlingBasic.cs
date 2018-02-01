using System;
 namespace Adinamespace
{
    public class QuantityZeroException : ApplicationException
    {
        public QuantityZeroException() : base()
        { }
        public QuantityZeroException(string message) : base(message) { }
    }


    public class Class1
    {
        public static void GetDetails()
        {
            int Qty = int.Parse(Console.ReadLine());
            if(Qty <= 0)
            {
                throw new QuantityZeroException("Quantity cannot be zero or Less");
            }
        }
        static void Main(string[] args)
        {
            try
            {
                GetDetails();
            }
            catch(QuantityZeroException e1)
            {
                Console.WriteLine(e1.Message);
            }
            Console.ReadKey(false);
        }
    }

}
