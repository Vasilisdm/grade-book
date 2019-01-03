using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades.Tests.Types
{
    [TestClass]
    public class TestTypes
    {
        [TestMethod]
        public void UsingArrays()
        {
            float[] grades;
            grades = new float[3];

            AddGrades(grades);
            Assert.AreEqual(7.8f, grades[1]);
        }

        private void AddGrades(float[] grades)
        {
            grades[1] = 7.8f;
        }

        [TestMethod]
        public void UppercaseString()
        {
            string name = "vassilis";
            name = name.ToUpper();
            Assert.AreEqual("VASSILIS", name);
        }

        [TestMethod]
        public void AddDaysToDateTime()
        {
            DateTime date = new DateTime(2018, 12, 30);
            date = date.AddDays(1);

            Assert.AreEqual(31, date.Day);
        }

        [TestMethod]
        public void ValueTypePassByValue()
        {
            int x = 5;
            Increment(x);

            Assert.AreEqual(5, x);
        }

        private void Increment(int x)
        {
            x += 1;
        }

        [TestMethod]
        public void ReferenceTypePassByValue()
        {
            GradeBook book1 = new GradeBook();
            GradeBook book2 = book1;

            GiveBookAName(book2);
            Assert.AreEqual("Zodiac killer", book1.Name);
        }

        private void GiveBookAName(GradeBook book)
        {
            book.Name = "Zodiac killer";
        }

        [TestMethod]
        public void StringComparisons()
        {
            string name1 = "Vassilis";
            string name2 = "vassilis";

            bool result = String.Equals(name1, name2, StringComparison.InvariantCultureIgnoreCase);
            Assert.IsTrue(result); 
        }

        [TestMethod]
        public void IntVariableHoldValue()
        {
            int x1 = 10;
            int x2 = x1;

            x1 = 4;

            Assert.AreNotEqual(x1, x2);
        }

        [TestMethod]
        public void GradeBookVariablesHoldReference()
        {
            GradeBook book = new GradeBook();
            GradeBook book1 = book;


            book.Name = "Vassilis's test book";
            Assert.AreEqual(book.Name, book1.Name);
        }
    }
}
