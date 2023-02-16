

namespace Aula23.Entities
{
    //HERANÇA -> ELA HERDA OS ATRIBUTOS E MÉTODOS
    internal class BusinessAccount : Account
    {
        public double LoanLimit { get; set; }

        public BusinessAccount() { }

        //PASSANDO OS VALORES DO CONSTRUTOR DA SUPER CLASSE
        public BusinessAccount(int number, string holder, double balance, double loanLimit) : base(number, holder, balance)
        {

            LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;
            }
        }
    }
}
