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
        }//ok
        public void Alterar()
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

            IMenuCadastro menuCadastro;

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
                        menuCadastro = new CadastroPaciente();
                        menuCadastro.Listar();
                        int cdgPaciente;
                        Int32.TryParse(Console.ReadLine(), out cdgPaciente);

                        consulta.paciente = Program.Mock.ListaPacientes.Find(p => p.CodigoPaciente == cdgPaciente);

                        break;
                    case "03":
                        Console.WriteLine("Informe novo medico:\n");
                        menuCadastro = new CadastroMedico();
                        menuCadastro.Listar();
                        int cdgMedico;
                        Int32.TryParse(Console.ReadLine(), out cdgMedico);

                        consulta.medico = Program.Mock.ListaMedicos.Find(p => p.CodigoMedico == cdgMedico);

                        break;
                    case "04":
                        Console.WriteLine("Informe nova recepcionista:\n");
                        menuCadastro = new CadastroRecepcionista();
                        menuCadastro.Listar();
                        int cdgRecepcionista;
                        Int32.TryParse(Console.ReadLine(), out cdgRecepcionista);

                        consulta.recepcionista = Program.Mock.ListaRecepcionistas.Find(p => p.CodigoRecepcionista == cdgRecepcionista);

                        break;
                    case "05":
                        Console.WriteLine("Informe novo custo: \n");
                        int novo_custo;
                        Int32.TryParse(Console.ReadLine(), out novo_custo);
                        consulta.custo = novo_custo;
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
        }//ok
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

            menuCadastros = new CadastroPaciente();
            
            menuCadastros.Listar();
            Console.WriteLine("Informe o Paciente:\n");
            Paciente paciente = new Paciente();
            Int32 cdgPaciente;
            Int32.TryParse(Console.ReadLine(), out cdgPaciente);

            consulta.paciente = Program.Mock.ListaPacientes.Find(p => p.CodigoPaciente == cdgPaciente);


            menuCadastros = new CadastroMedico();
            
            menuCadastros.Listar();
            Console.WriteLine("Informe o Medico:\n");
            Medico medico = new Medico();
            Int32 cdgMedico;
            Int32.TryParse(Console.ReadLine(), out cdgMedico);

            consulta.medico = Program.Mock.ListaMedicos.Find(p => p.CodigoMedico == cdgMedico);
            

            menuCadastros = new CadastroRecepcionista();
            
            menuCadastros.Listar();
            Console.WriteLine("Informe a recepcionista:\n");
            Recepcionista recepcionista = new Recepcionista();
            Int32 cdgRecepcionista;
            Int32.TryParse(Console.ReadLine(), out cdgRecepcionista);

            consulta.recepcionista = Program.Mock.ListaRecepcionistas.Find(p => p.CodigoRecepcionista == cdgRecepcionista);

            Random rd = new Random();
            consulta.CodigoAgenda = rd.Next(1, 100) + DateTime.Now.Second;
            consulta.CodigoAgenda = Int32.Parse($"{consulta.CodigoAgenda}{rd.Next(100, 999)}");

            Program.Mock.ListaAgenda.Add(consulta);
        }//ok

        public void Excluir()
        {

            Console.Clear();
            Agenda consulta;
            int cdgConsulta;
            string confirmacao = " ";

            Console.WriteLine("Informe o Recepcionista que Deseja Excluir:\n");
            ListarAgendaesByCodeAndName();

            Int32.TryParse(Console.ReadLine(), out cdgConsulta);

            consulta = Program.Mock.ListaAgenda.Find(p => p.CodigoAgenda == cdgConsulta);

            Console.WriteLine("Deseja mesmo excluir: " + consulta.CodigoAgenda + "?");
            Console.WriteLine("01 = Sim");
            Console.WriteLine("02 = Nao");
            confirmacao = Console.ReadLine();
            if (confirmacao == "01")
            {
                Program.Mock.ListaAgenda.Remove(consulta);
            }
            else
            {
                Console.WriteLine("cancelado");
                Console.ReadLine();
            }
        }

        public void Listar()
        {
            Console.Clear();

            foreach (Agenda consulta in Program.Mock.ListaAgenda)
            {
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine($"Codigo: {consulta.CodigoAgenda}");
                Console.WriteLine($"Data: {consulta.Data}");
                Console.WriteLine($"Nome do medico: {consulta.medico.Nome}");
                Console.WriteLine($"Nome do Paciente: {consulta.paciente.Nome}");
                Console.WriteLine($"Nome da recepcionista: {consulta.recepcionista.Nome}");
                Console.WriteLine($"Custo: {consulta.custo}");
                Console.WriteLine("-----------------------------------------\n");
            }
            Console.ReadLine();
        }

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
