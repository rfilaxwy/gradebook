using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        public Book(string name)
        {
            grades = new List<double>();
            this.Name = name;
        }
        public void AddGrade(double grade)
        {
            if (grade <= 100 && grade >= 0)
            {
                grades.Add(grade);
            }
            else
            {
                System.Console.WriteLine("Invalid value;");
            }
        }


        public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;

            foreach (double grade in grades)
            {
                result.Low = Math.Min(grade, result.Low);
                result.High = Math.Max(grade, result.High);

                result.Average += grade;
            }
            result.Average /= grades.Count;

            return result;
        }
        public List<double> GetGrades()
        {
            return grades;
        }
        private List<double> grades;

        public string Name;
    }
}