using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book();

            while (true)
            {
                Console.WriteLine("Enter a grade or 'q' to quit: ");
                var input = Console.ReadLine();

                if (input == "q") break;

                var grade = double.Parse(input);
                book.AddGrade(grade);
            }


            var stats = book.GetStatistics();
            book.ShowStatistics(stats);
        }
    }
}
