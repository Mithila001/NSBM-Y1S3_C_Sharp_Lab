using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Lab_2024_02_07__Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Books myBook = new Books();

            myBook.title = "How to Sleep";
            myBook.authur = "Mr.Sleep";

            Console.WriteLine("Title:"+ myBook.title);
            Console.WriteLine("Author:"+ myBook.authur);
        }
    }

    public class Books
    {
        public string title;
        public string authur;
    }
}
