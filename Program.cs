using System;

namespace guessingGame
{
    public class Program
    {
        public static void Main(string[] args)
        {

             
            Console.Write("Can you guess the secret number between 1 - 100? ");

 int secretNum = new Random().Next(1, 100);
  

        for (int i = 0; i < 4; i++){

           int num = Convert.ToInt32(Console.ReadLine());
                
            if(num == secretNum){
                Console.Write($"You guessed the number correct, {secretNum}!!!");
                break;

                           } else {

            Console.WriteLine(" Wrong! try again");
            Console.WriteLine($" {-i +4} guesses remaining!" + $"{secretNum}");
                        } 
             if(secretNum > num ){
                 Console.WriteLine("Your guess is to low");
             }else  if(secretNum < num ){
                   Console.WriteLine("Your guess is to high");
             }
            }        
        } 
    }
}