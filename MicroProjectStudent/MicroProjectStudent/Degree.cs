using System;
using System.Collections.Generic;
using System.Text;

namespace MicroProjectStudent
{
    class Degree : Intermediate
    {
        public decimal thirdYearMarks { get; }
        public Degree(String name, int _class, decimal ppercentage,
            decimal ExamMarksOutOfTen, decimal FirstYearMarks, decimal SecondYearMarks, decimal ThirdYearMarks) : 
            base(name, _class, ppercentage, ExamMarksOutOfTen, FirstYearMarks, SecondYearMarks)
        {
            this.thirdYearMarks = ThirdYearMarks;
        }
        public override void printPercentage()
        {
            Console.WriteLine(firstYearMarks);
            Console.WriteLine(secondYearMarks);
            Console.WriteLine(thirdYearMarks);
        }
    }
}
