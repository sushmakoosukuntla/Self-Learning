using System;
using System.Collections.Generic;
using System.Text;

namespace MicroProjectStudent
{
    class Btech : Degree
    {
        public decimal fourthYearMarks { get; }
        public Btech(String name, int _class, decimal ppercentage,
            decimal ExamMarksOutOfTen, decimal FirstYearMarks, decimal SecondYearMarks, decimal ThirdYearMarks, decimal FourthYearMarks) : 
            base(name, _class, ppercentage, ExamMarksOutOfTen, FirstYearMarks, SecondYearMarks, ThirdYearMarks)
        {
            this.fourthYearMarks = FourthYearMarks;
        }
        public override void printPercentage()
        {
            Console.WriteLine(firstYearMarks); 
            Console.WriteLine(secondYearMarks);
            Console.WriteLine(thirdYearMarks);
            Console.WriteLine(fourthYearMarks);
        }
    }
}
