using System;

namespace Udemy5Files
{
    class Program
    {
        static void Main(string[] args)
        {
            //files provides static methods, where as file info provides instance methods.
            //C:\Users\sushm\OneDrive\Documents
            var path = @"C:\Users\sushm\OneDrive\Documents\udemyText.txt";
            //var x = Files.NoOfWordsInTextFile(path);
            //Console.WriteLine(x);
            var x = Files.LongestWord(path);
            Console.WriteLine(x);

        }
    }
}
 