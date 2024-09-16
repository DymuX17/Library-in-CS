using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka_PD2
{
    public class LibraryInitializer
    {
        public static void AddBooks(Library library)
        {

            library.AddBook(new Book("Pan Tadeusz", "Adam Mickiewicz", 1834));
            library.AddBook(new Book("Lalka", "Boleslaw Prus", 1890));
            library.AddBook(new Book("Quo Vadis", "Henryk Sienkiewicz", 1896));
            library.AddBook(new Book("Ferdydurke", "Witold Gombrowicz", 1937));
            library.AddBook(new Book("Solaris", "Stanislaw Lem", 1961));
            library.AddBook(new Book("Dziady", "Adam Mickiewicz", 1823));
            library.AddBook(new Book("Krzyzacy", "Henryk Sienkiewicz", 1900));
            library.AddBook(new Book("Nad Niemnem", "Eliza Orzeszkowa", 1888));
            library.AddBook(new Book("Balladyna", "Juliusz Slowacki", 1839));
            library.AddBook(new Book("Chlopi", "Wladyslaw Reymont", 1904));
            library.AddBook(new Book("Wesele", "Stanislaw Wyspianski", 1901));
            library.AddBook(new Book("Przedwiosnie", "Stefan Zeromski", 1924));
            library.AddBook(new Book("Zbrodnia i kara", "Fiodor Dostojewski", 1866));
            library.AddBook(new Book("W pustyni i w puszczy", "Henryk Sienkiewicz", 1911));
            library.AddBook(new Book("Ogniem i mieczem", "Henryk Sienkiewicz", 1884));
            library.AddBook(new Book("Ludzie bezdomni", "Stefan Zeromski", 1899));
            library.AddBook(new Book("Wladca much", "William Golding", 1954));
            library.AddBook(new Book("Opowiadania", "Anton Czechow", 1886));
            library.AddBook(new Book("Ziemia obiecana", "Wladyslaw Reymont", 1899));
            library.AddBook(new Book("1984", "George Orwell", 1949));
            library.AddBook(new Book("Brave New World", "Aldous Huxley", 1932));
            library.AddBook(new Book("To Kill a Mockingbird", "Harper Lee", 1960));
            library.AddBook(new Book("The Great Gatsby", "F. Scott Fitzgerald", 1925));
            library.AddBook(new Book("Moby Dick", "Herman Melville", 1851));
            library.AddBook(new Book("War and Peace", "Leo Tolstoy", 1869));
            library.AddBook(new Book("Pride and Prejudice", "Jane Austen", 1813));
            library.AddBook(new Book("The Catcher in the Rye", "J.D. Salinger", 1951));
            library.AddBook(new Book("The Hobbit", "J.R.R. Tolkien", 1937));
            library.AddBook(new Book("The Lord of the Rings", "J.R.R. Tolkien", 1954));
            library.AddBook(new Book("Jane Eyre", "Charlotte Bronte", 1847));
            library.AddBook(new Book("Wuthering Heights", "Emily Bronte", 1847));
            library.AddBook(new Book("The Brothers Karamazov", "Fyodor Dostoevsky", 1880));
            library.AddBook(new Book("Anna Karenina", "Leo Tolstoy", 1877));
            library.AddBook(new Book("The Picture of Dorian Gray", "Oscar Wilde", 1890));
            library.AddBook(new Book("The Grapes of Wrath", "John Steinbeck", 1939));
            library.AddBook(new Book("One Hundred Years of Solitude", "Gabriel Garcia Marquez", 1967));
            library.AddBook(new Book("The Metamorphosis", "Franz Kafka", 1915));
            library.AddBook(new Book("The Stranger", "Albert Camus", 1942));
            library.AddBook(new Book("Don Quixote", "Miguel de Cervantes", 1605));
            library.AddBook(new Book("The Divine Comedy", "Dante Alighieri", 1320));
            library.AddBook(new Book("Les Miserables", "Victor Hugo", 1862));
            library.AddBook(new Book("Madame Bovary", "Gustave Flaubert", 1857));
            library.AddBook(new Book("The Count of Monte Cristo", "Alexandre Dumas", 1844));
            library.AddBook(new Book("The Three Musketeers", "Alexandre Dumas", 1844));
            library.AddBook(new Book("Dracula", "Bram Stoker", 1897));
            library.AddBook(new Book("Frankenstein", "Mary Shelley", 1818));
            library.AddBook(new Book("Nic dwa razy sie nie zdarza i nie zdarzy z tej przyczyny zrodzilismy sie", "Maria Konopnicka", 1972));
        }

    }
}
