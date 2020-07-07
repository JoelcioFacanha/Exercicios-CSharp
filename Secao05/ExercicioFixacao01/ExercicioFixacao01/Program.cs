using ExercicioFixacao01.Entities;
using System;
using System.Globalization;

namespace ExercicioFixacao01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char haveraDeposito = char.Parse(Console.ReadLine());

            Conta c;
            double valor = 0.0;

            if (haveraDeposito.Equals('S'))
            {
                Console.Write("Entre o valor de depósito inicial: ");
                valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                c = new Conta(numero, titular, valor);
            }
            else
            {
                c = new Conta(numero, titular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(c);

            Console.WriteLine();

            Console.Write("Entre um valor para depósito: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.Depositar(valor);

            Console.WriteLine();

            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(c);

            Console.WriteLine();

            Console.Write("Entre um valor para saque: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.Sacar(valor);

            Console.WriteLine();
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(c);
        }
    }
}
