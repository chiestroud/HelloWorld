using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Howdy Y'all!!");
            Console.WriteLine("Please type your name");

            var name = Console.ReadLine();

            Console.WriteLine($"Hello {name}");
            Console.WriteLine("Please type your favorite color");

            var favoriteColor = Console.ReadLine();


            var animals = new String[] { "Triceratops", "Gorilla", "Corgi", "Toucan" };
         
            foreach(var animal in animals)
            {
                {
                    if (animal.Length >= 5)
                    {
                        Console.WriteLine(animal);
                    } 
                }
            }

            Random rand = new Random();
            int index = rand.Next(animals.Length);
            Console.WriteLine($"Would you like to have a {favoriteColor} {animals[index]}?");

            Console.WriteLine("Please pick from the following Greetings");
            
            for (var i = 0; i < args.Length; i++)
            {
                Console.WriteLine(args[i]);
            }

            var greeting = Console.ReadLine().ToLower();

            switch (greeting)
            {
                case "southern":
                    Console.WriteLine("Howdy y'all?");
                    break;
                case "japanese":
                    Console.WriteLine("Ohayo");
                    break;
                case "spanish":
                    Console.WriteLine("Hola!");
                    break;
                default:
                    Console.WriteLine("Invalid.");
                    break;
            }
        }
    }
}
