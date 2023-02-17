namespace Aula30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //É UM CONJUNTO DESORDENADO 
            //FUNCIONA COMO O VETOR
            HashSet<string> set = new HashSet<string>(); //O PROCESSAMENTO DELE É MUITO RÁPIDO

            //ADICIONANDO 
            set.Add("a");
            set.Add("b");
            set.Add("c");

            //FAZENDO COMPARAÇÃO PARA VER SE CONTÉM O VALOR QUE ESTOU PESQUISANDO
            Console.WriteLine(set.Contains("a"));

            //COMO O CONJUNTO NÃO TEM NOÇÃO DE POSIÇÃO, NÃO PODE USAR UM FOR
            //TEM QUE USAR UM FOREACH PARA ANALISAR CADA ELEMENTO
            foreach(string p in set)
            {
                Console.WriteLine(p);
            }
        }
    }
}