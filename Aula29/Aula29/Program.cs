
using Aula29.Entities;
namespace Aula29
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
            //GETHASHCODE e EQUALS
            string a = "Maria";
            string b = "Maria ";

            //EQUALS
            Console.WriteLine(a.Equals(b)); // Devolve um boolean

            //GETHASHCODE
            //SE O CÓDIGO DOS DOIS OBJETOS FOREM DIFERENTES, OS DOIS OBJETOS SÃO DIFERENTES
            Console.WriteLine(a.GetHashCode()); //Devolve um código
            Console.WriteLine(b.GetHashCode());
            */

            Client a = new Client { Name = "Maria", Email = "maria@gmail" };
            Client b = new Client { Name = "Alex", Email = "alex@gmail" };

            Console.WriteLine(a.Equals("maria@gmail"));
        }
    }
}