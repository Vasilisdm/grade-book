using System.Collections;
using System.IO;

namespace Grades
{
    internal interface IGradeTracker : IEnumerable
    {
        void AddGrade(float grade);
        void WriteGrades(TextWriter destination);
        GradeStatistics ComputeStatistics();
        string Name { get; set; }
    }
}