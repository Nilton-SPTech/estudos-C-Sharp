
namespace Aula07
{
    internal class Calculadora
    {
        //O STATIC EXISTE PARA MÉTODOS QUE NÃO TEM NECESSIDADES DE SEREM ÚNICOS
        //POR EXEMPLO -- USAMOS O STATIC PARA CRIAR MÉTODOS QUE VAMOS UTILIZAR TODOS OS MOMENTOS 
        //MAS NÃO NECESSITA DE NENHUM OBJETO 

        //EXEMPLO DE MÉTODOS STATIC SÃO OS DA CLASSE MATH
        public static double Pi = 3.14;

        public static double Circuferencia(double r)
        {
            return 2.0 * Pi * r;
        }

        public static double Volume(double r)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(r, 3.0);
        }
    }
}

