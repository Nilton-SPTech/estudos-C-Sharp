using System.Drawing;
using System.Globalization;
namespace Aula11
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //PRIMEIRA PARTE DO CÓDIGO
            Console.Write("Entre o número da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string titularConta = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)?"); 
            string depositoInicial = Console.ReadLine();

            double valorDeposito = 0;

            if(depositoInicial == "s")
            {
                Console.Write("Entre o valor de depósito inicial: ");
                valorDeposito= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            Conta c = new Conta(numeroConta, titularConta, valorDeposito);

            Console.WriteLine("Dados da conta: \n" + c);

            int opcao = 1;
            while(opcao != 0)
            {
                Console.WriteLine("\nDigite qual ferramenta deseja usar: " +
                    "\n0 - Finalizar funcionalidade" +
                    "\n1 - Depósitar" +
                    "\n2 - Sacar");
                opcao = int.Parse(Console.ReadLine());

                double valor; 
                if(opcao == 1)
                {
                    //MÉTODOS DE ENTRADA E SAÍDA DE SALDO
                    //DEPÓSITO
                    Console.Write("Entre um valor para depósito: ");
                    valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    c.Deposito(valor);
                    Console.WriteLine("Dados da conta atualizados:\n" + c);
                }
                else if(opcao == 2){
                    //SAQUE
                    Console.Write("Entre um valor para Saque: ");
                    valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    c.Saque(valor);
                    Console.WriteLine("Dados da conta atualizados:\n" + c);

                }
                else if(opcao == 3) {
                    break; 
                }
            }
            Console.WriteLine("Dados da conta atualizados:\n" 
                + c 
                + "\nObrigado!");
        }
    }
}