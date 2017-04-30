using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySortedCollection
{
    public class Man : IComparable
    {
        private DateTime birthDate { get; }
        private string Name { get; }
        public int Age => DateTime.Today.Year - birthDate.Year;
        public Man(string name, DateTime date)
        {
            this.Name = name;
            this.birthDate = date;
        }
        public Man(string name, int day, int month, int year) :
            this(name, new DateTime(year, month, day))
        { }
        public int CompareTo(object obj)
        {
            Man other = obj as Man;
            if (this.birthDate > other.birthDate) return -1;
            else
                if (this.birthDate == other.birthDate) return 0;
                else
                    return 1;
        }
        public override string ToString()
        {
            return $"{Name}, Age {Age}";
        }
    }
}
