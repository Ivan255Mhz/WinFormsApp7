using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp7.Interfase;
using WinFormsApp7.JsonServise;

namespace WinFormsApp7.Base
{
    static public class UserDataBase
    {
        public static List<User> Users = new();

        public static int nextUserId = 1;

        private static JsonSerServise JsonServise = new();



        public static ReadOnlyCollection<User> GetUsers() => new ReadOnlyCollection<User>(Users);

        public static int GetNextAvailable() => nextUserId;

        public static void Add(User user)
        {
            if (user is null) throw new ArgumentNullException(nameof(user));
            user.id = nextUserId++;
            Users.Add(user);
        }

        public static void Remove(User user) => Users.Remove(user);

        public static void Clear() => Users.Clear();

        public static User ? GetUserById(int id) => Users.FirstOrDefault(u  => u.id == id);

        public static List<User> GetCliens(bool rols) => Users.Where(u => rols).ToList();


        public static void Save() => JsonServise.SaveToFile("users.json", Users);

        public static void Load() 
        {
            var loaded = JsonServise.LoadFormFile<List<User>>("users.json");

            Users = loaded ?? new List<User>();
            nextUserId = Users.Count > 0 ? Users.Max( u => u.id) + 1 : 1;
        }



    }
}

    