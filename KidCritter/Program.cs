using System;

namespace KidCritter
{
    class Program
    {
        public static void Main()
        {
            Random rnd = new Random();
            int comNum = rnd.Next(1,10);
            int userNum;
            Console.WriteLine("I'm thinking of a number, take a guess!");
            Guess();
    
       
        }

        public void SetUserNum(int )

        public static void Guess()
        {
            Console.WriteLine("Pick a number 1-10");
            string strNum = Console.ReadLine();
            int userNum = int.Parse(strNum);
            if (userNum > comNum)
        }
    }
}
