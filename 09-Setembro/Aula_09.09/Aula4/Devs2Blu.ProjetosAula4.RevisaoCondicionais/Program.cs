using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula4.RevisaoCondicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;
            Console.WriteLine("\nEscolha o programa desejado: ");
            Console.WriteLine("----------------");
            Console.WriteLine(" 1 - Exemplo 1");
            Console.WriteLine(" 2 - Exemplo 2 (IMCOMPLETO)");
            Console.WriteLine(" 3 - Exemplo 3");
            Console.WriteLine(" 4 - Exemplo 4");
            Console.WriteLine("----------------\n");


            string opcaoSTR = Console.ReadLine();

            Int32.TryParse(opcaoSTR, out opcao);

            if(opcao == 1)
            {
                exercicio7();
                //exercicioRevisao1();
            }
            else if(opcao == 2)
            {
                exercicioRevisao2();
            }else if(opcao == 3)
            {
                exercicio3();
            }else if(opcao == 4)
            {
                exercicio4();
            }else if(opcao == 5)
            {
                exercicio5();
            }



            Console.WriteLine("Digita ai qualquer coisa pra fechar");
            Console.ReadLine();
        }

        static void exercicioRevisao1()
        {
            Console.Clear();
            Console.WriteLine("\n***************   Exerecicio 1   ******************");
            Console.WriteLine("******** Gerar 2 numeros aleatorios 1-100 *********");

            int num1, num2;

            Random nd = new Random();
            num1 = nd.Next(1, 100);
            num2 = nd.Next(1, 100);

            if (num1 > num2)
            {
                Console.WriteLine("O numero 1: " + num1 + " é maior que o numero 2: " + num2);
            }else if(num1 == num2){
                Console.WriteLine("Numero 1 é igual ao 2: " + num2);
            }
            else
            {
                Console.WriteLine("O numero 2: " + num2 + " é maior que o numero 1: " + num1);
            }
        }
        
        static void exercicioRevisao2()
        {
            Console.Clear();
            Console.WriteLine("************************   Exerecicio 2   *************************");
            Console.WriteLine("***   Gerar 3 numeros aleatoria e escrever em ordem crescente   ***");
            int num1, num2, num3;

            Random rd = new Random();
            num1 = rd.Next(1, 100);
            num2 = rd.Next(1, 100);
            num3 = rd.Next(1, 100);

            if(num1 > num2)
            {
                if (num2 > num3)
                {
                    Console.WriteLine("a sequencia fica: " + num1 + " - " + num2 + " - " + num3 + "/n/n");
                }
            }
        }

        static void exercicio3()
        {
            Console.Clear();
            Console.WriteLine("****************************************");
            Console.WriteLine("**********   Exerecicio 3   ************");
            Console.WriteLine("***   Conferir se o numero é impar   ***");
            Console.WriteLine("****************************************");

            int num1;
            Random rd = new Random();
            num1 = rd.Next(1, 100);

            if(num1 - num1/2*2 == 0)
            {
                Console.WriteLine(" O numero: " + num1 + " é par.");
            }
            else{
                Console.WriteLine(" O numero: " + num1 + " é impar.");
            }
        }

        static void exercicio4()
        {
            Console.Clear();
            Console.WriteLine("****************************************");
            Console.WriteLine("**********   Exerecicio 4   ************");
            Console.WriteLine("*******   Lista de produtos   **********");
            Console.WriteLine("****************************************");

            int numeroItem = 0;
            string numeroSTR;
            string[] produtos;
            produtos = new string[5];
            produtos[0] = "Arroz";
            produtos[1] = "Feijao";
            produtos[2] = "farinha";
            produtos[3] = "diversos";
            string texto = "--";

            
            do{
                Console.WriteLine(" Digite o item que deseja adicionar a lista\n");
                numeroSTR = Console.ReadLine();
                Int32.TryParse(numeroSTR, out numeroItem);
                if(numeroItem > 2)
                {
                    texto += "\n" + produtos[3];  
                    Console.WriteLine( " \n" + texto + " \n");
                }
                else
                {
                    texto += "\n" + produtos[numeroItem];
                    Console.WriteLine(" \n" + texto + " \n");
                }
                
            } while (numeroItem < 99);

        }

        static void exercicio5()
        {

            Console.Clear();
            Console.WriteLine("*****************************************");
            Console.WriteLine("**********   Exerecicio 5   *************");
            Console.WriteLine("*****   Permissão maior de idade   ******");
            Console.WriteLine("*****************************************");

            int idade;
            bool permisao;
            string nome;

            Console.WriteLine(" Informe seu nome: ");
            nome = Console.ReadLine();

            Console.WriteLine(" Informe sua idade: ");
            string idadeSTR = Console.ReadLine();
            Int32.TryParse(idadeSTR, out idade);

            permisao = (idade >= 19) ? true : false;
        }

        static void exercicio6()
        {/*
            Console.Clear();
            Console.WriteLine("**************************************");
            Console.WriteLine("*********   Exerecicio 6   ***********");
            Console.WriteLine("*****   Permissão para votar   *******");
            Console.WriteLine("**************************************");

            string nome;
            string dataNascimentoSTR;
            int dataNasc;
            string negado = "usuario não pode votar";
            string aprovado = "usuario pode votar";
            bool resposta = ;
            Console.WriteLine(" Informe o nome: ");
            nome = Console.ReadLine();

            Console.WriteLine(" Informe o ano de nascimento: ");
            dataNascimentoSTR = Console.ReadLine();

            Int32.TryParse(dataNascimentoSTR, out dataNasc);
            int ano = dataNasc % 10000;
            int mes = (dataNasc / 10000) % 10;
            int dia = (dataNasc / 1000000) % 10;

            resposta = (dataNasc%10000 >= 2004) ? true : false; 
            *//*if (resposta == true &&)*//**/
        }
        static void exercicio7()
        {
            Console.Clear ();   
            const string SENHA = "1234";
            bool acesso = false;
            do
            {
                string tentativa;
                Console.WriteLine("Digite sua senha");
                tentativa = Console.ReadLine();

                if (tentativa.Equals(SENHA))
                {
                    Console.WriteLine("ACESSO PERMITIDO");
                    acesso = true;
                } else
                {
                    Console.WriteLine("ACESSO NEGADO");
                }
            } while (acesso == false);
        }
    }
}
