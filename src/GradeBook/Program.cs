using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new DiskBook("Disk book");
            var book1 = new InMemoryBook("InMemory book");

            book.GradeAdded += OnGradeAdded;
            book1.GradeAdded += OnGradeAdded;

            EnterGrades(book);

            var stats = book.GetStatistics();
            System.Console.WriteLine($"For the book: {book.Name}: ");
            book.ShowStatistics(stats);

            EnterGrades(book1);

            var stats1 = book1.GetStatistics();
            System.Console.WriteLine($"For the book: {book1.Name}: ");
            book1.ShowStatistics(stats1);
        }

        private static void EnterGrades(IBook book)
        {
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
        }

        static void OnGradeAdded(object sender, EventArgs e)
        {
            Console.WriteLine("A grade was added!");
        }
    }
}
