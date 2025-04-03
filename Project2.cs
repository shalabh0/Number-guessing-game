using System;

class Program2{
    static int bestScore = int.MaxValue;
    public static void Main(){
        Console.WriteLine("Welcome to number guessing game !!");
        Console.WriteLine("I am thinking of a number between 1 and 100.");


        Random random = new Random();
        int secretNumber = random.Next(1,101);
    

    int guess = 0;
    int attempt = 0;
    int maxAttempt = 25;

    while(guess != secretNumber && attempt < maxAttempt)
    {
        Console.WriteLine("Enter your guess");
        string input = Console.ReadLine();

        if(int.TryParse(input, out guess))
        {
            attempt++;
             if(guess > secretNumber)
            {
                Console.WriteLine("Your guess is too high");
            } 
               if(guess < secretNumber)
            {
                Console.WriteLine("Your guess is too low");
            } 
            if(Math.Abs(guess - secretNumber)>20)
            {
                Console.WriteLine("You are way off the answer");
            }
            else if(Math.Abs(guess - secretNumber)>10)
            {
                Console.WriteLine("You are getting closer to the answer");
            }
            else{
                Console.WriteLine($"Guess is correct in the {attempt} attempt!!");
                if(attempt < bestScore)
               {
                bestScore = attempt;
                Console.WriteLine($"New best score :{bestScore} attempts");
               }
               break;
            }
            
            

        }
        else{
            Console.WriteLine("Invalid input !!");
        }
    }
    if(attempt >= maxAttempt && guess != secretNumber)
    {
        Console.WriteLine($"You have used  your max attempts and the correct number was {secretNumber}");
    }
    Console.WriteLine("Do you want to play again :(Yes/No) :");
    string playAgain = Console.ReadLine().ToLower();

    if(playAgain == "yes")
    {
        Main();
    }
    else
    {

     Console.WriteLine("Thanks for playing");
    }
} 
}
