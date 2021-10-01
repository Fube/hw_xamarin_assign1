using System;
using System.Collections.Generic;
using System.Text;

namespace Assign1
{
    public class Employee
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public bool Hockey { get; set; }

        public bool Basketball { get; set; }

        public bool None { get; set; }

        public bool Day { get; set; }

        public bool Evening { get; set; }

        public string IsValid()
        {
            if (Name == null || Name.Length <= 0) return "Name not set";

            if (Salary < 0) return "Salary cannot be negative";

            if (Salary > 10000) return "Salary too high";

            if (!(Hockey || Basketball || None)) return "Must choose a sport";

            if (!Day && !Evening) return "Time must be set";

            return null;
        }

    }
}
