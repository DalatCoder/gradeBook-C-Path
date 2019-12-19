using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        List<double> grades;
        public string Name;

        public Book()
        {
            grades = new List<double>();
        }

        public Book(string name)
        {
            Name = name;
        }

        public int GetNumberOfGrades()
        {
            return grades.Count;
        }

        public void AddGrade(double grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                grades.Add(grade);
            }
            else
            {
                Console.WriteLine("Invalid value!");
            }
        }

        public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;

            var index = 0;
            do
            {
                result.High = Math.Max(grades[index], result.High);
                result.Low = Math.Min(grades[index], result.Low);
                result.Average += grades[index];
                index++;
            } while (index < grades.Count);

            result.Average /= grades.Count;

            return result;
        }

        public void ShowStatistics(Statistics result)
        {
            Console.WriteLine($"The average grade is: {result.Average}");
            Console.WriteLine($"The high grade is: {result.High}");
            Console.WriteLine($"The low grade is: {result.Low}");
        }
    }
}
