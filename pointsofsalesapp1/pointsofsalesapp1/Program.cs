using pointsofsalesapp1.BL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pointsofsalesapp1;


namespace pointsofsalesapp1
{
    class Program
    {
        public static int userCount = 0;
        static void Main(string[] args)
        {

            int option2 = 0;
            int op2 = 0;
            while (true)
            {
                //  readUserData(usersPath, MyUser.userList);
                Console.Clear();
                option2 = MyUserUI.MainMenu();
                if (option2 == 1)
                {

                    MyUser user = MyUserUI.GetInputfromConsoleWithoutRole();
                    if (user != null)
                    {
                        bool flag = MyUser.isAdmin(user);
                        if (flag == true)
                        {
                            Product p1 = new Product();
                            //int op = 0;
                            while (true)
                            {
                                string op = "0";

                                // op = menu();
                                op = ProductUI.menu();
                                if (op == "1")
                                {

                                    p1 = ProductUI.GetInputFromConsole();
                                    ProductDL.AddProductsintoList(p1);
                                }
                                else if (op.Equals("2"))
                                {

                                    CustomerUI.view(Product.productlist);
                                }
                                else if (op == "3")
                                {
                                    Product p = new Product();
                                    p = ProductDL.highest_priceProduct();
                                    ProductUI. ProductwithHighestPrice(p);
                                   
                                }
                                else if (op == "4")
                                {
                                    ProductUI. TaxforAllProducts();

                                }
                                else if (op == "5")
                                {

                                    ProductUI.productsToBeOrdered(Product.productlist);

                                }
                                else if (op == "6")
                                {
                                    break;
                                }
                                else
                                {
                                    Console.Write("You entered wrong option...");
                                }

                                CustomerUI.clearScreen();
                            }

                        }
                        else
                        {
                            Customer c = new Customer();
                            while (true)
                            {

                                op2 = CustomerUI.UserMenu();

                                if (op2 == 1)
                                {
                                    CustomerUI.view(Product.productlist);
                                }
                                else if (op2 == 2)
                                {
                                    CustomerUI.buytheproducts(c);
                                }
                                else if (op2 == 3)
                                {
                                    CustomerUI.GenerateInvoice(c);
                                }
                                else if (op2 == 4)
                                {
                                    break;
                                }
                                else
                                {
                                    Console.Write("You entered wrong option...");
                                }
                                CustomerUI.clearScreen();
                            }

                        }
                    }


                }
                else if (option2 == 2)
                {
                    MyUser user1 = MyUserUI.GetInputfromConsolewithRole();
                    MyUserDL.adduserintolist(user1);

                }

                else if (option2 == 3)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("You entered wrong option");
                }
                CustomerUI.clearScreen();
            }
        }








        
    }
}

