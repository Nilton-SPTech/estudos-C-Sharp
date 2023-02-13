using System.Globalization; 

namespace Aula07
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Produto p = new Produto();

            Console.WriteLine("Entre os dados do produto: ");
            Console.Write("Produto: ");
            p.Nome = Console.ReadLine();

            Console.Write("\nPreço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("\nQuantidade: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);


            Console.WriteLine("Dados do produto: " + p);
        
        }
    }
}