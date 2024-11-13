using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pointsofsalesapp1;
using pointsofsalesapp1.BL;

namespace pointsofsalesapp1
{
    class MyUserUI
    {
       public static MyUser GetInputfromConsoleWithoutRole()
        {

            string username = "";

            Console.WriteLine("Enter the username.... ");
            username = Console.ReadLine();
            Console.WriteLine("Enter password........ ");
            string pass;
            pass = Console.ReadLine();
            MyUser user = new MyUser(username, pass);
            return user;
        }
       public static MyUser GetInputfromConsolewithRole()
        {

            string username = "";

            Console.WriteLine("Enter the username.... ");
            username = Console.ReadLine();
            Console.WriteLine("Enter password........ ");
            string pass;
            pass = Console.ReadLine();
            string role;
            Console.WriteLine("Enter Role.....");
            role = Console.ReadLine();
            MyUser user = new MyUser(username, pass, role);
            return user;
        }
      public static int MainMenu()
        {
            int op;
            Console.WriteLine("1:Sign In");
            Console.WriteLine("2:Sign Up");
            Console.WriteLine("3:Exit");
            Console.Write("Enter Option: ");
            op = Convert.ToInt32(Console.ReadLine());
            return op;
        }
    }
}
