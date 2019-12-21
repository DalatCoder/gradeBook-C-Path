using System;

namespace GradeBook
{
    public delegate void GradeAddedDelegate(object sender, EventArgs args);

    public abstract class Book : NameObject, IBook
    {
        public Book(string name) : base(name)
        {
        }

        public abstract event GradeAddedDelegate GradeAdded;

        public abstract void AddGrade(double grade);
        public abstract Statistics GetStatistics();
        public virtual void ShowStatistics(Statistics stats)
        {
            System.Console.WriteLine($"For the book: {Name}: ");
            System.Console.WriteLine($"The average grade is: {stats.Average}");
            System.Console.WriteLine($"The high grade is: {stats.High}");
            System.Console.WriteLine($"The low grade is: {stats.Low}");
            System.Console.WriteLine($"The letter grade is: {stats.Letter}");
        }
    }
}
