using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.model
{
    public class Person
    {
        public Person()
        {
            Name = "Empty name";
            Id = 0;
            Gender = "Empty gender";
            Birth_day = new DateTime(1900,1,1);

        }
        public string Name { get; set; }
        public int Id { get; set; }
        public string Gender { get; set; }
        public DateTime Birth_day;
    }
}
