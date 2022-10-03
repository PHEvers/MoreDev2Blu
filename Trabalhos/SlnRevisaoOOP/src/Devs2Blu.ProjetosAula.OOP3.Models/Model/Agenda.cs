using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.OOP3.Models.Model
{
    public class Agenda
    {
        public Agenda()
        {

        }
        public Agenda(DateTime data, Medico medico, Paciente paciente, Recepcionista recepcionista, int custo)
        {
            Data = data;
            this.medico = medico;
            this.paciente = paciente;
            this.recepcionista = recepcionista;
            this.custo = custo;

            Random rd = new Random();
            CodigoAgenda = Int32.Parse($"{CodigoAgenda}{rd.Next(1000, 9999)}");
        }

        public DateTime Data { get; set; }
        public Medico medico { get; set; }
        public Paciente paciente { get; set; }
        public Recepcionista recepcionista { get; set; }
        public int custo { get; set; }
        public int CodigoAgenda { get; set; }


    }
}
