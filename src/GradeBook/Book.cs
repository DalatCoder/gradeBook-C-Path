using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Book
    {
        List<double> grades;
        string name;

        public Book()
        {
            grades = new List<double>();
        }

        public Book(string name)
        {
            this.name = name;
        }

        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public void ShowStatistics()
        {
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;
            var avgGrade = 0.0;

            foreach (var grade in grades)
            {
                highGrade = Math.Max(grade, highGrade);
                lowGrade = Math.Min(grade, lowGrade);
                avgGrade += grade;
            }

            avgGrade /= grades.Count;

            Console.WriteLine($"The highest grade is: {highGrade}");
            Console.WriteLine($"The lowest grade is: {lowGrade}");
            Console.WriteLine($"The average grade is: {avgGrade}");
        }
    }
}
