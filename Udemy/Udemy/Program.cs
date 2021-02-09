using System;

namespace Udemy
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1- Write a program and ask the user to enter a number. 
             * The number should be between 1 to 10. 
             * If the user enters a valid number, display "Valid" on the console. 
             * Otherwise, display "Invalid". 
             * (This logic is used a lot in applications where values entered into input boxes need to be validated.*/
            Console.WriteLine("Enter a number between 1 to 10");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number > 0 && number <= 10)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }

            //2- Write a program which takes two numbers from the console and displays the maximum of the two.

            Console.WriteLine("Enter two numbers");
            Console.WriteLine("Enter one number now");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2)
            {

                Console.WriteLine("Num1 is max");
            }
            else if (num1 == num2)
            {
                Console.WriteLine("numbers are equal");
            }
            else
            {
                Console.WriteLine("Num2 is max");
            }

            /*3- Write a program and ask the user to enter the width and height of an image. 
            Then tell if the image is landscape or portrait.*/

            Console.WriteLine("ENter width and hight of the image");
            Console.WriteLine("Enter Width");
            decimal width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Height");
            decimal height = Convert.ToInt32(Console.ReadLine());
            if (height == width)
            {
                Console.WriteLine("Its a portrait");
            }
            else
            {
                Console.WriteLine("Its a landscape");
            }

            /*4- Your job is to write a program for a speed camera. 
             * For simplicity, ignore the details such as camera, sensors, etc and focus purely on the logic. 
             * Write a program that asks the user to enter the speed limit. 
             * Once set, the program asks for the speed of a car. 
             * If the user enters a value less than the speed limit, program should display Ok on the console. 
             * If the value is above the speed limit, the program should calculate the number of demerit points. 
             * For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on the console. 
             * If the number of demerit points is above 12, the program should display License Suspended.*/

            Console.WriteLine("Enter the speed limit");
            int speedLimit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ENter the car speed");
            int carSpeed = Convert.ToInt32(Console.ReadLine());
            int demeritPoints = 0;
            int difference = carSpeed - speedLimit;
            if (carSpeed < speedLimit)
            {
                Console.WriteLine("OK");
            }
            else
            {
                for (int counter = 5; counter <= difference; counter++)
                {
                    if (counter % 5 == 0)
                    {
                        demeritPoints++;
                    }
                }
                Console.WriteLine(demeritPoints);

            }
            if (demeritPoints > 12)
            {
                Console.WriteLine("Liscence cancelled");
            }
            else
            {
                Console.WriteLine("you are good to go");
            }

            //Using while loop(we use while loop when we doesnt know how many times we need to execute the block of statements)
            //Example for while loop.
            // if the user enters the input(name), it displays input. If the user enetrs nothing, break then come out of the loop
            while (true)
            {
                Console.Write("Please enter the name: ");
                var input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                    break;
                Console.WriteLine(input);
            }

            //The above while loop example using continue keyword

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

            // we can generate random numbers by creating new random class
            // below example is printing 10 random numbers. 

            Random numbers = new Random();
            for (var i = 0; i <= 10; i++)
            {
                Console.WriteLine(numbers.Next());
            }

            //below example is to generate  5 random numbers from 1 - 10

            Random x = new Random();
            for (var i = 0; i <= 5; i++)
            {
                Console.WriteLine(x.Next(1, 10));
            }

            //below example is to generate a random string

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

            //Below example is to generate Random passwords.
            char[] password = new char[8];

            for (var i = 0; i < 8; i++)
            {
                password[i] = (char)('a' + s.Next(0, 26));
            }
            string generatedPassword = new string(password);
            Console.WriteLine(generatedPassword);
        }
    }
}
