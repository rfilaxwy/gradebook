using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public void ShowStatistics()
        {
            var result = 0.0;
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;

            foreach (double num in grades)
            {
                lowGrade = Math.Min(num, lowGrade);
                highGrade = Math.Max(num, highGrade);

                result += num;
            }
            Console.WriteLine($"The average grade is {(result / grades.Count):N1}");
            Console.WriteLine($"The highest grade is {highGrade}");
            Console.WriteLine($"The lowest grade is {lowGrade}");
        }
        private List<double> grades;



        private string name;
    }
}