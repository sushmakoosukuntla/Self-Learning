using System;
using System.Collections.Generic;
using System.Text;

namespace udemyObjectsConstructors1
{
    public class person
    {
        // we are using private access modifier here. Because its private, the object in the main method cannot access this property


        //private DateTime BirthDate; *****************************

        // if we use private modifier and write get and set methods, we can actully implement what we want in the method.
        //so now lets write SetBirthdate and GetBirthdate methods 

        /*public void SetBirthdate(DateTime birthdate) ********************
        {
            BirthDate = birthdate;
        }

        public DateTime GetBirthdate()
        {
            return BirthDate;
        } ****************************************************************************** */ 

        // So if there is no implementation we can write the above property in the below way.
        // public DateTime BirthDate { get; set; }  // Backened Auto implementation will happen, and Birthdate can be set after creating the object too

        /*Now we are writing a con structor for person which take Birthdate as a parameter and we can set the property of BirthDate to private
         * so that once the object is create by giving birthdate value in the parameter, thats it we cannot acces that again.    */
        
        public DateTime BirthDate { get; private set; }
        public int Age
        {
            /*so always the age depends on birthdate. so we need to implement this property, 
             * Auto implementation doesnt work for this property.*/
            get
            {
                var timeSpan = DateTime.Today - BirthDate;
                var years = timeSpan.Days / 365;
                return years;
            }
        }
        public string Name { get; set; }

        public person(DateTime birthDate)
        {
            this.BirthDate = birthDate;
        }
    }
}   
