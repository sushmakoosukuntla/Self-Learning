using System;
using System.Collections.Generic;
using System.Text;

namespace Udemy2
{
    class ArraysLists
    {
        /* 1- When you post a message on Facebook, depending on the number of people who like your post, 
         * Facebook displays different information.
        If no one likes your post, it doesn't display anything.
        If only one person likes your post, it displays: [Friend's Name] likes your post.
        If two people like your post, it displays: [Friend 1] and[Friend 2] like your post.
        If more than two people like your post, it displays: 
        [Friend 1], [Friend 2] and[Number of Other People] others like your post.
        Write a program and continuously ask the user to enter different names, 
        until the user presses Enter (without supplying a name). 
        Depending on the number of names provided, display a message based on the above pattern.*/
        public void NameEnterExit()
        {
            var s = new List<string>();
            while (true)

            {
                Console.WriteLine("Please enter name: ");
                string test = Console.ReadLine();
                if (test == "")
                {
                    if (s.Count == 1)
                    {
                        Console.WriteLine(s[0] + "Likes your post");

                    }
                    else if (s.Count == 2)
                    {
                        Console.WriteLine("{0} and {1} likes your post", s[0], s[1]);
                    }
                    else if (s.Count > 2)
                    {
                        Console.WriteLine("{0},{1} and {2} others likes your post", s[0], s[1], (s.Count)-2);
                    }
                break;                    
                }
                else
                {  
                    s.Add(test);
                }
                
            }
            
        }

        /*2- Write a program and ask the user to enter their name. 
         * Use an array to reverse the name and then store the result in a new string. 
         * Display the reversed name on the console.*/

        public void ReverseName()
        {
            Console.WriteLine("Please eneter a name: ");
            var name = Console.ReadLine().ToLower();
            var n = new char [name.Length];
            for(int i =0; i < name.Length; i++)
            {
                n[i] = name[i];
            }
            Array.Reverse(n);
            string s = new string(n);
            Console.WriteLine(s);
               
        }

        /*3- Write a program and ask the user to enter 5 numbers. 
         * If a number has been previously entered, display an error message and ask the user to re-try.
         * Once the user successfully enters 5 unique numbers, sort them and display the result on the console.*/
        public void FiveUniqueNumbers()
        {

            var number = new int[5];
            Console.WriteLine("Enter 5 unique numbers");

            for (int i = 0; i < 5; i++)
            {
                while (true)
                {
                    int value = 0;
                    var newValue = Console.ReadLine();
                    if (char.IsDigit(newValue[0]))
                    {
                        value = Convert.ToInt32(newValue);
                    }
                    else
                    {
                        continue;
                    }
                    var NumPosition = Array.IndexOf(number, newValue);
                    if (NumPosition == -1)
                    {
                        number[i] = newValue[0]; // Accept New value
                        break;
                    }
                      
                }
            }

            Array.Sort(number);
            Console.WriteLine();

            foreach (var n in number)
                Console.WriteLine(n);
        }

        /*4- Write a program and ask the user to continuously enter a number or type "Quit" to exit. 
         * The list of numbers may include duplicates. Display the unique numbers that the user has entered.*/

        public void NumberOkQuit()
        {
            var number = new List<int>();
            while (true)
            {
                Console.WriteLine("Please enter a number or quit to exit");
                var test = Console.ReadLine().ToLower();
                if(test == "quit")
                {
                    break;
                }
                else
                {
                    var testPosition = number.IndexOf(Convert.ToInt32(test));
                    if (testPosition == -1)
                    {
                        number.Add(Convert.ToInt32(test)); // Accept New value
                    }
                    else
                    {
                        Console.WriteLine("Number already there, so not adding to the list");
                    }
                }   
            }
            foreach(var items in number)
                Console.WriteLine(items);
            Console.ReadLine();
        }

        /*5- Write a program and ask the user to supply a list of comma separated numbers(e.g 5, 1, 9, 2, 10). 
         * If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try;
         * otherwise, display the 3 smallest numbers in the list.*/
        public void CommaSeparatedNumbers()
        {          
            var smallestList = new List<int>();
            var integers = new List<int>();
            while (true)
            {               
                Console.WriteLine("Please enter list of comma separated numbers: ");
                var numbers = Console.ReadLine();
                string[] number = numbers.Split(',');
                foreach(var ints in number)
                {
                    integers.Add(Convert.ToInt32(ints));
                }
                
                if(integers.Count < 5)
                {
                    Console.WriteLine("Invalid List, please retry");
                }
                else
                {
                    integers.Sort();
                    for(var i = 0; i<3; i++)
                    {
                        smallestList.Add(integers[i]);
                    }
                    break;
                }
                              
            }
            foreach (var smalls in smallestList)
                Console.WriteLine(smalls);
            Console.ReadLine();
            

        }
    }
}
