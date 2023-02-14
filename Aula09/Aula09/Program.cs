namespace Aula09
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //SE DEIXAR DESSA MANEIRA COM O MÉTODO CONTRUTOR ELE DÁ ERRO 
            // POIS ELE NECESSITA DOS SEUS ARGUMENTOS
            // Produto produto = new Produto();    

            Console.WriteLine("*** Entre cos dados do Produto ***");

            Console.Write("Nome: ");
            string nome = Console.ReadLine();// variavel auxiliar para receber o dado

            Console.Write("\nPreço:");
            double preco = double.Parse(Console.ReadLine());// variavel auxiliar para receber o dado

            /*
             * TESTE SOBRECARGA DE MÉTODOS
            Console.Write("\nQuantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());// variavel auxiliar para receber o dado
            */
            //DA MANEIRA QUE FOI FEITA NA CLASSE ANTERIOR, O CONSTRUTOR OBRIGA ENTRAR COM OS DADOS

            // EXEMPLO SOBRECARGA DE MÉODOS
            Produto produto = new Produto(nome, preco); // CONSTRUTOR DE DOIS ARGUMENTOS

            Console.WriteLine("\nDados do produto " + produto);

            Console.Write("\nDigite o número de produtos a ser adicionando ao estoque: ");
            int qnt = int.Parse(Console.ReadLine());
            produto.AdicionarProduto(qnt);

            Console.WriteLine("\nDados do produto atualizado " + produto);

            Console.Write("\nDigite o número de produtos a ser removido do estoque: ");
            qnt = int.Parse(Console.ReadLine());
            produto.RemoverProdutos(qnt);

            Console.WriteLine("\nDados do produto atualizado" + produto);


            Produto produto2 = new Produto(nome, preco, 20); // CONSTRUTOR DE TRÊS ARGUMENTOS

            // MODO ALTERNATIVO DE ADICIONAR VALORES AOS ATRIBUTOS
            // FORMA DE INSTANCIAR O PRODUTO
            Produto p = new Produto() //FUNCIONA PERFEITAMENTE MESMO SEM CONSTRUTOR
            {
                Nome = "Televisão",
                Preco = 22.23,
                Quantidade = 90
            };
        }
    }
}