using System.Globalization; 
namespace Aula06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangulo x, y; 
            x = new Triangulo();
            y = new Triangulo();

            // PEGANDO AS MEDIDAS DO TRIANGULO X
            Console.WriteLine("Entre com as medidas do Triângulo X: ");
            string medidas = Console.ReadLine();
            string[] vet = medidas.Split(' '); 
            x.A = double.Parse(vet[0], CultureInfo.InvariantCulture);
            x.B = double.Parse(vet[1], CultureInfo.InvariantCulture);
            x.C = double.Parse(vet[2], CultureInfo.InvariantCulture);

            // PEGANDO AS MEDIDAS DO TRIANGULO Y
            Console.WriteLine("Entre com as medidas do Triângulo Y: ");
            medidas = Console.ReadLine();
            vet = medidas.Split(' ');
            y.A = double.Parse(vet[0], CultureInfo.InvariantCulture);
            y.B = double.Parse(vet[1], CultureInfo.InvariantCulture);
            y.C = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine(x.CalcularArea());
            Console.WriteLine(y.CalcularArea());


        }
    }
}