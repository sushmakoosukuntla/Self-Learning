using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        public static void Main(string[] args)
        {
            var john = new personClass();
            john.FirstName = "john";
            john.LastName = "smith";
            john.Introduce();
            //********************************
            calculator c = new calculator();
            var total=c.Add(2,3);
            Console.WriteLine(total);
            //**********************************
            var result=calculator.Substract(3, 2);
            Console.WriteLine(result);
            //*******************************
            Array x = new Array();
            int Total=x.printArray();
            Console.WriteLine(Total);
            //*******************************
            StringFormat s = new StringFormat();
            var fullName = s.CombineName();
            Console.WriteLine(fullName);
            //******************USING STACK PUSH POP*************************
            string y = "SuShMa";
            Stack<char> k = new Stack<char>();
            int capCount = 0;
            for (int i = 0; i < y.Length; i++){
                if(Char.IsUpper(y[i])){
                    k.Push(y[i]);
                    Console.WriteLine("Pushed " + y[i]);
                }
                
            }
            int count = k.Count;
        //    Console.WriteLine (k.Count);        222241444
            
            for(int l = 0; l < count; l++){
         
            Console.WriteLine("count of pop " + l + "and count is " + k.Count);
                   char j = k.Pop();
            Console.WriteLine(j);
                }
            Console.ReadKey();
            

       
         

        }
    }
}
