using Aula20.Entities.Enums;
using System; 

namespace Aula20.Entities
{
    internal class Order
    {
        public int Id { get; set; }
        public DateTime Moment{ get; set; }

        public string OrderStatus Status{ get; set; }
    }
}
