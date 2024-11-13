using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pointsofsalesapp1;
using pointsofsalesapp1.BL;

namespace pointsofsalesapp1
{
    class ProductUI
    {
      public  static string menu()
        {
            Console.WriteLine("________________________________");
            Console.WriteLine("________Sales Application_______");
            Console.WriteLine("________________________________");

            Console.WriteLine("_________ADMIN MENU_________");
            Console.WriteLine("1:Add products");
            Console.WriteLine("2:View All Product.");
            Console.WriteLine("3:Find Product with the Highest Unit Price");
            Console.WriteLine("4:View Sales Tax of All Products. ");
            Console.WriteLine("5:Products to be Ordered.");
            Console.WriteLine("6:Exit");
            Console.Write("Enter your option:");
            string op;
            op = Console.ReadLine();
            return op;
        }

       public static Product GetInputFromConsole()
        {
            Product p1 = new Product();
            Console.WriteLine("Enter the name of product:");
            p1.Productname = Console.ReadLine();
            Console.WriteLine("Enter category of product:");
            p1.Productcategory = Console.ReadLine();
            Console.WriteLine("Enter price of the product:");
            p1.Productprice = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Stock_Quantity:");
            p1.Stock_Quantity = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Mini_Stock_Quantity:");
            p1.Mini_Stock_Quantity = int.Parse(Console.ReadLine());
            return p1;
        }
      public static void productsToBeOrdered(List<Product> productlist)
        {
            for (int i = 0; i < productlist.Count; i++)
            {
                if (productlist[i].Stock_Quantity < productlist[i].Mini_Stock_Quantity)
                {

                    Console.WriteLine(productlist[i].Productname + "'s quantity is less than minimum stock quantity");
                }
                else
                {
                    Console.WriteLine(productlist[i].Productname + "'s is enough");
                }
            }
        }


        public static void ProductwithHighestPrice(Product p)
        {
            Console.WriteLine("Product with the highest unit price is " + p.Productname);
        }
        public static void TaxforAllProducts()
        {
            foreach (Product p in Product.productlist)
            {
                float tax = p.tax();
                Console.WriteLine("Tax for the " + p.Productname + " is " + tax);
            }
        }
    }
}
