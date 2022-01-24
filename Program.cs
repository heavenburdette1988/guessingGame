using System;

namespace guessingGame
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Can you guess the secret number?");
            int num = Convert.ToInt32(Console.ReadLine());

        bool isFalse = TryAgain("Wrong, Try Again");

            int secretNum = 42;

            if(num == secretNum)
            {
                Console.Write("You guessed the number");
            } else {
            bool TryAgain()
          
            } 
            
           
        } 
    }
}