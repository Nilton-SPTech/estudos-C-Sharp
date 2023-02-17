using Aula32.Entities;
namespace Aula32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* //HASHSET -> GETHASHCODE EQUALS
             HashSet<string> set = new HashSet<string>();

             //ADICIONANDO
             set.Add("Maria");
             set.Add("Alex");

             //O CONTAINS FUNCIONA COMO UM GetHashCode + Equals
             //ELE PERCORRE TODO O CONJUNTO 
             //E VALIDA SE HÁ COMPARAÇÕES
             Console.WriteLine(set.Contains("Maria"));
            */

            HashSet<Product> a = new HashSet<Product>();
            a.Add(new Product("TV", 900.00));
            a.Add(new Product("Geladeira", 9900.00));

            HashSet<Point> b = new HashSet<Point>();
            b.Add(new Point(3, 4));
            b.Add(new Point(9, 10));

            Product prod = new Product("Geladeira", 9900.00);

            //(Antes de manipular o override do Equals e GetHashCode) = DEVOLVE false
            //NESSE CONTEXTO, EMBORA OS DADOS SEJAM IGUAIS
            //O OBJ prod NÃO ESTÁ CONTIDO NO CONJUNTO DE a 
            //ESSA PESQUISA / VALIDAÇÃO É FEITA PELA REFÊRENCIA DE MEMÓRIA

            //(Depois de manipular o override do Equals e GetHashCode) = DEVOLVE true
            //O QUE ANTES A VALIDAÇÃO ERA FEITA SOMENTE PELO ESPAÇO DE MEMÓRIA DOS OBJETOS
            //AGORA É FEITA PELOS VALORE QUE ESTÃO NESSES OBJS
            //DESCONSIDERANDO SE É UM CONJUNTO OU SOMENTE UMA INSTANCIA
            Console.WriteLine(a.Contains(prod));

            //MESMO NÃO TENDO IMPLEMENDO A MUDANÇA NA CLASSE Point
            //ELE VAI FAZER A COMPARAÇÃO POR CONTEUDO E NÃO MAIS POR REFERENCIA
            //IGUAL AO EXEMPLO DE CIMA 
            Point p = new Point(3, 4);
            Console.WriteLine(b.Contains(p));
        }
    }
}