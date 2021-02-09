using System;
using System.Collections.Generic;
using System.Text;

namespace UdemyInheritance3
{
    public class Text : PresentationObject
    {
        public int fontSize { get; set; }

        public string fontName { get; set; }

        public void HyperLink(string Url)
        {
            Console.WriteLine("We added a link to " + Url);
        }
    }
    
}
