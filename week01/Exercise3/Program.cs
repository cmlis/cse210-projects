using System;

class Program
{
    static void Main(string[] args)
    {
     
        string response = "yes";

        while (response == "yes")
        {

            //Console.Write("What is the magic number? ");
            //int magicNumber = int.Parse(Console.ReadLine());
            
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 100);
            //int magicNumber = 6;
            bool answerRight = false;

            do
            {
                Console.Write("What is your guess?");
                string valueGuess = Console.ReadLine();
                int guess = int.Parse(valueGuess);



                if (guess == magicNumber)
                {
                    answerRight = true;
                    Console.WriteLine(" You guessed it!");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("Higher");
                }




            } while (answerRight == false);

            Console.WriteLine("Would you like to play again?(yes/no)");
            response = Console.ReadLine();

        }
    
    }
}