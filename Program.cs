using System;

namespace guessingGame
{
    public class Program
    {
        public static void Main(string[] args)
        {

             
            Console.Write("Can you guess the secret number? ");
 int secretNum = new Random().Next(1, 99);


        for (int i = 0; i < 4; i++){

            int num = Convert.ToInt32(Console.ReadLine());
                
           
                
           
            if(num == secretNum){
                Console.Write($"You guessed the number correct!!!{secretNum}");
                break;

                           } else {
            Console.WriteLine(" Wrong! try again" + $"Your Guess {-i +4}!" + $"{secretNum}");
            
            } 
            }        
        } 
    }
}