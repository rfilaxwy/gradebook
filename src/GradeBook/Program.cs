using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Gulliver's Travels");
            book.AddGrade(89.1);
            book.AddGrade(92.4);
            book.AddGrade(81.6);
            book.ShowStatistics();
        }
    }

}
