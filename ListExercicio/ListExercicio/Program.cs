using System.Collections.Generic;
using System.Globalization;

//CONTINUAR ESTUDOS
namespace ListExercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos funcionários você deseja registrar? ");
            int qnt = int.Parse(Console.ReadLine());


            List<Funcionario> list = new List<Funcionario>();

            int id;
            string nome;
            double salario;
            int i; 
            for (i = 0; i < qnt; i++)
            {
                Console.WriteLine("Funcionario #" + (i + 1));

                Console.Write("Id: ");
                id = int.Parse(Console.ReadLine());

                Console.Write("Nome: ");
                nome = Console.ReadLine();

                Console.Write("Salário: ");
                salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                list.Add(new Funcionario(id, nome, salario));

                Console.WriteLine();
            }

            Console.Write("Entre com o Id do funcionario para adicionar o salário: ");
            int idInformado = int.Parse(Console.ReadLine());

            //int posicao = list.FindIndex(x => x[0] == id);
            int posicao = 0;
            bool validarId = false;
            double salarioAtual = 0; 
            foreach(Funcionario f in list)
            {
                int idAtual = f.Id;
                if(idAtual == idInformado)
                {
                    validarId = true;
                    salarioAtual = f.Salario;

                    Console.Write("Entre com o percentual de adição: ");
                    double porcentagem = double.Parse(Console.ReadLine());

                    double novoSalario = Funcionario.AcrescimoSalario(salarioAtual, porcentagem);
                    
                    f.Salario = novoSalario;
                    Console.WriteLine("\nAtualização da lista de funcionarios");
                    break;
                }
                posicao++;
            }

            foreach(Funcionario f in list)
            {
                Console.WriteLine(f.Id + ", " + f.Nome + ", " + f.Salario);
            }
        }
    }
}