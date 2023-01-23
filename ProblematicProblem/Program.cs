using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Threading;

namespace ProblematicProblem
{
    public class Program
    {

        static void Main(string[] args)
        {
            string[] userInfo = new string[];
            userInfo = Greeting(userInfo);

        }    
        
        public static string[] Greeting(string[] userInfo)
        {
            
            Console.Write("Hello, welcome to the random activity generator! \n");
            Console.WriteLine("Would you like to generate a random activity? yes/no: ");
            string contnu = Console.ReadLine();
            if (contnu.ToLower() == "yes")
            {
                Console.Write("We are going to need your information first! What is your name? ");
                userInfo[0] = Console.ReadLine();
                Console.WriteLine();
                Console.Write("What is your age? ");
                int userAge = int.TryParse(Console.ReadLine());
            }
            else 
            {
                Console.WriteLine("Oh, you don't like random activities? Thank you, goodbye!");
                return userInfo 
            }
            Console.WriteLine();
            Console.Write("We are going to need your information first! What is your name? ");
            string userName = Console.ReadLine();
            Console.WriteLine();
            Console.Write("What is your age? ");
            int userAge = int.TryParse(Console.ReadLine());
            Console.WriteLine();

            return userInfo;
        }

        public static void DisplayActivities()
        {

        }

        public static void AddActivity()
        {


        }
        Random rng = new Random();
        bool cont = true;
        List<string> activities = new List<string>()
        {  "Movies",
            "Paintball",
            "Bowling",
            "Lazer Tag",
            "LAN Party",
            "Hiking",
            "Axe Throwing",
            "Wine Tasting"
        };


    Console.Write("Hello, welcome to the random activity generator! \nWould you like to generate a random activity? yes/no: ")
            bool cont = bool.Parse(Console.ReadLine());
    Console.WriteLine();
    Console.Write("We are going to need your information first! What is your name? ");
    string userName = Console.ReadLine();
    Console.WriteLine();
    Console.Write("What is your age? ");
    int userAge = int.Parse(Console.ReadLine());
    Console.WriteLine();
    Console.Write("Would you like to see the current list of activities? Sure/No thanks: ");
    bool seeList = bool.Parse(Console.ReadLine());
    if (seeList)
    {
        foreach (string activity in activities)
        {
            Console.Write($"{activity} ");
            Thread.Sleep(250);
        }
        Console.WriteLine();
        Console.Write("Would you like to add any activities before we generate one? yes/no: ");
        bool addToList = bool.Parse(Console.ReadLine());
        Console.WriteLine();
        while (addToList)
        {
            Console.Write("What would you like to add? ");
            string userAddition = Console.ReadLine();
            activities.Add(userAddition);
            foreach (string activity activities)
            {
                Console.Write($"{activity} ");
                Thread.Sleep(250);
            }
            Console.WriteLine();
            Console.WriteLine("Would you like to add more? yes/no: ");
            string addToList = bool.Parse(Console.ReadLine());
        }
    }

    while (cont)
    {
        Console.Write("Connecting to the database");
        for (int i = 0; i < 10; i++)
        {
            Console.Write(". ");
            Thread.Sleep(2);
        }
        Console.WriteLine()
                Console.Write("Choosing your random activity");
        for (int i = 0; i < 9; i++)
        {
            Console.Write(". ");
            Thread.Sleep(500);
        }
        Console.WriteLine()
                int randomNumber = rng.Next(activities.Count);
        string randomActivity = activities[randomNumber]
                if (userAge > 21 && randomActivity == "Wine Tasting")
        {
            Console.WriteLine($"Oh no! Looks like you are too young to do {randomActivity}");
            Console.WriteLine("Pick something else!");
            activities.Remove(randomActivity);
            string randomNumber = rng.Next(activities.Count);
            string randomActivity = activities[randomNumber];
        }
        Console.Write($"Ah got it! {randomActivity}, your random activity is: {userName}! Is this ok or do you want to grab another activity? Keep/Redo: ")
                ConsoleWriteLine();
        bool cont = bool.Parse(Console.ReadLine());
    }
}
    }
}}