using System;
using System.Collections.Generic;
using System.Text;

namespace udemyObjectsConstructors1
{
    public class customer
    {
        public int Id;
        public string Name;
        /*so below we have craeted the parameterless constructor and initialize the empty list of orders.
         * instead of that we can directly initialize the empty list of orders in the property itself like below.
         * we should choose either of the approaches.*/
        // public List<order> orders = new List<order>(); OR the below Line

        public readonly List<order> orders = new List<order>();
        

        /* we use readonly modifier to initialize the list only once
         * for example, we intitialized with out READONLY modifier in the class, and 
         * again we initialize the orders list in tha method(for example in promote method)
         * when we call the promote method, all the orders data will be lost and we get 0 in the orders list
         * So if we use READONLY modifier, when we try to initialize the orders list again  in the promote method,
         * we get a compile time error.

        /*when ever we create the list property, we have to initialize an empty list in the parameterless contructor.
         * If we dont initialize the empty list, when we create the order in main, and try to add that order to the list, we get Null reference exception
         * because orders was not initialized and by default it will set to null. */
        /*from the main we should not create the empty list of orders, its not the resposibility of that class. 
         * In the main method we just create the new order.*/

        //If the still want the default or parameter less contructor, we have to create a parameterless contructor.

       /* public customer()
        {
             orders = new List<order>();
        }*/
        public customer(int id)
            // :this() //so before we call the this constructor, we call the constructor with out parameters which will initialize the empty list of orders.
        {
            this.Id = id;
        }
        //overloading the contructor

        public customer(int id, string name)
            :this(id)
        {            
            this.Name = name;
        }

        // we are writing a method 

        public void Promote()
        {

        }

    }
}