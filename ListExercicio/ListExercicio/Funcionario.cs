
namespace ListExercicio
{
    internal class Funcionario
    {
        public int Id;
        public string Nome;
        private double _salario;

        public Funcionario(int id, string nome, double salario)
        {
            this.Id = id;
            this.Nome = nome;
            this.Salario = salario;
        }
        public double Salario
        {
            get { return _salario; }
            set { 
                if(value < 0 ) { 
                    _salario = value; 
                }
            }
        }

        public static double AcrescimoSalario(double salario, double porcentagem)
        {
            return salario += (salario * (porcentagem / 100));
        }
    }
}
