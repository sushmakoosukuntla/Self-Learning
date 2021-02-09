using System;
using System.Collections.Generic;
using System.Text;

namespace udemyObjectsConstructors1
{
    public class RefAndOutModifier
    {
        public void MyMethod(int a)
        {
            a += 2;
        }
        /*so we call the baove method like var a =2 , RefModifier.MyMethod(a)
         * so after returning from this method what will be the value of a? it will be 2 because a is a value type.*/

        //so now I am adding REF to the parameter
         public void DoAWieredThing(ref int a)
        {
            a += 2;
        }
        //* so after returning from this method what will be the value of a? it will be 3 because the original a will be passed.*/

        public void MyMethodOut(out int result)
        {
              result = 1;
        }
        
        //so we call the baove method like int a  , RefModifier.MyMethodOut(out a);
    }

}
