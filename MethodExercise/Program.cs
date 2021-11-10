using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calling methods to obtain user's input and store them
            string userName = GetName();
            string favColor = GetColor();
            string favAnimal = GetAnimal();
            string favFood = GetFood();
            int userAge = GetAge();
            string petsName = PetName();

            //Utilizing the user's input to hopefully create a funny story
            Console.WriteLine($"\r\nThere was once a person by the name of {userName}." +
                $"\r\nThey had {userAge} {favColor} marbles they found while playing with their pet {favAnimal}, {petsName}." +
                $"\r\nOne windy afternoon, a toad hopped up to {userName} and {petsName}, and demanded that they return his marbles. " +
                $"\r\nThose marbles belonged to him, he croaked!" +
                $"\r\n{userName} and {petsName} traded glances in confusion for there was a toad who could speak! The toad croaked his demand again." + 
                $"\r\n{userName} laughed at the toad and left with {petsName} to get some {favFood}, because it was a toad... What was it going to do?");

            Console.WriteLine($"\r\nThe End!");

            Console.ReadKey();
        }
        private static string GetName() //Get user's name
        {
            Console.WriteLine("What is your name?");
            return Console.ReadLine();
        }
        private static string GetColor() //Get user's favorite color
        {
            Console.WriteLine("What is your favorite color?");
            return Console.ReadLine();
        }
        private static string GetAnimal() //Get user's favorite animal
        {
            Console.WriteLine("What is your favorite animal?");
            return Console.ReadLine();
        }
        private static string GetFood() //Get user's favorite band
        {
            Console.WriteLine("What is your favorite food?");
            return Console.ReadLine();
        }
        private static int GetAge() //Get user's current age
        {
            Console.WriteLine("How old are you?");
            return Convert.ToInt32(Console.ReadLine());
        }
        private static string PetName()
        {
            Console.WriteLine("What would you name your pet?");
            return Console.ReadLine();
        }

    }
}
