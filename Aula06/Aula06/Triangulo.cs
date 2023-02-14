using System; //IMPORTAÇÃO DE DEPENDENCIAS

namespace Aula06 //NAMESPACE DA CLASSE
{
    internal class Triangulo //NOME DA CLASSE
    {
        //ATRIBUTOS DA CLASSE 
        //o prefixo público indica que o atributo pode ser usado em outros arquivos
        public double A; 
        public double B;
        public double C;


        public double CalcularArea() //MÉTODO
        {
            //CORPO DO MÉTODO 

            //CALCULANDO A AREA DO TRIÂNGULO
            double p = (A + B + C) / 2.0;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}
