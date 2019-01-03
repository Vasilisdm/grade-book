using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            IGradeTracker book = CreateGradeBook();

            //GetBookName(book);
            AddGrades(book);
            SaveGrades(book);
            WriteResults(book);
        }

        private static IGradeTracker CreateGradeBook()
        {
            return new ThrowAwayGradeBook();
        }

        private static void WriteResults(IGradeTracker book)
        {
            GradeStatistics stats = book.ComputeStatistics();

            foreach (float grade in book)
            {
                Console.WriteLine(grade);
            }

            WriteResult("Average Grade", stats.AverageGrade);
            WriteResult("Highest Grade", (int)stats.HighestGrade);
            WriteResult("Lowest Grade", stats.LowestGrade);
            WriteResult(stats.Description, stats.LetterGrade);
            Console.ReadLine();
        }

        private static void SaveGrades(IGradeTracker book)
        {
            using (StreamWriter outputFile = File.CreateText("grades.txt"))
            {
                book.WriteGrades(outputFile);
            }
        }

        private static void AddGrades(IGradeTracker book)
        {
            book.AddGrade(88);
            book.AddGrade(77.88f);
            book.AddGrade(92.34f);
        }

        private static void GetBookName(GradeTracker book)
        {
            try
            {
                Console.WriteLine("Please enter a name for the Grade Book");
                book.Name = Console.ReadLine();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void WriteResult(string description, float result)
        {
            Console.WriteLine($"{description}: {result:f2}");
        }

        static void WriteResult(string description, string result)
        {
            Console.WriteLine($"{description}: {result}");
        }
    }
}
