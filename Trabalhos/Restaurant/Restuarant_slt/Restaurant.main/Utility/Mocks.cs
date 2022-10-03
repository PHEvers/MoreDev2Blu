using Restaurant.model;
using Restaurant.model.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.main.Utility
{
    public class Mocks
    {
        public List<Employee> Emplyoee_list { get; set; }
        public List<Client> Client_list { get; set; }

        public Mocks()
        {
            Emplyoee_list = new List<Employee>();
            Client_list = new List<Client>();
        }

        public void Mocks_charge()
        {
            
        }

        public void Employee_charge()
        {
            for (int i = 0; i < 3; i++)
            {
                Employee employee = new Employee($"Emplye {i + 1}", i + 101, "None", DateTime.Now, "Worker", 1212);
                Emplyoee_list.Add(employee);
            }
                
        }
        
    }
}
