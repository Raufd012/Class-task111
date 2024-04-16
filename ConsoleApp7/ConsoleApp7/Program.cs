using ConsoleApp7.Models;
using Microsoft.Extensions.DependencyModel;
using Library = ConsoleApp7.Models.Library;

namespace ConsoleApp7
{
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    Student Kamil = new Student("kamil", "khafarov", "7zd77aa");

        //    Student Rauf = new Student("rauf", "dostuyev", "739vz7d");

        //    Group group = new Group();
        //    group.AddStudent(Kamil);
        //    group.AddStudent(Rauf);

        //    Student student = group["739vz7d"];
        //    Console.WriteLine(student);
        //}

        static void Main(string[] args)
        {
            Book book = new Book("Sefirler", "Victor");

            Book book1 = new Book("Sefirler1", "Victor2");

            Library library1 = new Library();
            library1.AddBook(book);
            library1.AddBook(book1);
            Book book3 = library1[1];
            
            if (book3 == null)
            {
                Console.WriteLine("NotFound");
            }
            else
            {
                Console.WriteLine(book3.Author+" "+ book3.Name);
            }
        }





    }
}
