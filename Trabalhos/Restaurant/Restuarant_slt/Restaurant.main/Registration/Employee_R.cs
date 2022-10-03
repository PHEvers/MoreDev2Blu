using Restaurant.main.Interfaces;
using Restaurant.main.Utility;
using Restaurant.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.main.Registration
{
    public class Employee_R : I_Menu_R
    {
        public void Add_R()
        {
            Console.Clear();
            Employee employee = new Employee();
            Console.WriteLine("Employee name: ");
            employee.Name = Console.ReadLine();

            Console.WriteLine("Employee Id: ");

            int id;
            Int32.TryParse(Console.ReadLine(), out id);
            employee.Id = id;

            Console.WriteLine("Employee Birth date: ");
            employee.Birth_day = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Employee gender: ");
            employee.Gender = Console.ReadLine();

            Console.WriteLine("Employee function: ");
            employee.Function = Console.ReadLine();

            Console.WriteLine("Employee Wage: ");
            Int32.TryParse(Console.ReadLine(), out id);
            employee.Wage = id;

            Program.Mock.Emplyoee_list.Add(employee);

        }

        public void Show_R()
        {
            Console.Clear();

            foreach (Employee employee in Program.Mock.Emplyoee_list)
            {
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("Employee Name: " + employee.Name);
                Console.WriteLine("           Id: " + employee.Id);
                Console.WriteLine("       Gender: " + employee.Gender);
                Console.WriteLine("     Birthday: " + employee.Birth_day);
                Console.WriteLine("     Function: " + employee.Function);
                Console.WriteLine("         Wage: " + employee.Wage);
                Console.WriteLine("-----------------------------------------\n");
            }
            Console.ReadLine(); ;
        }

        public int Menu_R()
        {
            int answer;

            Console.Clear();
            Console.WriteLine("--------------------");
            Console.WriteLine("---Menu Employeer---");
            Console.WriteLine("--------------------\n");

            Console.WriteLine(" 01 - Show employeers list");
            Console.WriteLine(" 02 - Add new employeer");

            Int32.TryParse(Console.ReadLine(),out answer);

            return answer;
        }
    }
}
