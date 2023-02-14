using System.Globalization;

namespace Aula15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EXEMPLO DE VETOR COM OBJETO DO TIPO REFERÊNCIA 
            int n = int.Parse(Console.ReadLine());

            Produto[] vect = new Produto[n];

            for(int i = 0 ; i < n; i++)
            {
                string name = Console.ReadLine();   
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                vect[i] = new Produto { Name = name, Price = price };
            }

            double sum = 0; 

            for(int i = 0; i < n; i++)
            {
                sum += vect[i].Price;
            }

            double avg = sum / n;
            Console.WriteLine(avg);
        }
    }
}