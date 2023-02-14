using System.Globalization;

namespace Aula09
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        // MÉTODOS CONSTRUTORES SÃO IMPORTANTES NA HORA DE INSTANCIAR AS CLASSES
        // POIS ELE OBRIGA O PREENCHIMENTO DOS SEUS PARAMETROS 
        // CONSTRUTOR E ARGUMENTOS
        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        //SEGUNDO CONSTRUTOR SOBRECARGA DE MÉTODOS 

        //SOBRECARGA DE MÉTODOS É O MESMO MÉTODO PORÉM RECEBE PARAMETROS DIFEREFENTES 
        //PODEMOS FAZER "MUITAS" SOBRECARGAS DE MÉTODOS
        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = 0;
        }
        //CONSTRUTOR PADRÃO (SOBRECARGA DE MÉTODOS)
        public Produto() { }

        /// <summary>
        ///     Calcula o valor total dos produtos
        /// </summary>
        /// <remarks>
        ///     <list type="bullet">
        ///         <item>O valor total é calulado pelo Preco * Quantidade</item>
        ///     </list>
        /// </remarks>
        /// <returns>Calculo do Total do Estoque: Preco * Quantidade</returns>
        public double ValorTotalEstoque()
        {
            return Preco * Quantidade;
        }

        /// <summary>
        ///     Adicionar Produtos ao Estoque
        /// </summary>
        /// <remarks>
        ///     <list type="bullet">
        ///         <item>O parameter quantidade é adicionado ao atributo Quantidade da Classe</item>
        ///     </list>
        ///     
        ///</remarks>
        /// <param name="quantidade">Quantidade de produtos para adicionar</param>
        public void AdicionarProduto(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            string texto = Nome
                    + ", $ "
                    + Preco.ToString("F2", CultureInfo.InvariantCulture)
                    + ", "
                    + Quantidade
                    + " unidade, Total: $ "
                    + ValorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture);
            return texto;
        }
    }
}
