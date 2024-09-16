using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka_PD2
{
    public class Book
    {
        private string title;
        private string author;
        private int releaseYear;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public int ReleaseYear
        {
            get { return releaseYear; }
            set { releaseYear = value; }
        }

        public Book(string title, string author, int releaseYear)
        {
            this.title = title;
            this.author = author;
            this.releaseYear = releaseYear;
        }


    }
}
