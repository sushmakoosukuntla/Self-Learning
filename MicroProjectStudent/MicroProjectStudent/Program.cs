using System;

namespace MicroProjectStudent
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("sushma", 10, 80, 7);
            s.printPercentage();
            Console.WriteLine($"sushma Roll No is {s.RollNo}");

            Student k = new Intermediate("Kiran", 2, 85, 7, 3.5m, 3.5m);
            k.printPercentage();
            Console.WriteLine($"Kiran Roll No is {k.RollNo}");
        } 
    }
}
