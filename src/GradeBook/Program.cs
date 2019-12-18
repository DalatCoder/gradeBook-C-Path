﻿using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book();
            book.AddGrade(89.1);
            book.AddGrade(90.2);
            book.AddGrade(70.5);
            book.AddGrade(75.0);

            var stats = book.GetStatistics();
            book.ShowStatistics(stats);
        }
    }
}
