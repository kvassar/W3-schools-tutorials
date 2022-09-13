using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
    internal class Program
    {

        static void MyMethod()
        {
            Console.WriteLine("Kal is awsome!");
            Console.WriteLine("Who is awsome?");
            Console.ReadLine();
            Console.WriteLine("If you wrote Kal you were right but YOU are awsome!");
        }

        static int MyMethod2(int x, int y)
        {
            return x + y;

        }
        /*
        static void Madlib(string adjective, string noun, string name, string verb)
        {
            
             Console.WriteLine($"Last week your best friend {name} tried to be funny and prank me. I feel realy bad for his atempt to {verb} me. Lets just say that it ended badly for everyone involved. The {noun} was a funny decision. I wouldent have used it to scare me but ok, it was {adjective} though. ");
        }
        */

        
        static void Main(string[] args)
        {
            Console.WriteLine("Helllo World");
            Console.Write("This is my first time ");
            Console.Write("just using write instead of WritLine.");

            //The following is a multiy line comment. This line is a single line comment.

            /*
            Console.WriteLine("blah blah blah I am going to comment this out");
            Console.WriteLine("Nothing to see here. Nothing to see at all");
            Console.WriteLine("I think I am so funny :)");

            */

            int myFavoriteNum = 38;
            Console.WriteLine(myFavoriteNum);

            int myNum = 50;
            string myName = "John";

            int x = 5;
            int y = 10;
            Console.WriteLine(x + y);

            int z = x + y;
            Console.WriteLine(z);

            int a = 5, b = 6, c = 50;
            Console.WriteLine(a + b + c);

            int myNum2 = 9;
            double myDoubleNum = 8.99;
            char myLetter = 'A';
            bool myBoolean = false;
            string myText = "Hello world";

            bool yay = true;
            bool nay = false;

            string greeting = "Hello";
            Console.WriteLine(greeting);

            // Example of implicite casting 

            int num1 = 2;
            double newNum1 = num1;

            Console.WriteLine(num1);
            Console.WriteLine(newNum1);

            //Example of explicite casting 

            double expliciteCasting = 9.78;
            int explicitCasted = (int)expliciteCasting;

            Console.WriteLine(expliciteCasting);
            Console.WriteLine(explicitCasted);

            // Example of ReadLine 
            /*
             * Console.WriteLine("Enter username: ");
             * String userName = Console.ReadLine();
             * Console.WriteLine("Username is : " + userName);
            */

            //Example of ReadLine with explicit conversion 
            /*
             * Console.WriteLine("Think of a nuber:");
             * int myNum3 = Convert.ToInt32(Console.ReadLine());
             * Console.WriteLine("Your number is: " + myNum3);
            */

            double d = 8.8;
            Console.WriteLine(Math.Floor(d));
            Console.WriteLine(Math.Round(d));

            string txt = "Breakfast";
            Console.WriteLine(txt[2]);

            Console.WriteLine(txt.ToUpper());

            // Example of a switch statment 


            Random rnd = new Random();
            int num = rnd.Next(5);

            switch (num)
            {
                case 1:
                    
                    Console.WriteLine("Yes it will be most true.");
                    break;
                case 2:
                    Console.WriteLine("There is a high chance, yes.");
                    break;
                case 3:
                    Console.WriteLine("Sorry but this one is on you.");
                    break;
                case 4:
                    Console.WriteLine("There is a high probibility that this will not happen.");
                    break;
                default:
                    Console.WriteLine("Try again, to see your future.");
                    break;

                    
            }
            /*
            int i = 1;
            while (i < 6)
            {
                Console.WriteLine(i);
                i++;
            }
            */

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Yessssssssss!");

            }

            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };

            foreach (string i in cars)
            {
                Console.WriteLine(i);

            }

            Console.WriteLine(MyMethod2(9202, 320392));
            //Console.WriteLine(Madlib(verb: "strike", adjective: "huge", noun: "Statue of Liberty", name: "Ricky"));
        }
    }
}
