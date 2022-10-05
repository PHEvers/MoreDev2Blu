using Registration_System.Model.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration_System.Models.model
{
    public class Recepcionista : Pessoa
    {
        public Int32 Id { get; set; }
        public String Setor { get; set; }

        //public Recepcionista()
        //{
        //    TipoPessoa = TipoPessoa.PF;
        //}

        /*public Recepcionista(Int32 codigo, String nome, String cpf, string setor)
        {
            Codigo = codigo;
            Nome = nome;
            CGCCPF = cpf;
            TipoPessoa = TipoPessoa.PF;
            Setor = setor;

            Random rd = new Random();
            Id = Int32.Parse($"{codigo}{rd.Next(1000, 1100)}");
        }*/
    }
}
