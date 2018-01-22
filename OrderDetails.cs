using System;

namespace AdisNamespace
{
    class OrderDetails
    {
        int OrderID;
        String ProductName;
        int Qty;
        float Price;
        int OrderStatus;

        public void AcceptOrderDetails()
        {
            Console.Write("Enter the details of the order.\n 1:Order ID: \t");
            OrderID = Convert.ToInt32(Console.ReadLine());
            Console.Write("Product Name:\t");
            ProductName = Console.ReadLine();
            Console.Write("Quantity:\t");
            Qty = Convert.ToInt32(Console.ReadLine());
            Console.Write("Price:\t");
            Price = float.Parse(Console.ReadLine());
            Console.Write("Order Status:\t");
            OrderStatus = Convert.ToInt32(Console.ReadLine());
        }
        public void DisplayOrderDetails()
        {
            Console.WriteLine("The Details of the Customers are as follows:\n");
            Console.WriteLine("Order ID:\t" + OrderID + "\nProduct Name:\t" + ProductName + "\nQuantity:\t" + Qty + "\nPrice:\t" + Price + "\nOrder Status:\t" + OrderStatus);
        }
        public void UserAccept()
        {
            Console.WriteLine("Enter the Quantity of " + ProductName + " you want to buy");
            int quant = Convert.ToInt32(Console.ReadLine());
            if(quant <= Qty)
            {
                Console.WriteLine("The Product is available for sale.\n");
                Qty -= quant;
            }
            else
            {
                Console.WriteLine("The Product is out of stock. \n");
            }
        }
    }
}
