using System;

namespace Method_Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Hello there. Can you tell me your name?");
            var username = Console.ReadLine();

            Console.WriteLine($"That's a lovely name.");

            Console.WriteLine($"Now, {username}, I need to know a little more about you. Tell me your favorite color!");
            var favoriteColor = Console.ReadLine();

            Console.WriteLine($"{favoriteColor} is one awesome color. Mine is green! ");

            Console.WriteLine($"What is your favorite animal too?");
            var favoriteAnimal = Console.ReadLine();

            Console.WriteLine($"Very cool. Not as cool as a dolphin but that's alright.");

            Console.WriteLine($"This last question is the most important... What is your favorite band?");
            var favoriteBand = Console.ReadLine();

            Console.WriteLine($"Awesome {username}! Now to finish everything, all of your answers are below. It was nice getting to know you.");

            Console.WriteLine($"{username}'s favorites list:");
            Console.WriteLine($"{favoriteColor}");
            Console.WriteLine($"{favoriteAnimal}");
            Console.WriteLine($"{favoriteBand}");
        }
    }
}
