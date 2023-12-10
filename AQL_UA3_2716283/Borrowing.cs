using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AQL_UA3_2716283
{
    public enum BorrowingStatus
    {
        InProgress,
        Returned,
        Late
    }

    public class Borrowing
    {
        public int BorrowingID { get; set; }
        public Book BorrowedBook { get; set; }
        public DateTime BorrowDate { get; set; }
        public DateTime DueDate { get; set; }
        public BorrowingStatus Status { get; set; }

        // Constructeur
        public Borrowing(int borrowingID, Book borrowedBook, DateTime borrowDate, DateTime dueDate, BorrowingStatus status)
        {
            BorrowingID = borrowingID;
            BorrowedBook = borrowedBook;
            BorrowDate = borrowDate;
            DueDate = dueDate;
            Status = status;
        }
    }


}
