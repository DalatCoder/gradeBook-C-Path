using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var diskBook = new DiskBook("Disk book");
            var inMemoryBook = new InMemoryBook("InMemory book");

            diskBook.GradeAdded += OnGradeAdded;
            inMemoryBook.GradeAdded += OnGradeAdded;

            EnterGrades(diskBook);

            var diskBookStats = diskBook.GetStatistics();
            diskBook.ShowStatistics(diskBookStats);

            EnterGrades(inMemoryBook);

            var inMemoryBookStats = inMemoryBook.GetStatistics();
            inMemoryBook.ShowStatistics(inMemoryBookStats);
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
