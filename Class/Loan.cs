using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp7.Class
{
    public class Loan 
    {

        public int UserId { get; set; }

        public int BookId { get; set; }

        public DateTime LoanDate { get; set; } = DateTime.Now;

        public DateTime  ?  ReturnDate { get; set; }

        public override string ToString()
        {
            return $"Кн - {BookId} -> Поль - {UserId} | Выдана - {LoanDate:dd.MM.yy}" +
                   (ReturnDate.HasValue ? $" | Возращена - {ReturnDate:dd.MM.yy}" : "АКТИВНА"); 
        }



    }
}
