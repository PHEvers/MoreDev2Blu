using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Devs2Blu.ProjetosAula.OOP3.Main.Interfaces;
using Devs2Blu.ProjetosAula.OOP3.Main.Utils;
using Devs2Blu.ProjetosAula.OOP3.Main.Utils.Enums;
using Devs2Blu.ProjetosAula.OOP3.Models.Model;

namespace Devs2Blu.ProjetosAula.OOP3.Main.Cadastros
{
    public class CadastroPaciente : IMenuCadastro
    {
        public CadastroPaciente()
        {

        }
        private void ListarPacientes()
        {
            Console.Clear();

            foreach (Paciente paciente in Program.Mock.ListaPacientes)
            {
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine($"Paciente: {paciente.CodigoPaciente}");
                Console.WriteLine($"Nome: {paciente.Nome}");
                Console.WriteLine($"CPF: {paciente.CGCCPF}");
                Console.WriteLine($"Convenio: {paciente.Convenio}");
                Console.WriteLine("-----------------------------------------\n");
            }
            Console.ReadLine();
        }

        public Int32 MenuCadastro()
        {
            return 0;
        }
        private void CadastrarPaciente(Paciente novoPaciente)
        {
            Program.Mock.ListaPacientes.Add(novoPaciente);
        }

        private void AlterarPaciente(Paciente paciente)
        {

        }

        private void ExcluirPaciente(Paciente paciente)
        {

        }


        #region FACADE
        public void MenuCadastro()
        {
            Int32 opcao;

            do
            {
                Console.Clear();
                Console.WriteLine("----- Cadastro de Pacientes -----");
                Console.WriteLine("----- 1- Lista de Pacientes -----");
                Console.WriteLine("----- 2- Cadastro de Pacientes -----");
                Console.WriteLine("----- 3- Alterar Pacientes -----");
                Console.WriteLine("---------------------");
                Console.WriteLine("----- 0- Sair -----");
                Int32.TryParse(Console.ReadLine(), out opcao);

                switch (opcao)
                {
                    case (int)MenuEnums.LISTAR:
                        ListarPacientes();
                        break;
                    default:
                        break;
                }

            } while (!opcao.Equals((int)MenuEnums.SAIR));
        }

        public void Listar()
        {
            ListarPacientes();
        }

        public void Cadastrar(Pessoa pessoa)
        {
            CadastrarPaciente((Paciente)pessoa);
        }

        public void Alterar(Pessoa pessoa)
        {
            AlterarPaciente((Paciente)pessoa);
        }

        public void Excluir(Pessoa pessoa)
        {
            ExcluirPaciente((Paciente)pessoa);
        }

        #endregion
    }
}
