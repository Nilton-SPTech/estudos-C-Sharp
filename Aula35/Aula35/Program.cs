using System.Collections.Generic;
using System.Linq;
using Aula35.Entities; 

namespace Aula35
{
    internal class Program
    {
        //MÉTODO GENÉRICO PARA APRESENTAR A PESQUISA NO CONSOLE
        static void Print<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);
            foreach(T obj in collection)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            //OBJ PARA REPRESENTAR A CONSULTA
            Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2};
            Category c2 = new Category() { Id = 2, Name = "Computers", Tier = 1 };
            Category c3 = new Category() { Id = 3, Name = "Electronics", Tier = 1 };

            //List PARA REPRESENTAR A CONSULTA
            List<Product> products = new List<Product>()
            {
                new Product() { Id = 1,Name = "Computer", Price = 1100.0, Category = c2},
                new Product() { Id = 2,Name = "TV", Price = 2100.0, Category = c3},
                new Product() { Id = 3,Name = "Notebook", Price = 3400.0, Category = c2},
                new Product() { Id = 4,Name = "Marreta", Price = 50.0, Category = c1}
            };

            //DÁ PARA USAR PALAVRAS RESERVADAS DO SQL PARA FAZER A CONSULTA EM LIST
            //OU QUERY
            var q1 = 
                from p in products
                where p.Category.Tier == 2 && p.Price > 900
                select p;
            
            //Print() É O MÉTODO ESTÁTICO PARA ESCREVER NO CONSOLE
            Print("TIER 2 AND PRICE > 900", q1);    
        }
    }
}