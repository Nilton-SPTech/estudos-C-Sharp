using System.IO;
namespace Aula27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\teste.txt"; //PASSANDO O CAMINHO DO ARQUIVO

            try
            {
                //ELE FAZ O USO DO FileStream E AO FINAL DESSE BLOCO FECHA AUTOMATICAMENTE
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }
            catch (IOException e) //TRATAMENTO DA SEÇÃO
            {
                Console.WriteLine("Error! " + e.Message);
            }
        }
    }
}