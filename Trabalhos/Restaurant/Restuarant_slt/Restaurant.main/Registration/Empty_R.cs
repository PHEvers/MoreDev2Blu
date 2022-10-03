using Restaurant.main.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.main.Registration
{
    internal class Empty_R : I_Menu_R
    {
        public void Add_R()
        {
            throw new NotImplementedException();
        }

        public int Menu_R()
        {
            throw new NotImplementedException();
        }

        public void Show_R()
        {
            throw new NotImplementedException();
        }
    }
}
