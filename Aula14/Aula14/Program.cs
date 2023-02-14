using System.Globalization;
namespace Aula14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // MANIPULAÇÃO DE VETOR
            int n = int.Parse(Console.ReadLine()); // Tamanho do vetor

            double[] vect = new double[n]; //Criando o vetor

            for (int i = 0; i < n; i++)
            {
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double sum = 0

            for(int i = 0; i < n; i++)
            {
                sum += vect[i];
            }

            double avg = sum / n;

            Console.WriteLine(avg);
        }
    }
}