using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public abstract class GradeTracker : IGradeTracker
    {
        public abstract void AddGrade(float grade);
        public abstract void WriteGrades(TextWriter destination);
        public abstract GradeStatistics ComputeStatistics();
        public abstract IEnumerator GetEnumerator();

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be null or empty!");
                }

                if (_name != value && nameChanged != null)
                {
                    NameChangedEventArgs args = new NameChangedEventArgs();
                    args.existinName = _name;
                    args.newName = value;
                    nameChanged(this, args);
                }

                _name = value;
            }

        }
        public event NameChangedDelegate nameChanged;
        protected string _name;
    }
}
