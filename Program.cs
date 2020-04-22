using System;
using System.Collections.Generic;

namespace numberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
             //Set user prompt text color to green
            Console.ForegroundColor = ConsoleColor.Green;

            //Welcome message
            Console.WriteLine("=================Welcome to Number Guesser Game================== ");
            Console.WriteLine("");
            //Select level
            Console.WriteLine("Kindly select the game difficulty level to play (i.e 'EASY' or 'HARD')");
            Console.WriteLine(">>EASY ");
            Console.WriteLine(">>MEDIUM ");
            Console.WriteLine(">>HARD");

            //Reset text color
            Console.ResetColor();

            while (true)
            {
                
                //Read the user input
                Console.Write("LEVEL: ");
                var level = Console.ReadLine().ToUpper();

                //Conditional check to see 
                if (level == "EASY")
                {

                    //Set correct random number between 1 - 10
                    Random random = new Random();
                    int correctNumber = random.Next(0, 10); 

                    //User guessed value, default as 0
                    int guess = 0;


                    //Set user prompt text color to green
                    Console.ForegroundColor = ConsoleColor.Green;

                    //Game start prompt
                    Console.WriteLine($"You current level is 'EASY' and you have 5 attempt to guess a number between 1 - 10");

                    //Reset text color
                    Console.ResetColor();


                    for (int count = 0; count <= 5; count++)
                    {

                        //User prompt to guess a number
                        Console.Write("Guess a number between 1 - 10 => ");

                        var userGuess = Console.ReadLine();

                        if (!int.TryParse(userGuess, out guess))
                        {
                            //Set user prompt text color to red
                            Console.ForegroundColor = ConsoleColor.Red;

                            //Congratulate user
                            Console.WriteLine("Enter an actual number! ");

                            //Reset text color
                            Console.ResetColor();

                            continue;
                        }


                        //User guessed number parsed to int
                        guess = int.Parse(userGuess);

                        if (count == 4)
                        {
                            //Set user prompt text color to red
                            Console.ForegroundColor = ConsoleColor.Red;

                            //Congratulate user
                            Console.WriteLine("Game Over!");

                            //Reset text color
                            Console.ResetColor();

                            break;

                        } else {
                            if (correctNumber == guess)
                            {
                                //Set user prompt text color to green
                                Console.ForegroundColor = ConsoleColor.Green;

                                //Congratulate user
                                Console.WriteLine("You got it right!");

                                //Reset text color
                                Console.ResetColor();

                                break;
                            } 
                            else 
                            {
                                //Set user prompt text color to red
                                Console.ForegroundColor = ConsoleColor.Red;

                                //Congratulate user
                                Console.WriteLine($"That was wrong - {4 - count} attempt left");

                                //Reset text color
                                Console.ResetColor();
                            }

                        }
    
                    }

                    //Set user prompt text color to Yellow
                    Console.ForegroundColor = ConsoleColor.Yellow;

                    //Ask user do you want to play again?
                    Console.Write("Do you want to play again? (Y or N) :: ");

                    //Reset text color
                    Console.ResetColor();

                    var answer = Console.ReadLine().ToUpper();

                    if (answer == "Y")
                    {
                        continue;
                    } 
                    else if (answer == "N")
                    {
                        break;

                    } else {

                        //Set user prompt text color to Red
                        Console.ForegroundColor = ConsoleColor.Red;

                        //Invalid response message
                        Console.WriteLine("Invalid Response, Program Ended!");

                        //Reset text color
                        Console.ResetColor();

                        break;
                    }
   

                } 
                else if (level == "MEDIUM")
                {
                    //Set correct random number between 1 - 20
                    Random random = new Random();
                    int correctNumber = random.Next(0, 20); 

                    //User guessed value, default as 0
                    int guess = 0;


                    //Set user prompt text color to green
                    Console.ForegroundColor = ConsoleColor.Green;

                    //Game start prompt
                    Console.WriteLine($"You current level is 'MEDIUM' and you have 4 attempt to guess a number between 1 - 20");

                    //Reset text color
                    Console.ResetColor();


                    for (int count = 0; count <= 4; count++)
                    {

                        //User prompt to guess a number
                        Console.Write("Guess a number between 1 - 20 => ");


                        var userGuess = Console.ReadLine();

                        if (!int.TryParse(userGuess, out guess))
                        {
                            //Set user prompt text color to red
                            Console.ForegroundColor = ConsoleColor.Red;

                            //Congratulate user
                            Console.WriteLine("Enter an actual number! ");

                            //Reset text color
                            Console.ResetColor();

                            continue;
                        }


                        //User guessed number parsed to int
                        guess = int.Parse(userGuess);

                        if (count == 3)
                        {
                            //Set user prompt text color to red
                            Console.ForegroundColor = ConsoleColor.Red;

                            //Congratulate user
                            Console.WriteLine("Game Over!");

                            //Reset text color
                            Console.ResetColor();

                            break;

                        } else {
                            if (correctNumber == guess)
                            {
                                //Set user prompt text color to green
                                Console.ForegroundColor = ConsoleColor.Green;

                                //Congratulate user
                                Console.WriteLine("You got it right!");

                                //Reset text color
                                Console.ResetColor();

                                break;
                            } 
                            else 
                            {
                                //Set user prompt text color to red
                                Console.ForegroundColor = ConsoleColor.Red;

                                //Congratulate user
                                Console.WriteLine($"That was wrong - {3 - count} attempt left");

                                //Reset text color
                                Console.ResetColor();
                            }

                        }
    
                    }

                    //Set user prompt text color to Yellow
                    Console.ForegroundColor = ConsoleColor.Yellow;

                    //Ask user do you want to play again?
                    Console.Write("Do you want to play again? (Y or N) :: ");

                    //Reset text color
                    Console.ResetColor();

                    var answer = Console.ReadLine().ToUpper();

                    if (answer == "Y")
                    {
                        continue;
                    } 
                    else if (answer == "N")
                    {
                        break;

                    } else {

                        //Set user prompt text color to Red
                        Console.ForegroundColor = ConsoleColor.Red;

                        //Invalid response message
                        Console.WriteLine("Invalid Response, Program Ended!");

                        //Reset text color
                        Console.ResetColor();

                        break;
                    } 
                } 
                else if (level == "HARD")
                {
                    //Set correct random number between 1 - 50
                    Random random = new Random();
                    int correctNumber = random.Next(1, 50);

                    //User guessed value, default as 0
                    int guess = 0;


                    //Set user prompt text color to green
                    Console.ForegroundColor = ConsoleColor.Green;

                    //Game start prompt
                    Console.WriteLine($"You current level is 'HARD' and you have 3 attempt to guess a number between 1 - 50");

                    //Reset text color
                    Console.ResetColor();


                    for (int count = 0; count <= 3; count++)
                    {

                        //User prompt to guess a number
                        Console.Write("Guess a number between 1 - 50 => ");

                        var userGuess = Console.ReadLine();

                        if (!int.TryParse(userGuess, out guess))
                        {
                            //Set user prompt text color to red
                            Console.ForegroundColor = ConsoleColor.Red;

                            //Congratulate user
                            Console.WriteLine("Enter an actual number! ");

                            //Reset text color
                            Console.ResetColor();

                            continue;
                        }


                        //User guessed number parsed to int
                        guess = int.Parse(userGuess);

                        if (count == 2)
                        {
                            //Set user prompt text color to red
                            Console.ForegroundColor = ConsoleColor.Red;

                            //Congratulate user
                            Console.WriteLine("Game Over!");

                            //Reset text color
                            Console.ResetColor();

                            break;

                        } else {
                            if (correctNumber == guess)
                            {
                                //Set user prompt text color to green
                                Console.ForegroundColor = ConsoleColor.Green;

                                //Congratulate user
                                Console.WriteLine("You got it right!");

                                //Reset text color
                                Console.ResetColor();

                                break;
                            } 
                            else 
                            {
                                //Set user prompt text color to red
                                Console.ForegroundColor = ConsoleColor.Red;

                                //Congratulate user
                                Console.WriteLine($"That was wrong - {2 - count} attempt left");

                                //Reset text color
                                Console.ResetColor();
                            }

                        }
    
                    }

                    //Set user prompt text color to Yellow
                    Console.ForegroundColor = ConsoleColor.Yellow;

                    //Ask user do you want to play again?
                    Console.Write("Do you want to play again? (Y or N) :: ");

                    //Reset text color
                    Console.ResetColor();

                    var answer = Console.ReadLine().ToUpper();

                    if (answer == "Y")
                    {
                        continue;
                    } 
                    else if (answer == "N")
                    {
                        break;

                    } else {

                        //Set user prompt text color to Red
                        Console.ForegroundColor = ConsoleColor.Red;

                        //Invalid response message
                        Console.WriteLine("Invalid Response, Program Ended!");

                        //Reset text color
                        Console.ResetColor();

                        break;
                    } 
                } 
                else {
                    //Set user prompt text color to Red
                    Console.ForegroundColor = ConsoleColor.Red;

                    //Display user prompt to select appropriate level
                    Console.WriteLine("KINDLY SELECT A VALID LEVEL");

                    //Reset text color
                    Console.ResetColor();

                }

            }

        }
    }
}
