using System;


namespace Tema_2
{
    public static class ExerciseEighteen
    {
        // Exercise 18
        // Cititi 3 numere de la tastatura si afisati cel mai mare numar.

        public static void PrintExerciseEighteen()
        {
            Console.WriteLine("Input the first number :");
            int numberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the second number :");
            int numberTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the third number :");
            int numberThree = Convert.ToInt32(Console.ReadLine());

            if (numberOne > numberTwo)
            {
                if (numberOne > numberThree)
                {
                    Console.WriteLine("Number one is the largest number.");
                }
                else
                {
                    Console.WriteLine("Number three is the largest number.");
                }

            }
            else if (numberTwo > numberThree)
            {
                Console.WriteLine("Number two is the largest number.");
            }
            else
            {
                Console.WriteLine("Number three is the largest number.");
            }

        }
    }
}
