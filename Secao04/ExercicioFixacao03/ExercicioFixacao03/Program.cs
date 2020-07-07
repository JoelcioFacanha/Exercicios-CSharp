using ExercicioFixacao03.Entities;
using System;
using System.Globalization;

namespace ExercicioFixacao03
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a = new Aluno();

            Console.Write("Nome: ");
            a.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");
            Console.Write("Nota 1: ");
            a.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Nota 2: ");
            a.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Nota 3: ");
            a.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();

            Console.WriteLine(a);
        }
    }
}