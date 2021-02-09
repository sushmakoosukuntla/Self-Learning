using System;
using System.Collections.Generic;
using System.Text;

namespace udemyObjectsConstructorsFields1
{
    class IndexersHttpCookie
    {
        private readonly Dictionary<string, string> dictionary;
        public IndexersHttpCookie()
        {
            dictionary = new Dictionary<string, string>();
        }

        public string this [string key]
        {
            get { return dictionary[key]; }
            set { dictionary[key] = value; }
        }
    }
}
