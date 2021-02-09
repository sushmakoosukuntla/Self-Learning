using System;
using System.Collections.Generic;
using System.Text;

namespace Udemy4StringsAndText
{
    class StringsTextBuilder
    { 
        /*1- Write a program and ask the user to enter a few numbers separated by a hyphen. 
        * Work out if the numbers are consecutive. For example, 
        * if the input is "5-6-7-8-9" or "20-19-18-17-16", 
        * display a message: "Consecutive"; otherwise, display "Not Consecutive".*/
        public static void ConsecutiveNotConsecutive()
        {
            Console.WriteLine("Enter a few numbers separated by hyphen");
            var numbers = Console.ReadLine();
            var numsArray = numbers.Split('-');
            var newArray = new int[numsArray.Length];
            bool consecutiveFound = true;
            for(var i = 0; i< newArray.Length; i++)
            {
                newArray[i] = Convert.ToInt32(numsArray[i]);
            }
            for (var i = 0; i < newArray.Length - 1; i++)
            {
                if ((newArray[i] + 1 == newArray[i + 1]) || ((newArray[i] - 1) == newArray[i + 1]))
                {
                    consecutiveFound = true;
                }

                else
                {
                    consecutiveFound = false;
                    Console.WriteLine("Not consecutive");
                    break;
                }
            }
            if (consecutiveFound == true)
            {
                Console.WriteLine("consecutive");
            }

        }

        //STring summarizing 
        public static string summerizeText(string text, int maxLength = 20) 
        {
            if (text.Length  < maxLength)
                return text;
            var words = text.Split(' ');
            var totalCharacters = 0;
            var summaryWords = new List<string>();
            foreach(var word in words)
            {
                summaryWords.Add(word);
                totalCharacters += word.Length;
                if(totalCharacters > maxLength)                
                    break;                
            }
              return string.Join(" ", summaryWords) + "...";                
        }

        /*2- Write a program and ask the user to enter a few numbers separated by a hyphen. 
         * If the user simply presses Enter, without supplying an input, exit immediately; 
         * otherwise, check to see if there are duplicates. If so, display "Duplicate" on the console.*/
         public static void printDuplicates()
         {
            var duplicateList = new List<int>();
            Console.WriteLine("Enter a few numbers separated by hyphen");
            var numbers = Console.ReadLine();
            if (numbers != "")
            {
                var numbersArray = numbers.Split('-');
                var newArray = new int[numbersArray.Length];
                for (var i = 0; i < numbersArray.Length; i++)
                {
                    newArray[i] = Convert.ToInt32(numbersArray[i]);
                }
                for (var j=0; j<numbersArray.Length-1; j++)
                {
                    var duplicates = Array.IndexOf(newArray, newArray[j], j+1);
                    if (duplicates != -1)
                    {
                        duplicateList.Add(newArray[j]);
                    }                   
                }
                if (duplicateList.Count == 0)
                {
                    Console.WriteLine("no duplicates");
                }
                foreach(var dups in duplicateList)
                {
                    Console.WriteLine(dups);
                }
            }   

         }

        /*3- Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00). 
         * A valid time should be between 00:00 and 23:59. If the time is valid, display "Ok"; 
         * otherwise, display "Invalid Time". If the user doesn't provide any values, consider it as invalid time.*/

        public static void HourMinutes()
        {

            //var Input = Convert.ToDateTime(Console.ReadLine()).ToString("HH");
            //if (String.IsNullOrWhiteSpace(Input))
            //{
            //    Console.WriteLine("Invalid Time");

            //}
            //else
            //{
            //    var inputArray = new int[2];
            //    var timeArray = Input.Split(":");
            //    for (var i = 0; i < inputArray.Length; i++)
            //    {
            //        inputArray[i] = Convert.ToInt32(timeArray[i]);
            //    }
            //    if (inputArray[0] >= 0 || inputArray[1] <= 23)
            //        Console.WriteLine("Valid Time");

            //    else
            //        Console.WriteLine("Invalid Time");
            var Input = Convert.ToDateTime(Console.ReadLine()).ToString("HH");

            if (Convert.ToByte(Input) >= 0 || Convert.ToByte(Input) <= 23)
                Console.WriteLine("Valid Time");

            else
                Console.WriteLine("Invalid Time");
        }

        /*4- Write a program and ask the user to enter a few words separated by a space. 
         * Use the words to create a variable name with PascalCase. 
         * For example, if the user types: "number of students", display "NumberOfStudents". 
         * Make sure that the program is not dependent on the input. 
         * So, if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents".*/

        public static void PascalCase()
        {
            Console.WriteLine("Enter words separated by space");
            var sentence = Console.ReadLine().ToLower();
            if (sentence != "")
            {
                var newString = new StringBuilder();
                newString.Append(Char.ToUpper(sentence[0]));
                for (var i = 1; i < sentence.Length; i++)
                {
                    if (sentence[i] == ' ')
                    {
                        newString.Append(char.ToUpper(sentence[i + 1]));
                        i++;
                    }
                    else
                    {
                        newString.Append(sentence[i]);
                    }
                }
                Console.WriteLine(newString);
            }
            else 
            {
                Console.WriteLine("empty");
            }

        }

        /*5- Write a program and ask the user to enter an English word. 
         * Count the number of vowels (a, e, o, u, i) in the word. 
         * So, if the user enters "inadequate", the program should display 6 on the console.*/ 

        public static void VowelsCount()
        {
            var count = 0;
            var vowels = "aeiou";
            Console.WriteLine("Please enter a word");
            var word = Console.ReadLine().ToLower();
            for (var i = 0; i < word.Length; i++)
            {                
                var search = vowels.IndexOf(word[i]); //searching word[i] in vowels
                //Indecof method has many overloads, please check API before you call.
                if (search != -1)
                {
                    count++;
                }
            }
            Console.WriteLine(count);           
        }        
    }
}
