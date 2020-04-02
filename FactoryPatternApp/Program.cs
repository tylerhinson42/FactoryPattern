using System;
using System.Collections.Generic;
using System.Linq;

namespace FactoryPatternApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Ask the user for the phone they wish to create
            Console.WriteLine("What kind of phone do you want to create?");
            string userPhone = Console.ReadLine();

            //Choose the correct type of phone to create through the factory method that implements the ICallable interface
            ICallable phone = PhoneFactory.GetPhone(userPhone);
            phone.Build();
            Console.ReadLine();


            var Harley = new Moto();
            var Car1 = new Auto();
            Car1.Drive();
            Harley.Drive();



            //***********Example of bad practice************//

            //Console.WriteLine("What kind of phone do you want to create?");
            //string userPhone = Console.ReadLine();

            //if (userPhone.ToLower() == "android")
            //{
            //    AndroidPhone android = new AndroidPhone();
            //    android.Build();
            //    Console.ReadLine();
            //}
            //else if (userPhone.ToLower() == "apple")
            //{
            //    ApplePhone apple = new ApplePhone();
            //    apple.Build();
            //    Console.ReadLine();
            //}
            //else if (userPhone.ToLower() == "iphone")
            //{
            //    ApplePhone apple = new ApplePhone();
            //    apple.Build();
            //    Console.ReadLine();
            //}
            //else if (userPhone.ToLower() == "google")
            //{
            //    GooglePhone google = new GooglePhone();
            //    google.Build();
            //    Console.ReadLine();
            //}
            //else
            //{
            //    AndroidPhone android = new AndroidPhone();
            //    android.Build();
            //    Console.ReadLine();
            //}


            var animalNames = new List<string> { "gorilla", "bear", "horse" };
            var aniamlArray = new string[] { "hdhf", "hello" };

            var longAnimalNames = animalNames.Where(name => name.Contains("o"));

            //IEnumerable Count
            var sum = longAnimalNames.Count();
            //List Count
            var sumList = animalNames.Count;
            //Array
            var arraySum = animalArray.Count();

            foreach(var name in longAnimalNames)
            {
                Console.WriteLine(name);
            }

            //Class Exercise 2/4/20
            //1) Using Method Syntax
            //2) Create a list of video games
            //3) List games by the length of the game name
            //4) Order by length
            //5) Use the Lambda Expression in this exercise as well


            var videoGames = new List<string>
                { "wii sports", "rainbow six", "mario world", "grand theft auto", "mike tyson's punchout" };

            var methodSyntax = videoGames.OrderByDescending(game => game.Length);

            var querySyntax = from game in videoGames
                              orderby game.Length descending
                              select game;

            foreach (var game in querySyntax)
            {
                Console.WriteLine(game);
            }

            foreach (var game in methodSyntax)
            {
                Console.WriteLine(game);
            }

            var ordered = videoGames.OrderBy(name => name.Length); //Calling method OrderBy and storing it in new variable named ordered
            videoGames.OrderByDescending(name => name.Length);

          

            //Using Query Syntax
            //1) Create an array of cars
            //2) Select all of the cars that contain a particular letter of your choosing
            //3) Print out this array in descending order

            string[] cars = { "Corvette", "X5", "Maxima", "4runner",

            IEnumerable<string> 

        }
    }
}
