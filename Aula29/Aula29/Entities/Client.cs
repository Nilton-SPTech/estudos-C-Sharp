namespace Aula29.Entities
{
    internal class Client
    {
        public string Name{ get; set; }
        public string Email { get; set; }


        //DEFINIMOS QUE NECESSARIAMENTE O EQUALS SERÁ FEITO PELO EMAIL 
        //ELE FAZ A BUSCA NO OBJETO, MAS VALIDA SOMENTE O EMAIL 

        //CRIANDO O NOVO CRITÉRIO PARA O Equals
        public override bool Equals(object? obj)
        {
            if(!(obj is Client)) //SE O OBJ NÃO FOR CLIENTE, O OBJ DEVE SER DO TIPO Client, NÃO ADIANTA COLOCAR OUTRO VALOR
            {
                return false; // RETORNA FALSA
            }
            Client other = obj as Client; //PEGANDO O OBJ QUE FOI PASSADO POR PARAMETRO 
            return Email.Equals(other.Email); //RETORNA O VALOR DA COMPARAÇÃO
        }

        public override int GetHashCode() //O GetHashCode SERÁ FEITO A PESQUISA SOMENTE PELO EMAIL
        {
            return Email.GetHashCode();
        }
    }
}
