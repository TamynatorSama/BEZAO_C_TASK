using System;

namespace GUESSING_GAME{
    class Program{
        static void Main(String[] args){
            System.Random random = new System.Random();
            int secretNumber = random.Next(100);
            Console.WriteLine(secretNumber);
            int guessedNumber;
            List<int> guesses = new List<int>();


            Console.WriteLine("Guess the secret number");
            
            guessedNumber = Convert.ToInt32(Console.ReadLine());

            guesses.Add(guessedNumber);

            int numberOfGuesse = 0;

            //checks if the number is guessed correctly on first trial
            if(guessedNumber == secretNumber){
                numberOfGuesse++;
                Console.WriteLine("You Guessed Right in {0} try",numberOfGuesse);
            }
            else{
                while(guessedNumber != secretNumber){

                    if(guessedNumber > secretNumber){
                        Console.WriteLine("too large");
                    }
                    else if(guessedNumber < secretNumber){
                        Console.WriteLine("too small");
                    }
                    Console.WriteLine("Guess again");
                    guessedNumber = Convert.ToInt32(Console.ReadLine());

                    if(!guesses.Contains(guessedNumber)){
                        numberOfGuesse++;
                        guesses.Add(guessedNumber);
                    }

                    //checks if the number is guessed correctly after an input
                    if(guessedNumber == secretNumber){
                        numberOfGuesse++;
                        break;
                    }

                }
                Console.WriteLine("You Guessed Right in {0} try",numberOfGuesse);
            }

        }
    }
}
