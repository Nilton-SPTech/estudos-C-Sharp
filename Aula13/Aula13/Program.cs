namespace Aula13
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
                //NULLABLE DEIXA TIPO VALOR NULL

                //double x = null; 
                //JEITO ERRADO
                Nullable <double> x = null;

                //JEITO CORRETO
                double? y = null;
                double? z = 10.0;

                //ESSA FUNÇÃO PEGA O VALOR QUE TEM NA VAR OU O VALOR INICIAL DELA(que no caso é zero 0)
                Console.WriteLine(x.GetValueOrDefault());
                Console.WriteLine(z.GetValueOrDefault());

                // VERIFICA SE NA VAR TEM ALGUM VALOR E DEVOLVE UM BOOLEANO
                Console.WriteLine(x.HasValue);
                Console.WriteLine(z.HasValue);

                // ELA PEGA O VALOR DIRETO DA VAR
                Console.WriteLine(x.Value); // MAS DEVOLVE UM ERRO CASO ESTEJA VAZIO 
                Console.WriteLine(z.Value); 
            */

            double? x = null; 
            double? y = 10;

            //OPERADOR DE QUALICENCIA NULA 
            //SEMLHANTE AO IF / ELSE
            double a = x ?? 5; // SE x FOR null ENTÃO A VAR RECEBE 5 
            double b = y ?? 5;

            Console.WriteLine(a);
            Console.WriteLine(b);


        }
    }
}