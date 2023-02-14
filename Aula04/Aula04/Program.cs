using System.Globalization;

namespace Aula04
{
	class Program
	{

		//Estrutura de repetição WHILE
		/*static void Main(string[] args)
		{
			Console.WriteLine("Digite um número"); 
			double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (x >= 0)
			{
				double raiz = Math.Sqrt(x);
				Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));

				Console.WriteLine("\nDigite um número");
				x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
			}
			Console.WriteLine("Número negativo");
		}*/

		//ESTRUTURA DE REPETIÇÃO FOR 
		static void Main(string[] args)
		{
			Console.WriteLine("Qual a quantidade dos números que você quer digitar: ");

			int num = int.Parse(Console.ReadLine());

			double soma = 0; 
			for(int i = 0; i < num; i++)
			{
				Console.WriteLine($"\n{i + 1} - Digite um número: ");

				soma += double.Parse(Console.ReadLine());
			}

			Console.WriteLine($"\nA soma de todos os números é: {soma.ToString("F2", CultureInfo.InvariantCulture)}");
		}
	}
}