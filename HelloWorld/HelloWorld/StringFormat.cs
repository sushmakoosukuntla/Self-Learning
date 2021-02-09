using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class StringFormat
    {
        public string CombineName()
        {
            var firstName = "Sushma";
            var middleName = "reddy";
            var lastName = "koosukuntla";
            var fullName = string.Format("\"{0} <3 {1} <3 {2}\"", firstName, middleName, lastName);
            return fullName;
        }
    }
}
