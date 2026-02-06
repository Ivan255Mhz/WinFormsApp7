using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp7.Class
{
    public class Book
    {
        public Book(string name, string text)
        {
            Name = name;
            Text = text;
        }

        public string Name { get; set; }

        public string Text { get; set; }


        public override string ToString()
        {
            return Name; 
        }
    }
}
