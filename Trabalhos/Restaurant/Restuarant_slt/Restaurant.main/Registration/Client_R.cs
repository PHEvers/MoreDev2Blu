using Restaurant.main.Interfaces;
using Restaurant.model;
using Restaurant.model.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.main.Registration
{
    public class Client_R : I_Menu_R
    {
        public void Add_R()
        {
            Console.Clear();
            Client client = new Client();
            Console.WriteLine("Client name: ");
            client.Name = Console.ReadLine();

            Console.WriteLine("Client Id: ");
            int id;
            Int32.TryParse(Console.ReadLine(), out id);
            client.Id = id;

            Console.WriteLine("Client Birth date: ");
            client.Birth_day = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Client gender: ");
            client.Gender = Console.ReadLine();

            Console.WriteLine("Client Post code: ");
            Int32.TryParse(Console.ReadLine(), out id);
            client.Post_code = id;

            Console.WriteLine("Client debt: ");
            Int32.TryParse(Console.ReadLine(), out id);
            client.Debt = id;

            Program.Mock.Client_list.Add(client);
        }

        public int Menu_R()
        {
            int answer;

            Console.Clear();
            Console.WriteLine("--------------------");
            Console.WriteLine("---Menu Client---");
            Console.WriteLine("--------------------\n");

            Console.WriteLine(" 01 - Show Clients list");
            Console.WriteLine(" 02 - Add new Client");

            Int32.TryParse(Console.ReadLine(), out answer);

            return answer;
        }

        public void Show_R()
        {
            throw new NotImplementedException();
        }
    }
}
