using System;
using System.Globalization;

namespace Aula03
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
			 *Saída
			//toString() manipula a quantidade de casas decimais 
			double saldo = 10.92090; 
			Console.WriteLine(saldo.ToString("F2", CultureInfo.InvariantCulture));

			//PARA USAR O CultureInfo.InvariantCulture precisa usar o namespace System.Globalization
			*/

            int idade = 32;
            string nome = "Manuel";

            //Placeholder 
            //Console.WriteLine("Usando Placeholder");
            //Console.WriteLine("{0} tem {1:F2} anos de idade", nome, idade);

            //Interpulação 
            /*Console.WriteLine("Usando Interpulação");
			Console.WriteLine($"{nome} tem {idade:F1} anos de idade");*/

            //Concatenação 
            /*Console.WriteLine("Usando Concatenação");
            Console.WriteLine(nome + " tem " + idade.ToString("F2", CultureInfo.InvariantCulture) + " anos de idade");*/

            // ---------------------------------------------

            //Conversão implicita entre tipos
            /*double a;
            int b;

            a = 5.1;
            //Casting é a conversão explicita  
            b = (int)a; 

            Console.WriteLine(b);

            int c = 5;
            int d = 2;

            double resultado = (double)c / d; 
            Console.WriteLine(resultado);*/

            // ---------------------------------------------

            /*// Criando a formula de baskara 
            double a = 1.0, b = -3.0, c = -4.0;

            double delta = Math.Pow(b, 2.0) - 4.0 * a * c;

            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);
            Console.WriteLine(delta);
            Console.WriteLine(x1);
            Console.WriteLine(x2);*/

            /*//Entrada de dados 
            string frase = Console.ReadLine();

            string x = Console.ReadLine();  
            string y = Console.ReadLine();
            string z = Console.ReadLine();


            Console.WriteLine("Escreva algumas palavras");
            string s = Console.ReadLine();
            string[] vet = s.Split(' '); 
            string p1 = vet[0];
            string p2 = vet[1];
            string p3 = vet[2];
            Console.WriteLine("Palavras que você digitou {0} - {1} - {2}", p1, p2, p3);

            Console.WriteLine("Você digitou as palavras");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);*/

            /*//Entrada de dados conversão 

            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Você digitou: " + n1);

             
            char ch = char.Parse(Console.ReadLine());
            Console.WriteLine(ch);*/

            float soma = Somar(10,30);
            Console.WriteLine(soma);
        }


        /// <summary>
        ///     <c>Método</c> para somar dois números
        /// </summary>
        ///     <remarks>
        ///     ### Como utilizar esse método ###
        ///     <list type="bullet">
        ///     <item>Utilize esse método para somar números</item>
        ///     </list>
        ///     
        ///     ## Exemplo de entradas e saídas ###
        ///     <code>
        ///         float <paramref name="num1"/> = 10, <paramref name="num2"/> = 30.3; 
        ///         return num1 + num2;
        ///     </code>
        /// </remarks>
        /// <param name="num1">Primeiro número da soma</param>
        /// <param name="num2">Segundo número da soma</param>
        /// <returns>O resultado da soma entre os dois parameters</returns>
        static float Somar(float num1, float num2)
        {
            return num1 + num2;
        }
    }
}