using System;
using System.Collections.Generic;
using System.Text;

namespace MicroProjectStudent
{
    class Intermediate : Student
    {
        public decimal firstYearMarks { get; }
        public decimal secondYearMarks { get; }
        public Intermediate(String name, int _class, decimal ppercentage,
            decimal ExamMarksOutOfTen, decimal FirstYearMarks, decimal SecondYearMarks) :
            base(name, _class, ppercentage, ExamMarksOutOfTen)
        {
            this.firstYearMarks = FirstYearMarks;
            this.secondYearMarks = SecondYearMarks;
        }
        public override void printPercentage()
        {
            Console.WriteLine(firstYearMarks);
            Console.WriteLine(secondYearMarks);
        }
    }
}
