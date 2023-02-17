using System.Collections.Generic;
namespace Aula30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CONJUNTOS HashSet
            //GUARDA ELEMENTOS DE FORMA DESORDANADA MAS A PESQUISA E ADICIONAR É MUITO VELOZ
            //LEMBRA MUITO UM VETOR, MAS ELE NÃO TEM POSIÇÕES 

            HashSet<string> set = new HashSet<string>
            {
                //ADICIONANDO ELEMENTOS DENTRO DO CONJUNTO
                "Tv",
                "Notebook",
                "Celular"
            }; //INSTANCIANDO O CONJUNTO

            //VERIFICANDO SE A PESQUISA CONTÉM NO CONJUNTO
            Console.WriteLine(set.Contains("Tv"));


            
        }
    }
}