using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Tema_1
{
    class MyMain
    {
        static void Main(string[] args)
        {
            //Exercise 1
            //Console.WriteLine($"Result exercise 1: " + HelloWorld());

            //Exercise 2
            /*Console.WriteLine($"Result exercise 2: ");
            PrintVariableAndTypes();*/

            //Exercise 3
            /*Console.WriteLine($"Result exercise 3: ");
            PrintConditionals();*/

            //Exercise 4
            /*Console.WriteLine($"Result exercise 4: ");
            PrintArrays();*/

            //Exercise 5
            /*Console.WriteLine($"Result exercise 5: ");
            PrintLists();*/

            //Exercise 6
            /*Console.WriteLine($"Result exercise 6: ");
            PrintDictionaries();*/

            //Exercise 7
            /*Console.WriteLine($"Result exercise 7: ");
            PrintStrings();*/

            //Exercise 8
            /*Console.WriteLine($"Result exercise 8: ");
            PrintForLoops();*/

            //Exercise 9
            Console.WriteLine($"Result exercise 9: ");
            PrintWhileLoops();




            Console.ReadKey();
        }

        //Exercise 1
        // Print "Hello, World!" to the console.
        public static string PrintHelloWorld()
        {
            var myHello = "Hello, World!";
            return myHello;
        }

        /*int myInt = 1;
        float myFloat = 1f;
        bool myBoolean = true;
        string myName = "John";
        char myChar = 'a';
        double myDouble = 1.75;*/

        //Exercise 2
        //Define three variables: A string named productName equal to TV;  An integer named productYear equal to 2012;  A float named productPrice equal to 279.99f.
        public static void PrintVariableAndTypes()
        {
            string productName = "TV";
            int productYear = 2012;
            float productPrice = 279.99f;

            Console.WriteLine($"productName: {productName}");
            Console.WriteLine($"productYear: {productYear}");
            Console.WriteLine($"productPrice: {productPrice}");
        }

        //Exercise 3
        //In this exercise, you must construct an if statement that checks if the number guess is equal to 500. If that is the case, use Console.WriteLine to display "Success!".
        public static void PrintConditionals()
        {
            int guess = 500;

            if (guess == 500)
            {
                Console.WriteLine("Success!");
            } else
            {
                Console.WriteLine("No Success!");
            }
        }

        //Exercise 4
        //Define an array called fruits that holds the following strings: "apple", "banana", and "orange".
        public static void PrintArrays()
        {
            string[] fruits = { "apple", "banana", "orange" };

            Console.WriteLine(fruits[0]);
            Console.WriteLine(fruits[1]);
            Console.WriteLine(fruits[2]);
        }

        //Exercise 5
        //Construct a list of the first 5 prime numbers (2, 3, 5, 7, 11) called primeNumbers.
        public static void PrintLists()
        {
            List<int> primeNumbers = new List<int>();

            primeNumbers.Add(2);
            primeNumbers.Add(3);
            primeNumbers.Add(5);
            primeNumbers.Add(7);
            primeNumbers.Add(11);

            Console.WriteLine(primeNumbers.Count);
            Console.WriteLine(primeNumbers[0]);
            Console.WriteLine(primeNumbers[1]);
            Console.WriteLine(primeNumbers[2]);
            Console.WriteLine(primeNumbers[3]);
            Console.WriteLine(primeNumbers[4]);
        }

        //Exercise 6
        /*Create a new dictionary called inventory that holds 3 names of fruits, and the amount they are in stock.
        Here is the inventory specification: 3 of type apple, 5 of type orange, 2 of type banana*/
        public static void PrintDictionaries()
        {
            Dictionary<string, int> inventory = new Dictionary<string, int>();

            inventory.Add("apple", 3);
            inventory.Add("orange", 5);
            inventory.Add("banana", 2);

            Console.WriteLine(inventory["apple"]);
            Console.WriteLine(inventory["orange"]);
            Console.WriteLine(inventory["banana"]);
        }

        //Exercise 7
        /*Use string formatting to format the variables firstName, lastName and age to form the following sentence into the string sentence: John Doe is 27 years old.*/
        public static void PrintStrings()
        {
            string firstName = "John ";
            string lastName = "Doe ";
            int age = 27;

            string sentence = firstName + lastName + ("is ") + age + (" years old.");

            Console.WriteLine(sentence);
        }

        //Exercise 8
        /*Print the value of variable X to the screen N number of times*/
        /*for( [variable to count iterations] ; [conditions checked for] ; [code to execute every loop])
        { 
        }*/
        public static void PrintForLoops()
        {
            string x = "Hi";
            int n = 10;

            for(n = 0; n < 10; n++)
            {
                Console.WriteLine(x);
            }
        }

        //Exercise 9
        /*Print X to the console N time using a while loop*/
        /*while([conditions to be checked])
        {
        [Code to execute]
        }*/
        public static void PrintWhileLoops()
        {
            string x = "Hi";
            int n = 10;

            while (n >= 0)
            {
                Console.WriteLine(x);
                n--;
                
            }
        }


    }
}

 