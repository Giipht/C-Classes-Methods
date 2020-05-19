using System;
using System.Collections.Generic;
using System.Text;

namespace CLassesMethods
{
    class Animal
    {
        //CLASS VARIABLES
        public static int Count = 0;

        public string name;
        public int age;
        public float happiness;

        //CLASS CONSTRUCTORS
        public Animal()
        {
            name = "Blacky";
            age = 6;
            happiness = 0.5f;

            Count++;
        }

        public Animal(string _name, int _age, float _happiness)
        {
            name = _name;
            age = _age;
            happiness = _happiness;

            Count++;
        }

        //CLASS METHODS
        public void Print()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Happiness: " + happiness);
        }
    }
}
