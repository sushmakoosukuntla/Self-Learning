using System;
using System.Collections.Generic;

namespace Udemy4StringsAndText
{
    class Program
    {
        static void Main(string[] args)
        {

            //StringsTextBuilder.ConsecutiveNotConsecutive();
            //StringsTextBuilder.printDuplicates();
            //StringsTextBuilder.HourMinutes();
            //StringsTextBuilder.PascalCase();
            //StringsTextBuilder.VowelsCount();
            var text = StringsTextBuilder.summerizeText("sushma Kiran Reddy koosukuntla", 20);
            Console.WriteLine(text);
        }
    }
}
