using System;
using System.Collections.Generic;
using System.Text;

namespace udemy1Loops
{
    public class Loops
    {
        //Using while loop(we use while loop when we doesnt know how many times we need to execute the block of statements)
        //Example for while loop.
        // if the user enters the input(name), it displays input. If the user enetrs nothing, break then come out of the loop
        public void UsingWhileLoop()
        {
            while (true)
            {
                Console.Write("Please enter the name: ");
                var input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                    break;
                Console.WriteLine(input);
            }
        }

        //The above while loop example using continue keyword
        public void UsingContinueKeyword()
        {
            while (true)
            {
                Console.Write("please enter your name: ");
                var input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine(input);
                    continue;
                }
                break;
            }
        }

        // we can generate random numbers by creating new random class
        // below example is printing 10 random numbers. 
        public void CreatingTenRandomNumbers()
        {
            Random numbers = new Random();
            for (var i = 0; i <= 10; i++)
            {
                Console.WriteLine(numbers.Next());
            }
        }

        //below example is to generate  5 random numbers from 1 - 10
        public void CreatingFiveRandomNumbers()
        {

            Random x = new Random();
            for (var i = 0; i <= 5; i++)
            {
                Console.WriteLine(x.Next(1, 10));
            }
        }

        //below example is to generate a random string
        public void CreatingRandomString()
        {

            Random s = new Random();
            for (var i = 0; i < 10; i++)
            {
                Console.Write((char)s.Next(97, 122));
                // the above Next arguments seems comfusing , we can also write the abouve line as
                Console.Write((char)('a' + s.Next(0, 26)));
                //both 151 and 153 lines displays the same output.
                /*in 153 (0, 26) are the total number of letters we have, and we are adding char a to s.Next
                so that conputer understands to print characters from a to z*/
            }
        }

        //Below example is to generate Random passwords.
        public void CreatingRandomPassword()
        {
            Console.WriteLine();
            var s = new Random();
            Console.WriteLine("Random password");
            var password = new char[8];
            for (var i = 0; i < 8; i++)
            {
                password[i] = (char)('a' + s.Next(0, 26));
            }
            string generatedPassword = new string(password);
            Console.WriteLine(generatedPassword);
        }


        /*1- Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. 
        Display the count on the console.*/
        public void NumbersDivisibleByThree()
        {

            int count = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }

        /*2- Write a program and continuously ask the user to enter a number or "ok" to exit. 
         Calculate the sum of all the previously entered numbers and display it on the console.*/
        public void NumberOkExit()
        {
            var inp = 0;
            var total = 0;

            while (true)

            {
                Console.WriteLine("Please enter a number: ");
                string test = Console.ReadLine().ToLower();

                if (test == "ok")
                {
                    break;
                }
                else
                {
                    inp = Convert.ToInt32(test);
                    total = total + inp;
                }

                Console.WriteLine(total);
            }
        }

        /*3- Write a program and ask the user to enter a number. 
         Compute the factorial of the number and print it on the console. 
        For example, if the user enters 5, the program should calculate 
        5 x 4 x 3 x 2 x 1 and display it as 5! = 120.*/
        public void Factorial()
        {

            Console.Write("Please enter the integer: ");
            var num = Convert.ToInt32(Console.ReadLine());
            var factorial = 1;
            for (var i = num; i >= 1; i--)
            {
                factorial = factorial * i;
            }
            Console.WriteLine(factorial);
        }

        /*4- Write a program that picks a random number between 1 and 10. 
         * Give the user 4 chances to guess the number. 
         * If the user guesses the number, display “You won"; 
         * otherwise, display “You lost". 
         * (To make sure the program is behaving correctly, you can display the secret number on the console first.)*/
        public void GuessingGame()
        {

            Random n = new Random();
            int guessNumber = n.Next(1, 10); //the number generated by computer will be stored in guess number
            Console.WriteLine(guessNumber); // this will print on the console.
            for (var i = 1; i <= 4; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Guess any number between 1 and 10: ");
                //int userGuess = int.Parse(Console.ReadKey().KeyChar.ToString());
                var userChar = Console.ReadLine();
                var userGuess = 0;
                if (char.IsDigit(userChar[0]))
                {
                    userGuess = Convert.ToInt32(userChar);
                }
                else
                {
                    i--;
                    continue;
                   
                }
                
                if (userGuess == guessNumber)
                {
                    Console.WriteLine();
                    Console.WriteLine("You guessed right");
                    break;
                }
                else if (i == 4)
                {
                    Console.WriteLine();
                    Console.WriteLine("You are out of attempts. sorry");
                }
            }
        }

        /*5- Write a program and ask the user to enter a series of numbers separated by comma. 
         * Find the maximum of the numbers and display it on the console. 
         * For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.*/
        public void SeriesOfNumbers()
        {
            var max = 0;
            Console.WriteLine("Enter the series of numbers: ");
            string inputNumbers = Console.ReadLine();
            string[] charArray = inputNumbers.Split(',', ' ');
            for (var i = 0; i < charArray.Length; i++)
            {
                if (Convert.ToInt32(charArray[i]) > max)
                {
                    max = Convert.ToInt32(charArray[i]);
                }
            }
            Console.WriteLine(max);
        }
    }
}
