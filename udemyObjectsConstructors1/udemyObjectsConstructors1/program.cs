using System;
using udemyObjectsConstructorsFields1;

namespace udemyObjectsConstructors1
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = new customer(3, "sushma");
            //let us see the effect of default constructor c# creates for customer class.
            Console.WriteLine("Id is {0}", x.Id);
            Console.WriteLine("Name is {0}", x.Name);

            // we can also initialize the object in the below way
            // below is the another kind of object initialization syntax
            // the object cannot behave without passing intialization values.
            /*var person = new person
                            {
                                FirstName = "Mosh",
                                LastName = "josh"
                            };
*/

            //**********************POINT CLASS CALLING **********************************************************
            try
            {
                var point = new Point(10, 20);
                point.move(new Point(40, 60));
                Console.WriteLine("Points are ({0}, {1})", point.x, point.y);

                point.move(100, 200);
                Console.WriteLine("Points are ({0}, {1})", point.x, point.y);
            }
            catch (Exception)
            {
                Console.WriteLine("AN UNEXPECTED ERROR OCCURED");
            }

            //*********************PERSON CLASS CALLING**********************************************************

            var p = new person(new DateTime(1990, 11, 24));
            Console.WriteLine(p.Age);
           

            //*********************cCALLING INDEXERSHTTPCOOKIE**********************************************************


            var cookie = new IndexersHttpCookie();
            cookie["name"] = "sushma";
            Console.WriteLine(cookie["name"]);
        }
    }
}
