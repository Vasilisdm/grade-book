using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Grades.Tests
{
    
    [TestClass]
    public class GradeBookTests
    { 
       
        [TestMethod]
        public void ComputeHighestGrade()
        {
            GradeBook book = new GradeBook();

            book.AddGrade(10);
            book.AddGrade(8);

            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual(10, result.HighestGrade);
        }

        [TestMethod]
        public void ComputeLowestGrade()
        {
            GradeBook book = new GradeBook();

            book.AddGrade(10);
            book.AddGrade(8);

            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual(8, result.LowestGrade);
        }

        [TestMethod]
        public void ComputeAverageGrade()
        {
            GradeBook book = new GradeBook();

            book.AddGrade(8f);
            book.AddGrade(5.6f);
            book.AddGrade(7.8f);

            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual(7.13, result.AverageGrade, 0.01);
        }
    }
}
