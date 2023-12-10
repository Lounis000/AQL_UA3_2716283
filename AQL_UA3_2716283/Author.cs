using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AQL_UA3_2716283
{
    public class Author
    {
        public int AuthorID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime DateOfBirth { get; set; }

        // Constructeur
        public Author(int authorID, string lastName, string firstName, DateTime dateOfBirth)
        {
            AuthorID = authorID;
            LastName = lastName;
            FirstName = firstName;
            DateOfBirth = dateOfBirth;
        }
    }
}
