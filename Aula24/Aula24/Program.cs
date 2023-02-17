namespace Aula24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ESTRUTURA TRY CATCH

            //TRY
            //CONTÉM O CÓDIGO QUE REPRESENTA A EXECUÇÃO NORMAL DO TRECHO 
            //MAS VAI TER ALGUM COMANDO QUE PODE ACARRETAR UMA EXCEÇÃO 

            //CATCH 
            //CÓDIGO A SER EXECUTADO CASO UMA EXCEÇÃO OCORRA
            //DEVE SER ESPECIFICADO O TIPO DA EXCEÇÃO A SER TRATADA 
            try
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                int result  = n1 / n2;

                Console.WriteLine(result);
            }
            catch(DivideByZeroException e) //SE TRATA DO TIPO ESPECIFICO DA EXCEÇÃO 
            {
                Console.WriteLine("Error! " + e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine("Erro de formatação: ERROR! " + e.Message);
            }

            //AS EXCEÇÕES SÃO EM DIVERSOS TIPO
            /*
            A MAIS GENÉRICA 
            Exception -> casa com qualquer tipo de exceção 

            ESPECIFICA 
            DivideVyZeroException -> Exceção quando tenta dividir por zero 
            
             É BOM COLOCAR A EXCEÇÃO ESPECIFICA, POIS FACILITA NO ENTENDIMENTO
             */

            //FINALLY

            /*
             ELE ACONTECE MESMO SE ACONTECER OU NÃO UMA EXCEÇÃO 
             GERALMENTE É USADO PARA SITUAÇÕES ONDE PRECISA FECHAR ARQUIVOS OU FINALIZAR A COMUNICAÇÃO ENTRE O BANCO
             ELE FICA LOCALIZADO DEPOIS DO CATCH E SUA ESTRUTURA É SEMELHANTE COM O TRY
             */

        }
    }
}