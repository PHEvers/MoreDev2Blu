using Registration_System.Models.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration_System.Models.Model
{
    public class Convenio
    {
        public Int32 Id { get; set; }
        public String Nome { get; set; }
        public Fl_Status Status { get; set; }
        public Convenio() 
        {
            Status = Fl_Status.A;
        }

        public Convenio(int id, string nome, Fl_Status status)
        {
            Id = id;
            Nome = nome;
            Status = status;
        }
    }
}

public enum Fl_Status
{
    [Description("Offline")]
    I = 0,
    [Description("Online")]
    A = 1,
    
}