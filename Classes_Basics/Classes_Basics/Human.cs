using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_Basics
    // add two or more member variables to "Human". eyeColor and age
    //adjust thr Constructor, so it requires all of the four values to be used, when creating an object of Human.
    //create two objects of type human

    //this class is a blueprint for a datatype
{
    class Human
    {
        //1. member variable
       private string firstName;
       private string lastName;
        public string eyeColor;
        private int age;

        //default constructor
        public Human()
        {
            Console.WriteLine("Constructor called.Object created");

        }

        //COnstructer paramterized5
        public Human(int age)
        {
            this.age = age;
        }


        //COnstructer paramterized4
        public Human(string firstName)
        {
            this.firstName = firstName;
        }

        //COnstructer paramterized3
        public Human(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        //COnstructer paramterized2
        public Human(string firstName, string lastName, string eyeColor)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
           
        }

        //COnstructer paramterized
        public Human(string firstName, string lastName, string eyeColor, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age;
        }


        //COnstructer paramterized6
        public Human(string firstName, string lastName,int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }




        //member
        public void IntroduceMyself()
        {
            if(age != 0 && lastName != null && eyeColor != null && firstName != null)
            {
                Console.WriteLine("Hi, I'm {0} {1} and {2} years old. My eye color is {3}", firstName, lastName,age, eyeColor);

            }
            else if(age != 0 && lastName != null && firstName != null)
            {
                Console.WriteLine("Hi, I'm {0} {1} and {2} years old.", firstName, lastName,age);

            }

            else if (lastName != null && firstName != null)
            {
                Console.WriteLine("Hi, I'm {0} {1}. ", firstName, lastName);

            }

            else if (firstName != null )
            {
                Console.WriteLine("Hi, I'm {0}",  firstName);

            }

        }
    }
}
