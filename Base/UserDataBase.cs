using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp7.Interfase;
using WinFormsApp7.JsonServise;

namespace WinFormsApp7.Base
{
    static public class UserDataBase 
    {
        public static List<User> Users = new List<User>();

        public static int IdUsers = 1;

        private static JsonSerServise JsonServise = new JsonSerServise();


        public static List<User> GetUsers()

        {
           
            return Users;
        }

        public static int GetId()
        {
            return IdUsers;
        }

        public static void Add(User user)
        {
            Users.Add(user);

            ++IdUsers;

        }


        public static void Remove(User user)
        {
            Users.Remove(user);
        }

        public static void Clear()
        {
            Users.Clear();
        }

        public static User UserGetId (int id)
        {
            return Users[id];
        }

        public static void Save()
        {

            JsonServise.SaveToFile("json.json", Users);

            

        }

        public static void Load()
        {

            Users = JsonServise.LoadFormFile<List<User>>("json.json");

        }

    }
}

    