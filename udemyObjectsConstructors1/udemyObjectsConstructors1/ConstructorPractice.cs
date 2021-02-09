using System;
using System.Collections.Generic;
using System.Text;

namespace udemyObjectsConstructors1
{
    class ConstructorPractice
    {
        public string Name;
        public ConstructorPractice(string name)
        {
            //this is a keyword that references the current object
            this.Name = name;
            //we cannot have two overloadning contructors with exact same parameters
            // we opt for overloading construtots because to make the initialization easier
        }
                    
    }
}
