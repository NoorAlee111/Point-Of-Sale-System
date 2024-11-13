using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pointsofsalesapp1.BL
{
    class MyUser
    {
        public string userName;
        public string userPassword;
        public string userRole;
        public static List<MyUser> userList = new List<MyUser>();
        public MyUser(string userName, string userPassword, string userRole)
        {
            this.userName = userName;
            this.userPassword = userPassword;
            this.userRole = userRole;
        }
        public MyUser(string userName, string userPassword)
        {
            this.userName = userName;
            this.userPassword = userPassword;
            this.userRole = "NA";
        }
        public static bool isAdmin(MyUser user1)
        {
            bool flag = false;
            foreach(MyUser user in userList)
            {
                if(user1.userName==user.userName&& user1.userPassword == user.userPassword)
                {
                    if (user.userRole == "ADMIN")
                    {
                        flag = true;
                        return flag;
                    }
                }
            }

            return flag; ;
        }
      
    }
}
