using System.IO;

namespace Aula26
{
    internal class Program
    {
        //UTILIZANDO O StreamReader PARA FAZER LEITURA DE ARQUIVOS 
        //ELE LÊ CADA LINHA DO ARQUIVO .txt
        static void Main(string[] args)
        {
            string path = @"c:\temp\teste.txt"; //PASSANDO O CAMINHO DO ARQUIVO

            StreamReader sr = null; //CRIANDO O OBJ 

            try
            {
                sr = File.OpenText(path); //PASSANDO O CAMINHO E USANDO CRIANDO UM NEW OBJ

                while (!sr.EndOfStream) //LAÇO PARA PERCORRER TODAS AS LINHAS DO ARQUIVO
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            }
            catch(IOException e) //MOSTRA O ERRO
            {
                Console.WriteLine("An error accurred");
                Console.WriteLine(e.Message);
            }
            finally //QUANDO TUDO FOR FINALIZADO ELE FECHA A LEITURA DO StreamReader
            {
                if(sr != null) sr.Close();
            }
        }
    }
}