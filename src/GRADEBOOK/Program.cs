﻿using System;
using System.Collections.Generic;

namespace GRADEBOOK
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Dittu's Grade Book");

            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.5);

            var stats = book.GetStatistics();

            Console.WriteLine($"The lowest grade is {stats.Low : N1}");
            Console.WriteLine($"The highest grade is {stats.High : N1}");
            Console.WriteLine($"The Average grade is {stats.Average : N1}");

            
        }
    }
}
