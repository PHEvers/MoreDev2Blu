using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Restaurant.model.models
{
    public class Client : Person
    {
        public Client()
        {
            Name = "Empty name";
            Id = 0;
            Gender = "Empty gender";
            Birth_day = new DateTime(1900, 1, 1);
            Post_code = 0;
            Debt = 0;
        }

        public int Post_code;
        public int Debt;
    }
}
