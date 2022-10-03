using Devs2Blu.ProjetosAula.OOP3.Main.Interfaces;
using Devs2Blu.ProjetosAula.OOP3.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.OOP3.Main.Cadastros
{
    public class CadastroFornecedor : IMenuCadastro
    {
        private void ListarFornecedoresByCodeAndName()
        {
            foreach (Fornecedor fornecedor in Program.Mock.ListaFornecedores)
            {
                Console.Write($"| {fornecedor.CodigoFornecedor} - {fornecedor.Nome} ");
            }
            Console.WriteLine("\n");
        }//ok
        public void Alterar()
        {
            Console.Clear();
            Fornecedor fornecedor;
            int codigoFornecedor;

            Console.WriteLine("Informe o Médico que Deseja Alterar:\n");
            ListarFornecedoresByCodeAndName();

            Int32.TryParse(Console.ReadLine(), out codigoFornecedor);

            fornecedor = Program.Mock.ListaFornecedores.Find(p => p.CodigoFornecedor == codigoFornecedor);

            string opcaoAlterar;
            bool alterar = true;

            do
            {
                Console.WriteLine($"Fornecedor: {fornecedor.Codigo}/{fornecedor.CodigoFornecedor} | Nome: {fornecedor.Nome} | CNPJ: {fornecedor.CGCCPF} | Tipo fornecedor: {fornecedor.TipoFornecedor}");
                Console.WriteLine("Qual campo deseja alterar?");
                Console.WriteLine("01 - Nome | 02 - CNPJ | 03 - Tipo Fornecedor | 00 - SAIR");
                opcaoAlterar = Console.ReadLine();
                
                switch (opcaoAlterar)
                {
                    case "01":
                        Console.WriteLine("Informe um novo nome:");
                        fornecedor.Nome = Console.ReadLine();
                        break;
                    case "02":
                        Console.WriteLine("Informe um novo CNPJ:");
                        fornecedor.CGCCPF = Console.ReadLine();
                        break;
                    case "03":
                        Console.WriteLine("Informe um novo Tipo de fornecedor:");
                        fornecedor.TipoFornecedor = Console.ReadLine();
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

            var pact = Program.Mock.ListaFornecedores.Find(p => p.CodigoFornecedor == fornecedor.CodigoFornecedor);
            int index = Program.Mock.ListaFornecedores.IndexOf(pact);
            Program.Mock.ListaFornecedores[index] = fornecedor;
        }//ok

        public void Cadastrar()
        {
            Console.Clear();
            Fornecedor fornecedor = new Fornecedor();
            Console.WriteLine("Informe o Nome do Fornecedor");
            fornecedor.Nome = Console.ReadLine();

            Console.WriteLine("Informe o CNPJ do Fornecedor");
            fornecedor.CGCCPF = Console.ReadLine();

            Console.WriteLine("Informe o tipo do fornecedor");
            fornecedor.TipoFornecedor = Console.ReadLine();

            Random rd = new Random();
            fornecedor.Codigo = rd.Next(1, 100) + DateTime.Now.Second;
            fornecedor.CodigoFornecedor = Int32.Parse($"{fornecedor.Codigo}{rd.Next(100, 999)}");

            Program.Mock.ListaFornecedores.Add(fornecedor);
        }//ok

        public void Excluir()
        {
            Console.Clear();
            Fornecedor fornecedor;
            int cdgFornecedor;
            string confirmacao = " ";

            Console.WriteLine("Informe o Fornecedor que Deseja Excluir:\n");
            ListarFornecedoresByCodeAndName();

            Int32.TryParse(Console.ReadLine(), out cdgFornecedor);

            fornecedor = Program.Mock.ListaFornecedores.Find(p => p.CodigoFornecedor == cdgFornecedor);

            Console.WriteLine("Deseja mesmo excluir: " + fornecedor.Nome + "?");
            Console.WriteLine("01 = Sim");
            Console.WriteLine("02 = Nao");
            confirmacao = Console.ReadLine();
            if (confirmacao == "01")
            {
                Program.Mock.ListaFornecedores.Remove(fornecedor);
            }
            else
            {
                Console.WriteLine("cancelado");
                Console.ReadLine();
            }
        }//ok

        public void Listar()
        {
            Console.Clear();

            foreach (Fornecedor fornecedor in Program.Mock.ListaFornecedores)
            {
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine($"Médico: {fornecedor.CodigoFornecedor}");
                Console.WriteLine($"Nome: {fornecedor.Nome}");
                Console.WriteLine($"CPF: {fornecedor.CGCCPF}");
                Console.WriteLine($"Setor: {fornecedor.TipoFornecedor}") ;
                Console.WriteLine("-----------------------------------------\n");
            }
            Console.ReadLine();
        }//ok

        public int MenuCadastro()
        {
            Int32 opcao;
            Console.Clear();
            Console.WriteLine("----- Cadastro de Fornecedor -----");
            Console.WriteLine("----- 1- Lista de Fornecedor -----");
            Console.WriteLine("----- 2- Cadastro de Fornecedor -----");
            Console.WriteLine("----- 3- Alterar Fornecedor -----");
            Console.WriteLine("----- 4- Excluir Fornecedor -----");
            Console.WriteLine("---------------------");
            Console.WriteLine("----- 0- Sair -----");
            Int32.TryParse(Console.ReadLine(), out opcao);
            return opcao;
        }//ok
    }
}
