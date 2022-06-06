using System;

namespace BasicClassesExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

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






        }
    }
}
