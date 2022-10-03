using Restaurant.main.Interfaces;
using Restaurant.main.Registration;
using Restaurant.main.Utility;
using Restaurant.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Restaurant.main
{
    internal class Program
    {
        public static Mocks Mock { get; set; }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome");

            Mock = new Mocks();
            I_Menu_R Menu;
            int Main_Menu_Option = 0;
            int Menu_Option = 0;
            
            do
            {
                if(Main_Menu_Option == 0)
                {
                    Console.WriteLine("---------------");
                    Console.WriteLine("---Main menu---");
                    Console.WriteLine("---------------\n");

                    Console.WriteLine(" 01 - Menu Employee");
                    Console.WriteLine(" 02 - Menu Client");
                    Console.WriteLine(" 00 - Exit");

                    Console.WriteLine("\n");

                    Int32.TryParse(Console.ReadLine(), out Main_Menu_Option);
                }//menu primario/principal

                switch (Main_Menu_Option)
                {
                    case 1:
                        Menu = new Client_R();
                        Menu_Option = Menu.Menu_R();
                        break;
                    case 2:
                        Menu = new Employee_R();
                        Menu_Option = Menu.Menu_R();
                        break;
                    default:
                        Menu = new Empty_R();
                        break;
                }//abre as opções do menu secundario

                switch (Menu_Option)
                {
                    case 1:
                        Menu.Show_R();
                        break ;
                    case 2:
                        Menu.Add_R();
                        break;
                    default:
                        Main_Menu_Option = 0;
                        break;
                }//executa oq foi selecionado no meu secundario


            } while (Menu_Option != 0);

        }
    }
}
