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
            foreach (Agenda consulta in Program.Mock.ListaAgendaes)
            {
                Console.Write($"| {consulta.CodigoAgenda} - {consulta.Nome} ");
            }
            Console.WriteLine("\n");
        }
        public void Alterar()
        {
            Console.Clear();
            Agenda consulta;
            int codigoAgenda;

            Console.WriteLine("Informe o Médico que Deseja Alterar:\n");
            ListarAgendaesByCodeAndName();

            Int32.TryParse(Console.ReadLine(), out codigoAgenda);

            consulta = Program.Mock.ListaAgendaes.Find(p => p.CodigoAgenda == codigoAgenda);

            string opcaoAlterar;
            bool alterar = true;

            do
            {
                Console.WriteLine($"Agenda: {consulta.Codigo}/{consulta.CodigoAgenda} | Nome: {consulta.Nome} | CNPJ: {consulta.CGCCPF} | Tipo consulta: {consulta.TipoAgenda}");
                Console.WriteLine("Qual campo deseja alterar?");
                Console.WriteLine("01 - Nome | 02 - CNPJ | 03 - Tipo Agenda | 00 - SAIR");
                opcaoAlterar = Console.ReadLine();

                switch (opcaoAlterar)
                {
                    case "01":
                        Console.WriteLine("Informe um novo nome:");
                        consulta.Nome = Console.ReadLine();
                        break;
                    case "02":
                        Console.WriteLine("Informe um novo CNPJ:");
                        consulta.CGCCPF = Console.ReadLine();
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

            var pact = Program.Mock.ListaAgendaes.Find(p => p.CodigoAgenda == consulta.CodigoAgenda);
            int index = Program.Mock.ListaAgendaes.IndexOf(pact);
            Program.Mock.ListaAgendaes[index] = consulta;
        }

        public void Cadastrar()
        {
            Console.Clear();
            Agenda consulta = new Agenda();
            Console.WriteLine("Informe o ");
            consulta.Nome = Console.ReadLine();

            Console.WriteLine("Informe o CNPJ do Agenda");
            consulta.CGCCPF = Console.ReadLine();

            Console.WriteLine("Informe o tipo do consulta");
            consulta.TipoAgenda = Console.ReadLine();

            Random rd = new Random();
            consulta.Codigo = rd.Next(1, 100) + DateTime.Now.Second;
            consulta.CodigoAgenda = Int32.Parse($"{consulta.Codigo}{rd.Next(100, 999)}");

            Program.Mock.ListaAgendaes.Add(consulta);
        }

        public void Excluir()
        {
            Agenda consulta = new Agenda();
            Program.Mock.ListaAgendaes.Remove(consulta);
        }

        public void Listar()
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
