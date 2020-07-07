using ExercicioFixacao02.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExercicioFixacao02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());

            List<Employee> lista = new List<Employee>();
            int id = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Employee #" + i);
                Console.Write("Id: ");
                id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                lista.Add(new Employee(id, name, salary));

                Console.WriteLine("");
            }

            Console.Write("Enter the employee id that will have salary increase : ");
            id = int.Parse(Console.ReadLine());

            var employee = lista.Find(e => e.Id == id);

            if (employee != null)
            {
                Console.Write("Enter the percentage: ");
                double percentual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                employee.AumentarSalario(percentual);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine("");

            Console.WriteLine("Updated list of employees: ");

            foreach (var emp in lista)
            {
                Console.WriteLine(emp);
            }
        }
    }
}
