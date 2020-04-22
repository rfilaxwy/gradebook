﻿using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Gulliver's Travels");

            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);

            var stats = book.GetStatistics();

            System.Console.WriteLine($"The highest grade is {stats.High}");
            System.Console.WriteLine($"The lowest grade is {stats.Low}");
            System.Console.WriteLine($"The average is {stats.Average:N1}");
        }
    }

}
