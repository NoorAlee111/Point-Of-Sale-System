using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pointsofsalesapp1.BL;

namespace pointsofsalesapp1

{
    class MyUserDL
    {
        public static List<MyUser> userList = new List<MyUser>();
        public static void adduserintolist(MyUser user)
        {
            userList.Add(user);
        }
    }
}
