using System;

namespace ExercicioFixacao01.Entities
{
    public class Pencionato
    {
        public Student[] Quartos = new Student[10];

        public void Alugar(Student student, int numeroDoQuarto)
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