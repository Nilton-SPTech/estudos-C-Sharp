using System.Globalization;
namespace CotacaoDolar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ELE ESTÁ LENDO E FAZENDO E PASSANDO OS VALORES PARA OS DETERMINADOS ATRIBUTOS ESTÁTICOS
            Console.Write("Qual é a contação do dólar: ");
            ConversorDeMoeda.CotacaoDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("\nQuantos dólares você vai comprar?: ");
            ConversorDeMoeda.CompraDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //ESTÁ CHAMANDO O MÉTODO ESTÁTICO PARA CALCULAR A CONVERSÃO
            Console.Write("\nValor a ser pago em reais: ");
            Console.Write(ConversorDeMoeda.CalcularConversao()); 


        }
    }
}