using Registration_System.Model.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration_System.Models.model
{
    public class Fornecedor : Pessoa
    {
        public Int32 Id { get; set; }
        public String TipoFornecedor { get; set; }

        public Fornecedor()
        {
            TipoPessoa = TipoPessoa.PJ;
        }

        /*public Fornecedor(Int32 codigo, String nome, String cpf, String tipoFornecedor)
        {
            Id = codigo;
            Nome = nome;
            CGCCPF = cpf;
            TipoPessoa = TipoPessoa.PJ;
            TipoFornecedor = tipoFornecedor;

            Random rd = new Random();
            Id = Int32.Parse($"{codigo}{rd.Next(3000, 3999)}");
        }*/
    }
}
