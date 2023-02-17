using System.IO;
using Aula33.Entities;
namespace Aula33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<LogRecord> set = new HashSet<LogRecord>();

            Console.WriteLine("Entre com o caminho do arquivo");
            string path = Console.ReadLine();
            //path = c:\temp\login.txt

            try
            {
                using (StreamReader sr = File.OpenText(path)) {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(' ');
                        string name = line[0];
                        DateTime instant = DateTime.Parse(line[1]);
                        set.Add(new LogRecord {Username = name, Instant = instant});
                    }

                    Console.WriteLine("Total de usuarios: " + set.Count);
                }
            }
            catch(IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}