using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7.Models
{
    public class Book
    {
        static int Count = 0;
        public int Id { get; set; }

        public string Name { get; set; }
        public string Author { get; set; }

       
        public Book(string name, string author)
        {
            Name = name;
            Author = author;
            Count++;
            Id = Count;
        }

    }
}
