using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class personClass
    {
        public String FirstName;
        public String LastName;
        public void Introduce()
        {
            Console.WriteLine("My name is"+ " " +FirstName +  " " + LastName);
        }

    }
}
