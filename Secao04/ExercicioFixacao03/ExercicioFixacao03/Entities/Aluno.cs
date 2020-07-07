using System.Globalization;
using System.Text;

namespace ExercicioFixacao03.Entities
{
    public class Aluno
    {
        private static double QTDE_PONTOS = 60.0;

        public string Nome { get; set; }
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        public double Nota3 { get; set; }

        public double NotaFinal()
        {
            return Nota1 + Nota2 + Nota3;
        }

        private double FaltaPontos()
        {
            return QTDE_PONTOS - NotaFinal();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("NOTA FINAL: " + NotaFinal().ToString("F2", CultureInfo.InvariantCulture) + "\n");

            if (NotaFinal() >= QTDE_PONTOS)
            {
                sb.Append("APROVADO");
            }
            else
            {
                sb.Append("REPROVADO\n");
                sb.Append("FALTARAM " + FaltaPontos().ToString("F2", CultureInfo.InvariantCulture) + " PONTOS");
            }

            return sb.ToString();
        }
    }
}