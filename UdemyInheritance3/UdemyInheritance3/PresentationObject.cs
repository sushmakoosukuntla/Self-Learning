using System;
using System.Collections.Generic;
using System.Text;

namespace UdemyInheritance3
{
    public class PresentationObject
    {

        // Inheritance is a kind of realationship   or assciation between classes and it has 2 benifits
        // one is code reuse and other is polymorphic behaviour
        public int width { get; set; }
        public int height { get; set; }

        public void Copy()
        {
            Console.WriteLine("object copied to the clip board");
        }

        public void Duplicate()
        {
            Console.WriteLine("object is duplicated"); 

        }
    }
}
