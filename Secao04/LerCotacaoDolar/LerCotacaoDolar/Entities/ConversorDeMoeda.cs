namespace LerCotacaoDolar.Entities
{
    public static class ConversorDeMoeda
    {
        public static double IOF = 6.0;
        public static double DolarParaReal(double cotacao, double quantia)
        {
            double total = (cotacao * quantia);
            return total += total * IOF / 100;
        }
    }
}
