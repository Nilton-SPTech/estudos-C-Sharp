using Aula25.Entities;

namespace Aula25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EXCEÇÕES PERSONALIZADAS 

            //JEITO PRÁTICO PARA SOMENTE FAZER OS TESTES 
            int number = 102;

            DateTime checkIn = DateTime.Parse("16/02/2023");
            DateTime checkOut = DateTime.Parse("20/02/2023");

            Reservation reservation = new Reservation(number,checkIn,checkOut);
            Console.WriteLine(reservation);

        }
    }
}