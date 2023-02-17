namespace Aula34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EXTESIONS
            //FUNCIONA COMO UM MÉTODO PERSONALIZADO PARA CLASSES NATIVAS DO C#
            //PODEMOS CRIAR NOVAS VARIANTES OU MÉTODOS PARA AS CLASSES

            string s1 = "Nossa, Extensions é muito MANEIRO!!!";

            Console.WriteLine(s1.Cut(10));
        }
    }
}