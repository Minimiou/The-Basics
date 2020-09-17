using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            string aFriend = "Bill";
            string firstFriend = "Mammon";
            string secondFriend = "Sage";
            string greeting = "   Hello World!              ";
            string trimmedGreeting = greeting.TrimStart();
            string sayHello = "Hello World";
            string songLyric = "You say goodbye, and I say hello";
            string songLyrics = "Those poor unfortunate souls!";
            string schoolCheer;
            string firstName = "Aya";
            string faveMovie = "The Matrix";

            Console.WriteLine("Hello World");

            Console.WriteLine("Hello " + aFriend);
            aFriend = "Maira";
            Console.WriteLine($"Hello {aFriend}");

            Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");

            Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters");
            Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters");

            Console.WriteLine($"[{greeting}]");

            Console.WriteLine($"[{trimmedGreeting}]");

            trimmedGreeting = greeting.TrimEnd();
            Console.WriteLine($"[{trimmedGreeting}]");

            trimmedGreeting = greeting.Trim();
            Console.WriteLine($"[{trimmedGreeting}]");

            Console.WriteLine(sayHello);

            sayHello = sayHello.Replace("Hello", "Greetings");
            Console.WriteLine(sayHello);

            Console.WriteLine(sayHello.ToUpper());
            Console.WriteLine(sayHello.ToLower());

            Console.WriteLine(songLyrics.Contains("unfortunate"));
            Console.WriteLine(songLyrics.Contains("Eye"));

            Console.WriteLine(songLyrics.StartsWith("You"));
            Console.WriteLine(songLyrics.StartsWith("goodbye"));

            Console.WriteLine(songLyrics.EndsWith("hello"));
            Console.WriteLine(songLyrics.EndsWith("goodbye"));

            Console.WriteLine(firstFriend.Length);

            schoolCheer = "programmers are the best!";
            schoolCheer = schoolCheer.ToUpper();
            Console.WriteLine(schoolCheer);


            Console.WriteLine("   A        K    K");
            Console.WriteLine(" A   A      K   K");
            Console.WriteLine("A     A     K  K");
            Console.WriteLine("A A A A     KK");
            Console.WriteLine("A     A     K  K");
            Console.WriteLine("A     A     K   K");
            Console.WriteLine("A     A     K    K");


            Console.WriteLine($"Hello, my name is {firstName} and my favorite movie is {faveMovie}.".ToLower());
            faveMovie = faveMovie.ToUpper();
            Console.WriteLine(faveMovie);
            Console.WriteLine(faveMovie.Contains("THE"));
            faveMovie = faveMovie.Replace("A", "@");
            faveMovie = faveMovie.Replace("E", "3");
            Console.WriteLine(faveMovie);

            Console.ReadLine();




        }
    }
}
