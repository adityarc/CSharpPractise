using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginCred
{
    class ProductDetails
    {

        //static public void AddProductDetails(Product P)
        //{
        //    ProductList.Add(P);

        //}
        public void DisplayProductDetails(List<Product> ProductList)
        {
            foreach (Product p in ProductList)
            {
                p.DisplayProduct();
            }
        }
        public int SearchProduct(int id,List<Product> ProductList)
        {
            int flag = 0;
            foreach (Product p in ProductList)
            {

                if (p.ProductID == id)
                {
                    Console.WriteLine("Product Found\n");
                    p.DisplayProduct();
                    flag = 1;
                    break;
                }

            }
            return flag;
        }
    }
}
