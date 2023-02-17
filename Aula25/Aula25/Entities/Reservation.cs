using Aula25.Entities.Exceptions;

namespace Aula25.Entities
{
    internal class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation() { }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            //ESTÁ PEGANDO O INTERVALO ENTRE O CHECKOUT E O CHECKIN
            TimeSpan duration = CheckOut.Subtract(CheckIn); //SUBTRACT PEGA O INTERVALO

            //ESTPA PEGANDO O INTERVALO E CONVERTENDO EM DIAS
            return (int)duration.TotalDays; //COMO TotalDays DEVOLVE A CONVERSÃO EM DOUBLE, É NECESSÁRIO PASSAR ELA PARA INT
        }
        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            
            DateTime now = DateTime.Now;

            if(checkIn < now || checkOut < now)
            {
                //ESTÁ LANÇANDO UMA NOVA EXCEÇÃO 
                //EXCEÇÃO PERSONALIZADA
                throw new DomainException("A data não pode ser antes da data atual");

                //SE CAIR NO throw O MÉTODO NÃO É MAIS EXECUTADO
            }
            CheckIn= checkIn;
            CheckOut= checkOut;


        }
        public override string ToString()
        {

            return "Room "
                + RoomNumber
                + ", check-in: "
                + CheckIn.ToString("dd/MM/yyyy")
                + ", check-out: "
                + CheckOut.ToString("dd/MM/yyyy")
                + ", "
                + Duration()
                + " nigths";
        }
    }
}
