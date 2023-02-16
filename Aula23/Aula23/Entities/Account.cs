

namespace Aula23.Entities
{
    internal class Account
    {
        public int Number{ get; set; }
        public string Holder{ get; set; }
        public double Balance{ get; set; }

        public Account() { }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public void Withdraw(double amount)
        {
            Balance -= amount;   
        }

        public void Depoist(double amount) 
        {
            Balance += amount;
        }  
    }
}
