using Registration_System.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration_System.Models.model
{
    public class Pessoa
    {
        public Int32 Id { get; set; }
        public String Nome { get; set; }
        public String CGCCPF { get; set; }
        public TipoPessoa TipoPessoa { get; set; }
        public Fl_Status Status { get; set; }


        public Pessoa()
        {
            Status = Fl_Status.A;
        }

        public Pessoa(int id, string nome, string cGCCPF, TipoPessoa tipoPessoa, Fl_Status status)
        {
            Id = id;
            Nome = nome;
            CGCCPF = cGCCPF;
            TipoPessoa = tipoPessoa;
            Status = status;
        }
    }
}
