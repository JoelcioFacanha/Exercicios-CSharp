﻿using LerCotacaoDolar.Entities;
using System;
using System.Globalization;

namespace LerCotacaoDolar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar? ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Valor a ser pago em reais = " + ConversorDeMoeda.DolarParaReal(cotacao, quantia).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
