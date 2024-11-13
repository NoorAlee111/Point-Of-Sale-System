using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pointsofsalesapp1;
using pointsofsalesapp1.BL;

namespace pointsofsalesapp1
{
    class CustomerUI
    {
        public static void buytheproducts(Customer c)
        {
            bool flag = false;


            string productname = "";
            int productquantity = 0;
            Console.WriteLine("*************Buy Products************");
            Console.WriteLine("Available Products");
            displayproducts();
            Console.WriteLine("Enter the product you want to buy...");
            productname = Console.ReadLine();
            Console.WriteLine("Enter the product quantity you want to buy...");
            productquantity = int.Parse(Console.ReadLine());
            foreach (Product p in Product.productlist)
            {
                if (p.Productname == productname)
                {
                    flag = true;
                    Console.WriteLine("{0} is available", productname);
                    if (p.Stock_Quantity >= productquantity)
                    {

                        Console.WriteLine("Quantity also avaiable....");
                        c.ProductsBoughtbyCustomer.Add(p);
                        p.Stock_Quantity = p.Stock_Quantity - productquantity;

                    }
                    else
                    {
                        Console.WriteLine("Required quantity is not available");
                    }
                }
            }

            if (flag == false)
            {
                Console.WriteLine("Product is not available");
            }
        }
        public static void displayproducts()
        {
            foreach (Product p in Product.productlist)
            {
                Console.WriteLine(p.Productname);
            }
        }
        public static void clearScreen()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
        public static int UserMenu()
        {
            Console.WriteLine("_________USER MENU_________");

            Console.WriteLine("1: View All Product.");
            Console.WriteLine("2:Buy the Products");
            Console.WriteLine("3:Generate Invoice ");
            Console.WriteLine("4:Exit");
            Console.Write("Enter your option:");
            int op;
            op = int.Parse(Console.ReadLine());
            return op;
        }
        public static void view(List<Product> p)
        {
            foreach (Product p1 in p)
            {
                Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}\t\t{4}", p1.Productname, p1.Productcategory, p1.Productprice, p1.Stock_Quantity, p1.Mini_Stock_Quantity);
            }
        }
        public static void GenerateInvoice(Customer C)
        {
            foreach (Product p in C.ProductsBoughtbyCustomer)
            {
                float tax = p.tax();
                p.Productprice = (p.Productprice + tax);
                Console.WriteLine("{0}\t\t{1}\t\t{2}", p.Productname, p.Productcategory, p.Productprice);
            }
        }
    }
}
