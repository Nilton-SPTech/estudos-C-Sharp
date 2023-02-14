using System.Globalization;

namespace Aula11
{
    internal class Conta
    {
        private int _numeroConta;
        private double _saldo;
        public string TitularConta { get; set; }

        public double Saldo
        {
            get { return _saldo; }
            set {
                if (value >= 0) {
                    _saldo = value;
                 }; 
            }
        }
        public Conta(int numeroConta, string titularConta, double saldo)
        {
            _numeroConta= numeroConta;
            TitularConta = titularConta;
            _saldo= saldo;
        }

        public void Deposito(double valor)
        {
            _saldo += valor; 
        }

        public void Saque(double valor)
        {
            if(_saldo > 0)
            {
                if(valor < _saldo)
                {
                    _saldo -= valor + 5;
                }

            }
        }
        public override string ToString()
        {
            return "Conta: "
                + _numeroConta
                +", Titular: "
                +TitularConta
                +", Saldo: $"
                +_saldo.ToString("F2");
        }

    }
}
