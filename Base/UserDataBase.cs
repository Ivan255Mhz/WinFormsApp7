using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp7.Base
{
    static public class UserDataBase
    {
       public static List<User> Users = new List<User>();


        public static void Add(User user)
        {
            Users.Add(user);
        }
    }
}
