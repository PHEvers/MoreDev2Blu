using Registration_System.Models.Enum;
using Registration_System.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration_System.Models.model
{
    public class Paciente
    {
        public Int32 Id { get; set; }
        public Pessoa Pessoa { get; set; }

        public Convenio Convenio { get; set; }

        public Int32 NrProntuario { get; set;}
        public String PacienteRisco { get; set; }
        public Int32 FlObito { get; set; }
        public Fl_Status Status { get; set; }

        public Paciente(int id, Pessoa pessoa, Convenio convenio, int nrProntuario, string pacienteRisco, int flObito, Fl_Status status)
        {
            Id = id;
            Pessoa = pessoa;
            Convenio = convenio;
            NrProntuario = nrProntuario;
            PacienteRisco = pacienteRisco;
            FlObito = flObito;
            Status = status;
        }

        public Paciente(Pessoa pessoa, Convenio convenio, int nrProntuario, string pacienteRisco, int flObito, Fl_Status status)
        {
            Pessoa = pessoa;
            Convenio = convenio;
            NrProntuario = nrProntuario;
            PacienteRisco = pacienteRisco;
            FlObito = flObito;
            Status = status;
        }

        public Paciente()
        {
            Pessoa = new Pessoa();
            Convenio = new Convenio();
            FlObito = 0;
            Pessoa.TipoPessoa = TipoPessoa.PF;
            
            FlObito = 0;

        }

        
    }
}
