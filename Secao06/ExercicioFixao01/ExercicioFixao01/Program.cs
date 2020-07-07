using ExercicioFixacao01.Entities;
using System;
using System.Globalization;

namespace ExercicioFixao01
{
    class Program
    {
        static void Main(string[] args)
        {
            Pencionato p = new Pencionato();

            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Alugel #" + (i + 1));
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Nº do Quarto: ");
                int numero = int.Parse(Console.ReadLine());

                p.Alugar(new Estudante { Nome = nome, Email = email }, numero);

                Console.WriteLine("");
            }

            int totalDeQuartos = p.TotalDeQuartos();

            Console.WriteLine("Quartos Ocupados:");

            for (int i = 0; i < totalDeQuartos; i++)
            {
                p.ImprimirQuartosOcupados(i);
            }
        }
    }
}
