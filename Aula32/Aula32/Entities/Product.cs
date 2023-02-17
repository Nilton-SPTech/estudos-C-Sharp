
namespace Aula32.Entities
{
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        //PARAMETRIZADO O EQUALS 

        //O override MANIPULA O FUNCIONAMENTO DE CLASSES PROPRIAS DO C#
        public override int GetHashCode()
        {
            return Name.GetHashCode() + Price.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if(!(obj is Product))
            {
                return false;
            }
            Product other = (Product)obj;
            return Name.Equals(other.Name) && Price.Equals(other.Price);
        }
    }
}
