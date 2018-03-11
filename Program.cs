using System;

namespace classCsharp2
{
    class Program
    {
        class Person
        {
            //Fields are private, they hold data, so we don't want people to have access and change it
            private string _Name;
            private int _Age;

            //Properties
            public sting Name 
            {
                get
                {
                    if (_Name == "Bob")
                    {
                        _Name = "Bobby";
                    }
                    return _Name;
                } set
                    _Name = value;
                   // _Name = $"Hello {value}";
                {
                     
            }
            public int PhoneNumber {get; set; }//you need a private field to hold the data

            //Constructors
            public Person(string name, int age)
            {
                Name = name;
                _Age = age;//we can access in the class without property (get and set) just putting the sign on the front of the name
            }

            //Method
            public /*static*/ string SayHello(string n, int a)
            {
                //return $"hello my name is ${n} and I am ${a} years old";
                return $"hello my name is ${Name} and I am ${Age} years old";
                //return $"hello my name is ${Name} and I am ${_Age} years old"; //if you just add a sign in front of Age
            }
        }
        static void Main(string[] args)
         {
           /* var jeff = new Person();
            jeff.Name = "Jeff";
            jeff.Age = 35;

            var lucy = new Person();
            lucy.Name = "Lucy";
            lucy.Age = 32;
            Console.WriteLine($"Heloo {jeff.Name}, {jeff.Age}");*/


            var jeff = new Person("Jeff", 35);
            
            Console.WriteLine(jeff.SayHello();)
            


        }




        /*{
            Console.WriteLine(Greeting("Lisa"));
        }
        static string Greeting(string name)
        {
            return $"Hello {name}";
        }*/

    }
}
