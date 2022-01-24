using System;

namespace guessingGame
{
    public class Program
    {
        public static void Main(string[] args)
        {

 Console.Write("What difficulty Level do you want, easy, medium, hard? ");
string easy = "easy";
string medium = "medium";
string hard = "hard";
string Answer = Console.ReadLine();

 if(easy == Answer){
Console.WriteLine("Can you guess the secret number between 1 - 100? You get 8 guesses");

int secretNum = new Random().Next(1, 100);
  
        for (int i = 0; i < 8; i++){

           int num = Convert.ToInt32(Console.ReadLine());
           if(num == secretNum){
                
                Console.Write($"You guessed the number correct, {secretNum}!!!");
                break;

           }   else {

            Console.WriteLine(" Wrong! try again");
            Console.WriteLine($" {-i +7} guesses remaining!" + $"{secretNum}");
//                         
        } if(secretNum > num ){

                 Console.WriteLine("Your guess is to low");

            } else  if (secretNum < num ){
                   Console.WriteLine("Your guess is to high");
             }
 }
 }
 
 
 else if(medium == Answer){
Console.WriteLine("Can you guess the secret number between 1 - 100? You get 6 guesses");

int secretNum = new Random().Next(1, 100);
  
        for (int i = 0; i < 6; i++){

           int num = Convert.ToInt32(Console.ReadLine());
           if(num == secretNum){
                
                Console.Write($"You guessed the number correct, {secretNum}!!!");
                break;

           }   else {

            Console.WriteLine(" Wrong! try again");
            Console.WriteLine($" {-i +5} guesses remaining!" + $"{secretNum}");
//                         
        } if(secretNum > num ){

                 Console.WriteLine("Your guess is to low");

            } else  if (secretNum < num ){
                   Console.WriteLine("Your guess is to high");
             }
 }
} 

 else if(hard == Answer) {
    Console.WriteLine("Can you guess the secret number between 1 - 100? You get 4 guesses");
    int secretNum = new Random().Next(1, 100);
  
        for (int i = 0; i < 4; i++){

           int num = Convert.ToInt32(Console.ReadLine());
           if(num == secretNum){
                
                Console.Write($"You guessed the number correct, {secretNum}!!!");
                break;

           }   else {

            Console.WriteLine(" Wrong! try again");
            Console.WriteLine($" {-i +3} guesses remaining!" + $"{secretNum}");
//                         
        } if(secretNum > num ){

                 Console.WriteLine("Your guess is to low");

            } else  if (secretNum < num ){
                   Console.WriteLine("Your guess is to high");
             }
 }
}
        }
    }
}


       
   
 
 
 


//  Console.Write("Can you guess the secret number between 1 - 100? ");

//  
                
//             if(num == secretNum){
//                 Console.Write($"You guessed the number correct, {secretNum}!!!");
//                 break;

//                            } else {

//             Console.WriteLine(" Wrong! try again");
//             Console.WriteLine($" {-i +4} guesses remaining!" + $"{secretNum}");
//                         } 
//              if(secretNum > num ){

//                  Console.WriteLine("Your guess is to low");

//             } else  if (secretNum < num ){
//                    Console.WriteLine("Your guess is to high");
//              }
//             }        
//         } }
    
        
//  }}
