
namespace Aula16
{
    internal class Calculator
    {
        //TORNANDO DINÂMICO A INSERÇÃO DOS VALORE NO PARAMETRO

        //O PARAMS INFORMA QUE SERÁ PASSADO UMA SÉRIE DE VALORES
        /// <summary>
        ///     Método para somar quantidade indefinida de números
        /// </summary>
        /// <remarks>
        ///     É interessante ressaltar o uso do params nos parametros. 
        ///     Ele permite passar diversos valores sem precisar criar o vetor
        /// </remarks>
        /// <param name="numbers">Lista de números</param>
        /// <returns>Soma entre todos os números que foram passados no parametro</returns>
        public static int Sum(params int[] numbers) //PASSANDO UM VETOR NO PARAMETRO
        {
            int sum = 0; 

            for(int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i]; //SOMANDO DE ACORDO COM AS POSIÇÕES DO VETOR
            }
            return sum;
        }
    }
}
