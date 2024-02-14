using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Lab_2024_02_14__Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LibraryBook book1 = new LibraryBook("The Great Gatsby", "F. Scott Fitzgerald", true);
            LibraryBook book2 = new LibraryBook("To Kill a Mockingbird", "Harper Lee", true);
            LibraryBook book3 = new LibraryBook("1984", "George Orwell", true);
            LibraryBook book4 = new LibraryBook("Pride and Prejudice", "Jane Austen", true);
            LibraryBook book5 = new LibraryBook("The Catcher in the Rye", "J.D. Salinger", true);
            LibraryBook book6 = new LibraryBook("The Lord of the Rings", "J.R.R. Tolkien", true);

            LibraryBook[] books = { book1, book2, book3, book4, book5, book6 };

            DisplayLibraryBooks(books);

            book1.BorrowBooks();

        }
        static void DisplayLibraryBooks(LibraryBook[] books)
        {
            for (int i = 0; i < books.Length; i++)
            {
                LibraryBook book = books[i];
                Console.WriteLine($"{book.title},{book.author},{book.availability}");
            }

            Console.ReadKey();
        }
    }

    

    public class LibraryBook
    {
        public string title;
        public string author;
        public bool availability;

        public LibraryBook(string title, string author, bool availability)
        {
            this.title = title;
            this.author = author;
            this.availability = availability;
        }
        public void BorrowBooks()
        {
            if (availability)
            {
                availability = false;
                Console.WriteLine($"Book{title} by {author} has been borrowed");
            }
            else
            {
                Console.WriteLine("Not available.");
            }
        }
    }

    
}
