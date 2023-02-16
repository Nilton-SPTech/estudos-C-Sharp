using Aula22.Entities;

namespace Aula22
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            // STRING BUILDER
            Comment c1= new Comment("Have a nice trip");
            Comment c2= new Comment("Wow that's awesome");

            Post p1= new Post(
                DateTime.Parse("16/02/2023 08:58:10"),
                "Imagina que aqui tem um titulo", 
                "Aqui dá uma especificação para as viagens", 
                100
            );

            p1.AddComment(c1);
            p1.AddComment(c2);
        }
    }
}