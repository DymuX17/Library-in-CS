using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka_PD2
{
    public class Library
    {
        private List<Book> books = new List<Book>();
 
        public bool AddBook(Book book)
        {
            if (books.Any(b => b.Title == book.Title))
            {
                Console.WriteLine("Book already exists in the library... ");
                return false;
            }
            else
            {
                books.Add(book);
                return true;
            }
        }

        public void GetBookInfo(ref string title, ref string author, ref int releaseYear)
        {
            Console.WriteLine("Input new book's title: ");
            title = Console.ReadLine();
            Console.WriteLine("Input new book's author: ");
            author = Console.ReadLine();
            Console.WriteLine("Input new book's release year: ");
            releaseYear = int.Parse(Console.ReadLine());
            
        }

        public void DeleteBookByTitle(string title)
        {
            // books.RemoveAll(k => k.Title == title);
            books.RemoveAll(k => string.Equals(k.Title, title, StringComparison.CurrentCultureIgnoreCase));
        }

        public List<Book> SearchBookByTitle(string title)
        {
            var foundBooks = books.Where(k => k.Title.ToLower().Contains(title.ToLower())).ToList();
            if (foundBooks.Count == 0)
            {
                Console.WriteLine("\nThere are no books with provided title... ");
                return null;
            }
            else
                return foundBooks;
        }

        public List<Book> SearchBookByAuthor(string author)
        {
            // return books.Where(k => k.Author.Contains(author)).ToList();
            var foundAuthorsBooks = books.Where(k => k.Author.ToLower().Contains(author.ToLower())).ToList();
            if (foundAuthorsBooks.Count == 0)
            {
                Console.WriteLine("\nThere are no books with provided author... ");
                return null;
            }
            else
                return foundAuthorsBooks;
        }

        public List<Book> ListBooksByTitle()
        {
            return books.OrderBy(k => k.Title).ToList(); 
            // ksiazki.Sort((k1, k2) => k1.Title.CompareTo(k2.Tytul));
            // return books;
        }

        public List<Book> ListAll()
        {
            return books;
        }

    }

}