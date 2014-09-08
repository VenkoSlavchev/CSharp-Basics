using System;

namespace Problem3_CheckForACard
{
    class CheckForACard
    {
        static void Main()
        {
            Console.Write("Enter Play Card : ");
            string card = Console.ReadLine();
            switch (card)
            {
                case "2": 
                case "3": 
                case "4": 
                case "5":
                case "6": 
                case "7": 
                case "8":
                case "9":
                case "10":
                case "A": 
                case "J": 
                case "Q": 
                case "K": Console.WriteLine("Yes");
                    break;
                default: Console.WriteLine("No"); ;
                    break;
            }
        }
    }
}
