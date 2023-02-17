using System.Collections.Generic;

namespace Aula31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SortedSet FUNCIONA COMO UMA ÁRVORE + VETOR

            //CRIANDO O OBJ E PASSANDO OS VALORES DA INCLUSÃO
            SortedSet<int> a = new SortedSet<int> 
                { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            SortedSet<int> b = new SortedSet<int>
                { 5,6,7,8,9,10, 11, 12, 13};


            //union UNIÃO DE CONJUNTOS

            //INSTANCIANDO UM CONJUNTO c E INSERINDO NELE TODOS OS VALORES DO CONJUNTO a
            //c = CONJUNTO UNIÃO
            SortedSet<int> c = new SortedSet<int>(a);

            //ESTÁ INSERINDO EM c TODOS OS ELEMENTOS DE b, MAS SOMENTE OS QUE O CONJUNTO c AINDA NÃO TEM 
            c.UnionWith(b);

            // Intersection ELEMENTOS QUE EXISTEM NOS DOIS CONJUNTOS
            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(b);

            //difference DIFERENÇA ENTRE OS CONJUNTOS 
            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b);

            PrintCollecion(e);
        }

        //IEnumerable É UMA INTERFACE DO System.Collections.Generic
        //ELE SERVE PARA PERCORRER COLEÇÕES DE UMA FORMA PADRONIZADA 

        //PONTOS IMPORTANTES DESSE MÉTODO
        // 1. ELE É ESTÁTICO, ENTÃO NÃO PRECISA CRIAR UM OBJ PARA UTILIZAR ELE
        // 2. ELE É GENERICO, ENTÃO PODE SER USADO COM OUTROS TIPO DE VARIAVEIS <T>
        // 3. ELE PADRONIZA O CAMINHO PARA PERCORRER COLEÇÕES IEnumerable
        static void PrintCollecion<T>(IEnumerable<T> collecion)
        {
            //O FOREACH VAI FUNCIONAR ENSIMA DE COLEÇÕES QUE IMPLEMENTAM O IEnumerable
            //ELE VAI PROCURAR O ENUMERATOR QUE RETORNA DO IEnumerable

            //TIPOS DE COLEÇÕES QUE ELE PERCORRE: SortedSet, List, HashSet
            foreach (T t in collecion)
            {
                Console.Write(t + " ");
            }
            Console.WriteLine();
        }
    }
}