using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using testbasics;

namespace basics
{
    class helloworld
    {
        static void Main(String[] args)
        {
            Console.WriteLine("hello world11");
            Console.WriteLine("*********CALLING A FUNCTION PRINT FROM CLASS FAN********************************");
            //Fan f = new Fan();
            //f.wings = 3; //set
            //Console.WriteLine(f.wings); //get
            //Fan g = new Fan();
            //g.wings = 4;
            Fan.print();
            Console.WriteLine("******CALLING A FUNCTION MYCOST FROM CLASS AC***********************************");
            int cost = Ac.MyCost();

            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(cost + 500);
                }
                else
                {
                    Console.WriteLine(cost);
                }

            }
            Console.WriteLine("*********STRING INTERPOLATION********************************");
            string name = "sushma";
            Console.WriteLine($"My name is {name}");
            Console.WriteLine("*****************************************");

            string firstFriend = "kiran";
            string secondFriend = "Rudransh";
            Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");

            Console.WriteLine("*********LENGTH OF A STRING*********************");
            Console.WriteLine($"{firstFriend} has {firstFriend.Length} letters");
            Console.WriteLine($"{secondFriend} has {secondFriend.Length} letters");

            Console.WriteLine("**************SPACE TRIM***************************");
            String greeting = "        Hello World   ";
            Console.WriteLine($"*****{greeting}*****");
            //The output will be with the spaces. We can trim the spaces by using TrimStart and TrimEnd functions
            string trimmedGreeting = greeting.TrimStart();
            Console.WriteLine($"{trimmedGreeting}");
            trimmedGreeting = greeting.TrimEnd();
            Console.WriteLine($"{trimmedGreeting}");
            trimmedGreeting = greeting.Trim();
            Console.WriteLine($"{trimmedGreeting}");

            Console.WriteLine("**************REPLACING***************************");
            String sayHello = ("Heloo World");
            Console.WriteLine(sayHello);
            sayHello = sayHello.Replace("Hello", "Greeting");
            Console.WriteLine(sayHello);

            Console.WriteLine("**************UPPER AND LOWER***************************");
            Console.WriteLine(sayHello.ToUpper());
            Console.WriteLine(sayHello.ToLower());

            Console.WriteLine("**************STRING SEARCHING***************************");
            string lyrics = "Good morning hyderabad";
            var result = lyrics.Contains("morning");
            Console.WriteLine(result);
            Console.WriteLine(lyrics.Contains("Good"));
            Console.WriteLine(lyrics.Contains("bye"));
            Console.WriteLine(lyrics.StartsWith("Good"));

            Console.WriteLine("**************INTEGER PRECISION***************************");
            int a = 16;
            int b = 3;
            int c = a / b;
            int d = a % b;
            //a%b gives the remainder
            Console.WriteLine($"Division valu is {c}");
            Console.WriteLine($"Remainder is {d}");

            Console.WriteLine("**************MIN AND MAX VALUES***************************");
            int min = int.MinValue;
            int max = int.MaxValue;
            Console.WriteLine($"The min and max values in C# are {min} and {max}");

            Console.WriteLine("**************DECIMAL MIN AND MAX VALUES***************************");
            decimal mini = decimal.MinValue;
            decimal maxi = decimal.MaxValue;
            Console.WriteLine($"The range of decimal type in C# are {mini} and {maxi}");
            double e = 1.0;
            double f = 3.0;
            Console.WriteLine(e / f);
            decimal g = 1.0M;
            decimal h = 3.0M;
            Console.WriteLine(g / h);
            int mini1 = int.MinValue;
            int maxi1 = int.MaxValue;
            Console.WriteLine($"The range of int type in C# are {mini1} and {maxi1}");
            long mini2 = long.MinValue;
            long maxi2 = long.MaxValue;
            Console.WriteLine($"The range of long type in C# are {mini2} and {maxi2}");
            short mini3 = short.MinValue;
            short maxi3 = short.MaxValue;
            Console.WriteLine($"The range of long type in C# are {mini3} and {maxi3}");

            Console.WriteLine("*************AREA OF A CIRCLE***************************");
            double radius = 2.50;
            double area = Math.PI * radius * radius;
            Console.WriteLine($"Area of a circle is {area}");

            Console.WriteLine("*************BRANCHES AND LOOPS***************************");
            a = 10;
            b = 5;
            if (a + b < 20)
            {
                Console.WriteLine("The result is less than 20");
            }
            else
            {
                Console.WriteLine("The result is greater than 20");
            }
            Console.WriteLine("*************&& ||***************************");
            a = 10;
            b = 5;
            c = 10;
            if ((a + b + c < 20) && (a == b))
            {
                Console.WriteLine("The result is less than 20");
                Console.WriteLine(" a = b");
            }
            else
            {
                Console.WriteLine("The result is greater than 20");
                Console.WriteLine("Or a != b");
            }
            Console.WriteLine("****************************************");
            a = 5;
            b = 5;
            c = 2;
            if ((a + b + c < 20) || (a == b))
            {
                Console.WriteLine("The result is less than 20");
                Console.WriteLine(" a = b");
            }
            else
            {
                Console.WriteLine("The result is greater than 20");
                Console.WriteLine("and a != b");
            }
            Console.WriteLine("**************WHILE AND FOR LOOPS**************************");
            int count = 0;
            while (count < 10)
            {
                Console.WriteLine($"The count is {count}");
                count++;
            }
            Console.WriteLine("**We can also write the while loop using do**************************");
            count = 0;
            do
            {
                Console.WriteLine($"The count is {count}");
                count++;
            } while (count < 10);
            Console.WriteLine("**we can also write using FOR LOOP***");
            for (int index = 0; index < 10; index++)
            {
                Console.WriteLine($"The count is {index}");
            }
            Console.WriteLine("******SUM OF ALL INTEGERES 1 THROUGH 20 THAT ARE DIVISBLE BY 3*******");
            int sum = 0;
            for (int i = 0; i <= 20; i++)
            {
                if (i % 3 == 0)
                {
                    sum += i;

                }
            }
            Console.WriteLine(sum);

            Console.WriteLine("******ARRAYS LISTS AND COLLECTIONS*******");
            Console.WriteLine("******LIST OF STRINGS*******");
            var names = new List<String> { "scott", "kendra", "sushma", "kiran", "Rudransh" };
            names.Remove(names[0]);
            for (int i = 0; i<names.Count; i++)
            {
                Console.WriteLine($"Hello {names[i].ToUpper()}!"); 
            }

            Console.WriteLine("******LIST OF NUMBERS*******");
            var numbers = new List<int> {1,3,5,7,2,4,8,9,0};
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine($"Hello {numbers[i]}!");
            }

            Console.WriteLine("******LIST OF NUMBERS SUM*******");
            sum = 0;
            numbers = new List<int> { 1, 3, 5, 7, 2, 4, 8, 9, 0 };
            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];

            }
            Console.WriteLine(sum);

            Console.WriteLine("*****SORT SEARCH AND INDEX LISTS*******");
            var colors = new List<String> { "Red", "Orange", "Green", "Yellow", "Purple" };
            colors.Add("Blue");
            colors.Add("Brown");
            colors.Sort();
            foreach(var color in colors)
            {
                Console.WriteLine(color);
            }
            var position  = colors.IndexOf("Brown");
            Console.WriteLine($"position of Brown is {position}");

            Console.WriteLine("******LISTS OF OTHER TYPES*******");
            Console.WriteLine("******PRINT FIRST 20 FIBANACCI SERIES*******");
            var fibanacciNumbers = new List<int> { 1, 1 };
            while (fibanacciNumbers.Count < 20)
            {
                var previous1 = fibanacciNumbers[fibanacciNumbers.Count - 1];
                var previous2 = fibanacciNumbers[fibanacciNumbers.Count - 2];

                fibanacciNumbers.Add(previous1 + previous2);
            }
            foreach (var item in fibanacciNumbers)
                Console.WriteLine(item);            
            Console.ReadKey();
        }
    }
}