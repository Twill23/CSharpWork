using System;

namespace Classes_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            //create an object of my class
            //an instace of human
            Human drop = new Human("Drop","You","blue",35);
            drop.IntroduceMyself();

            Human jock = new Human("Jock", "Boy", "Brown");
            jock.IntroduceMyself();

            Human bad = new Human();
            bad.IntroduceMyself();

            Human trav = new Human("Trav");
            trav.IntroduceMyself();

            Human mike = new Human("Mike", "Jackson");
            mike.IntroduceMyself();

            Human jake = new Human("Jake", "Johnson", 34);
            jake.IntroduceMyself();

            //access public variable from outside, and enen change it
            
            //call methods of the class
            

           
            Console.ReadKey();

        }
    }
}
