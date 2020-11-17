using System;
using System.Collections.Generic;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Employee Ember = new Employee("Ember", "Parr", "Worker Bee");
            Employee Justin = new Employee("Justin", "Adams", "Worker Bee");
            Employee Aiden = new Employee("Aiden", "Parr", "Boss Bee");

            List<Employee> DunderStaff = new List<Employee>();
            DunderStaff.Add(Ember);
            DunderStaff.Add(Justin);

            Company Dunder = new Company("Dunder Mifflin", DunderStaff);
        }
    }
}
