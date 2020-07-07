using System.Globalization;

namespace ExercicioFixacao01.Entities
{
    public class Conta
    {
        public string _titular;
        public int Numero { get; private set; }
        public double Saldo { get; private set; }

        public Conta(int numero, string titular)
        {
            _titular = titular;
            Numero = numero;
        }

        public Conta(int numero, string titular, double valor)
            : this(numero, titular)
        {
            Saldo = valor;
            _titular = titular;
            Numero = numero;
        }

        public string Titular
        {
            get { return _titular; }
            set { _titular = value; }
        }

        public void Sacar(double valor)
        {
            Saldo -= valor + 5.0;
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
        }

        public override string ToString()
        {
            return "Conta "
                + Numero
                + ", Titular: "
                + Titular
                + ", Saldo: R$ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
