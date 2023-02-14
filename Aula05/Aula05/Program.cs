
using System.Globalization; 
namespace Aula05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double xA,xB,xC;
            double yA,yB,yC;

            Console.WriteLine("Entre com as medidas do triângulo X");

            string medidasX = Console.ReadLine();
            string[] trianguloX = medidasX.Split(' ');

            xA = double.Parse(trianguloX[0], CultureInfo.InvariantCulture);
            xB = double.Parse(trianguloX[1], CultureInfo.InvariantCulture);
            xC = double.Parse(trianguloX[2], CultureInfo.InvariantCulture);


            Console.WriteLine("\nEntre com as medidas do triângulo Y");

            string medidasY = Console.ReadLine();
            string[] trianguloY = medidasY.Split(' ');

            yA = double.Parse(trianguloY[0], CultureInfo.InvariantCulture);
            yB = double.Parse(trianguloY[1], CultureInfo.InvariantCulture);
            yC = double.Parse(trianguloY[2], CultureInfo.InvariantCulture);

            //CALCULANDO A AREA DO TRIANGULO x
            double p = (xA + xB + xC) / 2.0; 
            double areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));

            //CALCULANDO A AREA DO TRIANGULO y 
            p = (yA + yB + yC) / 2.0;
            double areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));

            Console.WriteLine($"Área de X = {areaX.ToString("F4", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Área de Y = {areaY.ToString("F4", CultureInfo.InvariantCulture)}");

            if(areaX > areaY)
            {
                Console.WriteLine("Maior área é X"); 
            }
            else{
                Console.WriteLine("Maior área é Y"); 
            }

        }
    }
}