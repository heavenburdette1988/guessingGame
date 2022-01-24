using System;

namespace guessingGame
{
    public class Program
    {
        public static void Main(string[] args)
        {

             
            Console.Write("Can you guess the secret number?");

        for (int i = 0; i < 4; i++){

            int num = Convert.ToInt32(Console.ReadLine());
                
            int secretNum = 42;

           
            if(num == secretNum){
                Console.Write("You guessed the number correct!!!");
                break;

                           } else {
            Console.WriteLine(" Wrong! try again" + $"Your Guess {i +1}");
            
            } 
            }        
        } 
    }
}