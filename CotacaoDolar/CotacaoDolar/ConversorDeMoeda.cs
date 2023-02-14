
namespace CotacaoDolar
{
    internal class ConversorDeMoeda
    {
        public static double CotacaoDolar;
        public static double CompraDolar;


        /// <summary>
        ///     Culadora de conversão de dólar para real
        /// </summary>
        /// <remarks>
        ///     ### Entrada ###
        ///     <list type="bullet">
        ///         <item>Atributo estático CotacaoDolar = representa o valor da cotação do dólar</item>
        ///         <item>Atributo estático CompraDolar= representa a quantidade de dólares</item>
        ///     </list>
        ///
        ///     ### Saída ###
        ///     <list type="bullet">
        ///         <item>Resultado da conversão = representa o valor de compra</item>
        ///     </list>
        /// 
        /// </remarks>
        /// <returns>Retorna totalComJuros que é o valor da conversão</returns>
        public static double CalcularConversao()
        {
            double totalSemJuros = CotacaoDolar * CompraDolar;
            double juros = .06;
            double totalComJuros = (totalSemJuros * juros) + totalSemJuros;

            return totalComJuros;
        }

    }
}
