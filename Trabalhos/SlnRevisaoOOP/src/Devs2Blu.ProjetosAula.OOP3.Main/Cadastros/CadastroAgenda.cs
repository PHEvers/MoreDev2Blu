using Devs2Blu.ProjetosAula.OOP3.Main.Interfaces;
using Devs2Blu.ProjetosAula.OOP3.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.OOP3.Main.Cadastros
{
    public class CadastroAgenda : IMenuCadastro
    {
        private void ListarAgendaesByCodeAndName()
        {
            foreach (Agenda consulta in Program.Mock.ListaAgenda)
            {
                Console.Write($"| {consulta.CodigoAgenda} - {consulta.paciente} ");
            }
            Console.WriteLine("\n");
        }
        /*public void Alterar()
        {
            Console.Clear();
            Agenda consulta;
            int codigoAgenda;

            Console.WriteLine("Informe a connsulta que Deseja Alterar:\n");
            ListarAgendaesByCodeAndName();

            Int32.TryParse(Console.ReadLine(), out codigoAgenda);

            consulta = Program.Mock.ListaAgenda.Find(p => p.CodigoAgenda == codigoAgenda);

            string opcaoAlterar;
            bool alterar = true;

            do
            {
                Console.WriteLine($"Consulta:{consulta.CodigoAgenda} |Data: {consulta.Data}| Pasciente: {consulta.paciente.Nome} | Medico: {consulta.medico.Nome} | Recepcionista: {consulta.recepcionista.Nome} | Custo: {consulta.custo}");
                Console.WriteLine("Qual campo deseja alterar?");
                Console.WriteLine("01 - Data | 02 - Paciente | 03 - Medico | 04 - Recepcionista | 05 - Custo | 00 - SAIR");
                opcaoAlterar = Console.ReadLine();

                switch (opcaoAlterar)
                {
                    case "01":
                        Console.WriteLine("Informe a data da consulta");
                        string data = Console.ReadLine();
                        DateTime dt;
                        while (!DateTime.TryParseExact(data, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out dt))
                        {
                            Console.WriteLine("Data invalida, tente novamente");
                            data = Console.ReadLine();
                        }
                        break;
                    case "02":
                        Console.WriteLine("Informe novo paciente:\n");
                        ListarPacientesByCodeAndName();

                        Int32.TryParse(Console.ReadLine(), out cdgPaciente);

                        paciente = Program.Mock.ListaPacientes.Find(p => p.CodigoPaciente == cdgPaciente);

                        break;
                    case "03":
                        Console.WriteLine("Informe um novo Tipo de consulta:");
                        consulta.TipoAgenda = Console.ReadLine();
                        break;
                    default:
                        alterar = false;
                        break;
                }

                if (alterar)
                {
                    Console.Clear();
                    Console.WriteLine("Dado Alterado com Sucesso!");
                }
            } while (alterar);

            var pact = Program.Mock.ListaAgenda.Find(p => p.CodigoAgenda == consulta.CodigoAgenda);
            int index = Program.Mock.ListaAgenda.IndexOf(pact);
            Program.Mock.ListaAgenda[index] = consulta;
        }*/

        public void Cadastrar()
        {
            Console.Clear();
            IMenuCadastro menuCadastros;

            Agenda consulta = new Agenda();

            Console.WriteLine("Informe a data da consulta");
            string data = Console.ReadLine();
            DateTime dt;
            while (!DateTime.TryParseExact(data, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out dt))
            {
                Console.WriteLine("Data invalida, tente novamente");
                data = Console.ReadLine();
            }

            menuCadastros = CadastroPaciente();
            Console.WriteLine("Informe o Paciente:\n");
            ListarPacientesByCodeAndName();

            Int32.TryParse(Console.ReadLine(), out cdgPaciente);

            paciente = Program.Mock.ListaPacientes.Find(p => p.CodigoPaciente == cdgPaciente);

            Console.WriteLine("Informe o tipo do consulta");
            consulta.TipoAgenda = Console.ReadLine();

            Random rd = new Random();
            consulta.Codigo = rd.Next(1, 100) + DateTime.Now.Second;
            consulta.CodigoAgenda = Int32.Parse($"{consulta.Codigo}{rd.Next(100, 999)}");

            Program.Mock.ListaAgendaes.Add(consulta);
        }

       /* public void Excluir()
        {
            Agenda consulta = new Agenda();
            Program.Mock.ListaAgendaes.Remove(consulta);
        }*/

        /*public void Listar()
        {
            Console.Clear();

            foreach (Agenda consulta in Program.Mock.ListaAgendaes)
            {
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine($"Médico: {consulta.CodigoAgenda}");
                Console.WriteLine($"Nome: {consulta.Nome}");
                Console.WriteLine($"CPF: {consulta.CGCCPF}");
                Console.WriteLine($"Setor: {consulta.TipoAgenda}");
                Console.WriteLine("-----------------------------------------\n");
            }
            Console.ReadLine();
        }*/

        public int MenuCadastro()
        {
            Int32 opcao;
            Console.Clear();
            Console.WriteLine("----- Lista de consultas -----");
            Console.WriteLine("----- 1- Listar as consultas -----");
            Console.WriteLine("----- 2- Cadastrar consulta -----");
            Console.WriteLine("----- 3- Alterar consulta -----");
            Console.WriteLine("----- 4- Excluir consulta -----");
            Console.WriteLine("---------------------");
            Console.WriteLine("----- 0- Sair -----");
            Int32.TryParse(Console.ReadLine(), out opcao);
            return opcao;
        }//ok
    }
}
