using System;
using System.Collections.Generic;
using System.Text;

namespace udemyObjectsConstructors1
{
    public class calculatorParamsModifier
    {
        // A method with varying number of parameters
        // Addiotn method has 3 overloads
        /*Below is not the efficient way to use overloads. What if we wanted to add the 10 numbers together?, we have to 
        overload add method 10 time and thats a code smell.*/
        public void Addition(int n1, int n2) { }
        public void Addition(int n1, int n2, int n3) { }
        public void Addition(int n1, int n2, int n3, int n4) { }


        //Is therea better way to achieve this? Yes, the first step to make this code better is to use an array so instead of overloading.
        // the above same overloading methods (Which are in multiple lines) we can write it ina single line using array.

        public void Addition (int[] numbers) { }

        // so when ever we call the above mehtod, we have to craete and intialize the array in the main method like below
        // var result = calculator.Addition(new int[] {1,2,3,4,5,6})
        // so there is a simpler way to do that.  And thats when we use PARAMS mosifier.

        public void AdditionUsingParams(params int[] numbers) { }

        // so because we use params before int[] we dont to create and initialize an array.
        /*we can use the "AdditionUsingParams" in a traditional way like var result = calculator.Addition(new int[] {1,2,3,4,5,6});
        * or we can just pass the numbers like var result = calculator.Addition(1,2,3,4,5,6);*/



    }
}
