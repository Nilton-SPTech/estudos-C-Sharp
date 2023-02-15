namespace Aula19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //CRIANDO UMA MATRIZ
            double[,] mat = new double[2, 3];

            Console.WriteLine(mat.Length);

            //QUANTIDADE DE LINHAS 
            Console.WriteLine(mat.Rank);

            //QUANTIDADE DE LINHAS E COLUNAS
            Console.WriteLine(mat.GetLength(0));
            */

            int n = int.Parse(Console.ReadLine());

            int[,] mar = new int[n, n];

            for(int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for(int j = 0; j < n; j++)
                {
                    mar[i, j] = int.Parse(values[j]); 
                }
            }

            Console.WriteLine("Diagonal principal: ");
            for(int i = 0 ; i < n; i++)
            {
                Console.Write(mar[i, i] + " ");
            }
            Console.WriteLine();

            int contagem = 0; 
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if (mar[i,j] < 0)
                    {
                        contagem++;
                    }
                }
            }

            Console.WriteLine("Números negativos: " + contagem);
        }
    }
}