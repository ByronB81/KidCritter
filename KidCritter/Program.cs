using System;

namespace KidCritter
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Pick a number 1-10");
            string strNum = Console.ReadLine();
            int userNum = int.Parse(strNum);

            Random rnd = new Random();
            int firstGuess = rnd.Next(1,10);
            Console.WriteLine("My guess is {0}", firstGuess);

            Console.WriteLine("Your number is {0}", userNum);
        }
    }
}
