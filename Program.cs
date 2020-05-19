using System;

namespace CLassesMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal dog = new Animal();
            dog.Print();

            Console.WriteLine();

            Animal cat = new Animal("Mr. Garfield", 10, 0.8f);
            cat.Print();

            Console.WriteLine();

            Animal rabbit = new Animal("Mr. Spotty", 4, 1.2f);
            rabbit.Print();

            Console.WriteLine();

            Console.WriteLine("Number of Animals: " + Animal.Count);

            Console.ReadLine();
        }
    }
}
