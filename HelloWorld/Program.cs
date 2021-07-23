using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name}!");

            var animals = new string[] { "Triceratops", "Gorilla", "Corgi", "Toucan" };

            foreach (var animal in animals)
            {
                if (animal.Length >= 5)
                {
                    Console.WriteLine(animal);
                }
            }
;
            Console.WriteLine("Pick from three greetings: southern, british, australian");
            string greeting;
            greeting = Console.ReadLine();

            switch (greeting)
            {
                case "southern":
                    Console.WriteLine("hey y'all!");
                    break;
                case "british":
                    Console.WriteLine("Cheerio");
                    break;
                case "australian":
                    Console.WriteLine("Good day mate!");
                    break;
                default:
                    break;
            }
           
        }
    }
}
