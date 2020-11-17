using System;
using System.Collections.Generic;

namespace classes
{

    class Company
    {
        public string Name { get; set; }
        public DateTime DateFounded { get; set; }

        public List<Employee> Employees;
        public void ListEmployees(List<Employee> employees)
        {
            foreach (Employee employee in Employees)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName}");
            }
        }

        public Company(string name, List<Employee> employees)
        {
            Name = name;
            DateFounded = DateTime.Now;
            Employees = employees;
        }

    }





}