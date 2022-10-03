using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.model
{
    public class Employee : Person
    {
        public Employee()
        {
            Name = "Empty name";
            Id = 0;
            Gender = "Empty gender";
            Birth_day = new DateTime(1900, 1, 1);
            Function = "Empty function";
            Wage = 0;
        }

        public Employee(string A, int B, string C, DateTime D, string E, int F)
        {
            Name = A;
            Id = B;
            Gender = C;
            Birth_day = D;
            Function = E;
            Wage = F;
        }
        public string Function { get; set; }
        public int Wage { get; set; }
    }
}
