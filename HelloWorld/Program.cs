using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Howdy Y'all!!");
            //Console.ReadKey(); // What happens if you run the app without this line?

            var animals = new string[] { "Triceratops", "Gorilla", "Corgi", "Toucan" };

            foreach (var animal in animals)
            {
                //Console.WriteLine(animal);
                if (animal.Length >= 5)
                {
                    Console.WriteLine(animal);
                }
            }

            var greeting = "southern, british, australian";
            Console.WriteLine("Pick from three greetings: southern, british, australian");
            greeting = Console.ReadLine();
            //if (greeting == "british")
            //{
            //    Console.WriteLine("allo!");
            //} else if (greeting == "australian")
            //{
            //    Console.WriteLine("good day mate");
            //} else if (greeting == "southern") {
            //    Console.WriteLine("hey yall");
            //}
        }
    }
}
