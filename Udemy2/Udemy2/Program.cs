using System;
using System.Collections.Generic;

namespace Udemy2
{
    class Program
    {
        //The difference between the RECTANGULAR ARRAY and JAGGED ARRAY is
        // RECTANGULAR ARRAY is represented as var Array = new int [3, 1];
        //JAGGED ARRAY is represented as var Aray = new int [3][];
        /*ARRAY is a class and it has some properties LENGTH is a property and some of the funtions are 
         * Clear(); Copy(); IndexOf(); Reverse();  Sort();*/

        /* ********************************************************************************
         * *********************************************************************************/

        /*LIST is same like ARRAY, but in LIST there is no need to specofy the size. If we doesnt 
        Know the length of the object, we can use use LISTS*/
        /* LIST is a class and some of the methods in LIST are Add(), AddRange(), Remove(),
         * RemoveAt(), IndexOf(), Contains(), and Count is a property*/

        //*********************************************************************************
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            //Indexof()
            var index = Array.IndexOf(array, 3);
            Console.WriteLine("The index of 3 is: " + index);

            //Clear()
            Array.Clear(array, 0, 2);
            Console.WriteLine("Effect of clear");
            foreach (var nums in array)
            {
                Console.WriteLine(nums);
            }
            //The output will be 0,0,3,4,5,6,7,8

            //copy()
            Console.WriteLine("Copies elements in the array");
            int[] another = new int[3];
            Array.Copy(array, another, 3);
            foreach (var nums in another)
                Console.WriteLine(nums);
            // the output of another array will be 0,0,3

            //sort()
            Array.Sort(array);
            Console.WriteLine("sorted elements in an array");
            foreach (var items in array)
                Console.WriteLine(items);

            //Reverse()

            Array.Reverse(array);
            Console.WriteLine("Effect of reverse method");
            foreach (var items in array)
                Console.WriteLine(items);

            // LISTS**************************************************************************
            //Add(), AddRange(), Remove(),
            //RemoveAt(), IndexOf(), Contains(), Count()
            Console.WriteLine("LISTS*******************************************");
            var integers = new List<int>() { 8, 5, 2, 4, 6, 1, 8, 4 };
            Console.WriteLine("Add()");
            //Add()
            integers.Add(6);

            //AddRange()
            Console.WriteLine("AddRange()");
            integers.AddRange(new int[] { 1, 5, 9 });
            foreach (var numbers in integers)
                Console.WriteLine(numbers);


            //Remove()
            //We cannot remove the object from array or list in foreach loop
            Console.WriteLine("Remove()");
            for (var i = 0; i < integers.Count; i++)
            {
                if (integers[i] == 8)
                {
                    integers.Remove(integers[i]);
                }
            }
            foreach (var items in integers)
                Console.WriteLine(items);

            //Indexof()
            Console.WriteLine("IndexOf()");
            Console.WriteLine("Index of 1 is: " + integers.IndexOf(1));
            Console.WriteLine("Index of 1 is: " + integers.LastIndexOf(1));

            //Clear()
            Console.WriteLine("Clear()");
            integers.Clear();
            Console.WriteLine("count is: " + integers.Count);

            // ARRAY LIST ******************************** CALLING FUNCTIONS
            var p = new ArraysLists();
            //p.NameEnterExit();
            //p.ReverseName();
            p.FiveUniqueNumbers();
            //p.NumberOkQuit();
            //p.CommaSeparatedNumbers();
        }
        
    }
}
