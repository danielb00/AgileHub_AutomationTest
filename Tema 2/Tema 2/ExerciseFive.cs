using System;


namespace Tema_2
{
    public static class ExerciseFive
    {
        // Exercise 5
        // Cititi de la tastatura un numar. Verificati daca numarul este pozitiv si afisati: “Numarul *numar* este pozitiv”..

        public static void PrintExerciseFive()
        {
            Console.WriteLine("Enter a number: ");

            int number = Convert.ToInt32(Console.ReadLine());

            if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive");
            }
            else
            {
                Console.WriteLine($"The number isn't positive");
            }
        }
    }
}
