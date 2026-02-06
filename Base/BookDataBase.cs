using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp7.Class;
using WinFormsApp7.JsonServise;

namespace WinFormsApp7.Base
{
    public static class BookDataBase
    {

        private static List<Book>  Books= new ();

        private static JsonSerServise JsonServis = new ();


        public static  List<Book> GetBooks()
        {
            return Books;
        }

        public static void Add (Book book) 
        {
            Books.Add (book);
        }

        public static void Remove(Book book) 
        {
            Books.Remove (book);
        }

        public static void Clear()
        {
            Books.Clear();
        }

        public static void Save() 
        {
            JsonServis.SaveToFile("books.json", Books);
        }


        public static void Load()
        {
            Books = JsonServis.LoadFormFile<List<Book>>("books.json");
        }
    }
}
