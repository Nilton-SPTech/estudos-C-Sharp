namespace Aula16
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //PASSANDO OS VALORES PARA O VETOR
            int result = Calculator.Sum(new int[] { 10, 20, 30, 80 });

            //MELHORANDO O CÓDIGO
            int result2 = Calculator.Sum(2, 8, 9); // FACILITA O MÉTODO DE ESCRITA
        }
    }
}