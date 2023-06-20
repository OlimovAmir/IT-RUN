using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListTask
{
    public class Person
    {
        public DateTime Birthdate { get; }
        public Person(int year, int month, int day)
        {
            Birthdate = new DateTime(year, month, day);

        }
    }
}
