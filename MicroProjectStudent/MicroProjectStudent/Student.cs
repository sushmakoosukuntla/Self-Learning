using System;
using System.Collections.Generic;
using System.Text;

namespace MicroProjectStudent
{
    class Student
    {
        public string Name { get; set; }
        public string RollNo { get; }
        public int _Class { get; set;}
        public char Section { get; set; }
        public decimal PPercentage { get; set; }
        public decimal Marks { get; set; }

        public static string schoolName = "Bhasyam";

        public static int RollNoSeed = 1;

        public static int totalPercentage;

        public Student(String name, int _class, decimal ppercentage , decimal ExamMarksOutOfTen)
        {
            this.Name = name;
            this._Class = _class;
            this.PPercentage = ppercentage;
            this.Marks = ExamMarksOutOfTen;
            this.RollNo = RollNoSeed.ToString();
            RollNoSeed++;
            Section = (PPercentage > 85) ? 'A' : 'B';
        }

        public virtual void printPercentage()
        {
            if (Marks/2 > 2.5m)  
            {
                totalPercentage = 85;
            }
            else
            {
                totalPercentage = 80; 
            }
            Console.WriteLine(totalPercentage);
        }
        
    }
}
