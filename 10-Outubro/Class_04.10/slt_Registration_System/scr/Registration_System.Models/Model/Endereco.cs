using Registration_System.Models.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration_System.Models.Model
{
    public class Endereco
    {
        public Int32 Id { get; set; }
        public Pessoa Pessoa { get; set; }
        public String CEP { get; set; }
        public String Rua { get; set; }
        public Int32 Numero { get; set; }
        public String Bairro { get; set; }
        public String Cidade { get; set; }
        public String UF { get; set; }

        public Endereco() { }

        public Endereco(int id, Pessoa pessoa, string cEP, string rua, int numero, string bairro, string cidade, string uF)
        {
            Id = id;
            Pessoa = pessoa;
            CEP = cEP;
            Rua = rua;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;
            UF = uF;
        }
    }
}
