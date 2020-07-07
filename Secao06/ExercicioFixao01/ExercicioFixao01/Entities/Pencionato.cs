﻿using System;

namespace ExercicioFixacao01.Entities
{
    public class Pencionato
    {
        public Estudante[] Quartos = new Estudante[10];

        public void Alugar(Estudante student, int numeroDoQuarto)
        {
            Quartos[numeroDoQuarto] = student;
        }

        private bool QuartoEstaOcupado(int numeroDoQuarto)
        {
            return Quartos[numeroDoQuarto] != null;
        }

        public int TotalDeQuartos()
        {
            return Quartos.Length;
        }

        public void ImprimirQuartosOcupados(int numero)
        {
            if (QuartoEstaOcupado(numero))
            {
                Console.WriteLine(numero + ":" + Quartos[numero].Nome + ", " + Quartos[numero].Email);
            }
        }
    }
}