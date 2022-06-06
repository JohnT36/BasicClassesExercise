using System;

namespace BasicClassesExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome! Won't you stay and chat a while?");
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            name = name.Trim();
            Console.WriteLine($"You're name is {name}?");
            var answer1 = Console.ReadLine();


            
            


            var johnsC = new Car();           
            johnsC.Make = "Honda";
            johnsC.Model = "Ridgeline";
            johnsC.Year = 2011;

            Console.WriteLine(johnsC.Make);
            Console.WriteLine(johnsC.Model);
            Console.WriteLine(johnsC.Year);

            var johnsK = new Kitties();
            johnsK.Name = "Tiger";
            johnsK.Origin = "Africa";
            johnsK.Speed = 50;

            Console.WriteLine(johnsK.Name);
            Console.WriteLine(johnsK.Origin);
            Console.WriteLine(johnsK.Speed);

            var johnsD = new Doggies();
            johnsD.Breed = "Lab";
            johnsD.Color = "Black";
            johnsD.Size = "Medium";
            johnsD.Age = 15;                    
                                   
            Console.WriteLine(johnsD.Breed);
            Console.WriteLine(johnsD.Color);
            Console.WriteLine(johnsD.Size);
            Console.WriteLine(johnsD.Age);









        }
    }
}
