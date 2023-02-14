namespace Aula10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Produto p = new Produto("TV", 500.00, 10);

            //EXEMPLO DE ENCAPSULAMENTO PROPERTIES 

            // FUNCIONA COMO UMA FORMA PRÁTICA E RÁPIDA DE ESCREVER OS MÉTODOS GET E SET
            // SE ASSEMALHA MUITO A ESCRITA QUANDO FAZEMOS SOMENTE PELO ATRIBUTO
            p.Nome = "TV 4K";
            Console.WriteLine(p.Nome);

            // EXEMPLO DE ENCAPSULAMENTO RAIZ 
            /*p.SetNome("TV 4k");
            Console.WriteLine(p.GetNome());*/


        }
    }
}