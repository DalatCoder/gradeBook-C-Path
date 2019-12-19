using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book();
            book.GradeAdded += OnGradeAdded;

            while (true)
            {
                Console.WriteLine("Enter a grade or 'q' to quit: ");
                var input = Console.ReadLine();

                if (input == "q") break;

                try
                {
                    var grade = double.Parse(input);
                    book.AddGrade(grade);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("------------------");
                }
            }


            var stats = book.GetStatistics();
            book.ShowStatistics(stats);
        }

        static void OnGradeAdded(object sender, EventArgs e)
        {
            Console.WriteLine("A grade was added!");
        }
    }
}
