using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka_PD2
{
    class Program
    {
        static void ListTheItems(List<string> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        static void InitialLengthCheck(List<Book> BookList, ref int TitleLength, ref int AuthorLength)
        {
            int TitleLengthMax = 30;
            int AuthorLengthMax = 30;
            foreach(var item in BookList)
            {
                if (item.Title.Length > 27)
                {    
                    TitleLength = item.Title.Length + 3;
                    if (TitleLength > TitleLengthMax)
                    {
                        TitleLengthMax = TitleLength;
                    }
                }

                if (item.Author.Length > 27)
                {
                    AuthorLength = item.Author.Length + 3;
                    if (AuthorLength > AuthorLengthMax)
                    {
                        AuthorLengthMax = AuthorLength;
                    }
                    
                }
            }
            TitleLength = TitleLengthMax;
            AuthorLength = AuthorLengthMax;
        }


        static void ListTheBooks(List<Book> BookList, string specyficBookTitle = null)
        {
            int TitleLen = 30;
            int AuthorLen = 30;
            InitialLengthCheck(BookList, ref TitleLen, ref AuthorLen);

            if (!string.IsNullOrEmpty(specyficBookTitle))
            {
                var item = BookList.Find(b => b.Title.Equals(specyficBookTitle, StringComparison.OrdinalIgnoreCase));
                if (item != null)
                {
                    Console.WriteLine("Item containing provided title was found... ");
                    Console.WriteLine(item.Title + "," + new string(' ', TitleLen - item.Title.Length) + item.Author +
                                  "," + new string(' ', AuthorLen - item.Author.Length) + item.ReleaseYear);
                }
                else
                {
                    Console.WriteLine("Book with provided title does not exist... ");
                }
            }
            
            else
            {                
                foreach (var item in BookList)
                {
                    Console.WriteLine(item.Title + "," + new string(' ', TitleLen - item.Title.Length) + item.Author + 
                                      "," + new string(' ', AuthorLen - item.Author.Length) + item.ReleaseYear);
                }
            }

        }



        static void Main(string[] args)
        {

            Library library = new Library();

            LibraryInitializer.AddBooks(library);

            List<string> menu = new List<string> {"Choose option from the list: "};
            menu.Add("[1] - Add new book to library... ");
            menu.Add("[2] - Delete the book by inerting its title... ");
            menu.Add("[3] - Search the book by inserting its title... ");
            menu.Add("[4] - Search the book by inserting its author... ");
            menu.Add("[5] - Write down all of the books ordered by their title... ");
            menu.Add("[6] - Write down all of the books... ");
            menu.Add("\nYour choose: ");
            while (true)
            { 
                ListTheItems(menu);
                var ConsoleChoice = Console.ReadLine();
                int Choice = 0;

                try
                {
                    Choice = int.Parse(ConsoleChoice);
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Press any key to exit... ");
                    Console.ReadLine();
                    break;
                }

                switch (Choice)
                {
                    case 1:
                        Console.WriteLine("Option selected: " + menu[Choice] + "\n");
                        string title = "", author = "";
                        int releaseYear = 0;

                        library.GetBookInfo(ref title, ref author, ref releaseYear);
                        bool RetVal = library.AddBook(new Book(title, author, releaseYear));

                        if (RetVal)
                            Console.WriteLine("\nYou have succesfully added new book...");

                        Console.WriteLine("\nIt's values: ");
                        Console.WriteLine("Title:   " + title + "   Author:   " + author + "   Release Year:   " + releaseYear);
                        Console.WriteLine("\nPress enter to display the menu... ");
                        Console.ReadLine();
                        break;


                    case 2:
                        Console.WriteLine("Option selected: " + menu[Choice] + "\n");

                        Console.WriteLine("Input book's title to be removed from the list: ");
                        string TitleToRemove = Console.ReadLine();
                        var ListOfAllBooks = library.ListAll();
                    
                        ListTheBooks(ListOfAllBooks, TitleToRemove);

                        Console.WriteLine("Are you sure to remove this item? [Y/N]");
                        var confirm = Console.ReadLine();
                        if (confirm == "Y")
                        {
                            library.DeleteBookByTitle(TitleToRemove);
                            Console.WriteLine("The item was removed from the library... ");
                        }
                        else
                            Console.WriteLine("Removal cancelled... ");
                        
                        Console.ReadLine();
                        break;


                    case 3:
                        Console.WriteLine("Option selected: " + menu[Choice] + "\n");
                        Console.WriteLine("Input book's title to list the books: ");
                        string TitleToSearch = Console.ReadLine();
                        var foundBooks = library.SearchBookByTitle(TitleToSearch);
                        ListTheBooks(foundBooks);
                        Console.WriteLine("\nPress enter to display the menu... ");
                        Console.ReadLine();
                        break;


                    case 4:
                        Console.WriteLine("Option selected: " + menu[Choice] + "\n");
                        Console.WriteLine("Input book's author to list the books: ");
                        string AuthorToSearch = Console.ReadLine();
                        var foundAuthorBooks = library.SearchBookByAuthor(AuthorToSearch);
                        ListTheBooks(foundAuthorBooks);
                        Console.WriteLine("\nPress enter to display the menu... ");
                        Console.ReadLine();
                        break;


                    case 5:
                        Console.WriteLine("Option selected: " + menu[Choice] + "\n");
                        var BooksOrderedByTitle = library.ListBooksByTitle();
                        ListTheBooks(BooksOrderedByTitle);
                        Console.WriteLine("\nPress enter to display the menu... ");
                        Console.ReadLine();
                        break;


                    case 6:
                        Console.WriteLine("Option selected: " + menu[Choice] + "\n");
                        var AllBooks = library.ListAll();
                        ListTheBooks(AllBooks);
                        Console.WriteLine("\nPress enter to display the menu... ");
                        Console.ReadLine();
                        break;

                    default:

                        break;
                }
            }
        }

    }
    
}
