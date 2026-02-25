using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using WinFormsApp7.Class;
using WinFormsApp7.JsonServise;

namespace WinFormsApp7.Base
{
    public static class BookDataBase
    {
        private static List<Book> Books = new();
        private static int nextBookId = 1;
        private static readonly JsonSerServise jsonService = new();

        public static ReadOnlyCollection<Book> GetBooks() => new ReadOnlyCollection<Book>(Books);

        public static void UpdateBookAt(int index, Book book)
        {
            if (book == null) throw new ArgumentNullException(nameof(book));
            if (index < 0 || index >= Books.Count)
                throw new ArgumentOutOfRangeException(nameof(index));
            Books[index] = book;
        }

        public static void Add(Book book)
        {
            if (book == null) throw new ArgumentNullException(nameof(book));
            book.Id = nextBookId++;
            Books.Add(book);
        }

        public static bool Remove(Book book) => book != null && Books.Remove(book);
        public static void Clear() { Books.Clear(); nextBookId = 1; }

        public static void Save() => jsonService.SaveToFile("books.json", Books);

        public static void Load()
        {
            var loaded = jsonService.LoadFormFile<List<Book>>("books.json");
            Books = loaded ?? new List<Book>();
            nextBookId = Books.Count > 0 ? Books.Max(b => b.Id) + 1 : 1;
        }
    }
}