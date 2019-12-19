using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        public string Name
        {
            get;
            set;
        }

        public Book()
        {
            grades = new List<double>();
        }

        public Book(string name) : base()
        {
            Name = name;
        }

        public int GetNumberOfGrades()
        {
            return grades.Count;
        }

        public void AddLetter(char letter)
        {
            switch (letter)
            {
                case 'A':
                    AddGrade(90);
                    break;

                case 'B':
                    AddGrade(80);
                    break;

                case 'C':
                    AddGrade(70);
                    break;

                case 'D':
                    AddGrade(60);
                    break;

                default:
                    AddGrade(0);
                    break;
            }
        }

        public void AddGrade(double grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                grades.Add(grade);
            }
            else
            {
                throw new ArgumentException($"Invalid {nameof(grade)}");
            }
        }

        public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;

            foreach (var grade in grades)
            {
                result.High = Math.Max(grade, result.High);
                result.Low = Math.Min(grade, result.Low);
                result.Average += grade;
            }

            result.Average /= grades.Count;

            switch (result.Average)
            {
                case var d when d >= 90.0:
                    result.Letter = 'A';
                    break;

                case var d when d >= 80:
                    result.Letter = 'B';
                    break;

                case var d when d >= 70:
                    result.Letter = 'C';
                    break;

                case var d when d >= 60:
                    result.Letter = 'D';
                    break;

                default:
                    result.Letter = 'F';
                    break;
            }

            return result;
        }

        public void ShowStatistics(Statistics result)
        {
            Console.WriteLine($"The average grade is: {result.Average}");
            Console.WriteLine($"The high grade is: {result.High}");
            Console.WriteLine($"The low grade is: {result.Low}");
            Console.WriteLine($"The letter grade is: {result.Letter}");
        }

        List<double> grades;
    }
}
