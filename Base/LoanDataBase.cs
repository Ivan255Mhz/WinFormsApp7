using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using WinFormsApp7.Class;
using WinFormsApp7.JsonServise;

namespace WinFormsApp7.Base
{
    public static class LoanDataBase
    {
        private static List<Loan> loans = new();
        private static readonly JsonSerServise jsonService = new();

        public static ReadOnlyCollection<Loan> GetLoans() => new ReadOnlyCollection<Loan>(loans);

        public static void AddLoan(int userId, int bookId)
        {
            loans.Add(new Loan { UserId = userId, BookId = bookId });
        }

        public static bool IsBookLoaned(int bookId) =>
            loans.Any(l => l.BookId == bookId && l.ReturnDate == null);

        public static void ReturnBook(int bookId)
        {
            var activeLoan = loans.FirstOrDefault(l =>
                l.BookId == bookId && l.ReturnDate == null);
            if (activeLoan != null)
                activeLoan.ReturnDate = DateTime.Now;
        }

        public static void Save() => jsonService.SaveToFile("loans.json", loans);

        public static void Load()
        {
            var loaded = jsonService.LoadFormFile<List<Loan>>("loans.json");
            loans = loaded ?? new List<Loan>();
        }

        public static void Clear() => loans.Clear();
    }
}