using System;

namespace Udemy3
{
    class Program
    {
        static void Main(string[] args)
        {
            var date = new DateTime(2021, 1, 1);
            var now = DateTime.Now;
            var today = DateTime.Today;

            //Console.WriteLine("Hour: " + now.Hour);
            //Console.WriteLine("Hour: " + now.Minute);

            /*some of the properties are immutable. we cannot change them. 
             * Example: Datetime.Now is a immutable property. 
             * we can just add days to that property but we cannot modify the property itself.
             * simply there is no set for the property.*/

            var tommorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);
            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());
            //ToString() method optionally takes an argument
            Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm"));

            // type in google: C# date and time format specifier and we can look over all the formats.

            //************************Creating TIME SPAN objects **************************************************


            var timespan = new TimeSpan(12, 2, 30);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;
            Console.WriteLine("Duration: " + duration);

            //***********************TIME SPAN Properties **************************************************

            Console.WriteLine("Minutes in timespan: " + timespan.Minutes);
            Console.WriteLine("Total Minutes: " + timespan.TotalMinutes);

            Console.WriteLine("Add Example: " + timespan.Add(TimeSpan.FromMinutes(8)));
            Console.WriteLine("Substract Example: " + timespan.Subtract(TimeSpan.FromMinutes(2)));

            //Conversion from to and From strings**********************************************
            Console.WriteLine("To String: " + timespan.ToString());

            // from string we use parse.

            Console.WriteLine("parse: " + TimeSpan.Parse("12:02:30"));

            
        }
    }
}
