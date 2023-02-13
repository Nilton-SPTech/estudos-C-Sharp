using System.Globalization;
namespace Aula07
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade; 

    
        //ESTÁ CALCULANDO O VALOR TOTAL NO ESTOQUE
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        // Esse método transforma um obj em String
        // override é a sobreposição de uma função
        public override string ToString()
        {
            string mensagem =  Nome 
                + ", $ " 
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);

            return mensagem;
        }

    }
}
