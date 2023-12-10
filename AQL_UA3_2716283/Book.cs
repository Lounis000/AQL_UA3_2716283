using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AQL_UA3_2716283
{
    public class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public Author Author { get; set; }
        public int PublicationYear { get; set; }
        public string Genre { get; set; }

        // Constructeur
        public Book(string isbn, string title, Author author, int publicationYear, string genre)
        {
            ISBN = isbn;
            Title = title;
            Author = author;
            PublicationYear = publicationYear;
            Genre = genre;
        }

        public Book()
        {
        }
    }

}
