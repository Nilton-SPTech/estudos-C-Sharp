using System.Globalization;

namespace Aula10
{
    internal class Produto
    {
        //*** ** **  ATRIBUTOS *** ** ** 
        //EXEMPLO DE AUTO PROPERTIES
        private string _nome;
        private int _quantidade;

        //*** ** **  PROPRIEDADE AUTOIMPLEMENTADA *** ** ** 
        public double Preco { get; private set;}

        // *** ** ** CONSTRUTORES *** ** ** 
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            _quantidade = quantidade;
        }

        public Produto() { }

        // *** ** ** PROPIEDADES CUSTOMIZADAS *** ** ** 
        // EXEMPLO DE PROPERTIES 
        //PROPERTIES É UM FORMATO SIMPLIFICADO DO GET E SET
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public int Quantidade
        {
            get { return _quantidade; }
        }
        // EXEMPLO DE ENCAPSULAMENTO POO comum
        /*
        // PARA MOSTRAR O ATRIBUTO PRIVADO USAMOS UM MÉTODO GET
            public string GetNome()
            {
                return _nome;
            }
            public double GetPreco()
            {
                return _preco;
            }
            public int GetQuantidade()
            {
                return _quantidade;
            }
        // ELE ATRIBUI VALORES AO ATRIBUTO PRIVADO
            public void SetNome(string nome)
            {
                _nome = nome;
            }
        */




        // *** ** ** MÉTODOS *** ** ** 

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
            return Preco * _quantidade;
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
            _quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }

        public override string ToString()
        {
            string texto = _nome
                    + ", $ "
                    + Preco.ToString("F2", CultureInfo.InvariantCulture)
                    + ", "
                    + _quantidade
                    + " unidade, Total: $ "
                    + ValorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture);
            return texto;
        }
    }
}

