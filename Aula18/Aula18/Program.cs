//ESSA IMPORTAÇÃO FAZ PARTE DO USO DAS LISTAS 
using System.Collections.Generic;

namespace Aula18
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //TAMANHO DA LISTA É VARIAVÉL

            //A LISTA FUNCIONA COMO UM VETOR
            //MAS NÃO TEMOS QUE PASSAR O TAMANHO E ELA INICIA SENDO VAZIA = NULL
            List<string> list = new List<string>();

            //COLANDO VALORES DENTRO DA LISTA AO INSTANCIAR 
            //List<string> list2= new List<string> { "Maria", "Alex"};


            //ADD - Adicionar
            list.Add("Maria"); //ADICIONANDO UM ELEMENTO DO TIPO DA LISTA 
            list.Add("Alex");
            list.Add("Willian");
            list.Add("Williana");
            list.Add("Anna");
            //MOSTRANDO OS ELEMENTOS QUE FORAM ADICIONANDOS
            foreach(string obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
            //INSERT - posso definir a posição da onde quero inserir o elemento
            list.Insert(2, "Nilton"); //VAI ADICIONAR O ELEMENTO NA POSIÇÃO DEFINIDA

            //ELE NÃO EXCLUÍ OS ELEMENTOS QUE ESTÃO NA POSIÇÃO, SÓ EMPURRA ELES PARA BAIXO

            foreach(string s in list)
            {
                Console.WriteLine(s);
            }

            //TAMANHO DA LISTA 
            int tamanho = list.Count;
            Console.WriteLine();
            //FUNÇÃO Find

            //ELA RECEBE COMO ARGUMENTO UMA FUNÇÃO QUE FAZ UM TESTE
            //MAS PODEMOS CRIAR UMA FUNÇÃO LAMBIDA (Uma função resumida dentro dos parenteses)
            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine(s1);

            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine(s2);

            //ENCONTRANDO A POSIÇÃO
            //PRIMEIRA POSIÇÃO
            int pos1 = list.FindIndex(x => x[0] == 'A');

            //ÚLTIMA POSIÇÃO
            int pos = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine(pos1);

            //FILTRAR A LISTA
            //PARA FILTRAR UMA LISTA COM OS PARAMETROS DA PESQUISA QUE QUEREMOS 
            //PRECISAMOS CRIAR UM NOVO OBJ DO TIPO List E CRIAR A PESQUISA
            List<string> list2 = list.FindAll(x => x.Length == 5);

            Console.WriteLine("---------------------------");

            foreach(string obj in list2)
            {
                Console.WriteLine(obj);
            }

            //REMOVER ELEMENTOS DA LISTA 
            //REMOVE ESPECIFICADAMENTE
            list.Remove("Alex"); //REMOVE É PRECISO

            //REMOVE EM MASSA TODOS QUE CONTÉM A CONDIÇÃO
            //NESSE CASO VAI REMOVER TODOS QUE NO PRIMEIRO NOME CONTÉM 'M'
            list.RemoveAll(x => x[0] == 'M');

            //REMOVER PELA POSIÇÃO 
            list.RemoveAt(2);

            //REMOVENDO OS ELEMENTOS DE UMA FAIXA 
            //PRIMEIRO PARAMETRO É A POSIÇÃO
            //SEGUNDO PARAMETRO É ATÉ ONDE ELE PODE IR  
            list.RemoveRange(2, 2);


        }
    }
}